
namespace POS.Views
{
    partial class ResetPasswordForm
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
            this.UpdatePasswordGroup = new CSharp.Winform.UI.GroupBox();
            this.SaveChangesbtn = new MaterialSkin.Controls.MaterialButton();
            this.ClosePagebtn = new MaterialSkin.Controls.MaterialButton();
            this.NewPasswordtxt = new MaterialSkin.Controls.MaterialTextBox();
            this.PhoneOrUsernametxt = new MaterialSkin.Controls.MaterialTextBox();
            this.UpdatePasswordGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdatePasswordGroup
            // 
            this.UpdatePasswordGroup.Controls.Add(this.SaveChangesbtn);
            this.UpdatePasswordGroup.Controls.Add(this.ClosePagebtn);
            this.UpdatePasswordGroup.Controls.Add(this.NewPasswordtxt);
            this.UpdatePasswordGroup.Controls.Add(this.PhoneOrUsernametxt);
            this.UpdatePasswordGroup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePasswordGroup.Location = new System.Drawing.Point(21, 39);
            this.UpdatePasswordGroup.Name = "UpdatePasswordGroup";
            this.UpdatePasswordGroup.Size = new System.Drawing.Size(455, 226);
            this.UpdatePasswordGroup.TabIndex = 0;
            this.UpdatePasswordGroup.TabStop = false;
            this.UpdatePasswordGroup.Text = "Change Password";
            // 
            // SaveChangesbtn
            // 
            this.SaveChangesbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveChangesbtn.Depth = 0;
            this.SaveChangesbtn.DrawShadows = true;
            this.SaveChangesbtn.HighEmphasis = true;
            this.SaveChangesbtn.Icon = null;
            this.SaveChangesbtn.Location = new System.Drawing.Point(31, 156);
            this.SaveChangesbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveChangesbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveChangesbtn.Name = "SaveChangesbtn";
            this.SaveChangesbtn.Size = new System.Drawing.Size(75, 36);
            this.SaveChangesbtn.TabIndex = 3;
            this.SaveChangesbtn.Text = "Submit";
            this.SaveChangesbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveChangesbtn.UseAccentColor = false;
            this.SaveChangesbtn.UseVisualStyleBackColor = true;
            this.SaveChangesbtn.Click += new System.EventHandler(this.SaveChangesbtn_Click);
            // 
            // ClosePagebtn
            // 
            this.ClosePagebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClosePagebtn.Depth = 0;
            this.ClosePagebtn.DrawShadows = true;
            this.ClosePagebtn.HighEmphasis = false;
            this.ClosePagebtn.Icon = null;
            this.ClosePagebtn.Location = new System.Drawing.Point(114, 156);
            this.ClosePagebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClosePagebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClosePagebtn.Name = "ClosePagebtn";
            this.ClosePagebtn.Size = new System.Drawing.Size(64, 36);
            this.ClosePagebtn.TabIndex = 2;
            this.ClosePagebtn.Text = "login";
            this.ClosePagebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ClosePagebtn.UseAccentColor = false;
            this.ClosePagebtn.UseVisualStyleBackColor = true;
            this.ClosePagebtn.Click += new System.EventHandler(this.ClosePagebtn_Click);
            // 
            // NewPasswordtxt
            // 
            this.NewPasswordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPasswordtxt.Depth = 0;
            this.NewPasswordtxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.NewPasswordtxt.Hint = "New Password";
            this.NewPasswordtxt.Location = new System.Drawing.Point(31, 97);
            this.NewPasswordtxt.MaxLength = 50;
            this.NewPasswordtxt.MouseState = MaterialSkin.MouseState.OUT;
            this.NewPasswordtxt.Multiline = false;
            this.NewPasswordtxt.Name = "NewPasswordtxt";
            this.NewPasswordtxt.Password = true;
            this.NewPasswordtxt.Size = new System.Drawing.Size(387, 50);
            this.NewPasswordtxt.TabIndex = 1;
            this.NewPasswordtxt.Text = "";
            // 
            // PhoneOrUsernametxt
            // 
            this.PhoneOrUsernametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneOrUsernametxt.Depth = 0;
            this.PhoneOrUsernametxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.PhoneOrUsernametxt.Hint = "Username or Phone";
            this.PhoneOrUsernametxt.Location = new System.Drawing.Point(31, 37);
            this.PhoneOrUsernametxt.MaxLength = 50;
            this.PhoneOrUsernametxt.MouseState = MaterialSkin.MouseState.OUT;
            this.PhoneOrUsernametxt.Multiline = false;
            this.PhoneOrUsernametxt.Name = "PhoneOrUsernametxt";
            this.PhoneOrUsernametxt.Size = new System.Drawing.Size(387, 50);
            this.PhoneOrUsernametxt.TabIndex = 0;
            this.PhoneOrUsernametxt.Text = "";
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 285);
            this.ControlBox = false;
            this.Controls.Add(this.UpdatePasswordGroup);
            this.Name = "ResetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPasswordForm";
            this.UpdatePasswordGroup.ResumeLayout(false);
            this.UpdatePasswordGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CSharp.Winform.UI.GroupBox UpdatePasswordGroup;
        private MaterialSkin.Controls.MaterialTextBox PhoneOrUsernametxt;
        private MaterialSkin.Controls.MaterialTextBox NewPasswordtxt;
        private MaterialSkin.Controls.MaterialButton SaveChangesbtn;
        private MaterialSkin.Controls.MaterialButton ClosePagebtn;
    }
}