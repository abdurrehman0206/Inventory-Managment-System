using MongoDB.Bson;
using Project.Controllers;
using Project.Models;

namespace Project.Pages.SuppliersForms
{
    public partial class DeleteSupplierForm : Form
    {

        private SupplierController _supplierController;
        public DeleteSupplierForm()
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

        private void DeleteSupplierForm_Load(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                _supplierController.DeleteSupplier(ObjectId.Parse(txtId.Text));
                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSuppliers();
                ClearTextFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
