
namespace POS.Views
{
    partial class AdminDashBoardForm
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
            this.groupBox1 = new CSharp.Winform.UI.GroupBox();
            this.UsersDataPanel = new CSharp.Winform.UI.Panel();
            this.UsersDataGrid = new CSharp.Winform.UI.DataGridView();
            this.ManageAccountsGroup = new CSharp.Winform.UI.GroupBox();
            this.AllUserscbx = new MaterialSkin.Controls.MaterialComboBox();
            this.SaveAccountChangesbtn = new MaterialSkin.Controls.MaterialButton();
            this.Back2Homebtn = new MaterialSkin.Controls.MaterialButton();
            this.AccountStatuscbx = new MaterialSkin.Controls.MaterialComboBox();
            this.AccountRolecbsx = new MaterialSkin.Controls.MaterialComboBox();
            this.SelectedAccountlbl = new MaterialSkin.Controls.MaterialLabel();
            this.DeleteAccountbtn = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.UsersDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).BeginInit();
            this.ManageAccountsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ManageAccountsGroup);
            this.groupBox1.Controls.Add(this.UsersDataPanel);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registered Users";
            // 
            // UsersDataPanel
            // 
            this.UsersDataPanel.Controls.Add(this.UsersDataGrid);
            this.UsersDataPanel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.UsersDataPanel.Location = new System.Drawing.Point(6, 29);
            this.UsersDataPanel.Name = "UsersDataPanel";
            this.UsersDataPanel.Size = new System.Drawing.Size(496, 301);
            this.UsersDataPanel.TabIndex = 0;
            // 
            // UsersDataGrid
            // 
            this.UsersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersDataGrid.Location = new System.Drawing.Point(0, 0);
            this.UsersDataGrid.Name = "UsersDataGrid";
            this.UsersDataGrid.ReadOnly = true;
            this.UsersDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.UsersDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UsersDataGrid.Size = new System.Drawing.Size(496, 301);
            this.UsersDataGrid.TabIndex = 1;
            // 
            // ManageAccountsGroup
            // 
            this.ManageAccountsGroup.Controls.Add(this.DeleteAccountbtn);
            this.ManageAccountsGroup.Controls.Add(this.SelectedAccountlbl);
            this.ManageAccountsGroup.Controls.Add(this.AccountRolecbsx);
            this.ManageAccountsGroup.Controls.Add(this.AccountStatuscbx);
            this.ManageAccountsGroup.Controls.Add(this.Back2Homebtn);
            this.ManageAccountsGroup.Controls.Add(this.SaveAccountChangesbtn);
            this.ManageAccountsGroup.Controls.Add(this.AllUserscbx);
            this.ManageAccountsGroup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageAccountsGroup.Location = new System.Drawing.Point(508, 29);
            this.ManageAccountsGroup.Name = "ManageAccountsGroup";
            this.ManageAccountsGroup.Size = new System.Drawing.Size(242, 301);
            this.ManageAccountsGroup.TabIndex = 1;
            this.ManageAccountsGroup.TabStop = false;
            this.ManageAccountsGroup.Text = "Manage Accounts";
            // 
            // AllUserscbx
            // 
            this.AllUserscbx.AutoResize = false;
            this.AllUserscbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AllUserscbx.Depth = 0;
            this.AllUserscbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AllUserscbx.DropDownHeight = 174;
            this.AllUserscbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AllUserscbx.DropDownWidth = 121;
            this.AllUserscbx.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AllUserscbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AllUserscbx.FormattingEnabled = true;
            this.AllUserscbx.Hint = "Registered Users";
            this.AllUserscbx.IntegralHeight = false;
            this.AllUserscbx.ItemHeight = 43;
            this.AllUserscbx.Location = new System.Drawing.Point(11, 43);
            this.AllUserscbx.MaxDropDownItems = 4;
            this.AllUserscbx.MouseState = MaterialSkin.MouseState.OUT;
            this.AllUserscbx.Name = "AllUserscbx";
            this.AllUserscbx.Size = new System.Drawing.Size(219, 49);
            this.AllUserscbx.StartIndex = 0;
            this.AllUserscbx.TabIndex = 0;
            this.AllUserscbx.SelectedIndexChanged += new System.EventHandler(this.AllUserscbx_SelectedIndexChanged);
            // 
            // SaveAccountChangesbtn
            // 
            this.SaveAccountChangesbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveAccountChangesbtn.Depth = 0;
            this.SaveAccountChangesbtn.DrawShadows = true;
            this.SaveAccountChangesbtn.HighEmphasis = true;
            this.SaveAccountChangesbtn.Icon = null;
            this.SaveAccountChangesbtn.Location = new System.Drawing.Point(9, 256);
            this.SaveAccountChangesbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveAccountChangesbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveAccountChangesbtn.Name = "SaveAccountChangesbtn";
            this.SaveAccountChangesbtn.Size = new System.Drawing.Size(77, 36);
            this.SaveAccountChangesbtn.TabIndex = 3;
            this.SaveAccountChangesbtn.Text = "Update";
            this.SaveAccountChangesbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveAccountChangesbtn.UseAccentColor = false;
            this.SaveAccountChangesbtn.UseVisualStyleBackColor = true;
            this.SaveAccountChangesbtn.Click += new System.EventHandler(this.SaveAccountChangesbtn_Click);
            // 
            // Back2Homebtn
            // 
            this.Back2Homebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Back2Homebtn.Depth = 0;
            this.Back2Homebtn.DrawShadows = true;
            this.Back2Homebtn.HighEmphasis = false;
            this.Back2Homebtn.Icon = null;
            this.Back2Homebtn.Location = new System.Drawing.Point(94, 256);
            this.Back2Homebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Back2Homebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Back2Homebtn.Name = "Back2Homebtn";
            this.Back2Homebtn.Size = new System.Drawing.Size(63, 36);
            this.Back2Homebtn.TabIndex = 4;
            this.Back2Homebtn.Text = "Home";
            this.Back2Homebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Back2Homebtn.UseAccentColor = false;
            this.Back2Homebtn.UseVisualStyleBackColor = true;
            this.Back2Homebtn.Click += new System.EventHandler(this.Back2Homebtn_Click);
            // 
            // AccountStatuscbx
            // 
            this.AccountStatuscbx.AutoResize = false;
            this.AccountStatuscbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AccountStatuscbx.Depth = 0;
            this.AccountStatuscbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AccountStatuscbx.DropDownHeight = 174;
            this.AccountStatuscbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountStatuscbx.DropDownWidth = 121;
            this.AccountStatuscbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AccountStatuscbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AccountStatuscbx.FormattingEnabled = true;
            this.AccountStatuscbx.Hint = "Account Status";
            this.AccountStatuscbx.IntegralHeight = false;
            this.AccountStatuscbx.ItemHeight = 43;
            this.AccountStatuscbx.Location = new System.Drawing.Point(11, 98);
            this.AccountStatuscbx.MaxDropDownItems = 4;
            this.AccountStatuscbx.MouseState = MaterialSkin.MouseState.OUT;
            this.AccountStatuscbx.Name = "AccountStatuscbx";
            this.AccountStatuscbx.Size = new System.Drawing.Size(219, 49);
            this.AccountStatuscbx.StartIndex = 0;
            this.AccountStatuscbx.TabIndex = 5;
            // 
            // AccountRolecbsx
            // 
            this.AccountRolecbsx.AutoResize = false;
            this.AccountRolecbsx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AccountRolecbsx.Depth = 0;
            this.AccountRolecbsx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AccountRolecbsx.DropDownHeight = 174;
            this.AccountRolecbsx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountRolecbsx.DropDownWidth = 121;
            this.AccountRolecbsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AccountRolecbsx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AccountRolecbsx.FormattingEnabled = true;
            this.AccountRolecbsx.Hint = "Account Role";
            this.AccountRolecbsx.IntegralHeight = false;
            this.AccountRolecbsx.ItemHeight = 43;
            this.AccountRolecbsx.Location = new System.Drawing.Point(11, 153);
            this.AccountRolecbsx.MaxDropDownItems = 4;
            this.AccountRolecbsx.MouseState = MaterialSkin.MouseState.OUT;
            this.AccountRolecbsx.Name = "AccountRolecbsx";
            this.AccountRolecbsx.Size = new System.Drawing.Size(219, 49);
            this.AccountRolecbsx.StartIndex = 0;
            this.AccountRolecbsx.TabIndex = 6;
            // 
            // SelectedAccountlbl
            // 
            this.SelectedAccountlbl.AutoSize = true;
            this.SelectedAccountlbl.Depth = 0;
            this.SelectedAccountlbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SelectedAccountlbl.Location = new System.Drawing.Point(12, 205);
            this.SelectedAccountlbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SelectedAccountlbl.Name = "SelectedAccountlbl";
            this.SelectedAccountlbl.Size = new System.Drawing.Size(10, 19);
            this.SelectedAccountlbl.TabIndex = 7;
            this.SelectedAccountlbl.Text = "0";
            this.SelectedAccountlbl.Visible = false;
            // 
            // DeleteAccountbtn
            // 
            this.DeleteAccountbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteAccountbtn.Depth = 0;
            this.DeleteAccountbtn.DrawShadows = true;
            this.DeleteAccountbtn.HighEmphasis = false;
            this.DeleteAccountbtn.Icon = null;
            this.DeleteAccountbtn.Location = new System.Drawing.Point(167, 256);
            this.DeleteAccountbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteAccountbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteAccountbtn.Name = "DeleteAccountbtn";
            this.DeleteAccountbtn.Size = new System.Drawing.Size(63, 36);
            this.DeleteAccountbtn.TabIndex = 8;
            this.DeleteAccountbtn.Text = "Delete";
            this.DeleteAccountbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteAccountbtn.UseAccentColor = false;
            this.DeleteAccountbtn.UseVisualStyleBackColor = true;
            this.DeleteAccountbtn.Click += new System.EventHandler(this.DeleteAccountbtn_Click);
            // 
            // AdminDashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminDashBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashBoardForm";
            this.Load += new System.EventHandler(this.AdminDashBoardForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.UsersDataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).EndInit();
            this.ManageAccountsGroup.ResumeLayout(false);
            this.ManageAccountsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CSharp.Winform.UI.GroupBox groupBox1;
        private CSharp.Winform.UI.GroupBox ManageAccountsGroup;
        private MaterialSkin.Controls.MaterialComboBox AccountRolecbsx;
        private MaterialSkin.Controls.MaterialComboBox AccountStatuscbx;
        private MaterialSkin.Controls.MaterialButton Back2Homebtn;
        private MaterialSkin.Controls.MaterialButton SaveAccountChangesbtn;
        private MaterialSkin.Controls.MaterialComboBox AllUserscbx;
        private CSharp.Winform.UI.Panel UsersDataPanel;
        private CSharp.Winform.UI.DataGridView UsersDataGrid;
        private MaterialSkin.Controls.MaterialLabel SelectedAccountlbl;
        private MaterialSkin.Controls.MaterialButton DeleteAccountbtn;
    }
}