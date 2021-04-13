
namespace POS.Views
{
    partial class SettingsScreen
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
            this.Productwrapper = new CSharp.Winform.UI.GroupBox();
            this.DateofServicetxt = new MaterialSkin.Controls.MaterialTextBox();
            this.ServiceStatustxt = new MaterialSkin.Controls.MaterialTextBox();
            this.ProductStatustxt = new MaterialSkin.Controls.MaterialTextBox();
            this.SoftwareVersiontxt = new MaterialSkin.Controls.MaterialTextBox();
            this.Developerwrapper = new CSharp.Winform.UI.GroupBox();
            this.DeveloperEmailtxt = new MaterialSkin.Controls.MaterialTextBox();
            this.DeveloperContacttxt = new MaterialSkin.Controls.MaterialTextBox();
            this.DeveloperNametxt = new MaterialSkin.Controls.MaterialTextBox();
            this.Customerwrapper = new CSharp.Winform.UI.GroupBox();
            this.ReceiptFooterNotetxt = new MaterialSkin.Controls.MaterialTextBox();
            this.BusinessTitletxt = new MaterialSkin.Controls.MaterialTextBox();
            this.CustomerNametxt = new MaterialSkin.Controls.MaterialTextBox();
            this.ClosePagebtn = new MaterialSkin.Controls.MaterialButton();
            this.Container.SuspendLayout();
            this.Productwrapper.SuspendLayout();
            this.Developerwrapper.SuspendLayout();
            this.Customerwrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.Controls.Add(this.ClosePagebtn);
            this.Container.Controls.Add(this.Productwrapper);
            this.Container.Controls.Add(this.Developerwrapper);
            this.Container.Controls.Add(this.Customerwrapper);
            this.Container.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Container.Location = new System.Drawing.Point(21, 45);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(744, 384);
            this.Container.TabIndex = 0;
            this.Container.TabStop = false;
            // 
            // Productwrapper
            // 
            this.Productwrapper.Controls.Add(this.DateofServicetxt);
            this.Productwrapper.Controls.Add(this.ServiceStatustxt);
            this.Productwrapper.Controls.Add(this.ProductStatustxt);
            this.Productwrapper.Controls.Add(this.SoftwareVersiontxt);
            this.Productwrapper.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Productwrapper.Location = new System.Drawing.Point(16, 252);
            this.Productwrapper.Name = "Productwrapper";
            this.Productwrapper.Size = new System.Drawing.Size(710, 81);
            this.Productwrapper.TabIndex = 3;
            this.Productwrapper.TabStop = false;
            this.Productwrapper.Text = "Product Information";
            // 
            // DateofServicetxt
            // 
            this.DateofServicetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateofServicetxt.Depth = 0;
            this.DateofServicetxt.Enabled = false;
            this.DateofServicetxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.DateofServicetxt.Hint = "date of service:";
            this.DateofServicetxt.Location = new System.Drawing.Point(515, 22);
            this.DateofServicetxt.MaxLength = 50;
            this.DateofServicetxt.MouseState = MaterialSkin.MouseState.OUT;
            this.DateofServicetxt.Multiline = false;
            this.DateofServicetxt.Name = "DateofServicetxt";
            this.DateofServicetxt.Size = new System.Drawing.Size(153, 50);
            this.DateofServicetxt.TabIndex = 10;
            this.DateofServicetxt.Text = "";
            // 
            // ServiceStatustxt
            // 
            this.ServiceStatustxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServiceStatustxt.Depth = 0;
            this.ServiceStatustxt.Enabled = false;
            this.ServiceStatustxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.ServiceStatustxt.Hint = "service status:";
            this.ServiceStatustxt.Location = new System.Drawing.Point(356, 22);
            this.ServiceStatustxt.MaxLength = 50;
            this.ServiceStatustxt.MouseState = MaterialSkin.MouseState.OUT;
            this.ServiceStatustxt.Multiline = false;
            this.ServiceStatustxt.Name = "ServiceStatustxt";
            this.ServiceStatustxt.Size = new System.Drawing.Size(153, 50);
            this.ServiceStatustxt.TabIndex = 9;
            this.ServiceStatustxt.Text = "";
            // 
            // ProductStatustxt
            // 
            this.ProductStatustxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductStatustxt.Depth = 0;
            this.ProductStatustxt.Enabled = false;
            this.ProductStatustxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.ProductStatustxt.Hint = "license status:";
            this.ProductStatustxt.Location = new System.Drawing.Point(197, 22);
            this.ProductStatustxt.MaxLength = 50;
            this.ProductStatustxt.MouseState = MaterialSkin.MouseState.OUT;
            this.ProductStatustxt.Multiline = false;
            this.ProductStatustxt.Name = "ProductStatustxt";
            this.ProductStatustxt.Size = new System.Drawing.Size(153, 50);
            this.ProductStatustxt.TabIndex = 8;
            this.ProductStatustxt.Text = "";
            // 
            // SoftwareVersiontxt
            // 
            this.SoftwareVersiontxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SoftwareVersiontxt.Depth = 0;
            this.SoftwareVersiontxt.Enabled = false;
            this.SoftwareVersiontxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.SoftwareVersiontxt.Hint = "software version:";
            this.SoftwareVersiontxt.Location = new System.Drawing.Point(38, 22);
            this.SoftwareVersiontxt.MaxLength = 50;
            this.SoftwareVersiontxt.MouseState = MaterialSkin.MouseState.OUT;
            this.SoftwareVersiontxt.Multiline = false;
            this.SoftwareVersiontxt.Name = "SoftwareVersiontxt";
            this.SoftwareVersiontxt.Size = new System.Drawing.Size(153, 50);
            this.SoftwareVersiontxt.TabIndex = 7;
            this.SoftwareVersiontxt.Text = "";
            // 
            // Developerwrapper
            // 
            this.Developerwrapper.Controls.Add(this.DeveloperEmailtxt);
            this.Developerwrapper.Controls.Add(this.DeveloperContacttxt);
            this.Developerwrapper.Controls.Add(this.DeveloperNametxt);
            this.Developerwrapper.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Developerwrapper.Location = new System.Drawing.Point(438, 20);
            this.Developerwrapper.Name = "Developerwrapper";
            this.Developerwrapper.Size = new System.Drawing.Size(288, 227);
            this.Developerwrapper.TabIndex = 2;
            this.Developerwrapper.TabStop = false;
            this.Developerwrapper.Text = "Developer Information";
            // 
            // DeveloperEmailtxt
            // 
            this.DeveloperEmailtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeveloperEmailtxt.Depth = 0;
            this.DeveloperEmailtxt.Enabled = false;
            this.DeveloperEmailtxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.DeveloperEmailtxt.Hint = "email address";
            this.DeveloperEmailtxt.Location = new System.Drawing.Point(16, 145);
            this.DeveloperEmailtxt.MaxLength = 50;
            this.DeveloperEmailtxt.MouseState = MaterialSkin.MouseState.OUT;
            this.DeveloperEmailtxt.Multiline = false;
            this.DeveloperEmailtxt.Name = "DeveloperEmailtxt";
            this.DeveloperEmailtxt.Size = new System.Drawing.Size(250, 50);
            this.DeveloperEmailtxt.TabIndex = 6;
            this.DeveloperEmailtxt.Text = "";
            // 
            // DeveloperContacttxt
            // 
            this.DeveloperContacttxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeveloperContacttxt.Depth = 0;
            this.DeveloperContacttxt.Enabled = false;
            this.DeveloperContacttxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.DeveloperContacttxt.Hint = "phone number";
            this.DeveloperContacttxt.Location = new System.Drawing.Point(16, 89);
            this.DeveloperContacttxt.MaxLength = 50;
            this.DeveloperContacttxt.MouseState = MaterialSkin.MouseState.OUT;
            this.DeveloperContacttxt.Multiline = false;
            this.DeveloperContacttxt.Name = "DeveloperContacttxt";
            this.DeveloperContacttxt.Size = new System.Drawing.Size(250, 50);
            this.DeveloperContacttxt.TabIndex = 5;
            this.DeveloperContacttxt.Text = "";
            // 
            // DeveloperNametxt
            // 
            this.DeveloperNametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeveloperNametxt.Depth = 0;
            this.DeveloperNametxt.Enabled = false;
            this.DeveloperNametxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.DeveloperNametxt.Hint = "developed by:";
            this.DeveloperNametxt.Location = new System.Drawing.Point(16, 33);
            this.DeveloperNametxt.MaxLength = 50;
            this.DeveloperNametxt.MouseState = MaterialSkin.MouseState.OUT;
            this.DeveloperNametxt.Multiline = false;
            this.DeveloperNametxt.Name = "DeveloperNametxt";
            this.DeveloperNametxt.Size = new System.Drawing.Size(250, 50);
            this.DeveloperNametxt.TabIndex = 4;
            this.DeveloperNametxt.Text = "";
            // 
            // Customerwrapper
            // 
            this.Customerwrapper.Controls.Add(this.ReceiptFooterNotetxt);
            this.Customerwrapper.Controls.Add(this.BusinessTitletxt);
            this.Customerwrapper.Controls.Add(this.CustomerNametxt);
            this.Customerwrapper.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Customerwrapper.Location = new System.Drawing.Point(16, 20);
            this.Customerwrapper.Name = "Customerwrapper";
            this.Customerwrapper.Size = new System.Drawing.Size(409, 227);
            this.Customerwrapper.TabIndex = 1;
            this.Customerwrapper.TabStop = false;
            this.Customerwrapper.Text = "Customer Information";
            // 
            // ReceiptFooterNotetxt
            // 
            this.ReceiptFooterNotetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReceiptFooterNotetxt.Depth = 0;
            this.ReceiptFooterNotetxt.Enabled = false;
            this.ReceiptFooterNotetxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.ReceiptFooterNotetxt.Hint = "receipt footer note";
            this.ReceiptFooterNotetxt.Location = new System.Drawing.Point(29, 145);
            this.ReceiptFooterNotetxt.MaxLength = 50;
            this.ReceiptFooterNotetxt.MouseState = MaterialSkin.MouseState.OUT;
            this.ReceiptFooterNotetxt.Multiline = false;
            this.ReceiptFooterNotetxt.Name = "ReceiptFooterNotetxt";
            this.ReceiptFooterNotetxt.Size = new System.Drawing.Size(347, 50);
            this.ReceiptFooterNotetxt.TabIndex = 3;
            this.ReceiptFooterNotetxt.Text = "";
            // 
            // BusinessTitletxt
            // 
            this.BusinessTitletxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BusinessTitletxt.Depth = 0;
            this.BusinessTitletxt.Enabled = false;
            this.BusinessTitletxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.BusinessTitletxt.Hint = "business title";
            this.BusinessTitletxt.Location = new System.Drawing.Point(29, 89);
            this.BusinessTitletxt.MaxLength = 50;
            this.BusinessTitletxt.MouseState = MaterialSkin.MouseState.OUT;
            this.BusinessTitletxt.Multiline = false;
            this.BusinessTitletxt.Name = "BusinessTitletxt";
            this.BusinessTitletxt.Size = new System.Drawing.Size(347, 50);
            this.BusinessTitletxt.TabIndex = 2;
            this.BusinessTitletxt.Text = "";
            // 
            // CustomerNametxt
            // 
            this.CustomerNametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerNametxt.Depth = 0;
            this.CustomerNametxt.Enabled = false;
            this.CustomerNametxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.CustomerNametxt.Hint = "customer name";
            this.CustomerNametxt.Location = new System.Drawing.Point(29, 33);
            this.CustomerNametxt.MaxLength = 50;
            this.CustomerNametxt.MouseState = MaterialSkin.MouseState.OUT;
            this.CustomerNametxt.Multiline = false;
            this.CustomerNametxt.Name = "CustomerNametxt";
            this.CustomerNametxt.Size = new System.Drawing.Size(347, 50);
            this.CustomerNametxt.TabIndex = 1;
            this.CustomerNametxt.Text = "";
            // 
            // ClosePagebtn
            // 
            this.ClosePagebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClosePagebtn.Depth = 0;
            this.ClosePagebtn.DrawShadows = true;
            this.ClosePagebtn.HighEmphasis = false;
            this.ClosePagebtn.Icon = null;
            this.ClosePagebtn.Location = new System.Drawing.Point(660, 339);
            this.ClosePagebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClosePagebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClosePagebtn.Name = "ClosePagebtn";
            this.ClosePagebtn.Size = new System.Drawing.Size(66, 36);
            this.ClosePagebtn.TabIndex = 4;
            this.ClosePagebtn.Text = "close";
            this.ClosePagebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ClosePagebtn.UseAccentColor = false;
            this.ClosePagebtn.UseVisualStyleBackColor = true;
            this.ClosePagebtn.Click += new System.EventHandler(this.ClosePagebtn_Click);
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Container);
            this.Name = "SettingsScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsScreen";
            this.Container.ResumeLayout(false);
            this.Container.PerformLayout();
            this.Productwrapper.ResumeLayout(false);
            this.Developerwrapper.ResumeLayout(false);
            this.Customerwrapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CSharp.Winform.UI.GroupBox Container;
        private CSharp.Winform.UI.GroupBox Productwrapper;
        private CSharp.Winform.UI.GroupBox Developerwrapper;
        private CSharp.Winform.UI.GroupBox Customerwrapper;
        private MaterialSkin.Controls.MaterialTextBox DateofServicetxt;
        private MaterialSkin.Controls.MaterialTextBox ServiceStatustxt;
        private MaterialSkin.Controls.MaterialTextBox ProductStatustxt;
        private MaterialSkin.Controls.MaterialTextBox SoftwareVersiontxt;
        private MaterialSkin.Controls.MaterialTextBox DeveloperEmailtxt;
        private MaterialSkin.Controls.MaterialTextBox DeveloperContacttxt;
        private MaterialSkin.Controls.MaterialTextBox DeveloperNametxt;
        private MaterialSkin.Controls.MaterialTextBox ReceiptFooterNotetxt;
        private MaterialSkin.Controls.MaterialTextBox BusinessTitletxt;
        private MaterialSkin.Controls.MaterialTextBox CustomerNametxt;
        private MaterialSkin.Controls.MaterialButton ClosePagebtn;
    }
}