using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Model;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS.Controller
{
   public class SalesController
    {
        /// <summary>
        /// MODELS,CLASSES AND GLOBAL VARIABLES
        /// </summary>
        ServerController serverController = new ServerController();

        /// <summary>
        /// SAVING THE SALE RECORD TO THE DATABASE
        /// </summary>
        /// <param name="model"></param>
        public void SaveSaleRecord(SalesModel model)
        {
            try
            {
                serverController.cmd = new SqlCommand("insert into nbs_sales(serviceId,transactionAmount,transactionDate,customerName,salesPerson) values(@sid,@amount,@date,@cname,@sname)", serverController.connection);
                //
                serverController.cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = model.ServiceId;
                serverController.cmd.Parameters.Add("@amount", SqlDbType.VarChar).Value = model.TransactionAmount;
                serverController.cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = model.TransactionDate;
                serverController.cmd.Parameters.Add("@cname", SqlDbType.VarChar).Value = model.CustomerName;
                serverController.cmd.Parameters.Add("@sname", SqlDbType.VarChar).Value = model.SalesPerson;
                //
                serverController.connection.Open();
                serverController.cmd.ExecuteNonQuery();
                serverController.connection.Close();
                serverController.cmd.Dispose();
            }
            catch (Exception ex)
            {
                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Sale Record Save Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// FETCH ALL SALES FROM THE DATABASE
        /// </summary>
        /// <returns></returns>
        public DataTable LoadAllSales()
        {
            serverController.dt = new DataTable();
            serverController.da = new SqlDataAdapter();
            try
            {
                serverController.cmd = new SqlCommand("select serviceId,transactionAmount,transactionDate,customerName,salesPerson from nbs_sales", serverController.connection);
                serverController.connection.Open();
                serverController.da.SelectCommand = serverController.cmd;
                serverController.da.Fill(serverController.dt);
                serverController.connection.Close();
                return serverController.dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load Sales Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return serverController.dt;
        }

        /// <summary>
        /// GET THE REPORT BY THE DATE
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public DataTable GetReportByDate(string date)
        {
            serverController.da = new SqlDataAdapter();
            serverController.dt = new DataTable();
            try
            {
                serverController.cmd = new SqlCommand("select serviceId,transactionAmount,transactionDate,customerName,salesPerson from nbs_sales where transactionDate=@tdate", serverController.connection);
                serverController.cmd.Parameters.Add("@tdate", SqlDbType.VarChar).Value = date;
                serverController.connection.Open();
                serverController.da.SelectCommand = serverController.cmd;
                serverController.da.Fill(serverController.dt);
                serverController.connection.Close();
                return serverController.dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load Sales By Date Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return serverController.dt;
        }

        /// <summary>
        /// LOAD SALES BY SERVICE ID
        /// </summary>
        /// <param name="serviceId"></param>
        /// <returns></returns>
        public DataTable GetSalesByServiceId(string serviceId)
        {
            serverController.da = new SqlDataAdapter();
            serverController.dt = new DataTable();
            try
            {
                serverController.cmd = new SqlCommand("select serviceId,transactionAmount,transactionDate,customerName,salesPerson from nbs_sales where serviceId=@sid", serverController.connection);
                serverController.cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = serviceId;
                serverController.connection.Open();
                serverController.da.SelectCommand = serverController.cmd;
                serverController.da.Fill(serverController.dt);
                serverController.connection.Close();
                return serverController.dt;
            }
            catch (Exception ex)
            {
                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Get Sales By ServiceID Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return serverController.dt;
        }

    }
}
