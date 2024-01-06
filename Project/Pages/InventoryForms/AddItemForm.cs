using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Project
{
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();

        }

        //itemName Events
        private void itemNameTextField_MouseClick(object sender, MouseEventArgs e)
        {
            itemNamePanel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void itemNameTextField_Leave(object sender, EventArgs e)
        {
            itemNamePanel.BorderStyle = BorderStyle.None;
        }

        //itemCategory Events
        private void itemCategoryTextField_MouseClick(object sender, MouseEventArgs e)
        {
            itemCategoryPanel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void itemCategoryTextField_Leave(object sender, EventArgs e)
        {
            itemCategoryPanel.BorderStyle = BorderStyle.None;
        }

        //itemPrice Events

        private void itemPriceTextField_MouseClick(object sender, MouseEventArgs e)
        {
            itemPricePanel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void itemPriceTextField_Leave(object sender, EventArgs e)
        {
            itemPricePanel.BorderStyle = BorderStyle.None;
        }
        private void itemPriceTextField_TextChanged(object sender, EventArgs e)
        {
            itemPriceTextField.Text = new string(itemPriceTextField.Text.Where(char.IsDigit).ToArray());
        }
        //itemQuantity Events
        private void itemQuantityTextField_MouseClick(object sender, MouseEventArgs e)
        {
            itemQuantityPanel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void itemQuantityTextField_Leave(object sender, EventArgs e)
        {
            itemQuantityPanel.BorderStyle = BorderStyle.None;
        }
        private void itemQuantityTextField_TextChanged(object sender, EventArgs e)
        {
            itemQuantityTextField.Text = new string(itemQuantityTextField.Text.Where(char.IsDigit).ToArray());
        }

        //itemDescription Events
        private void itemDescRichTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            itemDescRichTextBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void itemDescRichTextBox_Leave(object sender, EventArgs e)
        {
            itemDescRichTextBox.BorderStyle = BorderStyle.None;
        }

      
    }
}
