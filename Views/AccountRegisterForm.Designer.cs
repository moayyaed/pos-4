
namespace POS.Views
{
    partial class AccountRegisterForm
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
            this.AccountRegisterGroupBox = new CSharp.Winform.UI.GroupBox();
            this.RegisterNotificationlbl = new System.Windows.Forms.Label();
            this.AccountRegisterPasswordtxt = new MaterialSkin.Controls.MaterialTextBox();
            this.AccountRegisterPhonetxt = new MaterialSkin.Controls.MaterialTextBox();
            this.AccountRegisterUsernametxt = new MaterialSkin.Controls.MaterialTextBox();
            this.AccountRegisterbtn = new MaterialSkin.Controls.MaterialButton();
            this.Errorslbl = new Moonbyte.MaterialFramework.Controls.MaterialLabel();
            this.AccountLoginPagebtn = new Moonbyte.MaterialFramework.Controls.FlatButton();
            this.AccountRegisterPageCopyrightlbl = new Moonbyte.MaterialFramework.Controls.MaterialLabel();
            this.AccountRegisterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountRegisterGroupBox
            // 
            this.AccountRegisterGroupBox.Controls.Add(this.AccountRegisterPasswordtxt);
            this.AccountRegisterGroupBox.Controls.Add(this.AccountRegisterPhonetxt);
            this.AccountRegisterGroupBox.Controls.Add(this.AccountRegisterUsernametxt);
            this.AccountRegisterGroupBox.Controls.Add(this.AccountRegisterbtn);
            this.AccountRegisterGroupBox.Controls.Add(this.Errorslbl);
            this.AccountRegisterGroupBox.Controls.Add(this.AccountLoginPagebtn);
            this.AccountRegisterGroupBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.AccountRegisterGroupBox.Location = new System.Drawing.Point(43, 37);
            this.AccountRegisterGroupBox.Name = "AccountRegisterGroupBox";
            this.AccountRegisterGroupBox.Size = new System.Drawing.Size(425, 264);
            this.AccountRegisterGroupBox.TabIndex = 0;
            this.AccountRegisterGroupBox.TabStop = false;
            // 
            // RegisterNotificationlbl
            // 
            this.RegisterNotificationlbl.AutoSize = true;
            this.RegisterNotificationlbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterNotificationlbl.Location = new System.Drawing.Point(61, 316);
            this.RegisterNotificationlbl.Name = "RegisterNotificationlbl";
            this.RegisterNotificationlbl.Size = new System.Drawing.Size(0, 18);
            this.RegisterNotificationlbl.TabIndex = 13;
            // 
            // AccountRegisterPasswordtxt
            // 
            this.AccountRegisterPasswordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountRegisterPasswordtxt.Depth = 0;
            this.AccountRegisterPasswordtxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.AccountRegisterPasswordtxt.Hint = "Password";
            this.AccountRegisterPasswordtxt.Location = new System.Drawing.Point(50, 141);
            this.AccountRegisterPasswordtxt.MaxLength = 50;
            this.AccountRegisterPasswordtxt.MouseState = MaterialSkin.MouseState.OUT;
            this.AccountRegisterPasswordtxt.Multiline = false;
            this.AccountRegisterPasswordtxt.Name = "AccountRegisterPasswordtxt";
            this.AccountRegisterPasswordtxt.Password = true;
            this.AccountRegisterPasswordtxt.Size = new System.Drawing.Size(315, 50);
            this.AccountRegisterPasswordtxt.TabIndex = 12;
            this.AccountRegisterPasswordtxt.Tag = "password";
            this.AccountRegisterPasswordtxt.Text = "";
            this.AccountRegisterPasswordtxt.TextChanged += new System.EventHandler(this.AccountRegisterPasswordtxt_TextChanged_1);
            // 
            // AccountRegisterPhonetxt
            // 
            this.AccountRegisterPhonetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountRegisterPhonetxt.Depth = 0;
            this.AccountRegisterPhonetxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.AccountRegisterPhonetxt.Hint = "Phone Number";
            this.AccountRegisterPhonetxt.Location = new System.Drawing.Point(50, 77);
            this.AccountRegisterPhonetxt.MaxLength = 50;
            this.AccountRegisterPhonetxt.MouseState = MaterialSkin.MouseState.OUT;
            this.AccountRegisterPhonetxt.Multiline = false;
            this.AccountRegisterPhonetxt.Name = "AccountRegisterPhonetxt";
            this.AccountRegisterPhonetxt.Size = new System.Drawing.Size(315, 50);
            this.AccountRegisterPhonetxt.TabIndex = 11;
            this.AccountRegisterPhonetxt.Tag = "phone";
            this.AccountRegisterPhonetxt.Text = "";
            this.AccountRegisterPhonetxt.TextChanged += new System.EventHandler(this.AccountRegisterPhonetxt_TextChanged_1);
            // 
            // AccountRegisterUsernametxt
            // 
            this.AccountRegisterUsernametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountRegisterUsernametxt.Depth = 0;
            this.AccountRegisterUsernametxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.AccountRegisterUsernametxt.Hint = "Username";
            this.AccountRegisterUsernametxt.Location = new System.Drawing.Point(50, 15);
            this.AccountRegisterUsernametxt.MaxLength = 50;
            this.AccountRegisterUsernametxt.MouseState = MaterialSkin.MouseState.OUT;
            this.AccountRegisterUsernametxt.Multiline = false;
            this.AccountRegisterUsernametxt.Name = "AccountRegisterUsernametxt";
            this.AccountRegisterUsernametxt.Size = new System.Drawing.Size(315, 50);
            this.AccountRegisterUsernametxt.TabIndex = 10;
            this.AccountRegisterUsernametxt.Tag = "username";
            this.AccountRegisterUsernametxt.Text = "";
            this.AccountRegisterUsernametxt.TextChanged += new System.EventHandler(this.AccountRegisterUsernametxt_TextChanged_1);
            // 
            // AccountRegisterbtn
            // 
            this.AccountRegisterbtn.AutoSize = false;
            this.AccountRegisterbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AccountRegisterbtn.Depth = 0;
            this.AccountRegisterbtn.DrawShadows = true;
            this.AccountRegisterbtn.HighEmphasis = true;
            this.AccountRegisterbtn.Icon = null;
            this.AccountRegisterbtn.Location = new System.Drawing.Point(50, 203);
            this.AccountRegisterbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AccountRegisterbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AccountRegisterbtn.Name = "AccountRegisterbtn";
            this.AccountRegisterbtn.Size = new System.Drawing.Size(137, 38);
            this.AccountRegisterbtn.TabIndex = 9;
            this.AccountRegisterbtn.Text = "Register";
            this.AccountRegisterbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AccountRegisterbtn.UseAccentColor = false;
            this.AccountRegisterbtn.UseVisualStyleBackColor = true;
            this.AccountRegisterbtn.Click += new System.EventHandler(this.AccountRegisterbtn_Click);
            // 
            // Errorslbl
            // 
            this.Errorslbl.AutoSize = true;
            this.Errorslbl.BackColor = System.Drawing.Color.Transparent;
            this.Errorslbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Errorslbl.Location = new System.Drawing.Point(150, 258);
            this.Errorslbl.Name = "Errorslbl";
            this.Errorslbl.Opacity = 0;
            this.Errorslbl.OpacityColor = System.Drawing.Color.White;
            this.Errorslbl.Size = new System.Drawing.Size(0, 19);
            this.Errorslbl.TabIndex = 8;
            this.Errorslbl.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // AccountLoginPagebtn
            // 
            this.AccountLoginPagebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.AccountLoginPagebtn.BackgroundColorClicked = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.AccountLoginPagebtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.AccountLoginPagebtn.BorderWidth = 0;
            this.AccountLoginPagebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountLoginPagebtn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLoginPagebtn.Location = new System.Drawing.Point(194, 207);
            this.AccountLoginPagebtn.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AccountLoginPagebtn.Name = "AccountLoginPagebtn";
            this.AccountLoginPagebtn.Opacity = 0;
            this.AccountLoginPagebtn.OpacityColor = System.Drawing.Color.White;
            this.AccountLoginPagebtn.Size = new System.Drawing.Size(171, 32);
            this.AccountLoginPagebtn.TabIndex = 7;
            this.AccountLoginPagebtn.text = "already registered?";
            this.AccountLoginPagebtn.TextColor = System.Drawing.Color.RoyalBlue;
            this.AccountLoginPagebtn.WaveColor = System.Drawing.Color.Black;
            this.AccountLoginPagebtn.Click += new System.EventHandler(this.AccountLoginPagebtn_Click);
            // 
            // AccountRegisterPageCopyrightlbl
            // 
            this.AccountRegisterPageCopyrightlbl.AutoSize = true;
            this.AccountRegisterPageCopyrightlbl.BackColor = System.Drawing.Color.Transparent;
            this.AccountRegisterPageCopyrightlbl.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountRegisterPageCopyrightlbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.AccountRegisterPageCopyrightlbl.Location = new System.Drawing.Point(341, 352);
            this.AccountRegisterPageCopyrightlbl.Name = "AccountRegisterPageCopyrightlbl";
            this.AccountRegisterPageCopyrightlbl.Opacity = 0;
            this.AccountRegisterPageCopyrightlbl.OpacityColor = System.Drawing.Color.White;
            this.AccountRegisterPageCopyrightlbl.Size = new System.Drawing.Size(127, 18);
            this.AccountRegisterPageCopyrightlbl.TabIndex = 1;
            this.AccountRegisterPageCopyrightlbl.Text = "copyRight (c) 2021";
            this.AccountRegisterPageCopyrightlbl.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // AccountRegisterForm
            // 
            this.AcceptButton = this.AccountRegisterbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 395);
            this.ControlBox = false;
            this.Controls.Add(this.RegisterNotificationlbl);
            this.Controls.Add(this.AccountRegisterPageCopyrightlbl);
            this.Controls.Add(this.AccountRegisterGroupBox);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountRegisterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountRegister";
            this.Load += new System.EventHandler(this.AccountRegisterForm_Load);
            this.AccountRegisterGroupBox.ResumeLayout(false);
            this.AccountRegisterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CSharp.Winform.UI.GroupBox AccountRegisterGroupBox;
        private Moonbyte.MaterialFramework.Controls.FlatButton AccountLoginPagebtn;
        private Moonbyte.MaterialFramework.Controls.MaterialLabel AccountRegisterPageCopyrightlbl;
        private Moonbyte.MaterialFramework.Controls.MaterialLabel Errorslbl;
        private MaterialSkin.Controls.MaterialTextBox AccountRegisterPasswordtxt;
        private MaterialSkin.Controls.MaterialTextBox AccountRegisterPhonetxt;
        private MaterialSkin.Controls.MaterialTextBox AccountRegisterUsernametxt;
        private MaterialSkin.Controls.MaterialButton AccountRegisterbtn;
        private System.Windows.Forms.Label RegisterNotificationlbl;
    }
}