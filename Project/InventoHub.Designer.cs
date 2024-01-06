namespace Project
{
    partial class InventoHub
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoHub));
            panelSideNav = new Panel();
            pnlSubReports = new Panel();
            btnSalesRep = new Button();
            btnInvRep = new Button();
            btnReports = new Button();
            pnlSubSuppliers = new Panel();
            btnViewSup = new Button();
            btnUpdateSup = new Button();
            btnDeleteSup = new Button();
            btnAddSup = new Button();
            btnSuppliers = new Button();
            pnlSubOrders = new Panel();
            btnOrderHistory = new Button();
            btnViewOrders = new Button();
            btnPlaceOrder = new Button();
            btnOrders = new Button();
            pnlSubInventory = new Panel();
            btnViewInv = new Button();
            btnUpdateInv = new Button();
            btnDeleteItem = new Button();
            btnAddItem = new Button();
            btnInventory = new Button();
            btnDashboard = new Button();
            panel1 = new Panel();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            pnlChildPage = new Panel();
            panelSideNav.SuspendLayout();
            pnlSubReports.SuspendLayout();
            pnlSubSuppliers.SuspendLayout();
            pnlSubOrders.SuspendLayout();
            pnlSubInventory.SuspendLayout();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideNav
            // 
            panelSideNav.AutoScroll = true;
            panelSideNav.BackColor = Color.FromArgb(57, 36, 103);
            panelSideNav.Controls.Add(pnlSubReports);
            panelSideNav.Controls.Add(btnReports);
            panelSideNav.Controls.Add(pnlSubSuppliers);
            panelSideNav.Controls.Add(btnSuppliers);
            panelSideNav.Controls.Add(pnlSubOrders);
            panelSideNav.Controls.Add(btnOrders);
            panelSideNav.Controls.Add(pnlSubInventory);
            panelSideNav.Controls.Add(btnInventory);
            panelSideNav.Controls.Add(btnDashboard);
            panelSideNav.Controls.Add(panel1);
            panelSideNav.Dock = DockStyle.Left;
            panelSideNav.Location = new Point(0, 0);
            panelSideNav.Name = "panelSideNav";
            panelSideNav.Size = new Size(200, 800);
            panelSideNav.TabIndex = 0;
            // 
            // pnlSubReports
            // 
            pnlSubReports.BackColor = Color.FromArgb(163, 103, 177);
            pnlSubReports.Controls.Add(btnSalesRep);
            pnlSubReports.Controls.Add(btnInvRep);
            pnlSubReports.Dock = DockStyle.Top;
            pnlSubReports.Location = new Point(0, 748);
            pnlSubReports.Margin = new Padding(5);
            pnlSubReports.Name = "pnlSubReports";
            pnlSubReports.Padding = new Padding(5);
            pnlSubReports.Size = new Size(183, 91);
            pnlSubReports.TabIndex = 10;
            // 
            // btnSalesRep
            // 
            btnSalesRep.BackColor = Color.FromArgb(163, 103, 177);
            btnSalesRep.Dock = DockStyle.Top;
            btnSalesRep.FlatAppearance.BorderSize = 0;
            btnSalesRep.FlatStyle = FlatStyle.Flat;
            btnSalesRep.ForeColor = SystemColors.Control;
            btnSalesRep.Location = new Point(5, 45);
            btnSalesRep.Name = "btnSalesRep";
            btnSalesRep.Padding = new Padding(25, 0, 0, 0);
            btnSalesRep.Size = new Size(173, 40);
            btnSalesRep.TabIndex = 1;
            btnSalesRep.Text = "Sales Report";
            btnSalesRep.TextAlign = ContentAlignment.MiddleLeft;
            btnSalesRep.UseVisualStyleBackColor = false;
            btnSalesRep.Click += btnSalesRep_Click;
            // 
            // btnInvRep
            // 
            btnInvRep.BackColor = Color.FromArgb(163, 103, 177);
            btnInvRep.Dock = DockStyle.Top;
            btnInvRep.FlatAppearance.BorderSize = 0;
            btnInvRep.FlatStyle = FlatStyle.Flat;
            btnInvRep.ForeColor = SystemColors.Control;
            btnInvRep.Location = new Point(5, 5);
            btnInvRep.Name = "btnInvRep";
            btnInvRep.Padding = new Padding(25, 0, 0, 0);
            btnInvRep.Size = new Size(173, 40);
            btnInvRep.TabIndex = 0;
            btnInvRep.Text = "Inventory Reports";
            btnInvRep.TextAlign = ContentAlignment.MiddleLeft;
            btnInvRep.UseVisualStyleBackColor = false;
            btnInvRep.Click += btnInvRep_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(57, 36, 103);
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReports.ForeColor = SystemColors.Control;
            btnReports.Image = (Image)resources.GetObject("btnReports.Image");
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(0, 703);
            btnReports.Margin = new Padding(5);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(5);
            btnReports.Size = new Size(183, 45);
            btnReports.TabIndex = 9;
            btnReports.Text = " Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // pnlSubSuppliers
            // 
            pnlSubSuppliers.BackColor = Color.FromArgb(163, 103, 177);
            pnlSubSuppliers.Controls.Add(btnViewSup);
            pnlSubSuppliers.Controls.Add(btnUpdateSup);
            pnlSubSuppliers.Controls.Add(btnDeleteSup);
            pnlSubSuppliers.Controls.Add(btnAddSup);
            pnlSubSuppliers.Dock = DockStyle.Top;
            pnlSubSuppliers.Location = new Point(0, 532);
            pnlSubSuppliers.Margin = new Padding(5);
            pnlSubSuppliers.Name = "pnlSubSuppliers";
            pnlSubSuppliers.Padding = new Padding(5);
            pnlSubSuppliers.Size = new Size(183, 171);
            pnlSubSuppliers.TabIndex = 8;
            // 
            // btnViewSup
            // 
            btnViewSup.BackColor = Color.FromArgb(163, 103, 177);
            btnViewSup.Dock = DockStyle.Top;
            btnViewSup.FlatAppearance.BorderSize = 0;
            btnViewSup.FlatStyle = FlatStyle.Flat;
            btnViewSup.ForeColor = SystemColors.Control;
            btnViewSup.Location = new Point(5, 125);
            btnViewSup.Name = "btnViewSup";
            btnViewSup.Padding = new Padding(25, 0, 0, 0);
            btnViewSup.Size = new Size(173, 40);
            btnViewSup.TabIndex = 4;
            btnViewSup.Text = "View Suppliers";
            btnViewSup.TextAlign = ContentAlignment.MiddleLeft;
            btnViewSup.UseVisualStyleBackColor = false;
            btnViewSup.Click += btnViewSup_Click;
            // 
            // btnUpdateSup
            // 
            btnUpdateSup.BackColor = Color.FromArgb(163, 103, 177);
            btnUpdateSup.Dock = DockStyle.Top;
            btnUpdateSup.FlatAppearance.BorderSize = 0;
            btnUpdateSup.FlatStyle = FlatStyle.Flat;
            btnUpdateSup.ForeColor = SystemColors.Control;
            btnUpdateSup.Location = new Point(5, 85);
            btnUpdateSup.Name = "btnUpdateSup";
            btnUpdateSup.Padding = new Padding(25, 0, 0, 0);
            btnUpdateSup.Size = new Size(173, 40);
            btnUpdateSup.TabIndex = 3;
            btnUpdateSup.Text = "Update Suppliers";
            btnUpdateSup.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateSup.UseVisualStyleBackColor = false;
            btnUpdateSup.Click += btnUpdateSup_Click;
            // 
            // btnDeleteSup
            // 
            btnDeleteSup.BackColor = Color.FromArgb(163, 103, 177);
            btnDeleteSup.Dock = DockStyle.Top;
            btnDeleteSup.FlatAppearance.BorderSize = 0;
            btnDeleteSup.FlatStyle = FlatStyle.Flat;
            btnDeleteSup.ForeColor = SystemColors.Control;
            btnDeleteSup.Location = new Point(5, 45);
            btnDeleteSup.Name = "btnDeleteSup";
            btnDeleteSup.Padding = new Padding(25, 0, 0, 0);
            btnDeleteSup.Size = new Size(173, 40);
            btnDeleteSup.TabIndex = 2;
            btnDeleteSup.Text = "Delete Suppliers";
            btnDeleteSup.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteSup.UseVisualStyleBackColor = false;
            btnDeleteSup.Click += btnDeleteSup_Click;
            // 
            // btnAddSup
            // 
            btnAddSup.BackColor = Color.FromArgb(163, 103, 177);
            btnAddSup.Dock = DockStyle.Top;
            btnAddSup.FlatAppearance.BorderSize = 0;
            btnAddSup.FlatStyle = FlatStyle.Flat;
            btnAddSup.ForeColor = SystemColors.Control;
            btnAddSup.Location = new Point(5, 5);
            btnAddSup.Name = "btnAddSup";
            btnAddSup.Padding = new Padding(25, 0, 0, 0);
            btnAddSup.Size = new Size(173, 40);
            btnAddSup.TabIndex = 0;
            btnAddSup.Text = "Add Suppliers";
            btnAddSup.TextAlign = ContentAlignment.MiddleLeft;
            btnAddSup.UseVisualStyleBackColor = false;
            btnAddSup.Click += btnAddSup_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.BackColor = Color.FromArgb(57, 36, 103);
            btnSuppliers.Dock = DockStyle.Top;
            btnSuppliers.FlatAppearance.BorderSize = 0;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuppliers.ForeColor = SystemColors.Control;
            btnSuppliers.Image = (Image)resources.GetObject("btnSuppliers.Image");
            btnSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.Location = new Point(0, 487);
            btnSuppliers.Margin = new Padding(5);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Padding = new Padding(5);
            btnSuppliers.Size = new Size(183, 45);
            btnSuppliers.TabIndex = 7;
            btnSuppliers.Text = " Suppliers";
            btnSuppliers.TextAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuppliers.UseVisualStyleBackColor = false;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // pnlSubOrders
            // 
            pnlSubOrders.BackColor = Color.FromArgb(163, 103, 177);
            pnlSubOrders.Controls.Add(btnOrderHistory);
            pnlSubOrders.Controls.Add(btnViewOrders);
            pnlSubOrders.Controls.Add(btnPlaceOrder);
            pnlSubOrders.Dock = DockStyle.Top;
            pnlSubOrders.Location = new Point(0, 354);
            pnlSubOrders.Margin = new Padding(5);
            pnlSubOrders.Name = "pnlSubOrders";
            pnlSubOrders.Padding = new Padding(5);
            pnlSubOrders.Size = new Size(183, 133);
            pnlSubOrders.TabIndex = 6;
            // 
            // btnOrderHistory
            // 
            btnOrderHistory.BackColor = Color.FromArgb(163, 103, 177);
            btnOrderHistory.Dock = DockStyle.Top;
            btnOrderHistory.FlatAppearance.BorderSize = 0;
            btnOrderHistory.FlatStyle = FlatStyle.Flat;
            btnOrderHistory.ForeColor = SystemColors.Control;
            btnOrderHistory.Location = new Point(5, 85);
            btnOrderHistory.Name = "btnOrderHistory";
            btnOrderHistory.Padding = new Padding(25, 0, 0, 0);
            btnOrderHistory.Size = new Size(173, 40);
            btnOrderHistory.TabIndex = 2;
            btnOrderHistory.Text = "Order History";
            btnOrderHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnOrderHistory.UseVisualStyleBackColor = false;
            btnOrderHistory.Click += btnOrderHistory_Click;
            // 
            // btnViewOrders
            // 
            btnViewOrders.BackColor = Color.FromArgb(163, 103, 177);
            btnViewOrders.Dock = DockStyle.Top;
            btnViewOrders.FlatAppearance.BorderSize = 0;
            btnViewOrders.FlatStyle = FlatStyle.Flat;
            btnViewOrders.ForeColor = SystemColors.Control;
            btnViewOrders.Location = new Point(5, 45);
            btnViewOrders.Name = "btnViewOrders";
            btnViewOrders.Padding = new Padding(25, 0, 0, 0);
            btnViewOrders.Size = new Size(173, 40);
            btnViewOrders.TabIndex = 1;
            btnViewOrders.Text = "View Orders";
            btnViewOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnViewOrders.UseVisualStyleBackColor = false;
            btnViewOrders.Click += btnViewOrders_Click;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.FromArgb(163, 103, 177);
            btnPlaceOrder.Dock = DockStyle.Top;
            btnPlaceOrder.FlatAppearance.BorderSize = 0;
            btnPlaceOrder.FlatStyle = FlatStyle.Flat;
            btnPlaceOrder.ForeColor = SystemColors.Control;
            btnPlaceOrder.Location = new Point(5, 5);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Padding = new Padding(25, 0, 0, 0);
            btnPlaceOrder.Size = new Size(173, 40);
            btnPlaceOrder.TabIndex = 0;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.TextAlign = ContentAlignment.MiddleLeft;
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.FromArgb(57, 36, 103);
            btnOrders.Dock = DockStyle.Top;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrders.ForeColor = SystemColors.Control;
            btnOrders.Image = (Image)resources.GetObject("btnOrders.Image");
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(0, 309);
            btnOrders.Margin = new Padding(5);
            btnOrders.Name = "btnOrders";
            btnOrders.Padding = new Padding(5);
            btnOrders.Size = new Size(183, 45);
            btnOrders.TabIndex = 5;
            btnOrders.Text = " Orders";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // pnlSubInventory
            // 
            pnlSubInventory.BackColor = Color.FromArgb(163, 103, 177);
            pnlSubInventory.Controls.Add(btnViewInv);
            pnlSubInventory.Controls.Add(btnUpdateInv);
            pnlSubInventory.Controls.Add(btnDeleteItem);
            pnlSubInventory.Controls.Add(btnAddItem);
            pnlSubInventory.Dock = DockStyle.Top;
            pnlSubInventory.Location = new Point(0, 140);
            pnlSubInventory.Margin = new Padding(5);
            pnlSubInventory.Name = "pnlSubInventory";
            pnlSubInventory.Padding = new Padding(5);
            pnlSubInventory.Size = new Size(183, 169);
            pnlSubInventory.TabIndex = 4;
            // 
            // btnViewInv
            // 
            btnViewInv.BackColor = Color.FromArgb(163, 103, 177);
            btnViewInv.Dock = DockStyle.Top;
            btnViewInv.FlatAppearance.BorderSize = 0;
            btnViewInv.FlatStyle = FlatStyle.Flat;
            btnViewInv.ForeColor = SystemColors.Control;
            btnViewInv.Location = new Point(5, 125);
            btnViewInv.Name = "btnViewInv";
            btnViewInv.Padding = new Padding(25, 0, 0, 0);
            btnViewInv.Size = new Size(173, 40);
            btnViewInv.TabIndex = 3;
            btnViewInv.Text = "View Inventory";
            btnViewInv.TextAlign = ContentAlignment.MiddleLeft;
            btnViewInv.UseVisualStyleBackColor = false;
            btnViewInv.Click += btnViewInv_Click;
            // 
            // btnUpdateInv
            // 
            btnUpdateInv.BackColor = Color.FromArgb(163, 103, 177);
            btnUpdateInv.Dock = DockStyle.Top;
            btnUpdateInv.FlatAppearance.BorderSize = 0;
            btnUpdateInv.FlatStyle = FlatStyle.Flat;
            btnUpdateInv.ForeColor = SystemColors.Control;
            btnUpdateInv.Location = new Point(5, 85);
            btnUpdateInv.Name = "btnUpdateInv";
            btnUpdateInv.Padding = new Padding(25, 0, 0, 0);
            btnUpdateInv.Size = new Size(173, 40);
            btnUpdateInv.TabIndex = 2;
            btnUpdateInv.Text = "Update Inventory";
            btnUpdateInv.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateInv.UseVisualStyleBackColor = false;
            btnUpdateInv.Click += btnUpdateInv_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.BackColor = Color.FromArgb(163, 103, 177);
            btnDeleteItem.Dock = DockStyle.Top;
            btnDeleteItem.FlatAppearance.BorderSize = 0;
            btnDeleteItem.FlatStyle = FlatStyle.Flat;
            btnDeleteItem.ForeColor = SystemColors.Control;
            btnDeleteItem.Location = new Point(5, 45);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Padding = new Padding(25, 0, 0, 0);
            btnDeleteItem.Size = new Size(173, 40);
            btnDeleteItem.TabIndex = 1;
            btnDeleteItem.Text = "Delete Items";
            btnDeleteItem.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteItem.UseVisualStyleBackColor = false;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(163, 103, 177);
            btnAddItem.Dock = DockStyle.Top;
            btnAddItem.FlatAppearance.BorderSize = 0;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.ForeColor = SystemColors.Control;
            btnAddItem.Location = new Point(5, 5);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Padding = new Padding(25, 0, 0, 0);
            btnAddItem.Size = new Size(173, 40);
            btnAddItem.TabIndex = 0;
            btnAddItem.Text = "Add Items";
            btnAddItem.TextAlign = ContentAlignment.MiddleLeft;
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(57, 36, 103);
            btnInventory.Dock = DockStyle.Top;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInventory.ForeColor = SystemColors.Control;
            btnInventory.Image = (Image)resources.GetObject("btnInventory.Image");
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.Location = new Point(0, 95);
            btnInventory.Margin = new Padding(5);
            btnInventory.Name = "btnInventory";
            btnInventory.Padding = new Padding(5);
            btnInventory.Size = new Size(183, 45);
            btnInventory.TabIndex = 3;
            btnInventory.Text = " Inventory";
            btnInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(57, 36, 103);
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderColor = Color.FromArgb(54, 48, 98);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = SystemColors.Control;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 50);
            btnDashboard.Margin = new Padding(5);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(5);
            btnDashboard.Size = new Size(183, 45);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = " Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(163, 103, 177);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 50);
            label1.TabIndex = 0;
            label1.Text = "InventoHub";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // pnlChildPage
            // 
            pnlChildPage.AutoScroll = true;
            pnlChildPage.AutoSize = true;
            pnlChildPage.BackColor = Color.Lavender;
            pnlChildPage.Dock = DockStyle.Fill;
            pnlChildPage.Location = new Point(200, 0);
            pnlChildPage.Name = "pnlChildPage";
            pnlChildPage.Size = new Size(800, 800);
            pnlChildPage.TabIndex = 1;
            // 
            // InventoHub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 234, 255);
            ClientSize = new Size(1000, 800);
            Controls.Add(pnlChildPage);
            Controls.Add(panelSideNav);
            MaximizeBox = false;
            Name = "InventoHub";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventoHub";
            panelSideNav.ResumeLayout(false);
            pnlSubReports.ResumeLayout(false);
            pnlSubSuppliers.ResumeLayout(false);
            pnlSubOrders.ResumeLayout(false);
            pnlSubInventory.ResumeLayout(false);
            panel1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSideNav;
        private Button btnDashboard;
        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Button btnInventory;
        private Panel pnlSubInventory;
        private Button btnUpdateInv;
        private Button btnDeleteItem;
        private Button btnAddItem;
        private Button btnViewInv;
        private Panel pnlSubOrders;
        private Button btnOrderHistory;
        private Button btnViewOrders;
        private Button btnPlaceOrder;
        private Button btnOrders;
        private Panel pnlSubReports;
        private Button btnSalesRep;
        private Button btnInvRep;
        private Button btnReports;
        private Panel pnlSubSuppliers;
        private Button btnAddSup;
        private Button btnSuppliers;
        private Label label1;
        private Panel pnlChildPage;
        private Button btnDeleteSup;
        private Button btnUpdateSup;
        private Button btnViewSup;
    }
}