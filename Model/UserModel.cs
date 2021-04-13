using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace POS.Model
{
    public class UserModel
    {
        /// <summary>
        /// user model details 
        /// username,phone,password,id and valueType
        /// </summary>
        public string Id { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

        public Boolean Valid { get; set; }
        public string ValueType { get; set; }

        public string IsAdmin { get; set; }

        public string IsActive { get; set; }

        ///

        public static string LoggedId;
        public static string LoggedUsername;
        public static string LoggedPhone;
        public static string LoggedPassword;
        public static string LoggedIsAdmin;
        public static string LoggedIsActive;
        public static DataTable LoggedUserData;


        ///
        //set account inforamtion
        ///

        public void SetAccountDetails(DataTable userdata)
        {
            if (userdata.Rows.Count > 0)
            {
                LoggedUserData = userdata;
                foreach (DataRow dataRow in userdata.Rows)
                {
                    LoggedId = dataRow["id"].ToString();
                    LoggedUsername = dataRow["username"].ToString();
                    LoggedPhone = dataRow["phone"].ToString();
                    LoggedPassword = dataRow["password"].ToString();
                    LoggedIsAdmin = dataRow["isAdmin"].ToString();
                    LoggedIsActive = dataRow["isActive"].ToString();
                }
            }
        }
    }
}
