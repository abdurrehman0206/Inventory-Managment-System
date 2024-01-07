using MongoDB.Bson;
using Project.Controllers;
using Project.Models;

namespace Project.Pages.SuppliersForms
{
    public partial class UpdateSupplierForm : Form
    {
        private SupplierController _supplierController;
        public UpdateSupplierForm()
        {
            InitializeComponent();
            _supplierController = new SupplierController();
        }

        private void LoadSuppliers()
        {
            try
            {
                List<Supplier> suppliers = _supplierController.GetAllSuppliers();
                dgvSupplier.DataSource = suppliers;
                dgvSupplier.Columns[0].HeaderText = "SupplierID";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading suppliers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void UpdateSupplierForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSupplier.Rows[e.RowIndex];
                txtId.Text = row.Cells["_id"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtNum.Text = row.Cells["ContactNumber"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectId productIdToUpdate = ObjectId.Parse(txtId.Text);
                Supplier updatedProduct = new Supplier
                {
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    ContactNumber = txtNum.Text,
                    Address = txtAddress.Text,
                };
                _supplierController.UpdateSupplier(productIdToUpdate, updatedProduct);
                MessageBox.Show("Supplier updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSuppliers();
                ClearTextFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearTextFields()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtNum.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;

        }


        //txtFields Events
        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            pnlName.BorderStyle = BorderStyle.FixedSingle;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            pnlName.BorderStyle = BorderStyle.None;
        }

        private void txtNum_MouseClick(object sender, MouseEventArgs e)
        {
            pnlNum.BorderStyle = BorderStyle.FixedSingle;
        }

        private void txtNum_Leave(object sender, EventArgs e)
        {
            pnlNum.BorderStyle = BorderStyle.None;
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            pnlEmail.BorderStyle = BorderStyle.FixedSingle;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            pnlEmail.BorderStyle = BorderStyle.None;
        }

        private void txtAddress_MouseClick(object sender, MouseEventArgs e)
        {
            pnlAddress.BorderStyle = BorderStyle.FixedSingle;
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            pnlAddress.BorderStyle = BorderStyle.None;
        }
    }
}
