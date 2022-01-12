using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Product
    {
        public string Name { get; set; }
        [Key]
        public int BarCode { get; set; }
        public int Amount { get; set; }
        public DateTime BestBefore { get; set; }
        public float Price { get; set; }
    }
}
