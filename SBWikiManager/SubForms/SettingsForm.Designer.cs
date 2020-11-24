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
            this.ContentSwitch = new System.Windows.Forms.CheckBox();
            this.SocialSwitch = new System.Windows.Forms.CheckBox();
            this.ForumSwitch = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContentSwitch
            // 
            this.ContentSwitch.AutoSize = true;
            this.ContentSwitch.Location = new System.Drawing.Point(42, 39);
            this.ContentSwitch.Name = "ContentSwitch";
            this.ContentSwitch.Size = new System.Drawing.Size(176, 24);
            this.ContentSwitch.TabIndex = 3;
            this.ContentSwitch.Text = "Content Notifications";
            this.ContentSwitch.UseVisualStyleBackColor = true;
            this.ContentSwitch.CheckedChanged += new System.EventHandler(this.ContentSwitch_CheckedChanged);
            // 
            // SocialSwitch
            // 
            this.SocialSwitch.AutoSize = true;
            this.SocialSwitch.Location = new System.Drawing.Point(42, 80);
            this.SocialSwitch.Name = "SocialSwitch";
            this.SocialSwitch.Size = new System.Drawing.Size(162, 24);
            this.SocialSwitch.TabIndex = 4;
            this.SocialSwitch.Text = "Social Notifications";
            this.SocialSwitch.UseVisualStyleBackColor = true;
            this.SocialSwitch.CheckedChanged += new System.EventHandler(this.SocialSwitch_CheckedChanged);
            // 
            // ForumSwitch
            // 
            this.ForumSwitch.AutoSize = true;
            this.ForumSwitch.Location = new System.Drawing.Point(39, 123);
            this.ForumSwitch.Name = "ForumSwitch";
            this.ForumSwitch.Size = new System.Drawing.Size(165, 24);
            this.ForumSwitch.TabIndex = 5;
            this.ForumSwitch.Text = "Forum Notifications";
            this.ForumSwitch.UseVisualStyleBackColor = true;
            this.ForumSwitch.CheckedChanged += new System.EventHandler(this.ForumSwitch_CheckedChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(39, 216);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(129, 29);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save Settings";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 265);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ForumSwitch);
            this.Controls.Add(this.SocialSwitch);
            this.Controls.Add(this.ContentSwitch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ContentSwitch;
        private System.Windows.Forms.CheckBox SocialSwitch;
        private System.Windows.Forms.CheckBox ForumSwitch;
        private System.Windows.Forms.Button SaveButton;
    }
}