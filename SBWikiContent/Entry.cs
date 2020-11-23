using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBWikiContent
{
    public class Entry
    {
        public string type { get; set; }
        public string title { get; set; }
        public string user { get; set; }
        public string comment { get; set; }
        public string commentshort
        {
            get
            {
                if (comment != null)
                {
                    if (comment.Length > 20) return $"{comment.Substring(0, 20)}...";
                    else return comment;
                }
                else return "";
            }
        }
        public string timestamp { get; set; }
        public string bot { get; set; } //flag
        public bool HasBotFlag => bot == "";
        public string minor { get; set; } //flag
        public bool HasMinorFlag => minor == "";
        public string logtype { get; set; }
        public string logaction { get; set; }
        public Logparams logparams { get; set; }
    }
}
