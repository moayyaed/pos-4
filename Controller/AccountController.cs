using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using POS.Model;
namespace POS.Controller
{
   public  class AccountController
    {
        /// <summary>
        /// CONTROLLERS
        /// </summary>
        ServerController serverController = new ServerController();
        /// <summary>
        /// GET ALL REGISTERD USERS
        /// </summary>
        public DataTable GetAllRegisteredUsers()
        {
            serverController.da = new SqlDataAdapter();
            serverController.dt = new DataTable();
            try
            {
                serverController.cmd = new SqlCommand("select username,phone,isAdmin,isActive from nbs_users where not phone=0000000000", serverController.connection);
                serverController.connection.Open();
                serverController.da.SelectCommand = serverController.cmd;
                serverController.da.Fill(serverController.dt);
                serverController.connection.Close();
                return serverController.dt;
            }
            catch (Exception ex)
            {
                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Account Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return serverController.dt;
        }

        /// <summary>
        /// LIST OF REGISTERED USERS
        /// </summary>
        /// <returns></returns>
        public List<string> PrepareListOfUsers()
        {
            DataTable dt = GetAllRegisteredUsers();
            List<string> RegisteredUsersList = new List<string>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dt.Rows)
                {
                    RegisteredUsersList.Add(dataRow["username"].ToString());
                }
            }
            return RegisteredUsersList;
        }


        /// <summary>
        /// UPDATE USER ACCOUNT
        /// </summary>
        /// <param name="model"></param>
        public void UpdateAccount(UserModel model)
        {
            try
            {
                serverController.cmd = new SqlCommand("update nbs_users set isActive=@status,isAdmin=@role where id=@id", serverController.connection);
                serverController.cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = model.IsActive;
                serverController.cmd.Parameters.Add("@role", SqlDbType.VarChar).Value = model.IsAdmin;
                serverController.cmd.Parameters.Add("@id", SqlDbType.Int).Value = model.Id;
                serverController.connection.Open();
                serverController.cmd.ExecuteNonQuery();
                serverController.connection.Close();
                MessageBox.Show("Account Update Successful", "Account Server", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Account Update Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// GET USER ACCOUNT BY USERNAME
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public DataTable GetAccountbyUsername(string username)
        {
            serverController.dt = new DataTable();
            serverController.da = new SqlDataAdapter();
            try
            {
                serverController.cmd = new SqlCommand("select * from nbs_users where username=@username", serverController.connection);
                serverController.cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                serverController.connection.Open();
                serverController.da.SelectCommand = serverController.cmd;
                serverController.da.Fill(serverController.dt);
                serverController.connection.Close();
                return serverController.dt;

            }
            catch (Exception ex)
            {

                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Account Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return serverController.dt;
        }


        /// <summary>
        /// UPUDATE THE USER ACCOUNT NAME AND PHONE
        /// </summary>
        /// <param name="model"></param>
        public void UpdateAccountNamePhone(UserModel model)
        {
            try
            {
                serverController.cmd = new SqlCommand("update nbs_users set username=@username,phone=@phone where id=@id", serverController.connection);
                serverController.cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = model.Username;
                serverController.cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = model.Phone;
                serverController.cmd.Parameters.Add("@id", SqlDbType.Int).Value = model.Id;
                serverController.connection.Open();
                serverController.cmd.ExecuteNonQuery();
                serverController.connection.Close();
                MessageBox.Show("Account Update Successful", "Account Server", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Account Update Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// CHANGE ACCOUNT PASSWORD
        /// </summary>
        /// <param name="model"></param>
        public void ChangeAccountPassword(UserModel model)
        {
            try
            {
                serverController.cmd = new SqlCommand("update nbs_users set password=@password,status=@status where id=@id", serverController.connection);
                serverController.cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = model.Password;
                serverController.cmd.Parameters.Add("@id", SqlDbType.Int).Value = model.Id;
                serverController.cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = "Inactivate";
                serverController.connection.Open();
                serverController.cmd.ExecuteNonQuery();
                serverController.connection.Close();
                MessageBox.Show("Password Updated Successful", "Account Server", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Account Password Update Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// DELETE USER ACCOUNT 
        /// </summary>
        /// <param name="model"></param>
        public void DeleteUserAccount(UserModel model)
        {
            try
            {
                serverController.cmd = new SqlCommand("delete from nbs_users where username=@username", serverController.connection);
                serverController.cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = model.Username;
                serverController.connection.Open();
                serverController.cmd.ExecuteNonQuery();
                serverController.connection.Close();
                MessageBox.Show("Account Deleted Successful", "Account Server", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Account Password Update Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// GET ACCOUNT BY PHONE OR USERNAME
        /// </summary>
        /// <param name="PhoneUsername"></param>
        /// <returns></returns>
        public DataTable GetAccountByPhoneOrUsername(string PhoneUsername)
        {
            serverController.da = new SqlDataAdapter();
            serverController.dt = new DataTable();
            try
            {
                serverController.cmd = new SqlCommand("select * from nbs_users where username=@username or phone=@phone", serverController.connection);
                serverController.connection.Open();
                serverController.cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = PhoneUsername;
                serverController.cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = PhoneUsername;
                serverController.da.SelectCommand = serverController.cmd;
                serverController.da.Fill(serverController.dt);
                serverController.connection.Close();
                return serverController.dt;
            }
            catch (Exception ex)
            {
                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Account Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return serverController.dt;
        }
    }
}
