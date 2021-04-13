using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Model;
using System.Data;
using System.Data.SqlClient;
namespace POS.Controller
{
   public  class ReportController
    {
        /// <summary>
        /// CONTROLLERS
        /// </summary>
        ServerController serverController = new ServerController();
        /// <summary>
        /// MODELS
        /// </summary>
        ReportModel reportModel = new ReportModel();


        public ReportModel ServiceDetails(string serviceID)
        {
            try
            {
                serverController.dt = new DataTable();
                serverController.da = new SqlDataAdapter();
                serverController.cmd = new SqlCommand("select * from nbs_sales where serviceId=@sid", serverController.connection);
                serverController.cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = serviceID;
                serverController.connection.Open();
                serverController.da.SelectCommand = serverController.cmd;
                serverController.da.Fill(serverController.dt);
                serverController.connection.Close();
                if (serverController.dt.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in serverController.dt.Rows)
                    {
                        reportModel.Id = dataRow["id"].ToString();
                        reportModel.CustomerName = dataRow["customerName"].ToString();
                        reportModel.TransactionAmount = dataRow["transactionAmount"].ToString();
                        reportModel.SalesPerson = dataRow["salesPerson"].ToString();
                        reportModel.ServiceID = dataRow["serviceId"].ToString();
                        reportModel.TransactionDate = dataRow["transactionDate"].ToString();
                    }
                    return reportModel;
                }
                else
                {
                    MessageBox.Show("Invalid Sale Service ID", "Service Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            catch (Exception ex)
            {
                serverController.connection.Close();
                MessageBox.Show(ex.Message,"Service Details Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return reportModel;
        }

    }
}
