using MongoDB.Driver;
using Project.Models;

namespace Project.Controllers
{

    public class OrderController
    {
        private readonly IMongoCollection<Order> _orderCollection;
        private readonly IMongoCollection<Product> _productCollection;

        public OrderController()
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IMSDB";
            string orderCollectionName = "Orders";
            string productCollectionName = "Products";

            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);

            _orderCollection = database.GetCollection<Order>(orderCollectionName);
            _productCollection = database.GetCollection<Product>(productCollectionName);
        }
        public int GetTotalOrdersPlaced()
        {
            try
            {
                return _orderCollection.AsQueryable().Count();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting total orders placed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public double GetTotalOrdersPlacedPrice()
        {
            try
            {
                return _orderCollection.AsQueryable().Sum(order => order.TotalAmount);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting total orders placed price: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public int GetTotalSales()
        {
            try
            {
                return _orderCollection.AsQueryable().Count(order => order.IsShipped);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting total sales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public List<Product> GetAvailableProducts()
        {
            try
            {
                return _productCollection.Find(_ => true).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting available products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Product>();
            }
        }
        public void AddProductToOrder(Order order, Product product, int quantity)
        {
            try
            {
                if (order == null)
                {
                    MessageBox.Show("Order cannot be null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (product == null)
                {
                    MessageBox.Show("Product cannot be null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the product is already in the order
                Product existingProduct = order.OrderedProducts?.Find(p => p._id == product._id);

                if (existingProduct != null)
                {
                    // If the product is already in the order, update the quantity
                    existingProduct.Quantity += quantity;
                }
                else
                {
                    // If the product is not in the order, add a new Product
                    Product newProduct = new Product
                    {
                        _id = product._id,
                        Name = product.Name,
                        Price = product.Price,
                        Quantity = quantity,
                        Description = product.Description,
                        Category = product.Category,
                    };

                    // Make sure OrderedProducts is initialized before adding
                    order.OrderedProducts ??= new List<Product>();
                    order.OrderedProducts.Add(newProduct);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception by showing an error message
                MessageBox.Show($"Error adding product to order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         public void AddProductToOrder(Order order, Product product, int quantity)
        {
            try
            {
                Product? existingProduct = order.OrderedProducts.Find(p => p._id == product._id);

                if (existingProduct != null)
                {
                    existingProduct.Quantity += quantity;
                }
                else
                {
                    Product newProduct = new Product
                    {
                        _id = product._id,
                        Name = product.Name,
                        Price = product.Price,
                        Category = product.Category,
                        Description = product.Description,
                        Quantity = quantity
                    };
                  

                    order.OrderedProducts.Add(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product to order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        */
        public void PlaceOrder(Order order)
        {
            try
            {
                order.OrderDate = DateTime.Now;
                order.TotalAmount = CalculateTotalAmount(order);
                _orderCollection.InsertOne(order);
                MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error placing order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private double CalculateTotalAmount(Order order)
        {
            double totalAmount = 0;

            foreach (var product in order.OrderedProducts)
            {
                totalAmount += product.Quantity * product.Price;
            }

            return totalAmount;
        }

    }

}