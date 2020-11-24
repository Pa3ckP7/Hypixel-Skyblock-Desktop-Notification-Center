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
        public List<string> GetData() 
        {
            List<string> entrylist = new List<string>();
            WebClient wc = new WebClient();
            var binaryData = wc.DownloadData("https://hypixel-skyblock.fandom.com/wiki/Special:SocialActivity");
            var data = Encoding.UTF8.GetString(binaryData);
            var entries = Regex.Matches(data,"<div class=\"activity-data\">(?<entry>.*)<\\/div>");
            foreach (Match entry in entries) 
            {
                string entrytext="";
                var textsegments = Regex.Matches(entry.Groups["entry"].Value, "<(a|s|e|\\/)[^>]*>(?<text>[^<]*)");
                foreach (Match textsegment in textsegments) 
                {
                    entrytext+=textsegment.Groups["text"].Value;
                }
                entrytext = Regex.Replace(entrytext, @"\([^)]*\)", "");
                entrytext = Regex.Replace(entrytext,@"[ ]{2,}"," ");
                entrylist.Add(entrytext);
            }
            string stop = "debug";
            entrylist.RemoveAll(x => entrylist.IndexOf(x) >= 100);
            return entrylist;
        }
    }
}
