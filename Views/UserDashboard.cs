using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using POS.Model;
using POS.Controller;
namespace POS.Views
{
    public partial class UserDashboard : MaterialSkin.Controls.MaterialForm
    {
        AccountController accountController = new AccountController();
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void EditUsernamecbk_CheckedChanged(object sender, EventArgs e)
        {
            if (EditUsernamecbk.Checked == true)
            {
                Usernametxt.Enabled = true;
                return;
            }
            else
            {
                Usernametxt.Enabled = false;
                return;
            }
        }

        private void EditPhonecbk_CheckedChanged(object sender, EventArgs e)
        {
            if (EditPhonecbk.Checked == true)
            {
                Phonenumbertxt.Enabled = true;
                return;
            }
            else
            {
                Phonenumbertxt.Enabled = false;
                return;
            }
        }

        private void BackHomebtn_Click(object sender, EventArgs e)
        {
            MainPageForm mainPage = new MainPageForm();
            mainPage.Show();
            this.Hide();
        }

        private void Usernametxt_TextChanged(object sender, EventArgs e)
        {
            if (Usernametxt.Text.Length <= 0)
            {
                Usernametxt.Hint = "Account Username Required";

                UpdateBtn.Enabled = false;
                return;

            }
            else
            {
                Usernametxt.Hint = "Account Username";

                UpdateBtn.Enabled = true;
                return;

            }
        }

        private void Phonenumbertxt_TextChanged(object sender, EventArgs e)
        {
            int validphone = 0;
            if (Phonenumbertxt.Text.Length <= 0)
            {
                Phonenumbertxt.Hint = "phone number required";
                UpdateBtn.Enabled = false;
                return;

            }else if(!int.TryParse(Phonenumbertxt.Text,out validphone)){
                Phonenumbertxt.Hint = "invalid phone";
                UpdateBtn.Enabled = false;
                return;
            }else if (Phonenumbertxt.Text.Length != 10)
            {
                Phonenumbertxt.Hint = "max of 10 digits phonenumber required";
                UpdateBtn.Enabled = false;
                return;
            }
            else
            {
                Phonenumbertxt.Hint = "Account Phonenumber";
                UpdateBtn.Enabled = true;
                return;

            }
        }


        /// <summary>
        /// FORM ON LOAD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserDashboard_Load(object sender, EventArgs e)
        {
            LoadDetails();
        }

        /// <summary>
        /// load details
        /// </summary>
        public void LoadDetails()
        {
            Usernametxt.Text = StaticAccountModel.Username;
            Phonenumbertxt.Text = StaticAccountModel.Phone;
            AccountRoletxt.Text = StaticAccountModel.Role;
            AccountStatustxt.Text = StaticAccountModel.Status;
            AccountIdlbl.Text = StaticAccountModel.AccountID;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Save Changes??", "Update Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UserModel model = new UserModel();
                model.Username = Usernametxt.Text;
                model.Phone = Phonenumbertxt.Text;
                model.Id = AccountIdlbl.Text;
                model.IsAdmin = AccountRoletxt.Text;
                model.IsActive = AccountStatustxt.Text;
                StaticAccountModel staticModel = new StaticAccountModel();
                staticModel.SetAccountStaticModel(model);
                accountController.UpdateAccountNamePhone(model);
            }else
            {
                return;
            }
        }
    }
}
