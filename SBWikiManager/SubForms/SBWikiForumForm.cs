using APIs;
using SBWikiSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBWikiManager.SubForms
{
    public partial class SBWikiForumForm : Form
    {
        List<LinkedButton> buttons = new List<LinkedButton>();
        ForumAPI api = new ForumAPI();
        Settings Settings;
        NotifyIcon Notifications;
        public SBWikiForumForm(Settings settings, NotifyIcon notifications)
        {
            InitializeComponent();
            Notifications = notifications;
            Settings = settings;
            List<APIs.Post> posts = api.GetData();
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
                button.tags.ForeColor = Color.LightGray;
                button.name.ForeColor = Color.LightGray;
                button.tags.BackColor = Color.Transparent;
                button.tags.FlatStyle = FlatStyle.Flat;
                button.name.BackColor = Color.Transparent;
                button.name.FlatStyle = FlatStyle.Flat;
                button.tags.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.tags.FlatAppearance.BorderSize = 0;
                button.name.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.name.FlatAppearance.BorderSize = 0;
                Tooltips.SetToolTip(button.button, button.link);
                button.Height = 30;
                if (!posts[i].IsReply)
                {
                    button.name.Text = posts[i].PosterName;
                    ColorName(posts[i].PosterName, button);
                    button.tags.Hide();
                    button.button.Text = $"posted {posts[i].PostTitle}: {posts[i].Content}";
                }
                else
                {
                    button.name.Text = posts[i].PosterName;
                    ColorName(posts[i].PosterName, button);
                    button.tags.Hide();
                    button.button.Text = $"replied with {posts[i].Content} on {posts[i].PostTitle}";
                }
                button.button.TextAlign = ContentAlignment.TopLeft;
                Tooltips.SetToolTip(button.button, button.link);
                Controls.Add(button);
                buttons.Insert(0, button);
            }
            #endregion
        }
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            List<APIs.Post> posts = api.RefreshData();
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
                button.tags.ForeColor = Color.LightGray;
                button.name.ForeColor = Color.LightGray;
                button.tags.BackColor = Color.Transparent;
                button.tags.FlatStyle = FlatStyle.Flat;
                button.name.BackColor = Color.Transparent;
                button.name.FlatStyle = FlatStyle.Flat;
                button.tags.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.tags.FlatAppearance.BorderSize = 0;
                button.name.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.name.FlatAppearance.BorderSize = 0;
                Tooltips.SetToolTip(button.button, button.link);
                button.Height = 30;
                if (!posts[i].IsReply)
                {
                    button.name.Text = posts[i].PosterName;
                    button.tags.Hide();
                    ColorName(posts[i].PosterName, button);
                    button.button.Text = $"posted {posts[i].PostTitle}: {posts[i].Content}";
                    Notify("Forum", $"{posts[i].PosterName} created post {posts[i].PostTitle}", posts[i].PosterName);
                }
                else
                {
                    button.name.Text = posts[i].PosterName;
                    button.tags.Hide();
                    ColorName(posts[i].PosterName, button);
                    button.button.Text = $"replied with {posts[i].Content} on {posts[i].PostTitle}";
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
                if ((!Settings.StaffNotifs) && UserCheck.UserCheck.CheckUser(user) != "user") return;
                if (!Settings.Names.Contains(user))
                {
                    Notifications.ShowBalloonTip(5000, title, text, ToolTipIcon.None);
                }
            }
        }
        public void ColorName(string name, LinkedButton button)
        {
            string checkedUser = UserCheck.UserCheck.CheckUser(button.name.Text);
            switch (checkedUser)
            {
                case "bureaucrat":
                    button.name.ForeColor = Color.FromArgb(Int32.Parse("ff3f43", NumberStyles.HexNumber));
                    break;
                case "sysop":
                    button.name.ForeColor = Color.FromArgb(Int32.Parse("a431fc", NumberStyles.HexNumber)); ;
                    break;
                case "codeeditor":
                    button.name.ForeColor = Color.FromArgb(Int32.Parse("5874f3", NumberStyles.HexNumber)); ;
                    break;
                case "content-moderator":
                    button.name.ForeColor = Color.FromArgb(Int32.Parse("7FFFD4", NumberStyles.HexNumber)); ;
                    break;
                case "threadmoderator":
                    button.name.ForeColor = Color.FromArgb(Int32.Parse("1f9921", NumberStyles.HexNumber)); ;
                    break;
                case "rollback":
                    button.name.ForeColor = Color.FromArgb(Int32.Parse("ff992b", NumberStyles.HexNumber)); ;
                    break;
                default:
                    button.name.ForeColor = Color.LightGray;
                    break;
            }
        }
    }
}
