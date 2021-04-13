using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
   public  class StaticProductModel
    {
        public static string PID { get; set; }
        public static string ProductId { get; set; }
        public static string ProductName { get; set; }
        public static string ProductQuantity { get; set; }
        public static string ProductSellingPrice { get; set; }
        public static string ProductCostPrice { get; set; }
        public static string ProductCategory { get; set; }


        /// <summary>
        /// SET PARAMS FOR THE STATIC PRODUCT MODEL
        /// </summary>
        /// <param name="model"></param>
        public void SetStaticProductModel(ProductModel model)
        {
            PID = model.ID;
            ProductId = model.ProductID;
            ProductName = model.ProductName;
            ProductQuantity = model.ProductQuantity;
            ProductSellingPrice = model.ProductSellingPrice;
            ProductCostPrice = model.ProductCostPrice;
            ProductCategory = model.ProductCategory;
        }
    }
}
