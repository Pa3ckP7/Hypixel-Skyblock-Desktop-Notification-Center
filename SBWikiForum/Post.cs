using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBWikiForum
{
    public class Post
    {
        public string PosterName { get; set; }
        public string ReplyId { get; set; }
        public bool IsReply { get; set; }
        public string RawContent { get; set; }
        public string Content { get 
            {
                if (RawContent.Length > 20) return $"{RawContent.Substring(0, 20)}...";
                else return RawContent;
            }}
        public string Creator { get; set; } //name of the creator who originally created the post
        public string PostTitle { get; set; }
        public string ThreadId { get; set; }
        public string Link 
        {
            get 
            {
                if (IsReply) return $"https://hypixel-skyblock.fandom.com/f/p/{ThreadId}/r/{ReplyId}";
                else return $"https://hypixel-skyblock.fandom.com/f/p/{ThreadId}";
            }
        }
    }
}
