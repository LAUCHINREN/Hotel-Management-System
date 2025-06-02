using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    public class CleaningSupply
    {
        public string SuppliesID { get; set; }
        public string ItemName { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public decimal CostPerUnit { get; set; }
        public string Supplier { get; set; }
    }
}
