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
    public partial class SettingsForm : Form
    {
        Settings Settings;
        SettingsManager SM;
        public SettingsForm(SettingsManager settingsManager)
        {
            InitializeComponent();
            Tooltips.SetToolTip(label1, "Input wiki usernames seperated by commas to avoid getting notifications for those names ");
            Tooltips.SetToolTip(ContentSwitch, "Toggles the notification for the tab Content");
            Tooltips.SetToolTip(SocialSwitch, "Toggles the notification for the tab Social");
            Tooltips.SetToolTip(ForumSwitch, "Toggles the notification for the tab Forum");
            Tooltips.SetToolTip(SaveButton, "Saves your user settings so they can be restored after you reopen the app.");
            Tooltips.SetToolTip(ContentLogsSwitch, "Toggles notification for logs");
            Tooltips.SetToolTip(ContentArticlesSwitch, "Toggles notification for srticle edits and creation");
            Tooltips.SetToolTip(SocialMessagesSwitch, "Toggles notifications for message wall messages and their replies");
            Tooltips.SetToolTip(SocialCommentsSwitch, "Toggles notifications for article comments and their replies");
            Tooltips.SetToolTip(DefaultsButton, "Loads the default settings");
            Settings = settingsManager.Settings;
            SM = settingsManager;
            ContentLogsSwitch.Checked = Settings.Content.LogNotifications;
            ContentArticlesSwitch.Checked = Settings.Content.ArticleNotifications;
            SocialCommentsSwitch.Checked = Settings.Social.CommentNotifications;
            SocialMessagesSwitch.Checked = Settings.Social.MessageNotifications;
            ContentSwitch.Checked = Settings.Content.AllowNotifications;
            SocialSwitch.Checked = Settings.Social.AllowNotifications;
            ForumSwitch.Checked = Settings.Forum.AllowNotifications;
            if (Settings.Names.Length!=0)
            {
                var str = "";
                foreach (var name in Settings.Names) str += name + ", ";
                str = str.Substring(0, str.Length - 2);
                UsernameTBox.Text = str;
            }
        }
        private void ContentSwitch_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Content.AllowNotifications = ContentSwitch.Checked;
            ContentNotificationPanel.Visible = ContentSwitch.Checked;
        }

        private void SocialSwitch_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Social.AllowNotifications = SocialSwitch.Checked;
            SocialNotificationsPanel.Visible = SocialSwitch.Checked;
        }

        private void ForumSwitch_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Forum.AllowNotifications = ForumSwitch.Checked;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SM.SaveSettings();
        }
        private void UsernameTBox_Leave(object sender, EventArgs e)
        {
            var names = UsernameTBox.Text.Split(',');
            for (int i=0;i<names.Length;i++) names[i] = names[i].Trim();
            Settings.Names = names;
        }

        private void ContentLogsSwitch_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Content.LogNotifications = ContentLogsSwitch.Checked;
        }

        private void ContentArticlesSwitch_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Content.ArticleNotifications = ContentArticlesSwitch.Checked;
        }

        private void SocialCommentsSwitch_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Social.CommentNotifications = SocialCommentsSwitch.Checked;
        }

        private void SocialMessagesSwitch_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Social.MessageNotifications = SocialMessagesSwitch.Checked;
        }

        private void DefaultsButton_Click(object sender, EventArgs e)
        {
            ContentLogsSwitch.Checked = SM.Default.Content.LogNotifications;
            ContentArticlesSwitch.Checked = SM.Default.Content.ArticleNotifications;
            SocialCommentsSwitch.Checked = SM.Default.Social.CommentNotifications;
            SocialMessagesSwitch.Checked = SM.Default.Social.MessageNotifications;
            ContentSwitch.Checked = SM.Default.Content.AllowNotifications;
            SocialSwitch.Checked = SM.Default.Social.AllowNotifications;
            ForumSwitch.Checked = SM.Default.Forum.AllowNotifications;
            UsernameTBox.Text = "";
        }
    }
}
