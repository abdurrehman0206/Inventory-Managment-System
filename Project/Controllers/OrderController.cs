using MongoDB.Driver;
using Project.Models;

namespace Project.Controllers
{

    public class OrderController
    {
        private readonly IMongoCollection<Order> _orderCollection;

        public OrderController(string connectionString, string databaseName, string collectionName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _orderCollection = database.GetCollection<Order>(collectionName);
        }

        public void AddOrder(Order order)
        {
            try
            {
                _orderCollection.InsertOne(order);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Order? GetOrder(int orderId)
        {
            try
            {
                return _orderCollection.Find(o => o.OrderId == orderId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<Order> GetAllOrders()
        {
            try
            {
                return _orderCollection.Find(_ => true).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting all orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Order>();
            }
        }

    }

}