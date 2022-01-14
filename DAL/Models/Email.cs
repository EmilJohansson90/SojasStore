using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Email
    {
        public string Emails { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeSsn { get; set; }
    }
}
