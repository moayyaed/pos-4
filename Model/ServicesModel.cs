using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
   public class ServicesModel
    {
        public string ProductName { get; set; }
        public string ProductId { get; set; }
        public string ProductCategory { get; set; }
        public string ProductUnitCost { get; set; }
        public string ServiceId { get; set; }
        public string QuantitySold { get; set; }
        public string ServiceDate { get; set; }
        public string ServiceTotalCost { get; set; }

    }
}
