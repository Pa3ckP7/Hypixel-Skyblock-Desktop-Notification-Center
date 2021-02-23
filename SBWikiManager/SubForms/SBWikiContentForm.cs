using SBWikiContent;
using SBWikiSettings;
using UserCheck;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

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
                switch (entries[i].type)
                {
                    case "edit":
                        if (!entries[i].HasMinorFlag)
                        {
                            button.tags.Hide();
                            button.name.Text = entries[i].user;
                            ColorName(entries[i].user, button);
                            button.button.Text = $"edited {entries[i].title} description {entries[i].commentshort}";
                        }
                        else
                        {
                            button.tags.Text = "[minor]";
                            button.name.Text = entries[i].user;
                            ColorName(entries[i].user, button);
                            button.button.Text = $"edited {entries[i].title} description {entries[i].commentshort}";
                        }
                        break;
                    case "log":
                        button.tags.Text = $"[LOG|{entries[i].logtype}]";
                        button.name.Text = entries[i].user;
                        ColorName(entries[i].user, button);
                        button.button.Text = $"logged action {entries[i].logaction} {entries[i].title} description: {entries[i].commentshort}";
                        break;
                    case "new":
                        button.name.Text = entries[i].user;
                        button.tags.Hide();
                        ColorName(entries[i].user, button);
                        button.button.Text = $"created {entries[i].title} description {entries[i].commentshort}";
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
                switch (entries[i].type)
                {
                    case "edit":
                        if (!entries[i].HasMinorFlag)
                        {
                            button.name.Text = entries[i].user;
                            button.tags.Hide();
                            ColorName(entries[i].user, button);
                            button.button.Text = $"edited {entries[i].title} description {entries[i].commentshort}";
                            if(Settings.Content.ArticleNotifications)Notify("Content|Edit", $"{entries[i].user} done an edit on {entries[i].title}", entries[i].user);
                        }
                        else
                        {
                            button.tags.Text = "[minor]";
                            button.name.Text = entries[i].user;
                            ColorName(entries[i].user, button);
                            button.button.Text = $"edited {entries[i].title} description {entries[i].commentshort}";
                            if (Settings.Content.ArticleNotifications)Notify("Content|Minor Edit", $"{entries[i].user} done a minor edit on {entries[i].title}",entries[i].user);
                        }
                        break;
                    case "log":
                        button.tags.Text = $"[LOG|{entries[i].logtype}]";
                        button.name.Text = entries[i].user;
                        ColorName(entries[i].user, button);
                        button.button.Text = $"logged action {entries[i].logaction} {entries[i].title} description: {entries[i].commentshort}";
                        if(Settings.Content.LogNotifications)Notify("Content|Log", $"[LOG|{entries[i].logtype}] {entries[i].user} logged action {entries[i].logaction}", entries[i].user);
                        break;
                    case "new":
                        button.tags.Hide();
                        button.name.Text = entries[i].user;
                        ColorName(entries[i].user, button);
                        button.button.Text = $"created {entries[i].title} description {entries[i].commentshort}";
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
