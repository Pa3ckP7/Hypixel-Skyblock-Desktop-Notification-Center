namespace SBWikiManager.SubForms
{
    partial class SettingsForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.Tooltips = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ForumSwitch = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SocialNotificationsPanel = new System.Windows.Forms.Panel();
            this.SocialMessagesSwitch = new System.Windows.Forms.CheckBox();
            this.SocialCommentsSwitch = new System.Windows.Forms.CheckBox();
            this.SocialSwitch = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ContentNotificationPanel = new System.Windows.Forms.Panel();
            this.ContentArticlesSwitch = new System.Windows.Forms.CheckBox();
            this.ContentLogsSwitch = new System.Windows.Forms.CheckBox();
            this.ContentSwitch = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DefaultsButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SocialNotificationsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ContentNotificationPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveButton.Location = new System.Drawing.Point(16, 17);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(129, 29);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save Settings";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 338);
            this.panel1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.ForumSwitch);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 289);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(530, 45);
            this.panel4.TabIndex = 25;
            // 
            // ForumSwitch
            // 
            this.ForumSwitch.AutoSize = true;
            this.ForumSwitch.Location = new System.Drawing.Point(16, 12);
            this.ForumSwitch.Name = "ForumSwitch";
            this.ForumSwitch.Size = new System.Drawing.Size(165, 24);
            this.ForumSwitch.TabIndex = 5;
            this.ForumSwitch.Text = "Forum Notifications";
            this.ForumSwitch.UseVisualStyleBackColor = true;
            this.ForumSwitch.CheckedChanged += new System.EventHandler(this.ForumSwitch_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(0, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Forum";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.SocialNotificationsPanel);
            this.panel3.Controls.Add(this.SocialSwitch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 79);
            this.panel3.TabIndex = 23;
            // 
            // SocialNotificationsPanel
            // 
            this.SocialNotificationsPanel.Controls.Add(this.SocialMessagesSwitch);
            this.SocialNotificationsPanel.Controls.Add(this.SocialCommentsSwitch);
            this.SocialNotificationsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SocialNotificationsPanel.Location = new System.Drawing.Point(0, 24);
            this.SocialNotificationsPanel.Name = "SocialNotificationsPanel";
            this.SocialNotificationsPanel.Size = new System.Drawing.Size(530, 55);
            this.SocialNotificationsPanel.TabIndex = 5;
            // 
            // SocialMessagesSwitch
            // 
            this.SocialMessagesSwitch.AutoSize = true;
            this.SocialMessagesSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.SocialMessagesSwitch.Location = new System.Drawing.Point(0, 24);
            this.SocialMessagesSwitch.Name = "SocialMessagesSwitch";
            this.SocialMessagesSwitch.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SocialMessagesSwitch.Size = new System.Drawing.Size(530, 24);
            this.SocialMessagesSwitch.TabIndex = 1;
            this.SocialMessagesSwitch.Text = "Messages";
            this.SocialMessagesSwitch.UseVisualStyleBackColor = true;
            this.SocialMessagesSwitch.CheckedChanged += new System.EventHandler(this.SocialMessagesSwitch_CheckedChanged);
            // 
            // SocialCommentsSwitch
            // 
            this.SocialCommentsSwitch.AutoSize = true;
            this.SocialCommentsSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.SocialCommentsSwitch.Location = new System.Drawing.Point(0, 0);
            this.SocialCommentsSwitch.Name = "SocialCommentsSwitch";
            this.SocialCommentsSwitch.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SocialCommentsSwitch.Size = new System.Drawing.Size(530, 24);
            this.SocialCommentsSwitch.TabIndex = 0;
            this.SocialCommentsSwitch.Text = "Comments";
            this.SocialCommentsSwitch.UseVisualStyleBackColor = true;
            this.SocialCommentsSwitch.CheckedChanged += new System.EventHandler(this.SocialCommentsSwitch_CheckedChanged);
            // 
            // SocialSwitch
            // 
            this.SocialSwitch.AutoSize = true;
            this.SocialSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.SocialSwitch.Location = new System.Drawing.Point(0, 0);
            this.SocialSwitch.Name = "SocialSwitch";
            this.SocialSwitch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.SocialSwitch.Size = new System.Drawing.Size(530, 24);
            this.SocialSwitch.TabIndex = 4;
            this.SocialSwitch.Text = "Social Notifications";
            this.SocialSwitch.UseVisualStyleBackColor = true;
            this.SocialSwitch.CheckedChanged += new System.EventHandler(this.SocialSwitch_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(0, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Social";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.ContentNotificationPanel);
            this.panel2.Controls.Add(this.ContentSwitch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 78);
            this.panel2.TabIndex = 21;
            // 
            // ContentNotificationPanel
            // 
            this.ContentNotificationPanel.Controls.Add(this.ContentArticlesSwitch);
            this.ContentNotificationPanel.Controls.Add(this.ContentLogsSwitch);
            this.ContentNotificationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContentNotificationPanel.Location = new System.Drawing.Point(0, 24);
            this.ContentNotificationPanel.Name = "ContentNotificationPanel";
            this.ContentNotificationPanel.Size = new System.Drawing.Size(530, 54);
            this.ContentNotificationPanel.TabIndex = 4;
            // 
            // ContentArticlesSwitch
            // 
            this.ContentArticlesSwitch.AutoSize = true;
            this.ContentArticlesSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContentArticlesSwitch.Location = new System.Drawing.Point(0, 24);
            this.ContentArticlesSwitch.Name = "ContentArticlesSwitch";
            this.ContentArticlesSwitch.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ContentArticlesSwitch.Size = new System.Drawing.Size(530, 24);
            this.ContentArticlesSwitch.TabIndex = 1;
            this.ContentArticlesSwitch.Text = "Articles";
            this.ContentArticlesSwitch.UseVisualStyleBackColor = true;
            this.ContentArticlesSwitch.CheckedChanged += new System.EventHandler(this.ContentArticlesSwitch_CheckedChanged);
            // 
            // ContentLogsSwitch
            // 
            this.ContentLogsSwitch.AutoSize = true;
            this.ContentLogsSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContentLogsSwitch.Location = new System.Drawing.Point(0, 0);
            this.ContentLogsSwitch.Name = "ContentLogsSwitch";
            this.ContentLogsSwitch.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ContentLogsSwitch.Size = new System.Drawing.Size(530, 24);
            this.ContentLogsSwitch.TabIndex = 0;
            this.ContentLogsSwitch.Text = "Logs";
            this.ContentLogsSwitch.UseVisualStyleBackColor = true;
            this.ContentLogsSwitch.CheckedChanged += new System.EventHandler(this.ContentLogsSwitch_CheckedChanged);
            // 
            // ContentSwitch
            // 
            this.ContentSwitch.AutoSize = true;
            this.ContentSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContentSwitch.Location = new System.Drawing.Point(0, 0);
            this.ContentSwitch.Name = "ContentSwitch";
            this.ContentSwitch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ContentSwitch.Size = new System.Drawing.Size(530, 24);
            this.ContentSwitch.TabIndex = 3;
            this.ContentSwitch.Text = "Content Notifications";
            this.ContentSwitch.UseVisualStyleBackColor = true;
            this.ContentSwitch.CheckedChanged += new System.EventHandler(this.ContentSwitch_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(0, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Content";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.UsernameTBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(530, 52);
            this.panel5.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // UsernameTBox
            // 
            this.UsernameTBox.Location = new System.Drawing.Point(99, 11);
            this.UsernameTBox.Name = "UsernameTBox";
            this.UsernameTBox.Size = new System.Drawing.Size(100, 26);
            this.UsernameTBox.TabIndex = 7;
            this.UsernameTBox.Leave += new System.EventHandler(this.UsernameTBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Global";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DefaultsButton);
            this.panel6.Controls.Add(this.SaveButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 338);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(530, 56);
            this.panel6.TabIndex = 8;
            // 
            // DefaultsButton
            // 
            this.DefaultsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DefaultsButton.Location = new System.Drawing.Point(196, 17);
            this.DefaultsButton.Name = "DefaultsButton";
            this.DefaultsButton.Size = new System.Drawing.Size(129, 29);
            this.DefaultsButton.TabIndex = 7;
            this.DefaultsButton.Text = "Load Defaults";
            this.DefaultsButton.UseVisualStyleBackColor = true;
            this.DefaultsButton.Click += new System.EventHandler(this.DefaultsButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 396);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.SocialNotificationsPanel.ResumeLayout(false);
            this.SocialNotificationsPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ContentNotificationPanel.ResumeLayout(false);
            this.ContentNotificationPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ToolTip Tooltips;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox ForumSwitch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox SocialSwitch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox ContentSwitch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel SocialNotificationsPanel;
        private System.Windows.Forms.CheckBox SocialMessagesSwitch;
        private System.Windows.Forms.CheckBox SocialCommentsSwitch;
        private System.Windows.Forms.Panel ContentNotificationPanel;
        private System.Windows.Forms.CheckBox ContentArticlesSwitch;
        private System.Windows.Forms.CheckBox ContentLogsSwitch;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button DefaultsButton;
    }
}