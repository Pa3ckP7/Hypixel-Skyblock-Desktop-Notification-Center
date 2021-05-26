using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APIs
{
    public class ForumAPI
    {
        String time;
        public List<Post> GetData()
        {
            try
            {
                WebClient wc = new WebClient();
                string link = "https://hypixel-skyblock.fandom.com/wikia.php?controller=DiscussionPost&method=getPosts&limit=100&format=json";
                var data = wc.DownloadString(link);
                return ParseData(data);
            }
            catch (Exception)
            {
                return new List<Post>();
            }
        }
        public List<Post> RefreshData()
        {
            try
            {
                WebClient wc = new WebClient();
                var data = wc.DownloadString($"https://hypixel-skyblock.fandom.com/wikia.php?controller=DiscussionPost&method=getPosts&limit=100&format=json&since={time}");
                return ParseData(data);
            }
            catch (Exception)
            {
                return new List<Post>();
            }

        }
        List<Post> ParseData(String data)
        {
            List<Post> Forums = new List<Post>();
            var doc = JObject.Parse(data);
            var jForums = JArray.Parse(doc["_embedded"]["doc:posts"].ToString());
            for (int i = 0; i < jForums.Count; i++)
            {
                Post Forum = new Post();
                var thread = JArray.Parse(JObject.Parse(jForums[i]["_embedded"].ToString())["thread"].ToString());//because some crazy dev decided thread should be an array
                if (thread[0]["containerType"].ToString() != "FORUM") continue;
                Forum.PosterName = jForums[i]["createdBy"]["name"].ToString();
                if (jForums[i]["isReply"].ToString() == "True")
                {
                    Forum.IsReply = true;
                    Forum.ReplyId = jForums[i]["id"].ToString();
                }
                else Forum.IsReply = false;
                Forum.Content = jForums[i]["rawContent"].ToString();
                Forum.PostTitle = thread[0]["firstPost"]["title"].ToString();
                Forum.ThreadId = thread[0]["firstPost"]["threadId"].ToString();
                Forum.Creator = thread[0]["firstPost"]["createdBy"]["name"].ToString();
                Forums.Add(Forum);
            }
            time = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.000Z");
            return Forums;
        }
    }
}
