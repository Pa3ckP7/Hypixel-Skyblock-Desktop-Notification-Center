using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UserCheck
{
    public class UserCheck
    {
        static List<User> CachedUsers = new List<User>();
        public static string CheckUser(string name) 
        {
            foreach (User cacheduser in CachedUsers) if (cacheduser.name == name) return cacheduser.HighestGroup;
            try
            {
                WebClient wc = new WebClient();
                var data = wc.DownloadString($"https://hypixel-skyblock.fandom.com/api.php?action=query&list=users&ususers={name}&usprop=groups&format=json");
                var doc = Newtonsoft.Json.Linq.JObject.Parse(data);
                var user = doc["query"]["users"].ToObject<List<User>>()[0];
                CachedUsers.Add(user);
                return user.HighestGroup;
            }
            catch (Exception) { return "user"; }   
        }
    }
}
