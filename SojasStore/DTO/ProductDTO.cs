using DAL;

namespace API.DTO
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public int BarCode { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public DateTime BestBefore { get; set; }
        public double Price { get; set; }
        public List<Department> Departments { get; set; }
    }
}
