using Project.Controllers;
using Project.Models;
namespace Project.Pages.OrdersForms
{
    public partial class lblViewOrder : Form
    {

        private readonly OrderController _orderController;
        public lblViewOrder()
        {
            InitializeComponent();
            _orderController = new OrderController();
        }

        private void LoadOrders()
        {
            try
            {
                List<Order> orders = _orderController.GetAllOrders();
                dgvOrder.DataSource = orders;
                dgvOrder.Columns[0].HeaderText = "OrderId";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblViewOrder_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}
