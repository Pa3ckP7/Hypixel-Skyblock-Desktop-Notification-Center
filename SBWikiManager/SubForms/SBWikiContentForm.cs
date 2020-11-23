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
        List<Label> labels = new List<Label>();
        ContentManager cm = new ContentManager();
        public SBWikiContentForm()
        {
            InitializeComponent();
            List<Entry> entries = cm.GetData();
            #region display            
            for (int i = entries.Count-1; i >= 0; i--) 
            {
                Label label = new Label();
                label.Dock = DockStyle.Top;
                label.Name = "label";
                switch (entries[i].type)
                {
                    case "edit":
                        if (!entries[i].HasMinorFlag) label.Text = $"{entries[i].user} edited {entries[i].title} description {entries[i].commentshort}";
                        else label.Text = $"[minor]{entries[i].user} edited {entries[i].title} description {entries[i].commentshort}";
                        break;
                    case "log":
                        label.Text = $"[LOG|{entries[i].logtype}] {entries[i].user} logged action {entries[i].logaction} {entries[i].title} description: {entries[i].commentshort}";
                        break;
                    case "new":
                        label.Text = $"{entries[i].user} created {entries[i].title} description {entries[i].commentshort}";
                        break;
                } // set text
                label.TextAlign = ContentAlignment.MiddleLeft;
                Controls.Add(label);
                labels.Add(label);
            }
            #endregion
        }
        private void RefeshTimer_Tick(object sender, EventArgs e)
        {
            List<Entry> entries = cm.GetData();
            for (int i = entries.Count-1; i >= 0; i--) 
            {
                Label label = new Label();
                label.Dock = DockStyle.Top;
                label.Name = "label";
                switch (entries[i].type)
                {
                    case "edit":
                        if (!entries[i].HasMinorFlag) label.Text = $"{entries[i].user} edited {entries[i].title} description {entries[i].commentshort}";
                        else label.Text = $"[minor]{entries[i].user} edited {entries[i].title} description {entries[i].commentshort}";
                        break;
                    case "log":
                        label.Text = $"[LOG|{entries[i].logtype}] {entries[i].user} logged action {entries[i].logaction} {entries[i].title} description: {entries[i].commentshort}";
                        break;
                    case "new":
                        label.Text = $"{entries[i].user} created {entries[i].title} description {entries[i].commentshort}";
                        break;
                } // set text
                label.TextAlign = ContentAlignment.MiddleLeft;
                Controls.Add(label);
                labels.Add(label);
            }
            if (labels.Count > 100)
            {
                labels.Reverse();
                for (int i = 100; i < labels.Count; i++)
                {
                    labels[i].Dispose();
                }
                labels.RemoveAll(x => labels.IndexOf(x) >= 100);
                labels.Reverse();
            }
        }
    }
}
