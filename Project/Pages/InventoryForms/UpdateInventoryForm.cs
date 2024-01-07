using MongoDB.Bson;
using Project.Controllers;
using Project.Models;

namespace Project.Pages.InventoryForms
{
    public partial class UpdateInventoryForm : Form
    {
        private readonly ProductController _productController;
        public UpdateInventoryForm()
        {
            InitializeComponent();
            _productController = new ProductController();
        }
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProduct.Rows[e.RowIndex];
                txtItemId.Text = row.Cells["_id"].Value.ToString();
                txtItemName.Text = row.Cells["Name"].Value.ToString();
                txtItemPrice.Text = row.Cells["Price"].Value.ToString();
                txtItemQuan.Text = row.Cells["Quantity"].Value.ToString();
                txtItemCat.Text = row.Cells["Category"].Value.ToString();
                rtbItemDesc.Text = row.Cells["Description"].Value.ToString();
            }
        }
        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectId productIdToUpdate = ObjectId.Parse(txtItemId.Text);
                Product updatedProduct = new Product
                {
                    Name = txtItemName.Text,
                    Price = Convert.ToDouble(txtItemPrice.Text),
                    Quantity = Convert.ToInt32(txtItemQuan.Text),
                    Category = txtItemCat.Text,
                    Description = rtbItemDesc.Text
                };
                _productController.UpdateProduct(productIdToUpdate, updatedProduct);
                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
                ClearTextFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void LoadProducts()
        {
            try
            {
                dgvProduct.DataSource = _productController.GetAllProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateInventoryForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
