using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService
    {
        // -- 1A / 4A
        public List<SortedInventoryRequest> GetSortedList()
        {
            using (var context = new SojasStoreContext())
            {
                var products = context.Products
                    .OrderBy(p => p.Amount)
                    .ToList()
                    ;

                List<SortedInventoryRequest> sortedList = new List<SortedInventoryRequest>();
                string inventoryStatus;

                foreach(Product product in products)
                {
                    if (product.Amount >= 4) { inventoryStatus = "Ok"; }
                    else if (product.Amount >= 1) { inventoryStatus = "Snart slut"; }
                    else { inventoryStatus = "Slut"; }

                    sortedList.Add(new SortedInventoryRequest()
                    {
                        Amount = product.Amount,
                        Name = product.Name,
                        InventoryStatus = inventoryStatus
                    });
                }

                return sortedList;
            }
        }
        

        // -- 1B
        
        public void UpdateProductAmount(int productId, int newAmount)
        {
            using (var context = new SojasStoreContext())
            {
                var product = context.Products.First(p => p.ProductId == productId);
                product.Amount = newAmount;
                context.SaveChanges();
            }
        }
        
        public List<string> ProductList(string department, int count)
        {            
            using (var context = new SojasStoreContext())
            {
                var productList = context.Products
                    .Where(p => p.Amount <= count && (p.Departments.Any(d => d.Name == department)))
                    .Include(d => d.Departments)
                    .Select(p => p.Name)
                    .ToList();
                return productList;
            }
        }


    }
}
