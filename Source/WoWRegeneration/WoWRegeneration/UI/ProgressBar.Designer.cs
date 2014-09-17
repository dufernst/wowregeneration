namespace WoWRegeneration.UI
{
    partial class ProgressBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressBar));
            this.playButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackgroundImage = global::WoWRegeneration.Properties.Resources.PlayButtonDisabled;
            this.playButton.Location = new System.Drawing.Point(645, 20);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(141, 85);
            this.playButton.TabIndex = 0;
            this.playButton.TabStop = false;
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::WoWRegeneration.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(799, 118);
            this.Controls.Add(this.playButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProgressBar";
            this.Text = "DutchWoW Installer";
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playButton;
    }
}