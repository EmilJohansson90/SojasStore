using API.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace API.Controllers
{
    [Route("departments")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        [HttpGet]
        public List<DepartmentEmailDTO> GetDepartmentsWithMail()
        {
            var service = new DepartmentService();
            var departmentList = service.DepartmentList();
            var emailList = service.EmailList();

            var depMailList = new List<DepartmentEmailDTO>();

            foreach (var department in departmentList)
            {
                var stringList = new List<string>();
                foreach (var email in emailList)
                {
                    if (email.EmployeeSsn == department.InChargeSsn)
                    {
                        stringList.Add(email.Emails);
                    }
                }
                depMailList.Add(new DepartmentEmailDTO()
                {
                    DepartmentName = department.Name,
                    Email = stringList
                }); ;
            }

            return depMailList;
        }
    }
}
