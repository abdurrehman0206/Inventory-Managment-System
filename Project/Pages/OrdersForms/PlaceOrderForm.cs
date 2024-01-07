namespace Project.Pages.OrdersForms
{
    public partial class PlaceOrderForm : Form
    {
        public PlaceOrderForm()
        {
            InitializeComponent();
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
            dgvOrder.BorderStyle = BorderStyle.FixedSingle;
        }

        private void dgvOrder_Leave(object sender, EventArgs e)
        {
            dgvOrder.BorderStyle = BorderStyle.None;
            if (dgvOrder.SelectedCells.Count > 0)
            {

                dgvOrder.ClearSelection();
            }
        }




    }
}
