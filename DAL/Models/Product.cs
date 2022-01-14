using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Product
    {
        public int ProductId { get; set; }
        public int BarCode { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public DateTime BestBefore { get; set; }
        public double Price { get; set; }
        public List<Department> Departments { get; set; }
        public Employee? CheckedBy { get; set; }
        public int? CheckedBySsn { get; set; }
        public DateTime? CheckedDate { get; set; }
        public Sale? Sale { get; set; }
        

    }
}
