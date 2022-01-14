using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string? Name { get; set; }
        public List<Product> Products { get; set; }
        public int InChargeSsn { get; set; }
        public Employee? InCharge { get; set; }

    }
}
