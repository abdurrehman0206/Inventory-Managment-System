using Project.Controllers;
using Project.Models;
namespace Project.Pages.SuppliersForms
{
    public partial class ViewSupplierForm : Form
    {
        private SupplierController _supplierController;
        public ViewSupplierForm()
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

        private void ViewSupplierForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }
    }
}
