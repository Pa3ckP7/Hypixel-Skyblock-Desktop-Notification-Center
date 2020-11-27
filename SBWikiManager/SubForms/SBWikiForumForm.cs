using SBWikiForum;
using SBWikiSettings;
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
        Settings Settings;
        NotifyIcon Notifications;
        public SBWikiForumForm(Settings settings,NotifyIcon notifications)
        {
            InitializeComponent();
            Notifications = notifications;
            Settings = settings;
            List<Post> posts = fm.GetData();
            #region display            
            for (int i = posts.Count - 1; i >= 0; i--) 
            {
                LinkedButton button = new LinkedButton(posts[i].Link);
                button.Dock = DockStyle.Top;
                button.Name = "button";
                button.button.BackColor = Color.Transparent;
                button.button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.Transparent;
                button.button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.button.FlatAppearance.BorderSize = 0;
                button.button.ForeColor = Color.LightGray;
                button.Height = 30;
                if (!posts[i].IsReply) button.button.Text = $"{posts[i].PosterName} posted {posts[i].PostTitle}: {posts[i].Content}";
                else button.button.Text = $"{posts[i].PosterName} replied with {posts[i].Content} on {posts[i].PostTitle}";
                button.button.TextAlign = ContentAlignment.TopLeft;
                Tooltips.SetToolTip(button.button, button.link);
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
                button.button.BackColor = Color.Transparent;
                button.button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.Transparent;
                button.button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.button.FlatAppearance.BorderSize = 0;
                button.button.ForeColor = Color.LightGray;
                button.Height = 30;
                if (!posts[i].IsReply)
                {
                    button.button.Text = $"{posts[i].PosterName} posted {posts[i].PostTitle}: {posts[i].Content}";                    
                    Notify("Forum", $"{posts[i].PosterName} created post {posts[i].PostTitle}", posts[i].PosterName);
                }
                else
                {
                    button.button.Text = $"{posts[i].PosterName} replied with {posts[i].Content} on {posts[i].PostTitle}";
                    Notify("Forum", $"{posts[i].PosterName} replied on {posts[i].PostTitle}", posts[i].PosterName);
                }
                button.button.TextAlign = ContentAlignment.TopLeft;
                Tooltips.SetToolTip(button.button, button.link);
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
            VerticalScroll.Value = 0;
        }
        public void Notify(string title, string text, string user)
        {
            if (Settings.Forum.AllowNotifications)
            {
                if (!Settings.Names.Contains(user))
                {
                    Notifications.ShowBalloonTip(5000, title, text, ToolTipIcon.None);
                }
            }
        }
    }
}
