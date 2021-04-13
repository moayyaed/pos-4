using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using POS.Model;
using System.Windows.Forms;

namespace POS.Controller
{
   public class ServiceController
    {
        ServerController serverController = new ServerController();
        Utils.Utils utils = new Utils.Utils();
        /// <summary>
        /// COUNT THE TOTAL NUMBER OF ITEMS IN THE SERVICES
        /// </summary>
        /// <returns></returns>
        public string GetTotalServices()
        {
            string total="0";
            try
            {
                serverController.da = new SqlDataAdapter();
                serverController.dt = new DataTable();
                serverController.cmd = new SqlCommand("select * from nbs_service", serverController.connection);
                serverController.connection.Open();
                serverController.da.SelectCommand = serverController.cmd;
                serverController.da.Fill(serverController.dt);
                serverController.connection.Close();
                total = serverController.dt.Rows.Count.ToString();

                return total;
            }
            catch (Exception ex)
            {
                serverController.connection.Close();
                MessageBox.Show(ex.Message, "Total Services Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return total;
            
        }


        /// <summary>
        /// GENERATE SERVICE ID
        /// </summary>
        /// <param name="nextvalue"></param>
        /// <returns></returns>
        public string GenerateServiceId(string nextvalue)
        {
            string initial = utils.AppendServiceID();
            string serviceId=string.Format(initial+(Int32.Parse(nextvalue)+1));

            return serviceId;
        }


        /// <summary>
        /// CALCULATE SINGLE SALE COST
        /// </summary>
        /// <param name="quantity"></param>
        /// <param name="cost"></param>
        /// <returns></returns>
        public string CalculateSalCost(string quantity,string cost)
        {
            try
            {
                string total;
                total =(Double.Parse(cost) * Int32.Parse(quantity)).ToString();
                return total;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            
        }


        /// <summary>
        /// FETCH ALL SERVICES FROM THE DATA BASE
        /// </summary>
        /// <returns></returns>
        public DataTable FetAllServicesData()
        {
            serverController.da = new SqlDataAdapter();
            serverController.dt = new DataTable();
            serverController.cmd = new SqlCommand("select productName,productId,serviceCost,productUnitCost,serviceId,quantitySold,serviceDate from nbs_service", serverController.connection);
            serverController.connection.Open();
            serverController.da.SelectCommand = serverController.cmd;
            serverController.da.Fill(serverController.dt);
            serverController.connection.Close();
            return serverController.dt;
        }

        /// <summary>
        /// HANDLE SAVING SERVICE RECORD
        /// </summary>
        /// <param name="model"></param>
        public void SaveServiceRecord(ServicesModel model)
        {

            try
            {

                serverController.cmd = new SqlCommand("insert into nbs_service(productName,productId,serviceCost,productUnitCost,serviceId,quantitySold,serviceDate) values(@name,@pid,@scost,@ucost,@sid,@qnt,@date)", serverController.connection);
                serverController.cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = model.ProductName;
                serverController.cmd.Parameters.Add("@pid", SqlDbType.VarChar).Value = model.ProductId;
                serverController.cmd.Parameters.Add("@scost", SqlDbType.VarChar).Value = model.ServiceTotalCost;
                serverController.cmd.Parameters.Add("@ucost", SqlDbType.VarChar).Value = model.ProductUnitCost;
                serverController.cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = model.ServiceId;
                serverController.cmd.Parameters.Add("@qnt", SqlDbType.VarChar).Value = model.QuantitySold;
                serverController.cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = model.ServiceDate;
                //
                serverController.connection.Open();
                serverController.cmd.ExecuteNonQuery();
                serverController.connection.Close();
                //
            }
            catch (Exception ex)
            {
                serverController.connection.Close();
                MessageBox.Show(ex.Message,"Service Server Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// GET SERVICE DATA BY THE SERVICE ID
        /// </summary>
        /// <param name="serviceId"></param>
        /// <returns></returns>
        public DataTable GetServicesByServiceId(string serviceId)
        {
            serverController.da = new SqlDataAdapter();
            serverController.dt = new DataTable();
            try
            {
                serverController.cmd = new SqlCommand("select productName,productId,serviceCost,productUnitCost,serviceId,quantitySold,serviceDate from nbs_service where serviceId=@sid", serverController.connection);
                serverController.cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = serviceId;
                serverController.connection.Open();
                serverController.da.SelectCommand = serverController.cmd;
                serverController.da.Fill(serverController.dt);
                serverController.connection.Close();
                return serverController.dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Get Services By ServiceID Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return serverController.dt;
        }

        /// <summary>
        /// GET SALE SERVICE BY SERVICE DATE
        /// </summary>
        /// <param name="serviceDate"></param>
        /// <returns></returns>
        public DataTable GetServicesByServiceDate(string serviceDate)
        {
            serverController.da = new SqlDataAdapter();
            serverController.dt = new DataTable();
            try
            {
                serverController.cmd = new SqlCommand("select productName,productId,serviceCost,productUnitCost,serviceId,quantitySold,serviceDate from nbs_service where serviceDate=@sdt", serverController.connection);
                serverController.cmd.Parameters.Add("@sdt", SqlDbType.VarChar).Value = serviceDate;
                serverController.connection.Open();
                serverController.da.SelectCommand = serverController.cmd;
                serverController.da.Fill(serverController.dt);
                serverController.connection.Close();
                return serverController.dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Get Services By ServiceDate Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return serverController.dt;
        }
    }
}
