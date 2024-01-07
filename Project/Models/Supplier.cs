
using MongoDB.Bson;
namespace Project.Models
{
    public class Supplier
    {
        public BsonObjectId _id { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
