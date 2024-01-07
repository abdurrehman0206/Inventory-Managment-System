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

        public Product? GetProduct(int productId)
        {
            try
            {
                return _productCollection.Find(p => p.ProductId == productId).FirstOrDefault();

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
    }

}