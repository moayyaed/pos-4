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
    public partial class AccountRegisterForm : MaterialSkin.Controls.MaterialForm
    {
        Model.UserModel model = new Model.UserModel();
        Services.UserAccountValidation validation = new Services.UserAccountValidation();
        Services.AccountServices accountServices = new Services.AccountServices();
        Services.PrepareAccountRegistration prepareRegistrationData = new Services.PrepareAccountRegistration();
        Services.HashAccountPassword hashpassword = new Services.HashAccountPassword();
        public AccountRegisterForm()
        {
            InitializeComponent();
        }

    

        //pulic method to handle the user details validation
        public void handleValidation(string userdata,string valueType)
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
            if (validation.IsRegisterFormValid(model)){
                AccountRegisterbtn.Enabled = true;
            }
            else
            {
                AccountRegisterbtn.Enabled = false;
            }
            
        }



        private void AccountLoginPagebtn_Click(object sender, EventArgs e)
        {
            Views.AccountLoginForm LoginPage = new Views.AccountLoginForm();
            LoginPage.Show();
            this.Hide();
        }

        private void AccountRegisterForm_Load(object sender, EventArgs e)
        {
            Errorslbl.Text = "";
        }

        private void AccountRegisterUsernametxt_TextChanged_1(object sender, EventArgs e)
        {
            handleValidation(AccountRegisterUsernametxt.Text.ToString(), AccountRegisterUsernametxt.Tag.ToString());

        }

        private void AccountRegisterPhonetxt_TextChanged_1(object sender, EventArgs e)
        {
            handleValidation(AccountRegisterPhonetxt.Text.ToString(), AccountRegisterPhonetxt.Tag.ToString());

        }

        private void AccountRegisterPasswordtxt_TextChanged_1(object sender, EventArgs e)
        {
            handleValidation(AccountRegisterPasswordtxt.Text.ToString(), AccountRegisterPasswordtxt.Tag.ToString());

        }

        private void AccountRegisterbtn_Click(object sender, EventArgs e)
        {
            HandleAccountRegistration();
        }

        ///
        ///METHOD TO HANDLE THE REGISTRATION
        ///
        public void HandleAccountRegistration()
        {
            model = prepareRegistrationData.FormatInformation(model);
            model.Password = hashpassword.HashPassword(model.Password);
            int numberRows = accountServices.GetUserByPhone(model.Phone).Rows.Count;
            if (numberRows == 0)
            {

                // MessageBox.Show(, "Account Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RegisterNotificationlbl.Text = accountServices.AddUser(model).ToString();
                RegisterNotificationlbl.ForeColor = Color.Green;

            }
            else
            {
                RegisterNotificationlbl.Text = "Phone Number already Registered";
                RegisterNotificationlbl.ForeColor = Color.Red;
            }
        }
    }
}
