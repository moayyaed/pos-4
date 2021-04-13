using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using POS.Model;
using POS.Controller;
namespace POS.Model
{
    public class StaticAccountModel
    {
        /// <summary>
        /// STATIC ACCOUNT ROLES
        /// </summary>
        public static string AccountID;
        public static string Username;
        public static string Phone;
        public static string Role;
        public static string Status;

        /// <summary>
        /// SET STATIC VARIABLES
        /// </summary>
        /// <param name="model"></param>
        public void SetAccountStaticModel(UserModel model)
        {
            AccountID = model.Id;
            Username = model.Username;
            Phone = model.Phone;
            Role = model.IsAdmin;
            Status = model.IsActive;
        }
    }
}
