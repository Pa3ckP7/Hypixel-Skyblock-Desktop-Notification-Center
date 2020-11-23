namespace SBWikiManager.SubForms
{
    partial class SBWikiContentForm
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
            this.RefeshTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // RefeshTimer
            // 
            this.RefeshTimer.Enabled = true;
            this.RefeshTimer.Interval = 60000;
            this.RefeshTimer.Tick += new System.EventHandler(this.RefeshTimer_Tick);
            // 
            // SBWikiContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 412);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SBWikiContentForm";
            this.Text = "SBWikiContentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer RefeshTimer;
    }
}