using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Model;
using POS.Controller;
namespace POS.Views
{
    public partial class AdminDashBoardForm : MaterialSkin.Controls.MaterialForm
    {
        /// <summary>
        /// CONTROLLERS
        /// </summary>
        AccountController accountController = new AccountController();
        public AdminDashBoardForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// FORM LOAD EVENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminDashBoardForm_Load(object sender, EventArgs e)
        {
            PrepareRoleAndStatus();
            LoadDefault();


        }

        public void LoadDefault()
        {
            AllUserscbx.DataSource = accountController.PrepareListOfUsers();
            UsersDataGrid.DataSource = accountController.GetAllRegisteredUsers();
        }
        /// <summary>
        /// PREPARE ACCOUNT ROLE AND STATUS
        /// </summary>
        public void PrepareRoleAndStatus()
        {
            AccountRolecbsx.Items.Add("");
            AccountRolecbsx.Items.Add("Admin");
            AccountRolecbsx.Items.Add("User");

            //
            AccountStatuscbx.Items.Add("");
            AccountStatuscbx.Items.Add("Activate");
            AccountStatuscbx.Items.Add("Deactivate");
        }

        /// <summary>
        /// GET SELECTED USER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllUserscbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllUserscbx.Text.Length > 0) {
                if (accountController.GetAccountbyUsername(AllUserscbx.Text).Rows.Count > 0)
                {
                    foreach (DataRow dataRow in accountController.GetAccountbyUsername(AllUserscbx.Text).Rows)
                    {
                        SelectedAccountlbl.Text = dataRow["id"].ToString();
                    }
                }
            }
        }

        /// <summary>
        /// SAVE ACCOUNT CHANGES
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAccountChangesbtn_Click(object sender, EventArgs e)
        {
            if(AccountStatuscbx.Text.Length<=0 || AccountRolecbsx.Text.Length <= 0)
            {
                MessageBox.Show("Please select ROLE and STATUS", "Account Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                UserModel model = new UserModel();
                model.Id = SelectedAccountlbl.Text;
                model.IsActive = AccountStatuscbx.Text;
                model.IsAdmin = AccountRolecbsx.Text;
                accountController.UpdateAccount(model);
                LoadDefault();
                PrepareRoleAndStatus();
            }
        }

        /// <summary>
        /// DELET ACCOUNT BTN CLICK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteAccountbtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("do you want to delete account??","Delete User Account ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UserModel model = new UserModel();
                model.Username = AllUserscbx.Text;
                accountController.DeleteUserAccount(model);
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// BACK TO HOME
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back2Homebtn_Click(object sender, EventArgs e)
        {
            MainPageForm mainPage = new MainPageForm();
            mainPage.Show();
            this.Hide();
        }
    }
}
