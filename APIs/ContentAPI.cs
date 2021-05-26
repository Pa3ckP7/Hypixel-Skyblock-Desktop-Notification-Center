using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APIs
{
    public class ContentAPI
    {
        string time;
        public List<Content> GetData()
        {
            try
            {
                WebClient wc = new WebClient();
                var data = wc.DownloadString("https://hypixel-skyblock.fandom.com/api.php?action=query&list=recentchanges&rcprop=title|user|flags|comment|loginfo|ids&rctype=edit|new|log|&rclimit=100&format=json&rcshow=!bot");
                var doc = Newtonsoft.Json.Linq.JObject.Parse(data);
                var entries = doc["query"]["recentchanges"].ToObject<List<Content>>();
                time = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.000Z");
                return entries;
            }
            catch (Exception)
            {
                return new List<Content>();
            }
        }
        public List<Content> RefreshData()
        {
            try
            {
                WebClient wc = new WebClient();
                var data = wc.DownloadString($"https://hypixel-skyblock.fandom.com/api.php?action=query&list=recentchanges&rcprop=title|user|flags|comment|loginfo|ids&rctype=edit|new|log&rclimit=100&format=json&rcshow=!bot&rcend={time}");
                var doc = Newtonsoft.Json.Linq.JObject.Parse(data);
                var entries = doc["query"]["recentchanges"].ToObject<List<Content>>();
                time = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.000Z");
                return entries;
            }
            catch (Exception)
            {
                return new List<Content>();
            }
        }
    }
}
