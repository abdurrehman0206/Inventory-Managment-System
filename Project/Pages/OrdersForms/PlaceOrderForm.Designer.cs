namespace Project.Pages.OrdersForms
{
    partial class PlaceOrderForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblPlaceOrder = new Label();
            lblName = new Label();
            pnlName = new Panel();
            txtName = new TextBox();
            lblAddress = new Label();
            pnlAddress = new Panel();
            txtAddress = new TextBox();
            dgvOrder = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            lblSelect = new Label();
            lblAmount = new Label();
            btnPlaceOrder = new Button();
            pnlName.SuspendLayout();
            pnlAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // lblPlaceOrder
            // 
            lblPlaceOrder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPlaceOrder.BackColor = Color.FromArgb(57, 36, 103);
            lblPlaceOrder.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlaceOrder.ForeColor = SystemColors.Control;
            lblPlaceOrder.Location = new Point(0, 0);
            lblPlaceOrder.Name = "lblPlaceOrder";
            lblPlaceOrder.Size = new Size(784, 50);
            lblPlaceOrder.TabIndex = 0;
            lblPlaceOrder.Text = "Place Order";
            lblPlaceOrder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(58, 101);
            lblName.Name = "lblName";
            lblName.Size = new Size(133, 21);
            lblName.TabIndex = 3;
            lblName.Text = "Customer Name";
            // 
            // pnlName
            // 
            pnlName.Anchor = AnchorStyles.None;
            pnlName.BackColor = Color.FromArgb(225, 217, 242);
            pnlName.Controls.Add(txtName);
            pnlName.Location = new Point(58, 135);
            pnlName.Name = "pnlName";
            pnlName.Size = new Size(227, 40);
            pnlName.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(225, 217, 242);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(10, 12);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(210, 16);
            txtName.TabIndex = 5;
            txtName.MouseClick += txtName_MouseClick;
            txtName.Leave += txtName_Leave;
            // 
            // lblAddress
            // 
            lblAddress.Anchor = AnchorStyles.None;
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.ForeColor = Color.Black;
            lblAddress.Location = new Point(497, 101);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(143, 21);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Shipping Address";
            // 
            // pnlAddress
            // 
            pnlAddress.Anchor = AnchorStyles.None;
            pnlAddress.BackColor = Color.FromArgb(225, 217, 242);
            pnlAddress.Controls.Add(txtAddress);
            pnlAddress.Location = new Point(497, 135);
            pnlAddress.Name = "pnlAddress";
            pnlAddress.Size = new Size(227, 40);
            pnlAddress.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(225, 217, 242);
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(10, 12);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(210, 16);
            txtAddress.TabIndex = 5;
            txtAddress.MouseClick += txtAddress_MouseClick;
            txtAddress.Leave += txtAddress_Leave;
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToResizeColumns = false;
            dgvOrder.AllowUserToResizeRows = false;
            dgvOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOrder.BackgroundColor = Color.FromArgb(225, 217, 242);
            dgvOrder.BorderStyle = BorderStyle.None;
            dgvOrder.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(225, 217, 242);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { ProductID, Quantity });
            dgvOrder.EnableHeadersVisualStyles = false;
            dgvOrder.GridColor = Color.FromArgb(225, 217, 242);
            dgvOrder.Location = new Point(58, 328);
            dgvOrder.Margin = new Padding(0);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersVisible = false;
            dataGridViewCellStyle4.Padding = new Padding(5);
            dgvOrder.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvOrder.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            dgvOrder.RowTemplate.Height = 30;
            dgvOrder.ShowEditingIcon = false;
            dgvOrder.Size = new Size(666, 143);
            dgvOrder.TabIndex = 11;
            dgvOrder.Leave += dgvOrder_Leave;
            dgvOrder.MouseClick += dgvOrder_MouseClick;
            // 
            // ProductID
            // 
            ProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(225, 217, 242);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(163, 103, 177);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Control;
            ProductID.DefaultCellStyle = dataGridViewCellStyle2;
            ProductID.HeaderText = "ProductID";
            ProductID.Name = "ProductID";
            ProductID.Resizable = DataGridViewTriState.False;
            ProductID.ToolTipText = "Enter Product ID";
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(225, 217, 242);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(163, 103, 177);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Control;
            Quantity.DefaultCellStyle = dataGridViewCellStyle3;
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.Resizable = DataGridViewTriState.False;
            Quantity.ToolTipText = "Enter Product Quantity";
            // 
            // lblSelect
            // 
            lblSelect.Anchor = AnchorStyles.None;
            lblSelect.AutoSize = true;
            lblSelect.BackColor = Color.Transparent;
            lblSelect.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelect.ForeColor = Color.Black;
            lblSelect.Location = new Point(58, 257);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(127, 21);
            lblSelect.TabIndex = 12;
            lblSelect.Text = "Select Products";
            // 
            // lblAmount
            // 
            lblAmount.Anchor = AnchorStyles.None;
            lblAmount.AutoSize = true;
            lblAmount.BackColor = Color.Transparent;
            lblAmount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAmount.ForeColor = Color.Black;
            lblAmount.Location = new Point(58, 523);
            lblAmount.Margin = new Padding(0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(196, 25);
            lblAmount.TabIndex = 13;
            lblAmount.Text = "Total Amount :  $ 0.0";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Anchor = AnchorStyles.None;
            btnPlaceOrder.BackColor = Color.FromArgb(57, 36, 103);
            btnPlaceOrder.FlatAppearance.BorderColor = Color.FromArgb(57, 36, 135);
            btnPlaceOrder.FlatAppearance.BorderSize = 2;
            btnPlaceOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 103, 177);
            btnPlaceOrder.FlatStyle = FlatStyle.Flat;
            btnPlaceOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlaceOrder.ForeColor = SystemColors.Control;
            btnPlaceOrder.Location = new Point(323, 622);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(149, 45);
            btnPlaceOrder.TabIndex = 14;
            btnPlaceOrder.Tag = "";
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            // 
            // PlaceOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 761);
            Controls.Add(btnPlaceOrder);
            Controls.Add(lblAmount);
            Controls.Add(lblSelect);
            Controls.Add(dgvOrder);
            Controls.Add(pnlAddress);
            Controls.Add(lblAddress);
            Controls.Add(pnlName);
            Controls.Add(lblName);
            Controls.Add(lblPlaceOrder);
            Name = "PlaceOrderForm";
            Text = "PlaceOrderForm";
            pnlName.ResumeLayout(false);
            pnlName.PerformLayout();
            pnlAddress.ResumeLayout(false);
            pnlAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label lblPlaceOrder;
        private Label lblName;
        private Panel pnlName;
        private TextBox txtName;
        private Label lblAddress;
        private Panel pnlAddress;
        private TextBox txtAddress;
        private DataGridView dgvOrder;
        private Label lblSelect;
        private Label lblAmount;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn Quantity;
        private Button btnPlaceOrder;
    }
}