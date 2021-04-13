
namespace POS.Views
{
    partial class UserDashboard
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
            this.DashboardGroup = new CSharp.Winform.UI.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Usernametxt = new MaterialSkin.Controls.MaterialTextBox();
            this.Phonenumbertxt = new MaterialSkin.Controls.MaterialTextBox();
            this.UpdateBtn = new MaterialSkin.Controls.MaterialButton();
            this.BackHomebtn = new MaterialSkin.Controls.MaterialButton();
            this.EditUsernamecbk = new MaterialSkin.Controls.MaterialCheckbox();
            this.EditPhonecbk = new MaterialSkin.Controls.MaterialCheckbox();
            this.AccountStatustxt = new MaterialSkin.Controls.MaterialTextBox();
            this.AccountRoletxt = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1 = new CSharp.Winform.UI.GroupBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.AccountIdlbl = new CSharp.Winform.UI.Label();
            this.DashboardGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DashboardGroup
            // 
            this.DashboardGroup.Controls.Add(this.AccountIdlbl);
            this.DashboardGroup.Controls.Add(this.groupBox1);
            this.DashboardGroup.Controls.Add(this.AccountRoletxt);
            this.DashboardGroup.Controls.Add(this.AccountStatustxt);
            this.DashboardGroup.Controls.Add(this.EditPhonecbk);
            this.DashboardGroup.Controls.Add(this.EditUsernamecbk);
            this.DashboardGroup.Controls.Add(this.BackHomebtn);
            this.DashboardGroup.Controls.Add(this.UpdateBtn);
            this.DashboardGroup.Controls.Add(this.Phonenumbertxt);
            this.DashboardGroup.Controls.Add(this.Usernametxt);
            this.DashboardGroup.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.DashboardGroup.Location = new System.Drawing.Point(29, 71);
            this.DashboardGroup.Name = "DashboardGroup";
            this.DashboardGroup.Size = new System.Drawing.Size(603, 289);
            this.DashboardGroup.TabIndex = 0;
            this.DashboardGroup.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel1.Location = new System.Drawing.Point(245, 37);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(130, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "NBS DASHBOARD";
            // 
            // Usernametxt
            // 
            this.Usernametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usernametxt.Depth = 0;
            this.Usernametxt.Enabled = false;
            this.Usernametxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.Usernametxt.Hint = "Account Username";
            this.Usernametxt.Location = new System.Drawing.Point(164, 43);
            this.Usernametxt.MaxLength = 50;
            this.Usernametxt.MouseState = MaterialSkin.MouseState.OUT;
            this.Usernametxt.Multiline = false;
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(242, 50);
            this.Usernametxt.TabIndex = 0;
            this.Usernametxt.Text = "";
            this.Usernametxt.TextChanged += new System.EventHandler(this.Usernametxt_TextChanged);
            // 
            // Phonenumbertxt
            // 
            this.Phonenumbertxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Phonenumbertxt.Depth = 0;
            this.Phonenumbertxt.Enabled = false;
            this.Phonenumbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Phonenumbertxt.Hint = "Account Phone Number";
            this.Phonenumbertxt.Location = new System.Drawing.Point(164, 96);
            this.Phonenumbertxt.MaxLength = 50;
            this.Phonenumbertxt.MouseState = MaterialSkin.MouseState.OUT;
            this.Phonenumbertxt.Multiline = false;
            this.Phonenumbertxt.Name = "Phonenumbertxt";
            this.Phonenumbertxt.Size = new System.Drawing.Size(242, 50);
            this.Phonenumbertxt.TabIndex = 1;
            this.Phonenumbertxt.Text = "";
            this.Phonenumbertxt.TextChanged += new System.EventHandler(this.Phonenumbertxt_TextChanged);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateBtn.Depth = 0;
            this.UpdateBtn.DrawShadows = true;
            this.UpdateBtn.Enabled = false;
            this.UpdateBtn.HighEmphasis = true;
            this.UpdateBtn.Icon = null;
            this.UpdateBtn.Location = new System.Drawing.Point(63, 234);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(146, 36);
            this.UpdateBtn.TabIndex = 2;
            this.UpdateBtn.Text = "Submit Changes";
            this.UpdateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpdateBtn.UseAccentColor = false;
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // BackHomebtn
            // 
            this.BackHomebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackHomebtn.Depth = 0;
            this.BackHomebtn.DrawShadows = true;
            this.BackHomebtn.HighEmphasis = false;
            this.BackHomebtn.Icon = null;
            this.BackHomebtn.Location = new System.Drawing.Point(241, 234);
            this.BackHomebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BackHomebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.BackHomebtn.Name = "BackHomebtn";
            this.BackHomebtn.Size = new System.Drawing.Size(105, 36);
            this.BackHomebtn.TabIndex = 3;
            this.BackHomebtn.Text = "Back Home";
            this.BackHomebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BackHomebtn.UseAccentColor = false;
            this.BackHomebtn.UseVisualStyleBackColor = true;
            this.BackHomebtn.Click += new System.EventHandler(this.BackHomebtn_Click);
            // 
            // EditUsernamecbk
            // 
            this.EditUsernamecbk.AutoSize = true;
            this.EditUsernamecbk.Depth = 0;
            this.EditUsernamecbk.Location = new System.Drawing.Point(409, 52);
            this.EditUsernamecbk.Margin = new System.Windows.Forms.Padding(0);
            this.EditUsernamecbk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.EditUsernamecbk.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditUsernamecbk.Name = "EditUsernamecbk";
            this.EditUsernamecbk.Ripple = true;
            this.EditUsernamecbk.Size = new System.Drawing.Size(137, 37);
            this.EditUsernamecbk.TabIndex = 4;
            this.EditUsernamecbk.Text = "Edit Username";
            this.EditUsernamecbk.UseVisualStyleBackColor = true;
            this.EditUsernamecbk.CheckedChanged += new System.EventHandler(this.EditUsernamecbk_CheckedChanged);
            // 
            // EditPhonecbk
            // 
            this.EditPhonecbk.AutoSize = true;
            this.EditPhonecbk.Depth = 0;
            this.EditPhonecbk.Location = new System.Drawing.Point(409, 109);
            this.EditPhonecbk.Margin = new System.Windows.Forms.Padding(0);
            this.EditPhonecbk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.EditPhonecbk.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditPhonecbk.Name = "EditPhonecbk";
            this.EditPhonecbk.Ripple = true;
            this.EditPhonecbk.Size = new System.Drawing.Size(165, 37);
            this.EditPhonecbk.TabIndex = 5;
            this.EditPhonecbk.Text = "Edit Phonenumber";
            this.EditPhonecbk.UseVisualStyleBackColor = true;
            this.EditPhonecbk.CheckedChanged += new System.EventHandler(this.EditPhonecbk_CheckedChanged);
            // 
            // AccountStatustxt
            // 
            this.AccountStatustxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountStatustxt.Depth = 0;
            this.AccountStatustxt.Enabled = false;
            this.AccountStatustxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AccountStatustxt.Hint = "Account Status";
            this.AccountStatustxt.Location = new System.Drawing.Point(164, 158);
            this.AccountStatustxt.MaxLength = 50;
            this.AccountStatustxt.MouseState = MaterialSkin.MouseState.OUT;
            this.AccountStatustxt.Multiline = false;
            this.AccountStatustxt.Name = "AccountStatustxt";
            this.AccountStatustxt.Size = new System.Drawing.Size(227, 50);
            this.AccountStatustxt.TabIndex = 6;
            this.AccountStatustxt.Text = "";
            // 
            // AccountRoletxt
            // 
            this.AccountRoletxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountRoletxt.Depth = 0;
            this.AccountRoletxt.Enabled = false;
            this.AccountRoletxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AccountRoletxt.Hint = "Account Role";
            this.AccountRoletxt.Location = new System.Drawing.Point(397, 158);
            this.AccountRoletxt.MaxLength = 50;
            this.AccountRoletxt.MouseState = MaterialSkin.MouseState.OUT;
            this.AccountRoletxt.Multiline = false;
            this.AccountRoletxt.Name = "AccountRoletxt";
            this.AccountRoletxt.Size = new System.Drawing.Size(188, 50);
            this.AccountRoletxt.TabIndex = 7;
            this.AccountRoletxt.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconPictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(9, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 165);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 137;
            this.iconPictureBox1.Location = new System.Drawing.Point(6, 13);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(137, 145);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 9;
            this.iconPictureBox1.TabStop = false;
            // 
            // AccountIdlbl
            // 
            this.AccountIdlbl.AutoSize = true;
            this.AccountIdlbl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.AccountIdlbl.Location = new System.Drawing.Point(371, 246);
            this.AccountIdlbl.Name = "AccountIdlbl";
            this.AccountIdlbl.Size = new System.Drawing.Size(53, 13);
            this.AccountIdlbl.TabIndex = 9;
            this.AccountIdlbl.Text = "accountid";
            this.AccountIdlbl.Visible = false;
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 380);
            this.ControlBox = false;
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.DashboardGroup);
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDashboard";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.DashboardGroup.ResumeLayout(false);
            this.DashboardGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CSharp.Winform.UI.GroupBox DashboardGroup;
        private MaterialSkin.Controls.MaterialTextBox AccountRoletxt;
        private MaterialSkin.Controls.MaterialTextBox AccountStatustxt;
        private MaterialSkin.Controls.MaterialCheckbox EditPhonecbk;
        private MaterialSkin.Controls.MaterialCheckbox EditUsernamecbk;
        private MaterialSkin.Controls.MaterialButton BackHomebtn;
        private MaterialSkin.Controls.MaterialButton UpdateBtn;
        private MaterialSkin.Controls.MaterialTextBox Phonenumbertxt;
        private MaterialSkin.Controls.MaterialTextBox Usernametxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private CSharp.Winform.UI.GroupBox groupBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private CSharp.Winform.UI.Label AccountIdlbl;
    }
}