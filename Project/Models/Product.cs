

namespace Project.Models
{
    public class Product
    {
        private static int autoId = 1;
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }
        //public DateTime CreatedAt { get; set; }
        //public DateTime UpdatedAt { get; set; }
        public Product()
        {
            ProductId = autoId++;
        }
    }
}
