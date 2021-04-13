using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class RemoveItemModel
    {
        public string ItemId { get; set; }
        public string ItemQuantity { get; set; }
        public string ItemIndex { get; set; }
    }
}
