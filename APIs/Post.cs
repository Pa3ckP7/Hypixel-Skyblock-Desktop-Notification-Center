using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIs
{
    public class Post
    {
        public string PosterName { get; set; }
        public string ReplyId { get; set; }
        public bool IsReply { get; set; }
        public string Content { get; set; }        
        public string Creator { get; set; } //name of the creator who originally created the post
        public string PostTitle { get; set; }
        public string ThreadId { get; set; }
        public string Link 
        {
            get 
            {
                if (comment) 
                {
                    if(IsReply)
                        return $"https://hypixel-skyblock.fandom.com/{PageName}?{ThreadId}&replyId={ReplyId}";
                    else
                        return $"https://hypixel-skyblock.fandom.com/{PageName}";
                }
                else
                {
                    if (IsReply) 
                        return $"https://hypixel-skyblock.fandom.com/f/p/{ThreadId}/r/{ReplyId}";
                    else 
                        return $"https://hypixel-skyblock.fandom.com/f/p/{ThreadId}";
                }
            }
        }
        public string PageName { get; set;}

        public bool comment { get; set; } = false;
    }
}
