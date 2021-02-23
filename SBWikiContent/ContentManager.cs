using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SBWikiContent
{
    public class ContentManager
    {
        string time;
        public List<Entry> GetData() 
        {
            try
            {
                WebClient wc = new WebClient();
                var data = wc.DownloadString("https://hypixel-skyblock.fandom.com/api.php?action=query&list=recentchanges&rcprop=title|user|flags|comment|loginfo|ids&rctype=edit|new|log|&rclimit=100&format=json&rcshow=!bot");
                var doc = Newtonsoft.Json.Linq.JObject.Parse(data);
                var entries = doc["query"]["recentchanges"].ToObject<List<Entry>>();
                time = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.000Z");
                return entries;
            }
            catch (Exception) 
            {
                return new List<Entry>();
            }
        }
        public List<Entry> RefreshData() 
        {
            try
            {
                WebClient wc = new WebClient();
                var data = wc.DownloadString($"https://hypixel-skyblock.fandom.com/api.php?action=query&list=recentchanges&rcprop=title|user|flags|comment|loginfo|ids&rctype=edit|new|log&rclimit=100&format=json&rcshow=!bot&rcend={time}");
                var doc = Newtonsoft.Json.Linq.JObject.Parse(data);
                var entries = doc["query"]["recentchanges"].ToObject<List<Entry>>();
                time = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.000Z");
                return entries;
            }
            catch (Exception)
            {
                return new List<Entry>();
            }
        }
    }
}
