using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Employee
    {
        [Key]
        public int PersonalId { get; set; }
        public int Ssn { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

    }
}
