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
        public void UpdateProductAmount(int productId, int newAmount)
        {
            var service = new ProductService();
            service.UpdateProductAmount(productId, newAmount);
        }

        [HttpPut("update2")]
        public void Update([FromBody] UpdateRequest updateRequest)
        {
            var service = new ProductService();
            service.UpdateProductAmount2(updateRequest);
        }



        // -- Egna övningar
        [HttpGet("ListAllProducts")]
        public List<Product> ListAllProducts()
        {
            var service = new ProductService();
            return service.ListAllProducts();
        }
    }
}
