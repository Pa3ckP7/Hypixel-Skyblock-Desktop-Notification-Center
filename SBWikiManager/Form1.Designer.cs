namespace SBWikiManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ForumButton = new System.Windows.Forms.Button();
            this.SocialButton = new System.Windows.Forms.Button();
            this.ContentButton = new System.Windows.Forms.Button();
            this.SubWindow = new System.Windows.Forms.Panel();
            this.Notifications = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SettingsButton);
            this.panel1.Controls.Add(this.ForumButton);
            this.panel1.Controls.Add(this.SocialButton);
            this.panel1.Controls.Add(this.ContentButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 41);
            this.panel1.TabIndex = 0;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingsButton.Location = new System.Drawing.Point(344, 0);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(112, 41);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ForumButton
            // 
            this.ForumButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ForumButton.Location = new System.Drawing.Point(269, 0);
            this.ForumButton.Name = "ForumButton";
            this.ForumButton.Size = new System.Drawing.Size(75, 41);
            this.ForumButton.TabIndex = 3;
            this.ForumButton.Text = "Forum";
            this.ForumButton.UseVisualStyleBackColor = true;
            this.ForumButton.Click += new System.EventHandler(this.ForumButton_Click);
            // 
            // SocialButton
            // 
            this.SocialButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SocialButton.Location = new System.Drawing.Point(157, 0);
            this.SocialButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SocialButton.Name = "SocialButton";
            this.SocialButton.Size = new System.Drawing.Size(112, 41);
            this.SocialButton.TabIndex = 1;
            this.SocialButton.Text = "Social";
            this.SocialButton.UseVisualStyleBackColor = true;
            this.SocialButton.Click += new System.EventHandler(this.SocialButton_Click);
            // 
            // ContentButton
            // 
            this.ContentButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContentButton.Location = new System.Drawing.Point(0, 0);
            this.ContentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContentButton.Name = "ContentButton";
            this.ContentButton.Size = new System.Drawing.Size(157, 41);
            this.ContentButton.TabIndex = 0;
            this.ContentButton.Text = "Recent Changes";
            this.ContentButton.UseVisualStyleBackColor = true;
            this.ContentButton.Click += new System.EventHandler(this.ContentButton_Click);
            // 
            // SubWindow
            // 
            this.SubWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubWindow.AutoScroll = true;
            this.SubWindow.Location = new System.Drawing.Point(0, 41);
            this.SubWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubWindow.Name = "SubWindow";
            this.SubWindow.Size = new System.Drawing.Size(786, 403);
            this.SubWindow.TabIndex = 1;
            // 
            // Notifications
            // 
            this.Notifications.ContextMenuStrip = this.contextMenuStrip1;
            this.Notifications.Text = "SBWiki Dekstop Notifications";
            this.Notifications.Visible = true;
            this.Notifications.BalloonTipClicked += new System.EventHandler(this.Notifications_BalloonTipClicked);
            this.Notifications.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Notifications_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 444);
            this.Controls.Add(this.SubWindow);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Hypixel-Skyblock Wiki Desktop Notification Center ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SocialButton;
        private System.Windows.Forms.Button ContentButton;
        private System.Windows.Forms.Panel SubWindow;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ForumButton;
        private System.Windows.Forms.NotifyIcon Notifications;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

