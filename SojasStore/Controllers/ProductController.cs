using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL;
using Service;
using API.DTO;
using DAL.Models;

namespace API.Controllers
{
    [Route("products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // --  Inlämningsuppgifter
        // -- 1A

        [HttpGet("count")]
        public List<SortedInventoryRequest> SortedList()
        {
            var service = new ProductService();
            return service.GetSortedList();
        }

        // -- 1B

        [HttpPut("update")]
        public void Update([FromBody] UpdateInventoryDTO updateInventoryDTO)
        {
            var service = new ProductService();
            service.UpdateProductAmount(updateInventoryDTO.ProductId, updateInventoryDTO.NewAmount);
        }   
    }
}
