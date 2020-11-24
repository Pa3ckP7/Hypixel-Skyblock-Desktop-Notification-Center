using SBWikiContent;
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
    public partial class SBWikiContentForm : Form
    {
        List<LinkedButton> buttons = new List<LinkedButton>();
        ContentManager cm = new ContentManager();
        public SBWikiContentForm()
        {
            InitializeComponent();
            List<Entry> entries = cm.GetData();
            #region display            
            for (int i = entries.Count-1; i >= 0; i--) 
            {
                LinkedButton button = new LinkedButton(entries[i].link);
                button.Dock = DockStyle.Top;
                button.Name = "button";
                switch (entries[i].type)
                {
                    case "edit":
                        if (!entries[i].HasMinorFlag) button.button.Text = $"{entries[i].user} edited {entries[i].title} description {entries[i].commentshort}";
                        else button.button.Text = $"[minor]{entries[i].user} edited {entries[i].title} description {entries[i].commentshort}";
                        break;
                    case "log":
                        button.button.Text = $"[LOG|{entries[i].logtype}] {entries[i].user} logged action {entries[i].logaction} {entries[i].title} description: {entries[i].commentshort}";
                        break;
                    case "new":
                        button.button.Text = $"{entries[i].user} created {entries[i].title} description {entries[i].commentshort}";
                        break;
                } // set text
                button.button.TextAlign = ContentAlignment.MiddleLeft;
                Controls.Add(button);
                buttons.Add(button);
            }
            #endregion
        }
        private void RefeshTimer_Tick(object sender, EventArgs e)
        {
            List<Entry> entries = cm.GetData();
            for (int i = entries.Count-1; i >= 0; i--) 
            {
                LinkedButton button = new LinkedButton(entries[i].link);
                button.Dock = DockStyle.Top;
                button.Name = "button";
                switch (entries[i].type)
                {
                    case "edit":
                        if (!entries[i].HasMinorFlag) button.button.Text = $"{entries[i].user} edited {entries[i].title} description {entries[i].commentshort}";
                        else button.button.Text = $"[minor]{entries[i].user} edited {entries[i].title} description {entries[i].commentshort}";
                        break;
                    case "log":
                        button.button.Text = $"[LOG|{entries[i].logtype}] {entries[i].user} logged action {entries[i].logaction} {entries[i].title} description: {entries[i].commentshort}";
                        break;
                    case "new":
                        button.button.Text = $"{entries[i].user} created {entries[i].title} description {entries[i].commentshort}";
                        break;
                } // set text
                button.button.TextAlign = ContentAlignment.MiddleLeft;
                Controls.Add(button);
                buttons.Add(button);
            }
            if (buttons.Count > 100)
            {
                buttons.Reverse();
                for (int i = 100; i < buttons.Count; i++)
                {
                    buttons[i].Dispose();
                }
                buttons.RemoveAll(x => buttons.IndexOf(x) >= 100);
                buttons.Reverse();
            }
        }
    }
}
