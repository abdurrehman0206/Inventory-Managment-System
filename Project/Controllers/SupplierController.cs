using MongoDB.Bson;
using MongoDB.Driver;
using Project.Models;

namespace Project.Controllers
{

    public class SupplierController
    {
        private readonly IMongoCollection<Supplier> _supplierCollection;

        public SupplierController(string connectionString = "mongodb://localhost:27017", string databaseName = "IMSDB", string collectionName = "Suppliers")
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _supplierCollection = database.GetCollection<Supplier>(collectionName);
        }
        public int GetTotalSuppliers()
        {
            try
            {
                return _supplierCollection.AsQueryable().Count();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting total suppliers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
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
                return _supplierCollection.Find(s => s._id == supplierId).FirstOrDefault();
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

        public void DeleteSupplier(ObjectId supplierId)
        {
            try
            {
                var filter = Builders<Supplier>.Filter.Eq(s => s._id, supplierId);
                _supplierCollection.DeleteOne(filter);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting supolier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateSupplier(ObjectId supplierId, Supplier updatedSupplier)
        {
            try
            {
                var filter = Builders<Supplier>.Filter.Eq(s => s._id, supplierId);
                var update = Builders<Supplier>.Update
                    .Set(s => s.Name, updatedSupplier.Name)
                    .Set(s => s.Address, updatedSupplier.Address)
                    .Set(s => s.ContactNumber, updatedSupplier.ContactNumber)
                    .Set(s => s.Email, updatedSupplier.Email);
                _supplierCollection.UpdateOne(filter, update);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}