namespace SBWikiManager
{
    partial class LinkedButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tags = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tags
            // 
            this.Tags.AutoSize = true;
            this.Tags.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tags.Location = new System.Drawing.Point(0, 0);
            this.Tags.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.Tags.Name = "Tags";
            this.Tags.Size = new System.Drawing.Size(14, 29);
            this.Tags.TabIndex = 5;
            this.Tags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tags.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Dock = System.Windows.Forms.DockStyle.Left;
            this.User.Location = new System.Drawing.Point(14, 0);
            this.User.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(75, 29);
            this.User.TabIndex = 6;
            this.User.Text = "button2";
            this.User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.User.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(89, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(478, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LinkedButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Tags);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LinkedButton";
            this.Size = new System.Drawing.Size(567, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Tags;
        private System.Windows.Forms.Button User;
        private System.Windows.Forms.Button button1;
    }
}
