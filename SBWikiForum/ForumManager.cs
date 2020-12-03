using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SBWikiForum
{
    public class ForumManager
    {
        String time;
        public List<Post> GetData() 
        {
            try
            {
                WebClient wc = new WebClient();
                var data = wc.DownloadString("https://services.fandom.com/discussion/2011605/posts?limit=50&page=0");
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
                var data = wc.DownloadString($"https://services.fandom.com/discussion/2011605/posts?limit=50&page=0&since={time}");
                return ParseData(data);
            }
            catch (Exception) 
            {
                return new List<Post>();
            }
            
        }
        List<Post> ParseData(String data)
        {
            List<Post> posts = new List<Post>();
            var doc = JObject.Parse(data);
            var jposts = JArray.Parse(doc["_embedded"]["doc:posts"].ToString());
            //foreach (var jpost in jposts)
            //{
            //    Post post = new Post();
            //    var thread = JArray.Parse(JObject.Parse(jpost["_embedded"].ToString())["thread"].ToString());//because some crazy dev decided thread should be an array
            //    if (thread[0]["containerType"].ToString() != "FORUM") continue;
            //    post.PosterName = jpost["createdBy"]["name"].ToString();
            //    if (jpost["isReply"].ToString() == "True")
            //    {
            //        post.IsReply = true;
            //        post.ReplyId = jpost["id"].ToString();
            //    }
            //    else post.IsReply = false;
            //    post.RawContent = jpost["rawContent"].ToString();
            //    post.PostTitle = thread[0]["firstPost"]["title"].ToString();
            //    post.ThreadId = thread[0]["firstPost"]["threadId"].ToString();
            //    post.Creator = thread[0]["firstPost"]["createdBy"]["name"].ToString();
            //    posts.Add(post);
            //}
            for (int i = 0; i < jposts.Count; i++) 
            {
                Post post = new Post();
                var thread = JArray.Parse(JObject.Parse(jposts[i]["_embedded"].ToString())["thread"].ToString());//because some crazy dev decided thread should be an array
                if (thread[0]["containerType"].ToString() != "FORUM") continue;
                post.PosterName = jposts[i]["createdBy"]["name"].ToString();
                if (jposts[i]["isReply"].ToString() == "True")
                {
                    post.IsReply = true;
                    post.ReplyId = jposts[i]["id"].ToString();
                }
                else post.IsReply = false;
                post.RawContent = jposts[i]["rawContent"].ToString();
                post.PostTitle = thread[0]["firstPost"]["title"].ToString();
                post.ThreadId = thread[0]["firstPost"]["threadId"].ToString();
                post.Creator = thread[0]["firstPost"]["createdBy"]["name"].ToString();
                posts.Add(post);
            }
            time = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.000Z");
            return posts;
        }
    }
}
