using MongoDB.Bson;

namespace Project.Models
{
    public class OrderItem
    {
        public ObjectId _id { get; set; }
        public ObjectId ProductID { get; set; }
        public int Quantity { get; set; }
    }
}
