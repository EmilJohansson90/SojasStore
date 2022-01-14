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
        //[HttpGet]
        //public List<DepartmentEmailDTO> ListDepartmentEmail()
        //{
        //    //var service = new DepartmentService();
        //    //var emailList = service.EmailList();
        //    //var departmentList = service.DepartmentList();
        //    //var result = new List<DepartmentEmailDTO>();

        //    //foreach (var email in emailList)
        //    //{
        //    //    result.Add(new DepartmentEmailDTO
        //    //    {
        //    //        DepartmentName = department.Name,
        //    //        Email
        //    //    });
        //    //};


        //    return result;
        //}
    }
}
