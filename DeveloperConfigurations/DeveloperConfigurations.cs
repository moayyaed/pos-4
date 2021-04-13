using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace POS.DeveloperConfigurations
{
    public class DeveloperConfigurations
    {
        Controller.ServerController serverController = new Controller.ServerController();
       /// <summary>
       /// GET APPLICATION THEME
       /// </summary>
       /// <returns></returns>
       /// 
        public string GetTheme()
        {
            string theme = LocalResources.ThemeSettings.Theme;
            return theme;

        }

        /// <summary>
        /// UPDATE APPLICATION THEME
        /// </summary>
        /// <param name="theme"></param>
        public void SetThemeValue(string theme)
        {
            ResXResourceWriter reswriter = new ResXResourceWriter("../../LocalResources/ThemeSettings.resx");
            reswriter.AddResource("Theme", theme);
            reswriter.Generate();
            reswriter.Close();

        }

        /// <summary>
        /// UPDATE THE SERVICE CUSTOMER NAME
        /// </summary>
        /// <param name="customername"></param>
        public void UpdateCustomerName(string customername)
        {
            ResXResourceWriter reswriter = new ResXResourceWriter("../../LocalResources/CustomerName.resx");
            reswriter.AddResource("Name", customername);
            reswriter.Generate();
            reswriter.Close();
        }

        /// <summary>
        /// UPDATE THE DEVELOPER NAME
        /// </summary>
        /// <param name="customername"></param>
        public void UpdateDeveloperName(string developername)
        {
            ResXResourceWriter reswriter = new ResXResourceWriter("../../LocalResources/DeveloperName.resx");
            reswriter.AddResource("Name", developername);
            reswriter.Generate();
            reswriter.Close();
        }

        /// <summary>
        /// UPDATE THE RECEIPT FOOTER TEXT;
        /// </summary>
        /// <param name="customername"></param>
        public void UpdateReceiptFooter(string receiptfooter)
        {
            ResXResourceWriter reswriter = new ResXResourceWriter("../../LocalResources/ReceiptFooter.resx");
            reswriter.AddResource("Note", receiptfooter);
            reswriter.Generate();
            reswriter.Close();
        }

        /// <summary>
        /// UPDATE THE DEVELOPER EMAIL;
        /// </summary>
        /// <param name="customername"></param>
        public void UpdateDeveloperEmail(string developeremail)
        {
            ResXResourceWriter reswriter = new ResXResourceWriter("../../LocalResources/DeveloperEmail.resx");
            reswriter.AddResource("Email", developeremail);
            reswriter.Generate();
            reswriter.Close();
        }

        /// <summary>
        /// UPDATE THE DEVELOPER PHONE;
        /// </summary>
        /// <param name="customername"></param>
        public void UpdateDeveloperPhone(string developerphone)
        {
            ResXResourceWriter reswriter = new ResXResourceWriter("../../LocalResources/DeveloperPhone.resx");
            reswriter.AddResource("Phone", developerphone);
            reswriter.Generate();
            reswriter.Close();
        }
        /// <summary>
        /// UPDATE THE RECEIPT FOOTER TEXT;
        /// </summary>
        /// <param name="customername"></param>
        public void UpdateBusinessTitle(string businesstitle)
        {
            ResXResourceWriter reswriter = new ResXResourceWriter("../../LocalResources/BusinessTitle.resx");
            reswriter.AddResource("Logo", businesstitle);
            reswriter.Generate();
            reswriter.Close();
        }

        /// <summary>
        /// UPDATE THE SOFTWARE VERSION;
        /// </summary>
        /// <param name="customername"></param>
        public void UpdateSoftwareVersion(string softwareversion)
        {
            ResXResourceWriter reswriter = new ResXResourceWriter("../../LocalResources/SoftwareVersion.resx");
            reswriter.AddResource("Version", softwareversion);
            reswriter.Generate();
            reswriter.Close();
        }

        /// <summary>
        /// UPDATE THE SERVICE DATE;
        /// </summary>
        /// <param name="customername"></param>
        public void UpdateServiceDate(string servicedate)
        {
            ResXResourceWriter reswriter = new ResXResourceWriter("../../LocalResources/DateofService.resx");
            reswriter.AddResource("Date", servicedate);
            reswriter.Generate();
            reswriter.Close();
        }
        /// <summary>
        /// GET THE DEVELOPER TAG
        /// </summary>
        /// <returns></returns>
        public string GetDeveloper()
        {
            string Developer = LocalResources.ThemeSettings.Developer;
            return Developer;
        }

        /// <summary>
        /// APPLICATION VERSION GET
        /// </summary>
        /// <returns></returns>
        public string ApplicationVersion()
        {
            return LocalResources.ThemeSettings.Version;
        }

        /// <summary>
        /// GET THE CUSTOMER NAME
        /// </summary>
        /// <returns></returns>
        public string GetOwner()
        {
            return LocalResources.ThemeSettings.Customer;
        }

        /// <summary>
        /// ///CLEAN THE DATABASE
        /// </summary>
        public void CleanDataBase()
        {
            try
            {
                ///CLEAN THE PRODUCTS
                serverController.cmd = new SqlCommand("delete from nbs_products where not id=0", serverController.connection);
                serverController.connection.Open();
                serverController.cmd.ExecuteNonQuery();
                serverController.connection.Close();

                ///CLEAN THE SERVICES
                serverController.cmd = new SqlCommand("delete from nbs_service where not id=0", serverController.connection);
                serverController.connection.Open();
                serverController.cmd.ExecuteNonQuery();
                serverController.connection.Close();

                //CLEAN THE SALES
                serverController.cmd = new SqlCommand("delete from nbs_sales where not id=0", serverController.connection);
                serverController.connection.Open();
                serverController.cmd.ExecuteNonQuery();
                serverController.connection.Close();

                //CLEAN THE USERS
                serverController.cmd = new SqlCommand("delete from nbs_users where not phone=0000000000", serverController.connection);
                serverController.connection.Open();
                serverController.cmd.ExecuteNonQuery();
                serverController.connection.Close();

                //CLEAN THE CATEGORYS
                serverController.cmd = new SqlCommand("delete from nbs_product_category where not id=0", serverController.connection);
                serverController.connection.Open();
                serverController.cmd.ExecuteNonQuery();
                serverController.connection.Close();

                MessageBox.Show("Database cleaned successfully", "DabaseCleaned", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
