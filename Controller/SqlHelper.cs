using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace POS.Controller
{
    public class SqlHelper
    {
        SqlConnection conn;

        public  SqlHelper(string connectionString)
        {
            conn = new SqlConnection(connectionString);
        }

        public bool isConnection
        {
            get
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                    return true;
            }
        }

    }
}
