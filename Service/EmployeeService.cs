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
        public List<Employee> GetEmployeeList()
        {
            var employeeList = new List<Employee>();
            using(var context = new SojasStoreContext())
            {
                employeeList = context.Employees.ToList();
            }
            return employeeList; 
        }

        public List<int> GetResponsibleSsn()
        {
            List<Employee> employees = GetEmployeeList();
            List<int> ssnList = new List<int>();

            foreach(var employee in employees)
            {
                ssnList.Add(employee.Ssn);
            }
            return ssnList;
        }
        
    }
}
