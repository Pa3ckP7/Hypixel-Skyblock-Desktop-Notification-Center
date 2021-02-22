using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCheck
{
    class User
    {
        public string name { get; set; }
        public List<string> groups { get; set; }

        public string HighestGroup { get 
            {
                string returnValue="user";
                if(groups==null) return returnValue;
                foreach (string group in groups) 
                {
                    if (group == "bureaucrat") { returnValue = group; break; }
                    else if (group == "sysop") returnValue = group;
                    else if (group == "codeeditor" && returnValue != "sysop") returnValue = group;
                    else if (group == "content-moderator" && returnValue != "codeeditor") returnValue = group;
                    else if (group == "threadmoderator" && returnValue != "content-moderator") returnValue = group;
                    else if (group == "rollback" && returnValue != "threadmoderator") returnValue = group;
                }
                return returnValue;
            } }
    }
}
