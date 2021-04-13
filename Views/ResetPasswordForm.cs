using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Controller;
using POS.Model;
using System.Data.SqlClient;
using POS.Utils;
using POS.Services;

namespace POS.Views
{
    public partial class ResetPasswordForm : MaterialSkin.Controls.MaterialForm
    {
        /// <summary>
        /// CONTROLLERS
        /// </summary>
        AccountController accountController = new AccountController();
        HashAccountPassword hashPassword = new HashAccountPassword();

        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// CLOSE PAGE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClosePagebtn_Click(object sender, EventArgs e)
        {
            AccountLoginForm loginPage = new AccountLoginForm();
            loginPage.Show();
            this.Hide();
        }

        /// <summary>
        /// CHANGE PASSWORD BTNCLICK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveChangesbtn_Click(object sender, EventArgs e)
        {
            if (PhoneOrUsernametxt.Text.Length <= 0)
            {
                PhoneOrUsernametxt.Focus();
                return;
            }else if (NewPasswordtxt.Text.Length <= 0)
            {
                NewPasswordtxt.Focus();
                return;
            }
            else
            {
                DataTable dt = accountController.GetAccountByPhoneOrUsername(PhoneOrUsernametxt.Text);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("invalid username or phone", "Details not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    foreach (DataRow dataRow in accountController.GetAccountByPhoneOrUsername(PhoneOrUsernametxt.Text).Rows)
                    {
                        UserModel model = new UserModel();
                        model.Password = hashPassword.HashPassword(NewPasswordtxt.Text);
                        model.Id = dataRow["id"].ToString();
                        accountController.ChangeAccountPassword(model);
                    }
                    return;
                }
            }
        }

    }
}
