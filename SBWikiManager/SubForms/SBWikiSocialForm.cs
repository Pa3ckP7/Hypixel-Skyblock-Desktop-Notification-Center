using SBWikiSocial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBWikiManager.SubForms
{
    public partial class SBWikiSocialForm : Form
    {
        List<LinkedButton> buttons = new List<LinkedButton>();
        List<Social> entries = new List<Social>();
        SocialManager sm = new SocialManager();
        public SBWikiSocialForm()
        {
            InitializeComponent();            
            entries=sm.GetData();            
            for (int i = entries.Count - 1; i >= 0; i--) 
            {
                LinkedButton button = new LinkedButton(entries[i].Link);
                button.Dock = DockStyle.Top;
                button.Name = "button";
                button.button.Text = entries[i].Text;
                button.button.TextAlign = ContentAlignment.MiddleLeft;
                Controls.Add(button);
                buttons.Insert(0, button);
            }
        }
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            List<Social> newset = sm.GetData();
            List<Social> newentries = newset.Except(entries).ToList();
            for (int i = newentries.Count - 1; i >= 0; i--)
            {
                LinkedButton button = new LinkedButton(newentries[i].Link);
                button.Dock = DockStyle.Top;
                button.Name = "button";
                button.button.Text = newentries[i].Text;
                button.button.TextAlign = ContentAlignment.MiddleLeft;
                Controls.Add(button);
                entries.Insert(0, newentries[i]);
                buttons.Insert(0, button);
            }
            if (buttons.Count > 100)
            {
                for (int i = 100; i < buttons.Count; i++)
                {
                    buttons[i].Dispose();
                }
                buttons.RemoveAll(x => buttons.IndexOf(x) >= 100);
                entries.RemoveAll(x => entries.IndexOf(x) >= 100);
            }
        }
    }
}
