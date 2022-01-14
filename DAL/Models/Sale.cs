using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Discount { get; set; }
        public List<Product> ProductsOnSale { get; set; }
    }
}
