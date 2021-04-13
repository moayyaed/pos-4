using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.DeveloperConfigurations;

namespace POS.Views
{
    public partial class UpdateSoftwareDetailsScreen : MaterialSkin.Controls.MaterialForm
    {
        DeveloperConfigurations.DeveloperConfigurations developerConfigurations = new DeveloperConfigurations.DeveloperConfigurations();
        public UpdateSoftwareDetailsScreen()
        {
            InitializeComponent();
        }

        private void DeveloperPasscodetxt_TextChanged(object sender, EventArgs e)
        {
            if (DeveloperPasscodetxt.Text == LocalResources.PassCode.code)
            {
                ManageDetailsContainer.Enabled = true;
                EnableContainer.Enabled = false;
                return;
            }
            else
            {
                ManageDetailsContainer.Enabled = false;
            }
        }

        /// <summary>
        /// UPDATE THE CUSTOMER NAME
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCustomerNamebtn_Click(object sender, EventArgs e)
        {
            if (CustomerNametxt.Text.Length <= 0)
            {
                CustomerNametxt.Focus();
                return;
            }
            else
            {
                developerConfigurations.UpdateCustomerName(CustomerNametxt.Text.ToUpper());
            }
        }

        /// <summary>
        /// UPDATE THE BUSINESS TITLE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateBusinessTitlebtn_Click(object sender, EventArgs e)
        {
            if (BusinessTitletxt.Text.Length <= 0)
            {
                BusinessTitletxt.Focus();
                return;
            }
            else
            {
                developerConfigurations.UpdateBusinessTitle(BusinessTitletxt.Text.ToUpper());
            }
        }

        /// <summary>
        /// UPDATE THE RECEIPT FOOTER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateReceiptfooterbtn_Click(object sender, EventArgs e)
        {
            if (ReceiptFooterNotetxt.Text.Length <= 0)
            {
                developerConfigurations.UpdateReceiptFooter("----------------");
                return;
            }
            else
            {
                developerConfigurations.UpdateReceiptFooter(ReceiptFooterNotetxt.Text.ToUpper());
            }
        }

        /// <summary>
        /// UPDATE THE DEVELOPER NAME
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateDeveloperNamebtn_Click(object sender, EventArgs e)
        {
            if (DeveloperNametxt.Text.Length <= 0)
            {
                DeveloperNametxt.Focus();
                return;

            }
            else
            {
                developerConfigurations.UpdateDeveloperName(DeveloperNametxt.Text.ToUpper());
            }
        }

        /// <summary>
        /// UPDATE THE DEVELOPER CONTACT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateDeveloperPhonebtn_Click(object sender, EventArgs e)
        {
            if (DeveloperContacttxt.Text.Length <= 0)
            {
                DeveloperContacttxt.Focus();
                return;
            }
            else
            {
                developerConfigurations.UpdateDeveloperPhone(DeveloperContacttxt.Text.ToLower());
            }
        }


        /// <summary>
        /// UPDATE THE DEVELOPER EMAIL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateDeveloperEmailbtn_Click(object sender, EventArgs e)
        {
            if (DeveloperEmailtxt.Text.Length <= 0)
            {
                DeveloperEmailtxt.Focus();
                return;
            }
            else
            {
                developerConfigurations.UpdateDeveloperEmail(DeveloperEmailtxt.Text.ToLower());
            }
        }

        /// <summary>
        /// UPDATE THE SOFTWARE VERSION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateSoftwareVersionbtn_Click(object sender, EventArgs e)
        {
            if (SoftwareVersiontxt.Text.Length <= 0)
            {
                SoftwareVersiontxt.Focus();
                return;

            }
            else
            {
                developerConfigurations.UpdateSoftwareVersion(SoftwareVersiontxt.Text.ToLower());
            }
        }


        /// <summary>
        /// UPDATE THE DATE OF SERVICE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateDateOfServicebtn_Click(object sender, EventArgs e)
        {
            if (DateofServicetxt.Text.Length <= 0)
            {
                DateofServicetxt.Focus();
                return;
            }
            else
            {
                developerConfigurations.UpdateServiceDate(DateofServicetxt.Text.ToLower());
            }
        }

        /// <summary>
        /// CLOSE THE THIS PAGE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClosePagebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.AccountLoginForm accountLoginForm = new AccountLoginForm();
            accountLoginForm.Show();
        }

        /// <summary>
        /// FORMAT THE DATA BASE BUTTON CLICK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CleanDataBasebtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("do you want to Format Database??","Format Database", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                developerConfigurations.CleanDataBase();
                return;
            }
            else
            {
                return;
            }
        }
    }
}
