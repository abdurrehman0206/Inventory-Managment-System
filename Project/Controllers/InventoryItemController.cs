using MongoDB.Driver;
using Project.Models;

namespace Project.Controllers
{


    public class InventoryItemController
    {
        private readonly IMongoCollection<InventoryItem> _inventoryItemCollection;

        public InventoryItemController(string connectionString, string databaseName, string collectionName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _inventoryItemCollection = database.GetCollection<InventoryItem>(collectionName);
        }

        public void AddInventoryItem(InventoryItem inventoryItem)
        {
            try
            {
                _inventoryItemCollection.InsertOne(inventoryItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding inventory item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public InventoryItem? GetInventoryItem(int inventoryItemId)
        {
            try
            {
                return _inventoryItemCollection.Find(i => i.InventoryItemId == inventoryItemId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting inventory item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<InventoryItem> GetAllInventoryItems()
        {
            try
            {
                return _inventoryItemCollection.Find(_ => true).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting all inventory items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<InventoryItem>();
            }
        }

    }

}