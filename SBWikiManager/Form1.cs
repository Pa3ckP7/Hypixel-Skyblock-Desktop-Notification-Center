using SBWikiContent;
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
using SBWikiSettings;

namespace SBWikiManager
{
    public partial class Form1 : Form
    {
        SubForms.SBWikiContentForm content;
        SubForms.SBWikiForumForm forum;
        SubForms.SBWikiSocialForm social;
        SubForms.SettingsForm settingsF;
        Form activeform;
        SettingsManager sm = new SettingsManager();
        public Form1()
        {
            InitializeComponent();
            ForumManager cm = new ForumManager();
            cm.GetData();
            Notifications.Icon = SystemIcons.Information;
            settingsF = new SubForms.SettingsForm(sm);
            content = new SubForms.SBWikiContentForm(sm.Settings,Notifications);
            forum = new SubForms.SBWikiForumForm(sm.Settings,Notifications);
            social = new SubForms.SBWikiSocialForm(sm.Settings,Notifications);
            activeform = content;
            SwitchSubform(content);
        }
        private void SwitchSubform(Form form)
        {
            if (activeform != null) 
            {
                SubWindow.Controls.Remove(activeform);
                activeform.Hide();
            }
            form.TopLevel = false;
            form.AutoScroll = true;
            SubWindow.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            form.Show();
            activeform = form;
        }
        #region ForumSwitcher
        private void ContentButton_Click(object sender, EventArgs e)
        {
            SwitchSubform(content);
        }
        private void ForumButton_Click(object sender, EventArgs e)
        {
            SwitchSubform(forum);
        }
        private void SocialButton_Click(object sender, EventArgs e)
        {
            SwitchSubform(social);
        }        
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SwitchSubform(settingsF);
        }
        #endregion
    }
}
