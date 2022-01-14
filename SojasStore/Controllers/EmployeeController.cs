using API.DTO;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace API.Controllers
{
    [Route("employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        
        [HttpGet("ListAllEmployees")]
        public List<Employee> ListAllEmployees()
        {
            var service = new EmployeeService();
            return service.ListAllEmployees();
        }

        [HttpGet("GetEmployee/{ssn}")]
        public Employee GetEmployee(int ssn)
        {
            var service = new EmployeeService();
            return service.GetEmployee(ssn);
        }

        [HttpPost("AddEmployee")]
        public void AddEmployee(EmployeeDTO employee)
        {
            var service = new EmployeeService();
            service.AddEmployee(
                new Employee()
                {
                    EmployeeId = employee.EmployeeId,
                    Ssn = employee.Ssn,
                    Name = employee.Name,
                    PhoneNumber = employee.PhoneNumber
                }
            );
        }        
    }
}
