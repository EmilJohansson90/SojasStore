using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ssn { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public List<Product>? Checked { get; set; }
        public List<Department>? InChargeOf { get; set; }
        public Employee? Mentor { get; set; }
        public List<Email>? Emails { get; set; }

    }
}
