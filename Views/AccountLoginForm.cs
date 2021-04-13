using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Resources;
using POS.Model;
using POS.Controller;

namespace POS.Views
{
    public partial class AccountLoginForm : MaterialSkin.Controls.MaterialForm
    {
        Services.UserAccountValidation validation = new Services.UserAccountValidation();
        Model.UserModel model = new Model.UserModel();
        Services.HashAccountPassword hashpassword = new Services.HashAccountPassword();
        Controller.ServerController dbconfig = new Controller.ServerController();
        Services.AccountServices accountServices = new Services.AccountServices();
       //LocalResources.ThemeSettings settings = new LocalResources.ThemeSettings();

        public AccountLoginForm()
        {
            InitializeComponent();
        }

        private void AccountResetPasswordPageLink_MouseHover(object sender, EventArgs e)
        {
            AccountResetPasswordPageLink.ForeColor = Color.RoyalBlue;
        }

        private void AccountRegisterPageLink_MouseHover(object sender, EventArgs e)
        {
            AccountRegisterPageLink.ForeColor = Color.RoyalBlue;
        }

        //pulic method to handle the user details validation
        public void handleValidation(string userdata, string valueType)
        {
            switch (valueType)
            {
                case "username":
                    model.Username = userdata;
                    model.ValueType = valueType;
                    Errorslbl.Text = validation.validateUserDetails(model);
                    Errorslbl.ForeColor = Color.Firebrick;
                    break;
                case "phone":
                    model.Phone = userdata;
                    model.ValueType = valueType;
                    Errorslbl.Text = validation.validateUserDetails(model);
                    Errorslbl.ForeColor = Color.Firebrick;
                    break;
                case "password":
                    model.Password = userdata;
                    model.ValueType = valueType;
                    Errorslbl.Text = validation.validateUserDetails(model);
                    Errorslbl.ForeColor = Color.Firebrick;
                    break;
                default:
                    break;
            }
            if (validation.IsLoginFormValid(model))
            {
                AccountLoginbtn.Enabled = true;
            }
            else
            {
                AccountLoginbtn.Enabled = false;
            }

        }

        private void AccountRegisterPageLink_Click(object sender, EventArgs e)
        {
            Views.AccountRegisterForm RegisterPage = new AccountRegisterForm();
            RegisterPage.Show();
            this.Hide();
        }

        private void AccountLoginUsernametxt_TextChanged_1(object sender, EventArgs e)
        {
            handleValidation(AccountLoginUsernametxt.Text, AccountLoginUsernametxt.Tag.ToString());
        }

        private void AccountLoginPasswordtxt_TextChanged_1(object sender, EventArgs e)
        {
            handleValidation(AccountLoginPasswordtxt.Text, AccountLoginPasswordtxt.Tag.ToString());

        }

        private void ApplicationExitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close Application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AccountLoginForm_Load(object sender, EventArgs e)
        {
            Errorslbl.Text = "";
        }

        private void AccountLoginbtn_Click(object sender, EventArgs e)
        {
            initLogin();
           // MessageBox.Show(hashpassword.VerifyPassword(model.Password,model.Password).ToString(), "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ///
        ///HANDLE THE LOGIN 
        ///
        public void initLogin()
        {
            var dt = accountServices.GetUserByPhone(model.Username);
            if (dt.Rows.Count <=0)
            {
                MessageBox.Show("Incorrect Phone Number", "Account Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                foreach (DataRow dataRow in dt.Rows)
                {
                    Boolean match = hashpassword.VerifyPassword(model.Password, dataRow["password"].ToString());
                    if (match)
                    {
                        if (dataRow["isActive"].ToString() != "Activate")
                        {
                            MessageBox.Show("Account not Active,please contact admin", "InActive Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            model.Username = dataRow["username"].ToString();
                            model.Phone = dataRow["phone"].ToString();
                            model.IsActive = dataRow["isActive"].ToString();
                            model.IsAdmin = dataRow["isAdmin"].ToString();
                            model.Id = dataRow["id"].ToString();
                            model.SetAccountDetails(dt);
                            SetAccountDetails(model);
                            //MessageBox.Show(match, "results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MainPageForm homepage = new MainPageForm();
                            homepage.Show();
                            this.Hide();
                        }

                    }
                    else{
                        MessageBox.Show("Incorrect Phone Number", "Account Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }

        /// <summary>
        /// SET STATIC ACCOUNT DETAILS
        /// </summary>
        /// <param name="model"></param>
        public void SetAccountDetails(UserModel model)
        {
            StaticAccountModel staticAccounmodel = new StaticAccountModel();
            staticAccounmodel.SetAccountStaticModel(model);
        }

        private void ServerConfigbtn_Click(object sender, EventArgs e)
        {
            ServerConfigurationForm serverform = new ServerConfigurationForm();
            serverform.Show();
            this.Hide();
        }

        private void AccountResetPasswordPageLink_Click(object sender, EventArgs e)
        {
            ResetPasswordForm resetPass = new ResetPasswordForm();
            this.Hide();
            resetPass.Show();
        }


        /// <summary>
        /// CONFIGURE SYSTEM SETTINGS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigureSystemSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.UpdateSoftwareDetailsScreen updateSoftwareDetailsScreen = new UpdateSoftwareDetailsScreen();
            updateSoftwareDetailsScreen.Show();
        }
    }
}
