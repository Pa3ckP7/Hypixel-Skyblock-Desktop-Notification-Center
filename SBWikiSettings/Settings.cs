using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBWikiSettings
{
    public class Settings
    {
        public string Name { get; set; }
        public Forum Forum { get; set; } = new Forum();
        public Content Content { get; set; } = new Content();
        public Social Social { get; set; } = new Social();
    }
}
