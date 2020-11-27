using SBWikiSettings;
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
                button.button.Text = entries[i].Text;
                button.button.TextAlign = ContentAlignment.TopLeft;                
                button.button.BackColor = Color.Transparent;
                button.button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.Transparent;
                button.button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.button.FlatAppearance.BorderSize = 0;
                button.button.ForeColor = Color.LightGray;
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
                button.button.TextAlign = ContentAlignment.TopLeft;
                button.button.BackColor = Color.Transparent;
                Tooltips.SetToolTip(button.button, button.link);
                Controls.Add(button);
                entries.Insert(0, newentries[i]);
                buttons.Insert(0, button);
                string notificationtext = button.button.Text.Substring(0, 50);
                Notify("Social", button.button.Text.Substring(0, 50), newentries[i].User,newentries[i].Action);
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
                if (!Settings.Names.Contains(user))
                {
                    if (!Settings.Social.CommentNotifications && action.Contains("comment")) return;
                    if (!Settings.Social.MessageNotifications && action.Contains("message")) return;
                    Notifications.ShowBalloonTip(5000, title, text, ToolTipIcon.None);
                }
            }
        }
    }
}
