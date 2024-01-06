using Project.Pages.InventoryForms;
using Project.Pages.OrdersForms;
using Project.Pages.SuppliersForms;
using Project.Pages.ReportsForms;
namespace Project
{
    public partial class InventoHub : Form
    {
        private List<Panel> menuList;
        private Form? activePage;
        private Button? activeButton;
        public InventoHub()
        {
            InitializeComponent();
            menuList = new List<Panel>();
            MenuListGen();
            InitHideMenus();
            activePage = null;
            activeButton = null;

        }
        private void MenuListGen()
        {
            menuList.AddRange(new Panel[] { pnlSubInventory, pnlSubOrders, pnlSubReports, pnlSubSuppliers });
        }
        private void InitHideMenus()
        {
            menuList.ForEach(menu => { menu.Visible = false; });
        }
        private void HideSubMenu()
        {
            menuList.ForEach(menu => { if (menu.Visible) menu.Visible = false; });
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;

            }
            else if (subMenu.Visible)
            {
                subMenu.Visible = false;
            }
        }
        private void DesignPage(Form childPage)
        {
            childPage.TopLevel = false;
            childPage.FormBorderStyle = FormBorderStyle.None;
            childPage.Dock = DockStyle.Fill;
            childPage.BackColor = Color.GhostWhite;
            childPage.BackColor = Color.Lavender;
            pnlChildPage.Controls.Add(childPage);
            pnlChildPage.Tag = childPage;
            childPage.BringToFront();
            childPage.Show();
        }
        private void OpenPage(Form childPage)
        {
            /* if(activePage == childPage)
             {

             }
             else if (activePage != null)
             {
                 activePage.Close();
                 activePage = null;
             }
             else
             {
                 activePage = childPage;
                 DesignPage(childPage);

             }
            */
            activePage = childPage;
            DesignPage(childPage);

        }
        private void SetActiveButton(Button btn)
        {
            if (activeButton != null)
            {
                activeButton.BackColor = Color.FromArgb(57, 36, 103);
                activeButton = btn;
                btn.BackColor = Color.FromArgb(93, 53, 135);

            }
            else
            {
                activeButton = btn;
                activeButton.BackColor = Color.FromArgb(93, 53, 135);
            }

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            SetActiveButton(btnDashboard);
            OpenPage(new DashboardForm());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubInventory);
            SetActiveButton(btnInventory);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubOrders);
            SetActiveButton(btnOrders);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubSuppliers);
            SetActiveButton(btnSuppliers);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubReports);
            SetActiveButton(btnReports);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            OpenPage(new AddItemForm());
            HideSubMenu();

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenPage(new DeleteItemForm());
        }

        private void btnUpdateInv_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenPage(new UpdateInventoryForm());
        }

        private void btnViewInv_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenPage(new ViewInventoryForm());
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenPage(new PlaceOrderForm());
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenPage(new lblViewOrder());
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenPage(new OrderHistoryForm());
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenPage(new AddSupplierForm());
        }
        private void btnDeleteSup_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenPage(new DeleteSupplierForm());
        }

        private void btnUpdateSup_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenPage(new UpdateSupplierForm());
        }

        private void btnViewSup_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenPage(new ViewSupplierForm());
        }

        private void btnInvRep_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenPage(new InventoryReportForm());
        }

        private void btnSalesRep_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenPage(new SaleReportForm());
        }


    }
}