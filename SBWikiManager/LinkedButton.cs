using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SBWikiManager
{
    public partial class LinkedButton : UserControl
    {
        public Button button { get; internal set; }
        public string link {get; set;}
        public LinkedButton()
        {
            InitializeComponent();
            button = button1;
        }
        public LinkedButton(string link)
        {
            InitializeComponent();
            this.link = link;
            button = button1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(link!=null) Process.Start(link);
        }
    }
}
