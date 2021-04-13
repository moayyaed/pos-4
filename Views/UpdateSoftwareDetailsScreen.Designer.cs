
namespace POS.Views
{
    partial class UpdateSoftwareDetailsScreen
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
            this.Container = new CSharp.Winform.UI.GroupBox();
            this.ManageDetailsContainer = new CSharp.Winform.UI.GroupBox();
            this.DeveloperDetailsContainer = new CSharp.Winform.UI.GroupBox();
            this.CustomerDetailsContainer = new CSharp.Winform.UI.GroupBox();
            this.EnableContainer = new CSharp.Winform.UI.GroupBox();
            this.ReceiptFooterNotetxt = new MaterialSkin.Controls.MaterialTextBox();
            this.BusinessTitletxt = new MaterialSkin.Controls.MaterialTextBox();
            this.CustomerNametxt = new MaterialSkin.Controls.MaterialTextBox();
            this.DeveloperEmailtxt = new MaterialSkin.Controls.MaterialTextBox();
            this.DeveloperContacttxt = new MaterialSkin.Controls.MaterialTextBox();
            this.DeveloperNametxt = new MaterialSkin.Controls.MaterialTextBox();
            this.UpdateDeveloperNamebtn = new MaterialSkin.Controls.MaterialButton();
            this.UpdateDeveloperPhonebtn = new MaterialSkin.Controls.MaterialButton();
            this.UpdateDeveloperEmailbtn = new MaterialSkin.Controls.MaterialButton();
            this.UpdateCustomerNamebtn = new MaterialSkin.Controls.MaterialButton();
            this.UpdateBusinessTitlebtn = new MaterialSkin.Controls.MaterialButton();
            this.UpdateReceiptfooterbtn = new MaterialSkin.Controls.MaterialButton();
            this.DeveloperPasscodetxt = new MaterialSkin.Controls.MaterialTextBox();
            this.DateofServicetxt = new MaterialSkin.Controls.MaterialTextBox();
            this.SoftwareVersiontxt = new MaterialSkin.Controls.MaterialTextBox();
            this.UpdateSoftwareVersionbtn = new MaterialSkin.Controls.MaterialButton();
            this.UpdateDateOfServicebtn = new MaterialSkin.Controls.MaterialButton();
            this.CleanDataBasebtn = new MaterialSkin.Controls.MaterialButton();
            this.ClosePagebtn = new MaterialSkin.Controls.MaterialButton();
            this.Container.SuspendLayout();
            this.ManageDetailsContainer.SuspendLayout();
            this.DeveloperDetailsContainer.SuspendLayout();
            this.CustomerDetailsContainer.SuspendLayout();
            this.EnableContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.Controls.Add(this.EnableContainer);
            this.Container.Controls.Add(this.ManageDetailsContainer);
            this.Container.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Container.Location = new System.Drawing.Point(6, 41);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(776, 433);
            this.Container.TabIndex = 0;
            this.Container.TabStop = false;
            // 
            // ManageDetailsContainer
            // 
            this.ManageDetailsContainer.Controls.Add(this.CleanDataBasebtn);
            this.ManageDetailsContainer.Controls.Add(this.UpdateDateOfServicebtn);
            this.ManageDetailsContainer.Controls.Add(this.UpdateSoftwareVersionbtn);
            this.ManageDetailsContainer.Controls.Add(this.DateofServicetxt);
            this.ManageDetailsContainer.Controls.Add(this.SoftwareVersiontxt);
            this.ManageDetailsContainer.Controls.Add(this.DeveloperDetailsContainer);
            this.ManageDetailsContainer.Controls.Add(this.CustomerDetailsContainer);
            this.ManageDetailsContainer.Enabled = false;
            this.ManageDetailsContainer.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ManageDetailsContainer.Location = new System.Drawing.Point(6, 108);
            this.ManageDetailsContainer.Name = "ManageDetailsContainer";
            this.ManageDetailsContainer.Size = new System.Drawing.Size(764, 319);
            this.ManageDetailsContainer.TabIndex = 0;
            this.ManageDetailsContainer.TabStop = false;
            this.ManageDetailsContainer.Text = "Manage Details";
            // 
            // DeveloperDetailsContainer
            // 
            this.DeveloperDetailsContainer.Controls.Add(this.UpdateDeveloperEmailbtn);
            this.DeveloperDetailsContainer.Controls.Add(this.UpdateDeveloperPhonebtn);
            this.DeveloperDetailsContainer.Controls.Add(this.UpdateDeveloperNamebtn);
            this.DeveloperDetailsContainer.Controls.Add(this.DeveloperEmailtxt);
            this.DeveloperDetailsContainer.Controls.Add(this.DeveloperContacttxt);
            this.DeveloperDetailsContainer.Controls.Add(this.DeveloperNametxt);
            this.DeveloperDetailsContainer.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.DeveloperDetailsContainer.Location = new System.Drawing.Point(397, 23);
            this.DeveloperDetailsContainer.Name = "DeveloperDetailsContainer";
            this.DeveloperDetailsContainer.Size = new System.Drawing.Size(355, 214);
            this.DeveloperDetailsContainer.TabIndex = 3;
            this.DeveloperDetailsContainer.TabStop = false;
            this.DeveloperDetailsContainer.Text = "Developer Details";
            // 
            // CustomerDetailsContainer
            // 
            this.CustomerDetailsContainer.Controls.Add(this.UpdateReceiptfooterbtn);
            this.CustomerDetailsContainer.Controls.Add(this.UpdateBusinessTitlebtn);
            this.CustomerDetailsContainer.Controls.Add(this.UpdateCustomerNamebtn);
            this.CustomerDetailsContainer.Controls.Add(this.ReceiptFooterNotetxt);
            this.CustomerDetailsContainer.Controls.Add(this.BusinessTitletxt);
            this.CustomerDetailsContainer.Controls.Add(this.CustomerNametxt);
            this.CustomerDetailsContainer.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.CustomerDetailsContainer.Location = new System.Drawing.Point(12, 23);
            this.CustomerDetailsContainer.Name = "CustomerDetailsContainer";
            this.CustomerDetailsContainer.Size = new System.Drawing.Size(379, 214);
            this.CustomerDetailsContainer.TabIndex = 2;
            this.CustomerDetailsContainer.TabStop = false;
            this.CustomerDetailsContainer.Text = "Customer Details";
            // 
            // EnableContainer
            // 
            this.EnableContainer.Controls.Add(this.DeveloperPasscodetxt);
            this.EnableContainer.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.EnableContainer.Location = new System.Drawing.Point(11, 20);
            this.EnableContainer.Name = "EnableContainer";
            this.EnableContainer.Size = new System.Drawing.Size(759, 82);
            this.EnableContainer.TabIndex = 1;
            this.EnableContainer.TabStop = false;
            this.EnableContainer.Text = "enter developer passcode to enable editing";
            // 
            // ReceiptFooterNotetxt
            // 
            this.ReceiptFooterNotetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReceiptFooterNotetxt.Depth = 0;
            this.ReceiptFooterNotetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ReceiptFooterNotetxt.Hint = "receipt footer note";
            this.ReceiptFooterNotetxt.Location = new System.Drawing.Point(16, 138);
            this.ReceiptFooterNotetxt.MaxLength = 50;
            this.ReceiptFooterNotetxt.MouseState = MaterialSkin.MouseState.OUT;
            this.ReceiptFooterNotetxt.Multiline = false;
            this.ReceiptFooterNotetxt.Name = "ReceiptFooterNotetxt";
            this.ReceiptFooterNotetxt.Size = new System.Drawing.Size(264, 50);
            this.ReceiptFooterNotetxt.TabIndex = 6;
            this.ReceiptFooterNotetxt.Text = "";
            // 
            // BusinessTitletxt
            // 
            this.BusinessTitletxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BusinessTitletxt.Depth = 0;
            this.BusinessTitletxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BusinessTitletxt.Hint = "business title";
            this.BusinessTitletxt.Location = new System.Drawing.Point(16, 82);
            this.BusinessTitletxt.MaxLength = 50;
            this.BusinessTitletxt.MouseState = MaterialSkin.MouseState.OUT;
            this.BusinessTitletxt.Multiline = false;
            this.BusinessTitletxt.Name = "BusinessTitletxt";
            this.BusinessTitletxt.Size = new System.Drawing.Size(264, 50);
            this.BusinessTitletxt.TabIndex = 5;
            this.BusinessTitletxt.Text = "";
            // 
            // CustomerNametxt
            // 
            this.CustomerNametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerNametxt.Depth = 0;
            this.CustomerNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CustomerNametxt.Hint = "customer name";
            this.CustomerNametxt.Location = new System.Drawing.Point(16, 26);
            this.CustomerNametxt.MaxLength = 50;
            this.CustomerNametxt.MouseState = MaterialSkin.MouseState.OUT;
            this.CustomerNametxt.Multiline = false;
            this.CustomerNametxt.Name = "CustomerNametxt";
            this.CustomerNametxt.Size = new System.Drawing.Size(264, 50);
            this.CustomerNametxt.TabIndex = 4;
            this.CustomerNametxt.Text = "";
            // 
            // DeveloperEmailtxt
            // 
            this.DeveloperEmailtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeveloperEmailtxt.Depth = 0;
            this.DeveloperEmailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeveloperEmailtxt.Hint = "email address";
            this.DeveloperEmailtxt.Location = new System.Drawing.Point(15, 138);
            this.DeveloperEmailtxt.MaxLength = 50;
            this.DeveloperEmailtxt.MouseState = MaterialSkin.MouseState.OUT;
            this.DeveloperEmailtxt.Multiline = false;
            this.DeveloperEmailtxt.Name = "DeveloperEmailtxt";
            this.DeveloperEmailtxt.Size = new System.Drawing.Size(250, 50);
            this.DeveloperEmailtxt.TabIndex = 9;
            this.DeveloperEmailtxt.Text = "";
            // 
            // DeveloperContacttxt
            // 
            this.DeveloperContacttxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeveloperContacttxt.Depth = 0;
            this.DeveloperContacttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeveloperContacttxt.Hint = "phone number";
            this.DeveloperContacttxt.Location = new System.Drawing.Point(15, 82);
            this.DeveloperContacttxt.MaxLength = 50;
            this.DeveloperContacttxt.MouseState = MaterialSkin.MouseState.OUT;
            this.DeveloperContacttxt.Multiline = false;
            this.DeveloperContacttxt.Name = "DeveloperContacttxt";
            this.DeveloperContacttxt.Size = new System.Drawing.Size(250, 50);
            this.DeveloperContacttxt.TabIndex = 8;
            this.DeveloperContacttxt.Text = "";
            // 
            // DeveloperNametxt
            // 
            this.DeveloperNametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeveloperNametxt.Depth = 0;
            this.DeveloperNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeveloperNametxt.Hint = "developed by:";
            this.DeveloperNametxt.Location = new System.Drawing.Point(15, 26);
            this.DeveloperNametxt.MaxLength = 50;
            this.DeveloperNametxt.MouseState = MaterialSkin.MouseState.OUT;
            this.DeveloperNametxt.Multiline = false;
            this.DeveloperNametxt.Name = "DeveloperNametxt";
            this.DeveloperNametxt.Size = new System.Drawing.Size(250, 50);
            this.DeveloperNametxt.TabIndex = 7;
            this.DeveloperNametxt.Text = "";
            // 
            // UpdateDeveloperNamebtn
            // 
            this.UpdateDeveloperNamebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateDeveloperNamebtn.Depth = 0;
            this.UpdateDeveloperNamebtn.DrawShadows = true;
            this.UpdateDeveloperNamebtn.HighEmphasis = false;
            this.UpdateDeveloperNamebtn.Icon = null;
            this.UpdateDeveloperNamebtn.Location = new System.Drawing.Point(272, 34);
            this.UpdateDeveloperNamebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateDeveloperNamebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateDeveloperNamebtn.Name = "UpdateDeveloperNamebtn";
            this.UpdateDeveloperNamebtn.Size = new System.Drawing.Size(58, 36);
            this.UpdateDeveloperNamebtn.TabIndex = 10;
            this.UpdateDeveloperNamebtn.Text = "save";
            this.UpdateDeveloperNamebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpdateDeveloperNamebtn.UseAccentColor = false;
            this.UpdateDeveloperNamebtn.UseVisualStyleBackColor = true;
            this.UpdateDeveloperNamebtn.Click += new System.EventHandler(this.UpdateDeveloperNamebtn_Click);
            // 
            // UpdateDeveloperPhonebtn
            // 
            this.UpdateDeveloperPhonebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateDeveloperPhonebtn.Depth = 0;
            this.UpdateDeveloperPhonebtn.DrawShadows = true;
            this.UpdateDeveloperPhonebtn.HighEmphasis = false;
            this.UpdateDeveloperPhonebtn.Icon = null;
            this.UpdateDeveloperPhonebtn.Location = new System.Drawing.Point(272, 85);
            this.UpdateDeveloperPhonebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateDeveloperPhonebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateDeveloperPhonebtn.Name = "UpdateDeveloperPhonebtn";
            this.UpdateDeveloperPhonebtn.Size = new System.Drawing.Size(58, 36);
            this.UpdateDeveloperPhonebtn.TabIndex = 11;
            this.UpdateDeveloperPhonebtn.Text = "save";
            this.UpdateDeveloperPhonebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpdateDeveloperPhonebtn.UseAccentColor = false;
            this.UpdateDeveloperPhonebtn.UseVisualStyleBackColor = true;
            this.UpdateDeveloperPhonebtn.Click += new System.EventHandler(this.UpdateDeveloperPhonebtn_Click);
            // 
            // UpdateDeveloperEmailbtn
            // 
            this.UpdateDeveloperEmailbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateDeveloperEmailbtn.Depth = 0;
            this.UpdateDeveloperEmailbtn.DrawShadows = true;
            this.UpdateDeveloperEmailbtn.HighEmphasis = false;
            this.UpdateDeveloperEmailbtn.Icon = null;
            this.UpdateDeveloperEmailbtn.Location = new System.Drawing.Point(272, 144);
            this.UpdateDeveloperEmailbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateDeveloperEmailbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateDeveloperEmailbtn.Name = "UpdateDeveloperEmailbtn";
            this.UpdateDeveloperEmailbtn.Size = new System.Drawing.Size(58, 36);
            this.UpdateDeveloperEmailbtn.TabIndex = 12;
            this.UpdateDeveloperEmailbtn.Text = "save";
            this.UpdateDeveloperEmailbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpdateDeveloperEmailbtn.UseAccentColor = false;
            this.UpdateDeveloperEmailbtn.UseVisualStyleBackColor = true;
            this.UpdateDeveloperEmailbtn.Click += new System.EventHandler(this.UpdateDeveloperEmailbtn_Click);
            // 
            // UpdateCustomerNamebtn
            // 
            this.UpdateCustomerNamebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateCustomerNamebtn.Depth = 0;
            this.UpdateCustomerNamebtn.DrawShadows = true;
            this.UpdateCustomerNamebtn.HighEmphasis = false;
            this.UpdateCustomerNamebtn.Icon = null;
            this.UpdateCustomerNamebtn.Location = new System.Drawing.Point(287, 32);
            this.UpdateCustomerNamebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateCustomerNamebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateCustomerNamebtn.Name = "UpdateCustomerNamebtn";
            this.UpdateCustomerNamebtn.Size = new System.Drawing.Size(58, 36);
            this.UpdateCustomerNamebtn.TabIndex = 7;
            this.UpdateCustomerNamebtn.Text = "save";
            this.UpdateCustomerNamebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpdateCustomerNamebtn.UseAccentColor = false;
            this.UpdateCustomerNamebtn.UseVisualStyleBackColor = true;
            this.UpdateCustomerNamebtn.Click += new System.EventHandler(this.UpdateCustomerNamebtn_Click);
            // 
            // UpdateBusinessTitlebtn
            // 
            this.UpdateBusinessTitlebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateBusinessTitlebtn.Depth = 0;
            this.UpdateBusinessTitlebtn.DrawShadows = true;
            this.UpdateBusinessTitlebtn.HighEmphasis = false;
            this.UpdateBusinessTitlebtn.Icon = null;
            this.UpdateBusinessTitlebtn.Location = new System.Drawing.Point(287, 85);
            this.UpdateBusinessTitlebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateBusinessTitlebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateBusinessTitlebtn.Name = "UpdateBusinessTitlebtn";
            this.UpdateBusinessTitlebtn.Size = new System.Drawing.Size(58, 36);
            this.UpdateBusinessTitlebtn.TabIndex = 8;
            this.UpdateBusinessTitlebtn.Text = "save";
            this.UpdateBusinessTitlebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpdateBusinessTitlebtn.UseAccentColor = false;
            this.UpdateBusinessTitlebtn.UseVisualStyleBackColor = true;
            this.UpdateBusinessTitlebtn.Click += new System.EventHandler(this.UpdateBusinessTitlebtn_Click);
            // 
            // UpdateReceiptfooterbtn
            // 
            this.UpdateReceiptfooterbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateReceiptfooterbtn.Depth = 0;
            this.UpdateReceiptfooterbtn.DrawShadows = true;
            this.UpdateReceiptfooterbtn.HighEmphasis = false;
            this.UpdateReceiptfooterbtn.Icon = null;
            this.UpdateReceiptfooterbtn.Location = new System.Drawing.Point(287, 144);
            this.UpdateReceiptfooterbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateReceiptfooterbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateReceiptfooterbtn.Name = "UpdateReceiptfooterbtn";
            this.UpdateReceiptfooterbtn.Size = new System.Drawing.Size(58, 36);
            this.UpdateReceiptfooterbtn.TabIndex = 9;
            this.UpdateReceiptfooterbtn.Text = "save";
            this.UpdateReceiptfooterbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpdateReceiptfooterbtn.UseAccentColor = false;
            this.UpdateReceiptfooterbtn.UseVisualStyleBackColor = true;
            this.UpdateReceiptfooterbtn.Click += new System.EventHandler(this.UpdateReceiptfooterbtn_Click);
            // 
            // DeveloperPasscodetxt
            // 
            this.DeveloperPasscodetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeveloperPasscodetxt.Depth = 0;
            this.DeveloperPasscodetxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.DeveloperPasscodetxt.Hint = "passcode";
            this.DeveloperPasscodetxt.Location = new System.Drawing.Point(7, 20);
            this.DeveloperPasscodetxt.MaxLength = 50;
            this.DeveloperPasscodetxt.MouseState = MaterialSkin.MouseState.OUT;
            this.DeveloperPasscodetxt.Multiline = false;
            this.DeveloperPasscodetxt.Name = "DeveloperPasscodetxt";
            this.DeveloperPasscodetxt.Password = true;
            this.DeveloperPasscodetxt.Size = new System.Drawing.Size(281, 50);
            this.DeveloperPasscodetxt.TabIndex = 0;
            this.DeveloperPasscodetxt.Text = "";
            this.DeveloperPasscodetxt.TextChanged += new System.EventHandler(this.DeveloperPasscodetxt_TextChanged);
            // 
            // DateofServicetxt
            // 
            this.DateofServicetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateofServicetxt.Depth = 0;
            this.DateofServicetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DateofServicetxt.Hint = "date of service:";
            this.DateofServicetxt.Location = new System.Drawing.Point(254, 243);
            this.DateofServicetxt.MaxLength = 50;
            this.DateofServicetxt.MouseState = MaterialSkin.MouseState.OUT;
            this.DateofServicetxt.Multiline = false;
            this.DateofServicetxt.Name = "DateofServicetxt";
            this.DateofServicetxt.Size = new System.Drawing.Size(153, 50);
            this.DateofServicetxt.TabIndex = 12;
            this.DateofServicetxt.Text = "";
            // 
            // SoftwareVersiontxt
            // 
            this.SoftwareVersiontxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SoftwareVersiontxt.Depth = 0;
            this.SoftwareVersiontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SoftwareVersiontxt.Hint = "software version:";
            this.SoftwareVersiontxt.Location = new System.Drawing.Point(9, 243);
            this.SoftwareVersiontxt.MaxLength = 50;
            this.SoftwareVersiontxt.MouseState = MaterialSkin.MouseState.OUT;
            this.SoftwareVersiontxt.Multiline = false;
            this.SoftwareVersiontxt.Name = "SoftwareVersiontxt";
            this.SoftwareVersiontxt.Size = new System.Drawing.Size(153, 50);
            this.SoftwareVersiontxt.TabIndex = 11;
            this.SoftwareVersiontxt.Text = "";
            // 
            // UpdateSoftwareVersionbtn
            // 
            this.UpdateSoftwareVersionbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateSoftwareVersionbtn.Depth = 0;
            this.UpdateSoftwareVersionbtn.DrawShadows = true;
            this.UpdateSoftwareVersionbtn.HighEmphasis = false;
            this.UpdateSoftwareVersionbtn.Icon = null;
            this.UpdateSoftwareVersionbtn.Location = new System.Drawing.Point(178, 251);
            this.UpdateSoftwareVersionbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateSoftwareVersionbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateSoftwareVersionbtn.Name = "UpdateSoftwareVersionbtn";
            this.UpdateSoftwareVersionbtn.Size = new System.Drawing.Size(58, 36);
            this.UpdateSoftwareVersionbtn.TabIndex = 10;
            this.UpdateSoftwareVersionbtn.Text = "save";
            this.UpdateSoftwareVersionbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpdateSoftwareVersionbtn.UseAccentColor = false;
            this.UpdateSoftwareVersionbtn.UseVisualStyleBackColor = true;
            this.UpdateSoftwareVersionbtn.Click += new System.EventHandler(this.UpdateSoftwareVersionbtn_Click);
            // 
            // UpdateDateOfServicebtn
            // 
            this.UpdateDateOfServicebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateDateOfServicebtn.Depth = 0;
            this.UpdateDateOfServicebtn.DrawShadows = true;
            this.UpdateDateOfServicebtn.HighEmphasis = false;
            this.UpdateDateOfServicebtn.Icon = null;
            this.UpdateDateOfServicebtn.Location = new System.Drawing.Point(423, 251);
            this.UpdateDateOfServicebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateDateOfServicebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateDateOfServicebtn.Name = "UpdateDateOfServicebtn";
            this.UpdateDateOfServicebtn.Size = new System.Drawing.Size(58, 36);
            this.UpdateDateOfServicebtn.TabIndex = 13;
            this.UpdateDateOfServicebtn.Text = "save";
            this.UpdateDateOfServicebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpdateDateOfServicebtn.UseAccentColor = false;
            this.UpdateDateOfServicebtn.UseVisualStyleBackColor = true;
            this.UpdateDateOfServicebtn.Click += new System.EventHandler(this.UpdateDateOfServicebtn_Click);
            // 
            // CleanDataBasebtn
            // 
            this.CleanDataBasebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CleanDataBasebtn.Depth = 0;
            this.CleanDataBasebtn.DrawShadows = true;
            this.CleanDataBasebtn.HighEmphasis = false;
            this.CleanDataBasebtn.Icon = null;
            this.CleanDataBasebtn.Location = new System.Drawing.Point(516, 251);
            this.CleanDataBasebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CleanDataBasebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CleanDataBasebtn.Name = "CleanDataBasebtn";
            this.CleanDataBasebtn.Size = new System.Drawing.Size(146, 36);
            this.CleanDataBasebtn.TabIndex = 14;
            this.CleanDataBasebtn.Text = "Clean Database";
            this.CleanDataBasebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CleanDataBasebtn.UseAccentColor = false;
            this.CleanDataBasebtn.UseVisualStyleBackColor = true;
            this.CleanDataBasebtn.Click += new System.EventHandler(this.CleanDataBasebtn_Click);
            // 
            // ClosePagebtn
            // 
            this.ClosePagebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClosePagebtn.Depth = 0;
            this.ClosePagebtn.DrawShadows = true;
            this.ClosePagebtn.HighEmphasis = false;
            this.ClosePagebtn.Icon = null;
            this.ClosePagebtn.Location = new System.Drawing.Point(698, 7);
            this.ClosePagebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClosePagebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClosePagebtn.Name = "ClosePagebtn";
            this.ClosePagebtn.Size = new System.Drawing.Size(66, 36);
            this.ClosePagebtn.TabIndex = 15;
            this.ClosePagebtn.Text = "Close";
            this.ClosePagebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ClosePagebtn.UseAccentColor = false;
            this.ClosePagebtn.UseVisualStyleBackColor = true;
            this.ClosePagebtn.Click += new System.EventHandler(this.ClosePagebtn_Click);
            // 
            // UpdateSoftwareDetailsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 482);
            this.ControlBox = false;
            this.Controls.Add(this.ClosePagebtn);
            this.Controls.Add(this.Container);
            this.Name = "UpdateSoftwareDetailsScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateSoftwareDetailsScreen";
            this.Container.ResumeLayout(false);
            this.ManageDetailsContainer.ResumeLayout(false);
            this.ManageDetailsContainer.PerformLayout();
            this.DeveloperDetailsContainer.ResumeLayout(false);
            this.DeveloperDetailsContainer.PerformLayout();
            this.CustomerDetailsContainer.ResumeLayout(false);
            this.CustomerDetailsContainer.PerformLayout();
            this.EnableContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CSharp.Winform.UI.GroupBox Container;
        private CSharp.Winform.UI.GroupBox EnableContainer;
        private CSharp.Winform.UI.GroupBox ManageDetailsContainer;
        private CSharp.Winform.UI.GroupBox DeveloperDetailsContainer;
        private CSharp.Winform.UI.GroupBox CustomerDetailsContainer;
        private MaterialSkin.Controls.MaterialTextBox ReceiptFooterNotetxt;
        private MaterialSkin.Controls.MaterialTextBox BusinessTitletxt;
        private MaterialSkin.Controls.MaterialTextBox CustomerNametxt;
        private MaterialSkin.Controls.MaterialTextBox DeveloperEmailtxt;
        private MaterialSkin.Controls.MaterialTextBox DeveloperContacttxt;
        private MaterialSkin.Controls.MaterialTextBox DeveloperNametxt;
        private MaterialSkin.Controls.MaterialTextBox DeveloperPasscodetxt;
        private MaterialSkin.Controls.MaterialButton UpdateDeveloperEmailbtn;
        private MaterialSkin.Controls.MaterialButton UpdateDeveloperPhonebtn;
        private MaterialSkin.Controls.MaterialButton UpdateDeveloperNamebtn;
        private MaterialSkin.Controls.MaterialButton UpdateReceiptfooterbtn;
        private MaterialSkin.Controls.MaterialButton UpdateBusinessTitlebtn;
        private MaterialSkin.Controls.MaterialButton UpdateCustomerNamebtn;
        private MaterialSkin.Controls.MaterialButton ClosePagebtn;
        private MaterialSkin.Controls.MaterialButton CleanDataBasebtn;
        private MaterialSkin.Controls.MaterialButton UpdateDateOfServicebtn;
        private MaterialSkin.Controls.MaterialButton UpdateSoftwareVersionbtn;
        private MaterialSkin.Controls.MaterialTextBox DateofServicetxt;
        private MaterialSkin.Controls.MaterialTextBox SoftwareVersiontxt;
    }
}