
namespace Project.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> OrderedProducts { get; set; }
        public string CustomerName { get; set; }
        public string ShippingAddress { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsShipped { get; set; }
        public DateTime ShippedDate { get; set; }
    }
}
