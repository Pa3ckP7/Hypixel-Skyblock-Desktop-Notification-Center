﻿using SBWikiForum;
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
        List<LinkedButton> buttons = new List<LinkedButton>();
        ForumManager fm = new ForumManager();
        public SBWikiForumForm()
        {
            InitializeComponent();            
            List<Post> posts = fm.GetData();
            #region display            
            for (int i = posts.Count - 1; i >= 0; i--) 
            {
                LinkedButton button = new LinkedButton(posts[i].Link);
                button.Dock = DockStyle.Top;
                button.Name = "button";
                if (!posts[i].IsReply) button.button.Text = $"{posts[i].PosterName} posted {posts[i].PostTitle}: {posts[i].Content}";
                else button.button.Text = $"{posts[i].PosterName} replied with {posts[i].Content} on {posts[i].PostTitle}";
                button.button.TextAlign = ContentAlignment.MiddleLeft;
                Controls.Add(button);
                buttons.Insert(0, button);
            }
            #endregion
        }
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            List<Post> posts=fm.RefreshData();
            for (int i = posts.Count - 1; i >= 0; i--)
            {
                LinkedButton button = new LinkedButton(posts[i].Link);
                button.Dock = DockStyle.Top;
                button.Name = "button";
                if (!posts[i].IsReply) button.button.Text = $"{posts[i].PosterName} posted {posts[i].PostTitle}: {posts[i].Content}";
                else button.button.Text = $"{posts[i].PosterName} replied with {posts[i].Content} on {posts[i].PostTitle}";
                button.button.TextAlign = ContentAlignment.MiddleLeft;
                Controls.Add(button);
                buttons.Insert(0, button);
            }
            if (buttons.Count > 50) 
            {
                for (int i = 50; i < buttons.Count; i++) 
                {
                    buttons[i].Dispose();
                }
                buttons.RemoveAll(x => buttons.IndexOf(x) >= 50);
            }
        }
    }
}
