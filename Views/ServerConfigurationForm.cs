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
using POS.Controller;

namespace POS.Views
{
    public partial class ServerConfigurationForm :MaterialSkin.Controls.MaterialForm
    {
        public ServerConfigurationForm()
        {
            InitializeComponent();
        }

        private void ServerConfigurationForm_Load(object sender, EventArgs e)
        {
            loadAuth();
            loadServerName();
            Passwordtxt.Enabled = false;
            Usernametxt.Enabled = false;
        }

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
        }
        private void loadServerName()
        {
            Servernamecbx.Items.Add('.');
            Servernamecbx.Items.Add("(local)");
            Servernamecbx.Items.Add(@"\SQLEXPRESS");
            Servernamecbx.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            Servernamecbx.Items.Add(string.Format("{0}",Environment.MachineName));
        }
        private void loadAuth()
        {
            AuthenticationTypecbx.Items.Add("Windows Authentication");
            AuthenticationTypecbx.Items.Add("Server Authentication");
        }

        private void AuthenticationTypecbx_TextChanged(object sender, EventArgs e)
        {
            if (AuthenticationTypecbx.Text == "Windows Authentication")
            {
                Passwordtxt.Enabled = false;
                Usernametxt.Enabled = false;
            }
            else
            {
                Passwordtxt.Enabled = true;
                Usernametxt.Enabled = true;
            }
        }

        private void TestConnectionbtn_Click(object sender, EventArgs e)
        {
            string connectionstring;
            if(AuthenticationTypecbx.Text=="Windows Authentication")
            {
                connectionstring = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", Servernamecbx.Text, Databasenametxt.Text);

            }
            else
            {
                connectionstring = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};Integrated Security=True", Servernamecbx.Text, Databasenametxt.Text,Usernametxt.Text,Passwordtxt.Text);

            }
            try
            {
                SqlHelper helper = new SqlHelper(connectionstring);
                if (helper.isConnection)
                {
                    MessageBox.Show("Connection Successful", "Server Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Server Response", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveChangesbtn_Click(object sender, EventArgs e)
        {
            string connectionstring;
            if (AuthenticationTypecbx.Text == "Windows Authentication")
            {
                connectionstring = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", Servernamecbx.Text, Databasenametxt.Text);

            }
            else
            {
                connectionstring = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};Integrated Security=True", Servernamecbx.Text, Databasenametxt.Text, Usernametxt.Text, Passwordtxt.Text);

            }
            try
            {

                AppSettings settings = new AppSettings();
                settings.SaveConnectionString("dbConstring", connectionstring);
                
                    MessageBox.Show("Connection Successful Saved", "Server Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Server Response", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitPagebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
