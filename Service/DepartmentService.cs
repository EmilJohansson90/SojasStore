using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DepartmentService
    {
        public List<Email> EmailList()
        {
            var emailList = new List<Email>();
            using (var context = new SojasStoreContext())
            {
                emailList = context.Emails.ToList();
            }
            return emailList;
        }

        public List<Department> DepartmentList()
        {
            var departmentList = new List<Department>();
            using(var context = new SojasStoreContext())
            {
                departmentList = context.Departments.ToList();
            }
            return departmentList;
        }
    }
}
