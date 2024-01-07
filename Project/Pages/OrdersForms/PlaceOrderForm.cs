using MongoDB.Bson;
using Project.Controllers;
using Project.Models;

namespace Project.Pages.OrdersForms
{
    public partial class PlaceOrderForm : Form
    {
        private readonly OrderController _orderController;
        private List<Product> _availableProducts;
        public PlaceOrderForm()
        {
            InitializeComponent();
            _orderController = new OrderController();
            _availableProducts = _orderController.GetAvailableProducts();

            cmbProducts.DataSource = _availableProducts;
            cmbProducts.DisplayMember = "Name";
            cmbProducts.ValueMember = "_id";
            dgvOrderDetails.Columns.Add("_id", "ProductId");
            dgvOrderDetails.Columns.Add("Name", "Product Name");
            dgvOrderDetails.Columns.Add("Description", "Description");
            dgvOrderDetails.Columns.Add("Quantity", "Quantity");
            dgvOrderDetails.Columns.Add("Category", "Category");
            dgvOrderDetails.Columns.Add("Price", "Price");
            dgvOrderDetails.Columns["Name"].ReadOnly = true;
            dgvOrderDetails.Columns["Price"].ReadOnly = true;
        }

        //txtName Events
        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            pnlName.BorderStyle = BorderStyle.FixedSingle;

        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            pnlName.BorderStyle = BorderStyle.None;
        }


        //txtAddress Events
        private void txtAddress_MouseClick(object sender, MouseEventArgs e)
        {
            pnlAddress.BorderStyle = BorderStyle.FixedSingle;
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            pnlAddress.BorderStyle = BorderStyle.None;
        }


        //dgvOrder Events
        private void dgvOrder_MouseClick(object sender, MouseEventArgs e)
        {
            dgvOrderDetails.BorderStyle = BorderStyle.FixedSingle;
        }

        private void dgvOrder_Leave(object sender, EventArgs e)
        {
            dgvOrderDetails.BorderStyle = BorderStyle.None;
            if (dgvOrderDetails.SelectedCells.Count > 0)
            {

                dgvOrderDetails.ClearSelection();
            }
        }
        //txtQuantity Events 
        private void txtQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            pnlQuantity.BorderStyle = BorderStyle.FixedSingle;
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            pnlQuantity.BorderStyle = BorderStyle.None;
        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            txtQuantity.Text = new string(txtQuantity.Text.Where(char.IsDigit).ToArray());
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetails.Rows.Count == 1)
            {
                MessageBox.Show("Please add products to the order before placing it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

                Order order = new Order
                {
                    CustomerName = txtName.Text,
                    ShippingAddress = txtAddress.Text,
                    IsShipped = false,
                    ShippedDate = DateTime.MinValue
                };


                for (int i = 0; i < dgvOrderDetails.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dgvOrderDetails.Rows[i];

                    if (row.Cells["_id"].Value != null &&
                        row.Cells["Name"].Value != null &&
                        row.Cells["Price"].Value != null &&
                        row.Cells["Quantity"].Value != null &&
                        row.Cells["Category"].Value != null &&
                        row.Cells["Description"].Value != null)
                    {
                        Product orderedProduct = new Product
                        {
                            _id = (BsonObjectId)row.Cells["_id"].Value,
                            Name = (string)row.Cells["Name"].Value,
                            Price = (double)row.Cells["Price"].Value,
                            Quantity = (int)row.Cells["Quantity"].Value,
                            Category = (string)row.Cells["Category"].Value,
                            Description = (string)row.Cells["Description"].Value,
                        };

                        _orderController.AddProductToOrder(order, orderedProduct, orderedProduct.Quantity);
                    }
                    else
                    {
                        MessageBox.Show("One or more cell values are null. Cannot create the ordered product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                _orderController.PlaceOrder(order);
                txtName.Clear();
                txtQuantity.Clear();
                txtAddress.Clear();
                dgvOrderDetails.Rows.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error placing order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedProduct = (Product)cmbProducts.SelectedItem;
            bool productExists = false;
            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
            {
                if (row.Cells["_id"].Value != null && row.Cells["_id"].Value.Equals(selectedProduct._id))
                {
                    int existingQuantity = (int)row.Cells["Quantity"].Value;
                    row.Cells["Quantity"].Value = existingQuantity + quantity;

                    productExists = true;
                    break;
                }
            }

            if (!productExists)
            {
                dgvOrderDetails.Rows.Add(selectedProduct._id, selectedProduct.Name, selectedProduct.Description, quantity, selectedProduct.Category, selectedProduct.Price);
            }
            cmbProducts.SelectedIndex = -1;
            txtQuantity.Clear();
        }

       
    }
}
