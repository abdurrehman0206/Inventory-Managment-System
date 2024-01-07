
using MongoDB.Bson;

namespace Project.Models
{
    public class Order
    {
        public ObjectId _id { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> OrderedProducts { get; set; }
        public string CustomerName { get; set; }
        public string ShippingAddress { get; set; }
        public double TotalAmount { get; set; }
        public bool IsShipped { get; set; }
        public DateTime ShippedDate { get; set; }
    }
}
