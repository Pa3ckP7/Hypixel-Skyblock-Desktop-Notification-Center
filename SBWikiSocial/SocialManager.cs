using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SBWikiSocial
{
    public class SocialManager
    {
        //private readonly string DiscussionsLink;
        public List<Social> GetData() 
        {
            List<Social> entrylist = new List<Social>();
            try
            {
                WebClient wc = new WebClient();
                var binaryData = wc.DownloadData("https://hypixel-skyblock.fandom.com/wiki/Special:SocialActivity");
                var data = Encoding.UTF8.GetString(binaryData);
                var entries = Regex.Matches(data, "<div class=\"activity-data\">(?<entry>.*)<\\/div>");
                foreach (Match entry in entries)
                {
                    Social socialentry = new Social();
                    var textsegments = Regex.Matches(entry.Groups["entry"].Value, "<(a|s|e|\\/)[^>]*>(?<text>[^<]*)");
                    foreach (Match textsegment in textsegments)
                    {
                        socialentry.Text += textsegment.Groups["text"].Value;
                    }
                    socialentry.Text = Regex.Replace(socialentry.Text, @"\([^)]*\)", "");
                    socialentry.Text = Regex.Replace(socialentry.Text, @"[ ]{2,}", " ");
                    socialentry.Text = Regex.Replace(socialentry.Text, textsegments[0].Groups["text"].Value, "");
                    socialentry.User = textsegments[0].Groups["text"].Value;
                    socialentry.Action = textsegments[7].Groups["text"].Value;
                    string link = Regex.Match(entry.Groups["entry"].Value, "<a href=\"(?<link>[^ \"]*)\">v").Groups["link"].Value;
                    socialentry.Link = $"https://hypixel-skyblock.fandom.com/{link}";
                    entrylist.Add(socialentry);
                }
                entrylist.RemoveAll(x => entrylist.IndexOf(x) >= 100);
                return entrylist;
            }
            catch (Exception) 
            {
                return entrylist;
            }
            
        }
    }
}
