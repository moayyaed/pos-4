using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using POS.Model;
using System.Windows.Forms;

namespace POS.Services
{
    public class AccountServices
    {
        Controller.ServerController dbconfig = new Controller.ServerController();
 
       
        ////
        ///Get User by Phone
        ///

        public DataTable GetUserByPhone(string phone="")
        {
            DataTable dt = new DataTable();
            try
            {
                
                dbconfig.OpenServerConnection();
                dbconfig.cmd = new SqlCommand("select * from nbs_users where phone=@phone", dbconfig.connection);
                dbconfig.cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = dbconfig.cmd;
                da.Fill(dt);
                dbconfig.CloseServerConnection();
                return dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "LoginServerError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
            
        }

        ///
        ///ADD USER TO THE DATABASE
        ///
        public string AddUser(UserModel model)
        {
            try
            {
                dbconfig.cmd = new SqlCommand("insert into nbs_users values(@username,@phone,@password,@isAdmin,@isActive)", dbconfig.connection);
                dbconfig.cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = model.Username;
                dbconfig.cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = model.Phone;
                dbconfig.cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = model.Password;
                dbconfig.cmd.Parameters.Add("@isAdmin", SqlDbType.VarChar).Value = model.IsAdmin.ToString();
                dbconfig.cmd.Parameters.Add("@isActive", SqlDbType.VarChar).Value = model.IsActive.ToString();
                dbconfig.OpenServerConnection();
                dbconfig.cmd.ExecuteNonQuery();
                dbconfig.CloseServerConnection();
                return "Registration Successful";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
            
        }
    }
}
