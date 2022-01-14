using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace Service
{
    public class EmployeeService
    {
        public List<Employee> ListAllEmployees()
        {
            using (var context = new SojasStoreContext())
            {
                return context.Employees
                    .ToList()
                    ;
            }
        }

        public Employee GetEmployee(int ssn)
        {
            using (var context = new SojasStoreContext())
            {
                return context.Employees.Find(ssn);
            }
        }

        public void AddEmployee(Employee employee)
        {
            using (var context = new SojasStoreContext())
            {

                context.Add(employee);
                context.SaveChanges();
            }
        }
    }
}
