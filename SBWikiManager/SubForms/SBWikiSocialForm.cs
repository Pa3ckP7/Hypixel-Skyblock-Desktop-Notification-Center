using SBWikiSettings;
using SBWikiSocial;
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
    public partial class SBWikiSocialForm : Form
    {
        List<LinkedButton> buttons = new List<LinkedButton>();
        List<SBWikiSocial.Social> entries = new List<SBWikiSocial.Social>();
        SocialManager sm = new SocialManager();
        Settings Settings;
        NotifyIcon Notifications;
        public SBWikiSocialForm(Settings settings,NotifyIcon notifications)
        {
            InitializeComponent();
            Notifications = notifications;
            Settings = settings;
            entries =sm.GetData();            
            for (int i = entries.Count - 1; i >= 0; i--) 
            {
                LinkedButton button = new LinkedButton(entries[i].Link);
                button.Dock = DockStyle.Top;
                button.Name = "button";
                button.button.Text = entries[i].Text.Trim();
                button.name.Text = entries[i].User.Trim();
                ColorName(entries[i].User.Trim(), button);
                button.button.TextAlign = ContentAlignment.TopLeft;                
                button.button.BackColor = Color.Transparent;
                button.button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.Transparent;
                button.button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.button.FlatAppearance.BorderSize = 0;
                button.button.ForeColor = Color.LightGray;
                button.tags.ForeColor = Color.LightGray;
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
                Tooltips.SetToolTip(button.button, button.link);
                Controls.Add(button);
                buttons.Insert(0, button);
            }
        }
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            List<SBWikiSocial.Social> newset = sm.GetData();
            List<SBWikiSocial.Social> newentries = newset.Where(x => !entries.Any(y => x.Text == y.Text)).ToList();
            for (int i = newentries.Count - 1; i >= 0; i--)
            {
                LinkedButton button = new LinkedButton(newentries[i].Link);
                button.Dock = DockStyle.Top;
                button.Name = "button";
                button.button.BackColor = Color.Transparent;
                button.button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.Transparent;
                button.button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.button.FlatAppearance.BorderSize = 0;
                button.button.ForeColor = Color.LightGray;
                button.Height = 30;
                button.button.Text = newentries[i].Text;
                button.name.Text = newentries[i].User;
                ColorName(newentries[i].User, button);
                button.button.TextAlign = ContentAlignment.TopLeft;
                button.button.BackColor = Color.Transparent;
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
                Controls.Add(button);
                entries.Insert(0, newentries[i]);
                buttons.Insert(0, button);
                Notify("Social", button.button.Text, newentries[i].User,newentries[i].Action);
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
            VerticalScroll.Value = 0;
        }
        public void Notify(string title, string text, string user, string action)
        {
            if (Settings.Social.AllowNotifications)
            {
                if ((!Settings.StaffNotifs) && UserCheck.UserCheck.CheckUser(user) != "user") return;
                if (!Settings.Names.Contains(user))
                {
                    if (!Settings.Social.CommentNotifications && action.Contains("comment")) return;
                    if (!Settings.Social.MessageNotifications && action.Contains("message")) return;
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
