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
            SubWindow.BackColor = Color.FromArgb(54, 26, 29);
            panel1.BackColor = Color.FromArgb(204, 153, 51);
            ContentButton.BackColor = Color.FromArgb(193, 89, 38);
            SocialButton.BackColor = Color.FromArgb(193, 89, 38);
            ForumButton.BackColor = Color.FromArgb(193, 89, 38);
            SettingsButton.BackColor = Color.FromArgb(193, 89, 38);
            ContentButton.ForeColor = Color.LightGray;
            SocialButton.ForeColor = Color.LightGray;
            ForumButton.ForeColor = Color.LightGray;
            SettingsButton.ForeColor = Color.LightGray;
            SettingsButton.FlatAppearance.BorderColor = Color.LightGray;
            ContentButton.FlatAppearance.BorderColor = Color.LightGray;
            SocialButton.FlatAppearance.BorderColor = Color.LightGray;
            ForumButton.FlatAppearance.BorderColor = Color.LightGray;
            ForumManager cm = new ForumManager();
            cm.GetData();
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
            form.BackColor = Color.FromArgb(54, 26, 29);
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

        private void Notifications_BalloonTipClicked(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
        }
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Show();
            WindowState = FormWindowState.Normal;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            Notifications.ShowBalloonTip(1000,"Hypixel-Skyblock Dekstop Notification Center","The app has been minimized to System Tray",ToolTipIcon.None);
        }
        private void Notifications_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Show();
            WindowState = FormWindowState.Normal;
        }
    }
}
