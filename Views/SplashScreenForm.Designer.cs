

namespace POS.Views
{
    partial class SplashScreenForm
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
            this.ApplicationProgressStatelbl = new Moonbyte.MaterialFramework.Controls.MaterialLabel();
            this.ApplicationProgressStateCounterlbl = new Moonbyte.MaterialFramework.Controls.MaterialLabel();
            this.ProgressStatelbl = new Moonbyte.MaterialFramework.Controls.MaterialLabel();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.DeveloperLogolbl = new Moonbyte.MaterialFramework.Controls.MaterialLabel();
            this.ApplicationProgressBar = new Moonbyte.MaterialFramework.Controls.MaterialProgressBar();
            this.SuspendLayout();
            // 
            // ApplicationProgressStatelbl
            // 
            this.ApplicationProgressStatelbl.AutoSize = true;
            this.ApplicationProgressStatelbl.BackColor = System.Drawing.Color.Transparent;
            this.ApplicationProgressStatelbl.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationProgressStatelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.ApplicationProgressStatelbl.Location = new System.Drawing.Point(216, 22);
            this.ApplicationProgressStatelbl.Name = "ApplicationProgressStatelbl";
            this.ApplicationProgressStatelbl.Opacity = 0;
            this.ApplicationProgressStatelbl.OpacityColor = System.Drawing.Color.White;
            this.ApplicationProgressStatelbl.Size = new System.Drawing.Size(94, 16);
            this.ApplicationProgressStatelbl.TabIndex = 1;
            this.ApplicationProgressStatelbl.Text = "progress state";
            this.ApplicationProgressStatelbl.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ApplicationProgressStatelbl.Visible = false;
            // 
            // ApplicationProgressStateCounterlbl
            // 
            this.ApplicationProgressStateCounterlbl.AutoSize = true;
            this.ApplicationProgressStateCounterlbl.BackColor = System.Drawing.Color.Transparent;
            this.ApplicationProgressStateCounterlbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.ApplicationProgressStateCounterlbl.Location = new System.Drawing.Point(368, 266);
            this.ApplicationProgressStateCounterlbl.Name = "ApplicationProgressStateCounterlbl";
            this.ApplicationProgressStateCounterlbl.Opacity = 0;
            this.ApplicationProgressStateCounterlbl.OpacityColor = System.Drawing.Color.White;
            this.ApplicationProgressStateCounterlbl.Size = new System.Drawing.Size(50, 32);
            this.ApplicationProgressStateCounterlbl.TabIndex = 2;
            this.ApplicationProgressStateCounterlbl.Text = "0%";
            this.ApplicationProgressStateCounterlbl.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // ProgressStatelbl
            // 
            this.ProgressStatelbl.AutoSize = true;
            this.ProgressStatelbl.BackColor = System.Drawing.Color.Transparent;
            this.ProgressStatelbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ProgressStatelbl.Location = new System.Drawing.Point(167, 22);
            this.ProgressStatelbl.Name = "ProgressStatelbl";
            this.ProgressStatelbl.Opacity = 0;
            this.ProgressStatelbl.OpacityColor = System.Drawing.Color.White;
            this.ProgressStatelbl.Size = new System.Drawing.Size(43, 19);
            this.ProgressStatelbl.TabIndex = 3;
            this.ProgressStatelbl.Text = "State:";
            this.ProgressStatelbl.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ProgressStatelbl.Visible = false;
            // 
            // progressTimer
            // 
            this.progressTimer.Interval = 30;
            this.progressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
            // 
            // DeveloperLogolbl
            // 
            this.DeveloperLogolbl.AutoSize = true;
            this.DeveloperLogolbl.BackColor = System.Drawing.Color.Transparent;
            this.DeveloperLogolbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeveloperLogolbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DeveloperLogolbl.Location = new System.Drawing.Point(12, 277);
            this.DeveloperLogolbl.Name = "DeveloperLogolbl";
            this.DeveloperLogolbl.Opacity = 0;
            this.DeveloperLogolbl.OpacityColor = System.Drawing.Color.White;
            this.DeveloperLogolbl.Size = new System.Drawing.Size(124, 20);
            this.DeveloperLogolbl.TabIndex = 4;
            this.DeveloperLogolbl.Text = "Zbug Technology";
            this.DeveloperLogolbl.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // ApplicationProgressBar
            // 
            this.ApplicationProgressBar.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ApplicationProgressBar.Location = new System.Drawing.Point(38, 28);
            this.ApplicationProgressBar.Maximum = 100;
            this.ApplicationProgressBar.Minimum = 0;
            this.ApplicationProgressBar.Name = "ApplicationProgressBar";
            this.ApplicationProgressBar.Opacity = 0;
            this.ApplicationProgressBar.OpacityColor = System.Drawing.Color.White;
            this.ApplicationProgressBar.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.ApplicationProgressBar.Size = new System.Drawing.Size(99, 10);
            this.ApplicationProgressBar.TabIndex = 0;
            this.ApplicationProgressBar.Value = 0;
            this.ApplicationProgressBar.Visible = false;
            // 
            // SplashScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::POS.Properties.Resources.oldlogo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(442, 309);
            this.Controls.Add(this.DeveloperLogolbl);
            this.Controls.Add(this.ProgressStatelbl);
            this.Controls.Add(this.ApplicationProgressStateCounterlbl);
            this.Controls.Add(this.ApplicationProgressStatelbl);
            this.Controls.Add(this.ApplicationProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreenForm";
            this.Load += new System.EventHandler(this.SplashScreenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private Moonbyte.MaterialFramework.Controls.MaterialLabel ApplicationProgressStatelbl;
        private Moonbyte.MaterialFramework.Controls.MaterialLabel ApplicationProgressStateCounterlbl;
        private Moonbyte.MaterialFramework.Controls.MaterialLabel ProgressStatelbl;
        private System.Windows.Forms.Timer progressTimer;
        private Moonbyte.MaterialFramework.Controls.MaterialLabel DeveloperLogolbl;
        private Moonbyte.MaterialFramework.Controls.MaterialProgressBar ApplicationProgressBar;
    }
}