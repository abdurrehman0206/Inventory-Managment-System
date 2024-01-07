using Project.Controllers;
using Project.Models;

namespace Project.Pages.InventoryForms
{
    public partial class ViewInventoryForm : Form
    {
        private readonly ProductController _productController;
        public ViewInventoryForm()
        {
            InitializeComponent();
            _productController = new ProductController();
        }
        private void LoadProducts()
        {
            try
            {
                List<Product> products = _productController.GetAllProducts();
                dgvProduct.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewInventoryForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
