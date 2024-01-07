using Project.Controllers;
using Project.Models;
using System.Data;
namespace Project.Pages.InventoryForms
{
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();

        }

        //itemName Events
        private void tfItemName_MouseClick(object sender, MouseEventArgs e)
        {
            itemNamePanel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void tfItemName_Leave(object sender, EventArgs e)
        {
            itemNamePanel.BorderStyle = BorderStyle.None;
        }

        //itemCategory Events
        private void tfItemCat_MouseClick(object sender, MouseEventArgs e)
        {
            pnlItemCategory.BorderStyle = BorderStyle.FixedSingle;
        }

        private void tfItemCat_Leave(object sender, EventArgs e)
        {
            pnlItemCategory.BorderStyle = BorderStyle.None;
        }

        //itemPrice Events

        private void tfItemPrice_MouseClick(object sender, MouseEventArgs e)
        {
            itemPricePanel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void tfItemPrice_Leave(object sender, EventArgs e)
        {
            itemPricePanel.BorderStyle = BorderStyle.None;
        }
        private void tfItemPrice_TextChanged(object sender, EventArgs e)
        {
            txtItemPrice.Text = new string(txtItemPrice.Text.Where(char.IsDigit).ToArray());
        }
        //itemQuantity Events
        private void tfItemQuan_MouseClick(object sender, MouseEventArgs e)
        {
            pnlItemQuantity.BorderStyle = BorderStyle.FixedSingle;
        }

        private void tfItemQuan_Leave(object sender, EventArgs e)
        {
            pnlItemQuantity.BorderStyle = BorderStyle.None;
        }
        private void tfItemQuan_TextChanged(object sender, EventArgs e)
        {
            txtItemQuan.Text = new string(txtItemQuan.Text.Where(char.IsDigit).ToArray());
        }

        //itemDescription Events
        private void rtbItemDesc_MouseClick(object sender, MouseEventArgs e)
        {
            rtbItemDesc.BorderStyle = BorderStyle.FixedSingle;

        }

        private void rtbItemDesc_Leave(object sender, EventArgs e)
        {
            rtbItemDesc.BorderStyle = BorderStyle.None;
        }
        // addButton events
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string productName = txtItemName.Text;
            double price = Convert.ToDouble(txtItemPrice.Text);
            int quantity = Convert.ToInt32(txtItemQuan.Text);
            string description = rtbItemDesc.Text.ToString();
       
            Product newProduct = new Product
            {
                Name = productName,
                Price = price,
                QuantityInStock = quantity,
                Description = description
                
            };

            ProductController productController = new ProductController();
            productController.AddProduct(newProduct);
            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
