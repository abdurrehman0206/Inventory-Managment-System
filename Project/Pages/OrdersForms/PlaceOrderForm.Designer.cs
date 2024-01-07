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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblPlaceOrder = new Label();
            lblName = new Label();
            pnlName = new Panel();
            txtName = new TextBox();
            lblAddress = new Label();
            pnlAddress = new Panel();
            txtAddress = new TextBox();
            lblSelect = new Label();
            lblAmount = new Label();
            btnPlaceOrder = new Button();
            cmbProducts = new ComboBox();
            btnAddProduct = new Button();
            lblQuantity = new Label();
            pnlQuantity = new Panel();
            txtQuantity = new TextBox();
            dgvOrderDetails = new DataGridView();
            lblSelectProd = new Label();
            pnlName.SuspendLayout();
            pnlAddress.SuspendLayout();
            pnlQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
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
            lblName.Location = new Point(46, 90);
            lblName.Margin = new Padding(5);
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
            pnlName.Location = new Point(46, 119);
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
            lblAddress.Location = new Point(279, 90);
            lblAddress.Margin = new Padding(5);
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
            pnlAddress.Location = new Point(279, 119);
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
            // lblSelect
            // 
            lblSelect.Anchor = AnchorStyles.None;
            lblSelect.AutoSize = true;
            lblSelect.BackColor = Color.Transparent;
            lblSelect.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelect.ForeColor = Color.Black;
            lblSelect.Location = new Point(46, 275);
            lblSelect.Margin = new Padding(5);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(146, 21);
            lblSelect.TabIndex = 12;
            lblSelect.Text = "Selected Products";
            // 
            // lblAmount
            // 
            lblAmount.Anchor = AnchorStyles.None;
            lblAmount.AutoSize = true;
            lblAmount.BackColor = Color.Transparent;
            lblAmount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAmount.ForeColor = Color.Black;
            lblAmount.Location = new Point(46, 589);
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
            btnPlaceOrder.Location = new Point(323, 704);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(149, 45);
            btnPlaceOrder.TabIndex = 14;
            btnPlaceOrder.Tag = "";
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // cmbProducts
            // 
            cmbProducts.Anchor = AnchorStyles.None;
            cmbProducts.BackColor = Color.FromArgb(225, 217, 242);
            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducts.FlatStyle = FlatStyle.Flat;
            cmbProducts.FormattingEnabled = true;
            cmbProducts.ItemHeight = 15;
            cmbProducts.Location = new Point(46, 217);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(693, 23);
            cmbProducts.Sorted = true;
            cmbProducts.TabIndex = 15;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.None;
            btnAddProduct.BackColor = Color.FromArgb(57, 36, 103);
            btnAddProduct.FlatAppearance.BorderColor = Color.FromArgb(57, 36, 135);
            btnAddProduct.FlatAppearance.BorderSize = 2;
            btnAddProduct.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 103, 177);
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProduct.ForeColor = SystemColors.Control;
            btnAddProduct.Location = new Point(323, 540);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(149, 45);
            btnAddProduct.TabIndex = 16;
            btnAddProduct.Tag = "";
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.None;
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.ForeColor = Color.Black;
            lblQuantity.Location = new Point(512, 90);
            lblQuantity.Margin = new Padding(5);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(77, 21);
            lblQuantity.TabIndex = 11;
            lblQuantity.Text = "Quantity";
            // 
            // pnlQuantity
            // 
            pnlQuantity.Anchor = AnchorStyles.None;
            pnlQuantity.BackColor = Color.FromArgb(225, 217, 242);
            pnlQuantity.Controls.Add(txtQuantity);
            pnlQuantity.Location = new Point(512, 119);
            pnlQuantity.Name = "pnlQuantity";
            pnlQuantity.Size = new Size(227, 40);
            pnlQuantity.TabIndex = 12;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(225, 217, 242);
            txtQuantity.BorderStyle = BorderStyle.None;
            txtQuantity.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(10, 12);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Quantity";
            txtQuantity.Size = new Size(210, 16);
            txtQuantity.TabIndex = 5;
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.AllowUserToDeleteRows = false;
            dgvOrderDetails.AllowUserToOrderColumns = true;
            dgvOrderDetails.AllowUserToResizeColumns = false;
            dgvOrderDetails.AllowUserToResizeRows = false;
            dgvOrderDetails.Anchor = AnchorStyles.None;
            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOrderDetails.BackgroundColor = Color.Lavender;
            dgvOrderDetails.BorderStyle = BorderStyle.None;
            dgvOrderDetails.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvOrderDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(135, 104, 202);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvOrderDetails.DefaultCellStyle = dataGridViewCellStyle2;
            dgvOrderDetails.EnableHeadersVisualStyles = false;
            dgvOrderDetails.GridColor = Color.FromArgb(225, 217, 242);
            dgvOrderDetails.Location = new Point(46, 301);
            dgvOrderDetails.Margin = new Padding(0);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.Lavender;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(225, 217, 242);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvOrderDetails.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvOrderDetails.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            dgvOrderDetails.RowTemplate.Height = 30;
            dgvOrderDetails.RowTemplate.ReadOnly = true;
            dgvOrderDetails.ShowEditingIcon = false;
            dgvOrderDetails.Size = new Size(693, 236);
            dgvOrderDetails.TabIndex = 17;
            // 
            // lblSelectProd
            // 
            lblSelectProd.Anchor = AnchorStyles.None;
            lblSelectProd.AutoSize = true;
            lblSelectProd.BackColor = Color.Transparent;
            lblSelectProd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectProd.ForeColor = Color.Black;
            lblSelectProd.Location = new Point(46, 193);
            lblSelectProd.Name = "lblSelectProd";
            lblSelectProd.Size = new Size(120, 21);
            lblSelectProd.TabIndex = 18;
            lblSelectProd.Text = "Select Product";
            // 
            // PlaceOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Lavender;
            ClientSize = new Size(784, 761);
            Controls.Add(lblSelectProd);
            Controls.Add(dgvOrderDetails);
            Controls.Add(pnlQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(btnAddProduct);
            Controls.Add(cmbProducts);
            Controls.Add(btnPlaceOrder);
            Controls.Add(lblAmount);
            Controls.Add(lblSelect);
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
            pnlQuantity.ResumeLayout(false);
            pnlQuantity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
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
        private DataGridView dgvOrderDetails;
        private Label lblSelectProd;
        private Label lblSelect;
        private Label lblAmount;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn Quantity;
        private Button btnPlaceOrder;
        private ComboBox cmbProducts;
        private Button btnAddProduct;
        private Panel panel1;
        private Label lblQuantity;
        private Panel pnlQuantity;
        private TextBox txtQuantity;
        private DataGridView dgvOrder;
    }
}