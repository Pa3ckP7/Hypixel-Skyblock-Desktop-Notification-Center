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

namespace SBWikiManager
{
    public partial class Form1 : Form
    {
        List<Entry> CurrentEntries;
        SubForms.SBWikiContentForm content = new SubForms.SBWikiContentForm();
        SubForms.SBWikiForumForm forum = new SubForms.SBWikiForumForm();
        SubForms.SBWikiSocialForm social = new SubForms.SBWikiSocialForm();
        Form activeform;
        public Form1()
        {
            InitializeComponent();
            ForumManager cm = new ForumManager();
            cm.GetData();
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
        #endregion
    }
}
