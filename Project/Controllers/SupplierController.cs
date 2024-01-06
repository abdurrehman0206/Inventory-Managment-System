using MongoDB.Driver;
using Project.Models;

namespace Project.Controllers
{

    public class SupplierController
    {
        private readonly IMongoCollection<Supplier> _supplierCollection;

        public SupplierController(string connectionString, string databaseName, string collectionName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _supplierCollection = database.GetCollection<Supplier>(collectionName);
        }

        public void AddSupplier(Supplier supplier)
        {
            try
            {
                _supplierCollection.InsertOne(supplier);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Supplier? GetSupplier(int supplierId)
        {
            try
            {
                return _supplierCollection.Find(s => s.SupplierId == supplierId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<Supplier> GetAllSuppliers()
        {
            try
            {
                return _supplierCollection.Find(_ => true).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting all suppliers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Supplier>();
            }
        }

    }

}