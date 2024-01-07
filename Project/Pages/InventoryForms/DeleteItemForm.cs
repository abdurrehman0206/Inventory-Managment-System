using MongoDB.Bson;
using Project.Controllers;
using Project.Models;

namespace Project.Pages.InventoryForms
{
    public partial class DeleteItemForm : Form
    {
        private readonly ProductController _productController;
        public DeleteItemForm()
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
                dgvProduct.Columns[0].HeaderText = "ProductID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteItemForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProduct.Rows[e.RowIndex];
                txtItemId.Text = row.Cells["_id"].Value.ToString() ?? string.Empty;
                txtItemName.Text = row.Cells["Name"].Value.ToString() ?? string.Empty;
                txtItemPrice.Text = row.Cells["Price"].Value.ToString() ?? string.Empty;
                txtItemQuan.Text = row.Cells["Quantity"].Value.ToString() ?? string.Empty;
                txtItemCat.Text = row.Cells["Category"].Value.ToString() ?? string.Empty;
                rtbItemDesc.Text = row.Cells["Description"].Value.ToString() ?? string.Empty;
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {

                _productController.DeleteProduct(ObjectId.Parse(txtItemId.Text));
                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
                ClearTextFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearTextFields()
        {
            txtItemId.Text = string.Empty;
            txtItemName.Text = string.Empty;
            txtItemPrice.Text = string.Empty;
            txtItemQuan.Text = string.Empty;
            txtItemCat.Text = string.Empty;
            rtbItemDesc.Text = string.Empty;
        }
    }
}

