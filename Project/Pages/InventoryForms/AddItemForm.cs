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
            tfItemPrice.Text = new string(tfItemPrice.Text.Where(char.IsDigit).ToArray());
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
            tfItemQuan.Text = new string(tfItemQuan.Text.Where(char.IsDigit).ToArray());
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


    }
}
