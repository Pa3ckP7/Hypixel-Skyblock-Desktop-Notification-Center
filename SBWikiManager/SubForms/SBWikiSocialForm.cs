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
        List<Label> labels = new List<Label>();
        List<string> entries = new List<string>();
        SocialManager sm = new SocialManager();
        public SBWikiSocialForm()
        {
            InitializeComponent();            
            entries=sm.GetData();
            foreach (var entry in entries)
            {
                Label label = new Label();
                label.Dock = DockStyle.Top;
                label.Name = "label";
                label.Text = entry;
                label.TextAlign = ContentAlignment.MiddleLeft;
                Controls.Add(label);
                labels.Insert(0, label);
            }
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            List<string> newset = sm.GetData();
            List<string> newentries = newset.Except(entries).ToList();
            foreach (var entry in newentries)
            {
                Label label = new Label();
                label.Dock = DockStyle.Top;
                label.Name = "label";
                label.Text = entry;
                label.TextAlign = ContentAlignment.MiddleLeft;
                Controls.Add(label);
                entries.Add(entry);
                labels.Insert(0, label);
            }
            if (labels.Count > 100)
            {
                for (int i = 100; i < labels.Count; i++)
                {
                    labels[i].Dispose();
                }
                labels.RemoveAll(x => labels.IndexOf(x) >= 100);
                entries.RemoveAll(x => entries.IndexOf(x) >= 100);
            }
        }
    }
}
