using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
   public class SalesModel
    {

        public string ServiceId { get; set; }
        public string TransactionAmount { get; set; }
        public string TransactionDate { get; set; }
        public string CustomerName { get; set; }
        public string SalesPerson { get; set; }
    }
}
