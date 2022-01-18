using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Ingredients
    {
        public string Ingredient { get; set; }
        public Product Product { get; set; }
        public int ProductProductId { get; set; }
    }
}
