using System;
using System.Windows.Forms;

namespace POS.Views
{
   
    public partial class SplashScreenForm : Form
    {
        // calling the utils data
        Utils.Utils utils = new Utils.Utils();
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            ApplicationProgressBar.Value += 1;
            ApplicationProgressStateCounterlbl.Text = ApplicationProgressBar.Value +"%";
            this.UseWaitCursor = true;
            if (ApplicationProgressBar.Value < 25)
            {
                ApplicationProgressStatelbl.Text = utils.startUp;
            }
            else if (ApplicationProgressBar.Value < 50)
            {
                ApplicationProgressStatelbl.Text = utils.loadResources;
            }
            else if (ApplicationProgressBar.Value < 75)
            {
                ApplicationProgressStatelbl.Text = utils.storeConnection;
            }
            else if (ApplicationProgressBar.Value < 100)
            {
                ApplicationProgressStatelbl.Text = utils.serverConnection;
            }
            else if (ApplicationProgressBar.Value == 100)
            {
                ApplicationProgressStatelbl.Text = utils.connectedState;
                progressTimer.Enabled = false;
                this.UseWaitCursor = false;
                //calling the login page 
                Views.AccountLoginForm LoginPage = new Views.AccountLoginForm();
                LoginPage.Show();
                this.Hide();
            }
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            progressTimer.Enabled = true;
            DeveloperLogolbl.Text = LocalResources.AppConfigResource.LogoTitle;
        }
    }
}
