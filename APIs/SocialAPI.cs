using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APIs
{
    public class SocialAPI
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
            List<Post> Comments = new List<Post>();
            List<String> pageIds = new List<string>();
            var doc = JObject.Parse(data);
            var jComments = JArray.Parse(doc["_embedded"]["doc:posts"].ToString());
            for (int i = 0; i < jComments.Count; i++)
            {
                Post Comment = new Post();
                Comment.comment = true;
                var thread = JArray.Parse(JObject.Parse(jComments[i]["_embedded"].ToString())["thread"].ToString());//because some crazy dev decided thread should be an array
                if (thread[0]["containerType"].ToString() != "ARTICLE_COMMENT") continue;
                Comment.PosterName = jComments[i]["createdBy"]["name"].ToString();
                if (jComments[i]["isReply"].ToString() == "True")
                {
                    Comment.IsReply = true;
                    Comment.ReplyId = jComments[i]["id"].ToString();
                }
                else Comment.IsReply = false;
                var raw = JObject.Parse(jComments[i]["jsonModel"].ToString());
                if (JObject.Parse(raw["content"][0].ToString()).ContainsKey("content"))
                    Comment.Content = raw["content"][0]["content"][0]["text"].ToString();
                else
                    Comment.Content = "API returned 0 content";
                pageIds.Add(jComments[i]["forumId"].ToString());
                Comment.PostTitle = jComments[i]["forumId"].ToString();
                Comment.ThreadId = thread[0]["firstPost"]["threadId"].ToString();
                Comment.Creator = thread[0]["firstPost"]["createdBy"]["name"].ToString();
                if (Comment.PosterName == "")
                    Comment.PosterName = "A Fandom User";
                Comments.Add(Comment);
            }
            Comments = ParsePageIds(pageIds,Comments);
            time = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.000Z");
            return Comments;
        }
        private List<Post> ParsePageIds(List<string> ids, List<Post> comments)
        {
            WebClient wc = new WebClient();
            string pageIds = ids.Aggregate((i, j) => i + "," + j).ToString();
            string link = $"https://hypixel-skyblock.fandom.com/wikia.php?controller=FeedsAndPosts&method=getArticleNamesAndUsernames&stablePageIds={pageIds}&format=json`";
            var data = wc.DownloadString(link);
            var pagenames = JObject.Parse(data);
            comments.ForEach(x =>
            {
                x.PageName = pagenames["articleNames"][x.PostTitle]["title"].ToString();
            });
            return comments;
        }
    }
}
