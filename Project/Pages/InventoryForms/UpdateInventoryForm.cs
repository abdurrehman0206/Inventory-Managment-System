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
                dgvProduct.Columns[0].HeaderText="ProductID";
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


        //txtFields Events
        private void txtItemName_MouseClick(object sender, MouseEventArgs e)
        {
            itemNamePanel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void txtItemName_Leave(object sender, EventArgs e)
        {
            itemNamePanel.BorderStyle = BorderStyle.None;
        }

        private void txtItemPrice_MouseClick(object sender, MouseEventArgs e)
        {
            itemPricePanel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void txtItemPrice_Leave(object sender, EventArgs e)
        {
            itemPricePanel.BorderStyle = BorderStyle.None;
        }
        private void txtItemPrice_TextChanged(object sender, EventArgs e)
        {
            txtItemPrice.Text = new string(txtItemPrice.Text.Where(char.IsDigit).ToArray());
        }
        private void txtItemCat_MouseClick(object sender, MouseEventArgs e)
        {
            pnlItemCategory.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pnlItemCategory_Leave(object sender, EventArgs e)
        {
            pnlItemCategory.BorderStyle = BorderStyle.None;
        }

        private void txtItemQuan_MouseClick(object sender, MouseEventArgs e)
        {
            pnlItemQuantity.BorderStyle = BorderStyle.FixedSingle;
        }

        private void txtItemQuan_Leave(object sender, EventArgs e)
        {
            pnlItemQuantity.BorderStyle = BorderStyle.None;
        }
        private void txtItemQuan_TextChanged(object sender, EventArgs e)
        {

            txtItemQuan.Text = new string(txtItemQuan.Text.Where(char.IsDigit).ToArray());

        }
        private void rtbItemDesc_MouseClick(object sender, MouseEventArgs e)
        {
            rtbItemDesc.BorderStyle = BorderStyle.FixedSingle;
        }

        private void rtbItemDesc_Leave(object sender, EventArgs e)
        {
            rtbItemDesc.BorderStyle = BorderStyle.None;
        }

     
    }
}
