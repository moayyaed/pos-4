using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Model;
using System.Data;
using System.Windows.Forms;

namespace POS.Utils
{
   
    public class Utils

    {
        public double totalProductsold = 0;
        public double totalReturns =0;
        public  string serverConnection = "connecting to server";
        public  string startUp = "loading.......";
        public  string loadResources = "loading resources";
        public  string storeConnection = "loading store resources";
        public  string connectedState = "connection successful, Please wait...";
        public  string developerLogo = "NovinceProgrammers (c) " + DateTime.Now.Year.ToString();

        ///PRODUCT ID;
        ///
        public static string ProductIDModel = "NBS";

        ///USER ACCOUNT LOGIN AND REGISTRATION CONSTANTS
        ///
        public static string USERNAME_CONSTANT = "username";
        public static string PHONE_CONSTANT = "phone";
        public static  string PASSWORD_CONSTANT = "password";


        /// <summary>
        /// PREPARE THE SALES MODEL
        /// </summary>
        /// <param name="sid"></param>
        /// <param name="amount"></param>
        /// <param name="dte"></param>
        /// <param name="cname"></param>
        /// <param name="sname"></param>
        /// <returns></returns>
        public SalesModel PrepareSalesModel(string sid, string amount,string dte,string cname,string sname)
        {
            SalesModel smodel = new SalesModel();
            smodel.CustomerName = cname;
            smodel.TransactionAmount = amount;
            smodel.SalesPerson = sname;
            smodel.TransactionDate = dte;
            smodel.ServiceId = sid;
            //
            return smodel;
        }

        /// <summary>
        /// PREPARE THE SERVICES MODEL
        /// </summary>
        /// <param name="item"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public ServicesModel PrepareServiceModel(DataRow dataRow, string date,string serviceid)
        {
            ServicesModel serviceModel = new ServicesModel();
            serviceModel.ProductId = dataRow[0].ToString();
            serviceModel.ProductUnitCost = dataRow[3].ToString();
            serviceModel.ProductName = dataRow[1].ToString();
            serviceModel.QuantitySold = dataRow[2].ToString();
            serviceModel.ServiceDate = date;
            serviceModel.ServiceId = serviceid;
            serviceModel.ServiceTotalCost = dataRow[4].ToString();
            return serviceModel;
        }

        /// <summary>
        /// PREPARE PRODUCT MODEL
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public ProductModel PrepareProductModel(DataTable dt)
        {
            ProductModel pmodel = new ProductModel();
            foreach (DataRow dataRow in dt.Rows)
            {
                pmodel.ID = dataRow["id"].ToString();
                pmodel.ProductID = dataRow["productId"].ToString();
                pmodel.ProductName = dataRow["name"].ToString();
                pmodel.ProductQuantity = dataRow["quantity"].ToString();
                pmodel.ProductCostPrice = dataRow["costPrice"].ToString();
                pmodel.ProductSellingPrice = dataRow["sellingPrice"].ToString();
                pmodel.ProductCategory = dataRow["productCategory"].ToString();
            }
            return pmodel;
        }

        /// <summary>
        /// FORMAT PRODUCT QUANTITY
        /// </summary>
        /// <param name="old"></param>
        /// <param name="newvalue"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public ProductModel FormatProductQuantity(string old, string newvalue, string type)
        {
            ProductModel model = new ProductModel();

            switch (type)
            {
                case "add":
                    model.ProductQuantity=(Int32.Parse(old) + Int32.Parse(newvalue)).ToString();
                    return model;

                case "remove":

                    model.ProductQuantity=(Int32.Parse(old) - Int32.Parse(newvalue)).ToString();
                    return model;
                default:
                    return model;
            }

        }

        /// <summary>
        /// type=saleReport and serviceReport
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public ReturnsTotalModel CalculateReturns(DataTable dt,string type)
        {
            ReturnsTotalModel returnstotalModel = new ReturnsTotalModel();
            totalReturns = 0;
            totalProductsold = 0;
            if (dt.Rows.Count <= 0)
            {
                returnstotalModel.TotalProductsSold = totalProductsold.ToString();
                returnstotalModel.TotalReturnsMade = totalReturns.ToString();
            }
            else
            {
                switch (type)
                {
                    case "saleReport":
                        foreach (DataRow dataRow in dt.Rows)
                        {
                            totalReturns = Double.Parse((totalReturns + Double.Parse(dataRow["transactionAmount"].ToString())).ToString());
                        }
                        returnstotalModel.TotalReturnsMade = totalReturns.ToString();
                        returnstotalModel.TotalProductsSold = totalProductsold.ToString();
                        return returnstotalModel;
                    case "serviceReport":
                        foreach (DataRow dataRow in dt.Rows)
                        {
                            totalReturns = Double.Parse((totalReturns + Double.Parse(dataRow["serviceCost"].ToString())).ToString());

                            totalProductsold = Double.Parse((totalProductsold + Double.Parse(dataRow["quantitySold"].ToString())).ToString());


                        }
                        returnstotalModel.TotalReturnsMade = totalReturns.ToString();
                        returnstotalModel.TotalProductsSold = totalProductsold.ToString();
                        return returnstotalModel;
                    default:
                        return returnstotalModel;
                }
            }
            return returnstotalModel;
        }

        /// <summary>
        /// GET THE INITIAL START UP FOR THE PRODUCT ID
        /// </summary>
        /// <returns></returns>
        public string AppendProductID()
        {
            string Initial = LocalResources.AppConfigResource.ProductID;
            return Initial;
        }

        /// <summary>
        /// GET THE INITIAL START UP FOR THE SERVICES ID
        /// </summary>
        /// <returns></returns>
        public string AppendServiceID()
        {
            return LocalResources.AppConfigResource.ServiceID;
        }
    }
}
