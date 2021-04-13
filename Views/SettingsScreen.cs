using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Views
{
    public partial class SettingsScreen : MaterialSkin.Controls.MaterialForm
    {
        public SettingsScreen()
        {
            InitializeComponent();
            CustomerNametxt.Text = LocalResources.CustomerName.Name.ToUpper();
            DeveloperEmailtxt.Text = LocalResources.DeveloperEmail.Email.ToLower();
            DeveloperContacttxt.Text = LocalResources.DeveloperPhone.Phone.ToLower();
            BusinessTitletxt.Text = LocalResources.BusinessTitle.Logo.ToUpper();
            ReceiptFooterNotetxt.Text = LocalResources.ReceiptFooter.Note.ToUpper();

            ///
            SoftwareVersiontxt.Text = LocalResources.SoftwareVersion.Version.ToLower();
            ServiceStatustxt.Text = LocalResources.ServiceStatus.Status.ToLower();
            ProductStatustxt.Text = LocalResources.LicenseStatus.Status.ToLower();
            DateofServicetxt.Text = LocalResources.DateofService.Date.ToLower();
        }

        private void ClosePagebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
