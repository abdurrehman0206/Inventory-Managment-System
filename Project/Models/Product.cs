

using MongoDB.Bson;

namespace Project.Models
{
    public class Product
    {
        public BsonObjectId _id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        //public DateTime CreatedAt { get; set; }
        //public DateTime UpdatedAt { get; set; }
       
    }
}
