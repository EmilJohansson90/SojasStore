using API.DTO;
using DAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public List<EmployeeListDTO> EmployeeList()
        {
            var service = new EmployeeService();
            var employeeList = service.GetEmployeeList();
            var responsibleSsn = service.GetResponsibleSsn();

            var employeeInfoListDTO = new List<EmployeeInfoDTO>().ToList();

            foreach (var employee in employeeList)
            {
                employeeInfoListDTO.Add(new EmployeeInfoDTO()
                {
                    Name = employee.Name,
                    IsResponsible = responsibleSsn.Contains(employee.Ssn)
                });
            }

            var employeeListDTO = new List<EmployeeListDTO>();

            employeeListDTO.Add(new EmployeeListDTO
            {
                Count = employeeList.Count,
                EmployeeInfo = employeeInfoListDTO
            });

            return employeeListDTO;
        }
    }
}
