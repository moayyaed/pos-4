using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class ProductModel
    {
        public string ProductID { get; set; }
        public string ID { get; set; }
        public string ProductName { get; set; }
        public string ProductQuantity { get; set; }
        public string ProductCostPrice { get; set; } 
        public string  ProductSellingPrice { get; set; } 
        public string ProductCategory { get; set; } 
        public string type { get; set; } = "";
        public Boolean Error { get; set; } = true;


    }
}
