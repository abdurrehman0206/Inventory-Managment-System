using MongoDB.Bson;
using MongoDB.Driver;
using Project.Models;

namespace Project.Controllers
{

    public class ProductController
    {
        private readonly IMongoCollection<Product> _productCollection;

        public ProductController()
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IMSDB";
            string collectionName = "Products";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _productCollection = database.GetCollection<Product>(collectionName);
        }
        public int GetTotalItemsInInventory()
        {
            try
            {
                return _productCollection.AsQueryable().Sum(item => item.Quantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting total items in inventory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public double GetTotalPriceOfItemsInInventory()
        {
            try
            {
                return _productCollection.AsQueryable().Sum(item => item.Quantity * item.Price);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting total price of items in inventory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public double GetAveragePriceOfItemsInInventory()
        {
            try
            {
                return _productCollection.AsQueryable().Average(item => item.Price);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting average price of items in inventory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public void AddProduct(Product product)
        {
            try
            {
                _productCollection.InsertOne(product);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Product GetProduct(ObjectId productId)
        {
            try
            {
                var filter = Builders<Product>.Filter.Eq(p => p._id, productId);
                return _productCollection.Find(filter).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                return _productCollection.Find(_ => true).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting all products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Product>();
            }
        }
        public void DeleteProduct(ObjectId productId)
        {
            try
            {
                var filter = Builders<Product>.Filter.Eq(p => p._id, productId);
                _productCollection.DeleteOne(filter);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateProduct(ObjectId productId, Product updatedProduct)
        {
            try
            {
                var filter = Builders<Product>.Filter.Eq(p => p._id, productId);
                var update = Builders<Product>.Update
                    .Set(p => p.Name, updatedProduct.Name)
                    .Set(p => p.Price, updatedProduct.Price)
                    .Set(p => p.Quantity, updatedProduct.Quantity)
                    .Set(p => p.Category, updatedProduct.Category)
                    .Set(p => p.Description, updatedProduct.Description);
                _productCollection.UpdateOne(filter, update);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}