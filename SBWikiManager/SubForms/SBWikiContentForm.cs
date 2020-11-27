using SBWikiContent;
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
    public partial class SBWikiContentForm : Form
    {
        List<LinkedButton> buttons = new List<LinkedButton>();
        ContentManager cm = new ContentManager();
        Settings Settings;
        NotifyIcon Notifications;
        public SBWikiContentForm(Settings settings,NotifyIcon notifications)
        {
            InitializeComponent();
            Notifications = notifications;
            Settings = settings;
            List<Entry> entries = cm.GetData();
            #region display            
            for (int i = entries.Count-1; i >= 0; i--) 
            {
                LinkedButton button = new LinkedButton(entries[i].link);
                button.Dock = DockStyle.Top;
                button.Name = "button";
                button.button.BackColor = Color.Transparent;
                button.button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.Transparent;
                button.button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.button.FlatAppearance.BorderSize = 0;
                button.button.ForeColor = Color.LightGray;
                button.Height = 30;
                switch (entries[i].type)
                {
                    case "edit":
                        if (!entries[i].HasMinorFlag) button.button.Text = $"{entries[i].user} edited {entries[i].title} description {entries[i].commentshort}";
                        else button.button.Text = $"[minor]{entries[i].user} edited {entries[i].title} description {entries[i].commentshort}";
                        break;
                    case "log":
                        button.button.Text = $"[LOG|{entries[i].logtype}] {entries[i].user} logged action {entries[i].logaction} {entries[i].title} description: {entries[i].commentshort}";
                        break;
                    case "new":
                        button.button.Text = $"{entries[i].user} created {entries[i].title} description {entries[i].commentshort}";
                        break;
                } // set text
                button.button.TextAlign = ContentAlignment.TopLeft;
                Tooltips.SetToolTip(button.button, button.link);
                Controls.Add(button);
                buttons.Add(button);
            }
            #endregion
        }
        private void RefeshTimer_Tick(object sender, EventArgs e)
        {
            List<Entry> entries = cm.RefreshData();
            for (int i = entries.Count-1; i >= 0; i--) 
            {
                LinkedButton button = new LinkedButton(entries[i].link);               
                button.Dock = DockStyle.Top;
                button.Name = "button";
                button.button.BackColor = Color.Transparent;
                button.button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.Transparent;
                button.button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.button.FlatAppearance.BorderSize = 0;
                button.button.ForeColor = Color.LightGray;
                button.Height = 30;
                switch (entries[i].type)
                {
                    case "edit":
                        if (!entries[i].HasMinorFlag)
                        {
                            button.button.Text = $"{entries[i].user} edited {entries[i].title} description {entries[i].commentshort}";
                            if(Settings.Content.ArticleNotifications)Notify("Content|Edit", $"{entries[i].user} done an edit on {entries[i].title}", entries[i].user);
                        }
                        else
                        {
                            button.button.Text = $"[minor]{entries[i].user} edited {entries[i].title} description {entries[i].commentshort}";
                            if (Settings.Content.ArticleNotifications)Notify("Content|Minor Edit", $"{entries[i].user} done a minor edit on {entries[i].title}",entries[i].user);
                        }
                        break;
                    case "log":
                        button.button.Text = $"[LOG|{entries[i].logtype}] {entries[i].user} logged action {entries[i].logaction} {entries[i].title} description: {entries[i].commentshort}";
                        if(Settings.Content.LogNotifications)Notify("Content|Log", $"[LOG|{entries[i].logtype}] {entries[i].user} logged action {entries[i].logaction}", entries[i].user);
                        break;
                    case "new":
                        button.button.Text = $"{entries[i].user} created {entries[i].title} description {entries[i].commentshort}";
                        if (Settings.Content.ArticleNotifications)Notify("Content|New Article", $"{entries[i].user} created {entries[i].title}", entries[i].user);
                        break;
                } // set text
                button.button.TextAlign = ContentAlignment.TopLeft;
                Tooltips.SetToolTip(button.button, button.link);
                Controls.Add(button);
                buttons.Add(button);
                
            }
            if (buttons.Count > 100)
            {
                buttons.Reverse();
                for (int i = 100; i < buttons.Count; i++)
                {
                    buttons[i].Dispose();
                }
                buttons.RemoveAll(x => buttons.IndexOf(x) >= 100);
                buttons.Reverse();
            }
            VerticalScroll.Value = 0;
        }
        public void Notify(string title, string text, string user) 
        {
            if (Settings.Content.AllowNotifications)
            {
                if (!Settings.Names.Contains(user))
                {
                    Notifications.ShowBalloonTip(5000, title, text, ToolTipIcon.None);
                }
            }
        }
    }
}
