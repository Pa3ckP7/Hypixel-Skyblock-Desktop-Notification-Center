using SBWikiForum;
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
    public partial class SBWikiForumForm : Form
    {
        List<Label> labels = new List<Label>();
        ForumManager fm = new ForumManager();
        public SBWikiForumForm()
        {
            InitializeComponent();            
            List<Post> posts = fm.GetData();
            #region display            
            for (int i = posts.Count - 1; i >= 0; i--) 
            {
                Label label = new Label();
                label.Dock = DockStyle.Top;
                label.Name = "label";
                if (!posts[i].IsReply) label.Text = $"{posts[i].PosterName} posted {posts[i].PostTitle}: {posts[i].Content}";
                else label.Text = $"{posts[i].PosterName} replied with {posts[i].Content} on {posts[i].PostTitle}";
                label.TextAlign = ContentAlignment.MiddleLeft;
                Controls.Add(label);
                labels.Insert(0, label);
            }
            #endregion
        }
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            List<Post> posts=fm.RefreshData();
            for (int i = posts.Count - 1; i >= 0; i--)
            {
                Label label = new Label();
                label.Dock = DockStyle.Top;
                label.Name = "label";
                if (!posts[i].IsReply) label.Text = $"{posts[i].PosterName} posted {posts[i].PostTitle}: {posts[i].Content}";
                else label.Text = $"{posts[i].PosterName} replied with {posts[i].Content} on {posts[i].PostTitle}";
                label.TextAlign = ContentAlignment.MiddleLeft;
                Controls.Add(label);
                labels.Insert(0, label);
            }
            if (labels.Count > 50) 
            {
                for (int i = 50; i < labels.Count; i++) 
                {
                    labels[i].Dispose();
                }
                labels.RemoveAll(x => labels.IndexOf(x) >= 50);
            }
        }
    }
}
