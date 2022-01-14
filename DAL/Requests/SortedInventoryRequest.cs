using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SortedInventoryRequest
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public string InventoryStatus { get; set; }
    }
}
