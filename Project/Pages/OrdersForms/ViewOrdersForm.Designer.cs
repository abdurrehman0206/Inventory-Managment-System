namespace Project.Pages.OrdersForms
{
    partial class lblViewOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            viewOrderFormHeader = new Label();
            dgvOrder = new DataGridView();
            CustomerName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Products = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            OrderStatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // viewOrderFormHeader
            // 
            viewOrderFormHeader.BackColor = Color.FromArgb(57, 36, 103);
            viewOrderFormHeader.Dock = DockStyle.Top;
            viewOrderFormHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            viewOrderFormHeader.ForeColor = SystemColors.Control;
            viewOrderFormHeader.Location = new Point(0, 0);
            viewOrderFormHeader.Name = "viewOrderFormHeader";
            viewOrderFormHeader.Size = new Size(800, 50);
            viewOrderFormHeader.TabIndex = 0;
            viewOrderFormHeader.Text = "Order Info";
            viewOrderFormHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToDeleteRows = false;
            dgvOrder.AllowUserToResizeColumns = false;
            dgvOrder.AllowUserToResizeRows = false;
            dgvOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOrder.BackgroundColor = Color.Lavender;
            dgvOrder.BorderStyle = BorderStyle.None;
            dgvOrder.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(135, 104, 202);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(135, 104, 202);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { CustomerName, Address, Products, TotalAmount, OrderStatus });
            dgvOrder.Dock = DockStyle.Fill;
            dgvOrder.EnableHeadersVisualStyles = false;
            dgvOrder.GridColor = Color.Lavender;
            dgvOrder.Location = new Point(0, 50);
            dgvOrder.Margin = new Padding(0);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(225, 217, 242);
            dataGridViewCellStyle7.Padding = new Padding(5);
            dgvOrder.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvOrder.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            dgvOrder.RowTemplate.Height = 30;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.ShowEditingIcon = false;
            dgvOrder.Size = new Size(800, 750);
            dgvOrder.TabIndex = 12;
            // 
            // CustomerName
            // 
            CustomerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Lavender;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(163, 103, 177);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Control;
            CustomerName.DefaultCellStyle = dataGridViewCellStyle2;
            CustomerName.HeaderText = "Customer Name";
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            CustomerName.Resizable = DataGridViewTriState.False;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Lavender;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(163, 103, 177);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Control;
            Address.DefaultCellStyle = dataGridViewCellStyle3;
            Address.HeaderText = "Address";
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Resizable = DataGridViewTriState.False;
            Address.ToolTipText = "Enter Product Quantity";
            // 
            // Products
            // 
            Products.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = Color.Lavender;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.Padding = new Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(163, 103, 177);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Control;
            Products.DefaultCellStyle = dataGridViewCellStyle4;
            Products.HeaderText = "Products";
            Products.Name = "Products";
            Products.ReadOnly = true;
            // 
            // TotalAmount
            // 
            TotalAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.BackColor = Color.Lavender;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(163, 103, 177);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Control;
            TotalAmount.DefaultCellStyle = dataGridViewCellStyle5;
            TotalAmount.HeaderText = "Total Amount";
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            // 
            // OrderStatus
            // 
            OrderStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.BackColor = Color.Lavender;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(163, 103, 177);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.Control;
            OrderStatus.DefaultCellStyle = dataGridViewCellStyle6;
            OrderStatus.HeaderText = "Order Status";
            OrderStatus.Name = "OrderStatus";
            OrderStatus.ReadOnly = true;
            // 
            // lblViewOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 800);
            Controls.Add(dgvOrder);
            Controls.Add(viewOrderFormHeader);
            Name = "lblViewOrder";
            Text = "ViewOrdersForm";
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label viewOrderFormHeader;
        private DataGridView dgvOrder;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Products;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn OrderStatus;
    }
}