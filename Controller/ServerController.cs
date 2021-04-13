using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Resources;

namespace POS.Controller
{
    public class ServerController
    {
        //TODO
        //assign value to the sql connection instance;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;
        public SqlDataReader dr;
        public DataSet ds;
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConstring"].ConnectionString);
        // 

        /// public method to check the connection state of the server
        /// 
        public void OpenServerConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        ///public method to close the connection to server
        ///
        public void CloseServerConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }


    }
}
