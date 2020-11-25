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
            Settings = settingsManager.Settings;
            SM = settingsManager;
            ContentSwitch.Checked = Settings.Content.AllowNotifications;
            SocialSwitch.Checked = Settings.Social.AllowNotifications;
            ForumSwitch.Checked = Settings.Forum.AllowNotifications;
            UsernameTBox.Text = Settings.Name;
        }

        private void ContentSwitch_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Content.AllowNotifications = ContentSwitch.Checked;
        }

        private void SocialSwitch_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Social.AllowNotifications = SocialSwitch.Checked;
        }

        private void ForumSwitch_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Forum.AllowNotifications = ForumSwitch.Checked;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SM.SaveSettings();
        }

        private void UsernameTBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Name = UsernameTBox.Text;
        }
    }
}
