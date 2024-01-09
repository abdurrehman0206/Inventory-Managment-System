

using Project.Controllers;

namespace Project
{
    public partial class DashboardForm : Form
    {
        private readonly ProductController _inventoryController;
        private readonly OrderController _orderController;
        private readonly SupplierController _supplierController;
        public DashboardForm()
        {
            InitializeComponent();
            _inventoryController = new ProductController();
            _orderController = new OrderController();
            _supplierController = new SupplierController();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                int totalItemsInInventory = _inventoryController.GetTotalItemsInInventory();
                double totalPriceOfItemsInInventory = _inventoryController.GetTotalPriceOfItemsInInventory();
                int totalOrdersPlaced = _orderController.GetTotalOrdersPlaced();
                double totalOrdersPlacedPrice = _orderController.GetTotalOrdersPlacedPrice();
                int totalSales = _orderController.GetTotalSales();
                int totalSuppliers = _supplierController.GetTotalSuppliers();

                lblTotalItems.Text = $"Total Items in Inventory: {totalItemsInInventory}";
                lblTotalPrice.Text = $"Total Price of Items in Inventory: {totalPriceOfItemsInInventory:C}";
                lblTotalOrders.Text = $"Total Orders Placed: {totalOrdersPlaced}";
                lblTotalOrdersPrice.Text = $"Total Orders Placed Price: {totalOrdersPlacedPrice:C}";
                lblTotalSales.Text = $"Total Sales: {totalSales}";
                lblTotalSuppliers.Text = $"Total Suppliers: {totalSuppliers}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
