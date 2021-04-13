
namespace POS.Views
{
    partial class AccountLoginForm
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
            this.AccountLoginGroupBox = new CSharp.Winform.UI.GroupBox();
            this.ServerConfigbtn = new FontAwesome.Sharp.IconButton();
            this.ApplicationExitbtn = new MaterialSkin.Controls.MaterialButton();
            this.AccountLoginbtn = new MaterialSkin.Controls.MaterialButton();
            this.AccountLoginPasswordtxt = new MaterialSkin.Controls.MaterialTextBox();
            this.AccountLoginUsernametxt = new MaterialSkin.Controls.MaterialTextBox();
            this.Errorslbl = new Moonbyte.MaterialFramework.Controls.MaterialLabel();
            this.AccountRegisterPageLink = new Moonbyte.MaterialFramework.Controls.MaterialLabel();
            this.AccountResetPasswordPageLink = new Moonbyte.MaterialFramework.Controls.MaterialLabel();
            this.ConfigureSystemSettings = new FontAwesome.Sharp.IconButton();
            this.AccountLoginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountLoginGroupBox
            // 
            this.AccountLoginGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountLoginGroupBox.Controls.Add(this.ConfigureSystemSettings);
            this.AccountLoginGroupBox.Controls.Add(this.ServerConfigbtn);
            this.AccountLoginGroupBox.Controls.Add(this.ApplicationExitbtn);
            this.AccountLoginGroupBox.Controls.Add(this.AccountLoginbtn);
            this.AccountLoginGroupBox.Controls.Add(this.AccountLoginPasswordtxt);
            this.AccountLoginGroupBox.Controls.Add(this.AccountLoginUsernametxt);
            this.AccountLoginGroupBox.Controls.Add(this.Errorslbl);
            this.AccountLoginGroupBox.Controls.Add(this.AccountRegisterPageLink);
            this.AccountLoginGroupBox.Controls.Add(this.AccountResetPasswordPageLink);
            this.AccountLoginGroupBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.AccountLoginGroupBox.Location = new System.Drawing.Point(21, 44);
            this.AccountLoginGroupBox.Name = "AccountLoginGroupBox";
            this.AccountLoginGroupBox.Size = new System.Drawing.Size(431, 274);
            this.AccountLoginGroupBox.TabIndex = 0;
            this.AccountLoginGroupBox.TabStop = false;
            // 
            // ServerConfigbtn
            // 
            this.ServerConfigbtn.FlatAppearance.BorderSize = 0;
            this.ServerConfigbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServerConfigbtn.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.ServerConfigbtn.IconColor = System.Drawing.Color.Silver;
            this.ServerConfigbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ServerConfigbtn.IconSize = 20;
            this.ServerConfigbtn.Location = new System.Drawing.Point(385, 234);
            this.ServerConfigbtn.Name = "ServerConfigbtn";
            this.ServerConfigbtn.Size = new System.Drawing.Size(40, 30);
            this.ServerConfigbtn.TabIndex = 13;
            this.ServerConfigbtn.UseVisualStyleBackColor = true;
            this.ServerConfigbtn.Click += new System.EventHandler(this.ServerConfigbtn_Click);
            // 
            // ApplicationExitbtn
            // 
            this.ApplicationExitbtn.AutoSize = false;
            this.ApplicationExitbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ApplicationExitbtn.Depth = 0;
            this.ApplicationExitbtn.DrawShadows = true;
            this.ApplicationExitbtn.HighEmphasis = false;
            this.ApplicationExitbtn.Icon = null;
            this.ApplicationExitbtn.Location = new System.Drawing.Point(256, 135);
            this.ApplicationExitbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ApplicationExitbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ApplicationExitbtn.Name = "ApplicationExitbtn";
            this.ApplicationExitbtn.Size = new System.Drawing.Size(109, 36);
            this.ApplicationExitbtn.TabIndex = 12;
            this.ApplicationExitbtn.Text = "exit";
            this.ApplicationExitbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ApplicationExitbtn.UseAccentColor = false;
            this.ApplicationExitbtn.UseVisualStyleBackColor = true;
            this.ApplicationExitbtn.Click += new System.EventHandler(this.ApplicationExitbtn_Click);
            // 
            // AccountLoginbtn
            // 
            this.AccountLoginbtn.AutoSize = false;
            this.AccountLoginbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AccountLoginbtn.Depth = 0;
            this.AccountLoginbtn.DrawShadows = true;
            this.AccountLoginbtn.HighEmphasis = true;
            this.AccountLoginbtn.Icon = null;
            this.AccountLoginbtn.Location = new System.Drawing.Point(61, 135);
            this.AccountLoginbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AccountLoginbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AccountLoginbtn.Name = "AccountLoginbtn";
            this.AccountLoginbtn.Size = new System.Drawing.Size(187, 36);
            this.AccountLoginbtn.TabIndex = 11;
            this.AccountLoginbtn.Text = "Submit";
            this.AccountLoginbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AccountLoginbtn.UseAccentColor = false;
            this.AccountLoginbtn.UseVisualStyleBackColor = true;
            this.AccountLoginbtn.Click += new System.EventHandler(this.AccountLoginbtn_Click);
            // 
            // AccountLoginPasswordtxt
            // 
            this.AccountLoginPasswordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountLoginPasswordtxt.Depth = 0;
            this.AccountLoginPasswordtxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.AccountLoginPasswordtxt.Hint = "Password";
            this.AccountLoginPasswordtxt.Location = new System.Drawing.Point(61, 79);
            this.AccountLoginPasswordtxt.MaxLength = 50;
            this.AccountLoginPasswordtxt.MouseState = MaterialSkin.MouseState.OUT;
            this.AccountLoginPasswordtxt.Multiline = false;
            this.AccountLoginPasswordtxt.Name = "AccountLoginPasswordtxt";
            this.AccountLoginPasswordtxt.Password = true;
            this.AccountLoginPasswordtxt.Size = new System.Drawing.Size(304, 50);
            this.AccountLoginPasswordtxt.TabIndex = 10;
            this.AccountLoginPasswordtxt.Tag = "password";
            this.AccountLoginPasswordtxt.Text = "";
            this.AccountLoginPasswordtxt.TextChanged += new System.EventHandler(this.AccountLoginPasswordtxt_TextChanged_1);
            // 
            // AccountLoginUsernametxt
            // 
            this.AccountLoginUsernametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountLoginUsernametxt.Depth = 0;
            this.AccountLoginUsernametxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.AccountLoginUsernametxt.Hint = "Phone Number";
            this.AccountLoginUsernametxt.Location = new System.Drawing.Point(61, 20);
            this.AccountLoginUsernametxt.MaxLength = 50;
            this.AccountLoginUsernametxt.MouseState = MaterialSkin.MouseState.OUT;
            this.AccountLoginUsernametxt.Multiline = false;
            this.AccountLoginUsernametxt.Name = "AccountLoginUsernametxt";
            this.AccountLoginUsernametxt.Size = new System.Drawing.Size(304, 50);
            this.AccountLoginUsernametxt.TabIndex = 9;
            this.AccountLoginUsernametxt.Tag = "username";
            this.AccountLoginUsernametxt.Text = "";
            this.AccountLoginUsernametxt.TextChanged += new System.EventHandler(this.AccountLoginUsernametxt_TextChanged_1);
            // 
            // Errorslbl
            // 
            this.Errorslbl.AutoSize = true;
            this.Errorslbl.BackColor = System.Drawing.Color.Transparent;
            this.Errorslbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Errorslbl.ForeColor = System.Drawing.Color.Firebrick;
            this.Errorslbl.Location = new System.Drawing.Point(146, 220);
            this.Errorslbl.Name = "Errorslbl";
            this.Errorslbl.Opacity = 0;
            this.Errorslbl.OpacityColor = System.Drawing.Color.White;
            this.Errorslbl.Size = new System.Drawing.Size(0, 19);
            this.Errorslbl.TabIndex = 8;
            this.Errorslbl.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // AccountRegisterPageLink
            // 
            this.AccountRegisterPageLink.AutoSize = true;
            this.AccountRegisterPageLink.BackColor = System.Drawing.Color.Transparent;
            this.AccountRegisterPageLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountRegisterPageLink.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountRegisterPageLink.ForeColor = System.Drawing.Color.SteelBlue;
            this.AccountRegisterPageLink.Location = new System.Drawing.Point(247, 190);
            this.AccountRegisterPageLink.Name = "AccountRegisterPageLink";
            this.AccountRegisterPageLink.Opacity = 0;
            this.AccountRegisterPageLink.OpacityColor = System.Drawing.Color.White;
            this.AccountRegisterPageLink.Size = new System.Drawing.Size(118, 19);
            this.AccountRegisterPageLink.TabIndex = 7;
            this.AccountRegisterPageLink.Text = "create Account";
            this.AccountRegisterPageLink.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.AccountRegisterPageLink.Click += new System.EventHandler(this.AccountRegisterPageLink_Click);
            this.AccountRegisterPageLink.MouseHover += new System.EventHandler(this.AccountRegisterPageLink_MouseHover);
            // 
            // AccountResetPasswordPageLink
            // 
            this.AccountResetPasswordPageLink.AutoSize = true;
            this.AccountResetPasswordPageLink.BackColor = System.Drawing.Color.Transparent;
            this.AccountResetPasswordPageLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountResetPasswordPageLink.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountResetPasswordPageLink.ForeColor = System.Drawing.Color.SteelBlue;
            this.AccountResetPasswordPageLink.Location = new System.Drawing.Point(57, 190);
            this.AccountResetPasswordPageLink.Name = "AccountResetPasswordPageLink";
            this.AccountResetPasswordPageLink.Opacity = 0;
            this.AccountResetPasswordPageLink.OpacityColor = System.Drawing.Color.White;
            this.AccountResetPasswordPageLink.Size = new System.Drawing.Size(129, 19);
            this.AccountResetPasswordPageLink.TabIndex = 6;
            this.AccountResetPasswordPageLink.Text = "forgot Password";
            this.AccountResetPasswordPageLink.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.AccountResetPasswordPageLink.Click += new System.EventHandler(this.AccountResetPasswordPageLink_Click);
            this.AccountResetPasswordPageLink.MouseHover += new System.EventHandler(this.AccountResetPasswordPageLink_MouseHover);
            // 
            // ConfigureSystemSettings
            // 
            this.ConfigureSystemSettings.FlatAppearance.BorderSize = 0;
            this.ConfigureSystemSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigureSystemSettings.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ConfigureSystemSettings.IconColor = System.Drawing.Color.Silver;
            this.ConfigureSystemSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ConfigureSystemSettings.IconSize = 20;
            this.ConfigureSystemSettings.Location = new System.Drawing.Point(339, 234);
            this.ConfigureSystemSettings.Name = "ConfigureSystemSettings";
            this.ConfigureSystemSettings.Size = new System.Drawing.Size(40, 30);
            this.ConfigureSystemSettings.TabIndex = 14;
            this.ConfigureSystemSettings.UseVisualStyleBackColor = true;
            this.ConfigureSystemSettings.Click += new System.EventHandler(this.ConfigureSystemSettings_Click);
            // 
            // AccountLoginForm
            // 
            this.AcceptButton = this.AccountLoginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 333);
            this.ControlBox = false;
            this.Controls.Add(this.AccountLoginGroupBox);
            this.KeyPreview = true;
            this.Name = "AccountLoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountLogin";
            this.Load += new System.EventHandler(this.AccountLoginForm_Load);
            this.AccountLoginGroupBox.ResumeLayout(false);
            this.AccountLoginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CSharp.Winform.UI.GroupBox AccountLoginGroupBox;
        private Moonbyte.MaterialFramework.Controls.MaterialLabel Errorslbl;
        private Moonbyte.MaterialFramework.Controls.MaterialLabel AccountRegisterPageLink;
        private Moonbyte.MaterialFramework.Controls.MaterialLabel AccountResetPasswordPageLink;
        private MaterialSkin.Controls.MaterialTextBox AccountLoginPasswordtxt;
        private MaterialSkin.Controls.MaterialTextBox AccountLoginUsernametxt;
        private MaterialSkin.Controls.MaterialButton AccountLoginbtn;
        private MaterialSkin.Controls.MaterialButton ApplicationExitbtn;
        private FontAwesome.Sharp.IconButton ServerConfigbtn;
        private FontAwesome.Sharp.IconButton ConfigureSystemSettings;
    }
}