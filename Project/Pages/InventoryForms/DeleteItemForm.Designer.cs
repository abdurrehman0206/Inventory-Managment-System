namespace Project.Pages.InventoryForms
{
    partial class DeleteItemForm
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
            lblDelItem = new Label();
            dgvProduct = new DataGridView();
            rtbItemDesc = new RichTextBox();
            lblItemDesc = new Label();
            btnDeleteItem = new Button();
            pnlItemQuantity = new Panel();
            txtItemQuan = new TextBox();
            lblItemQuan = new Label();
            itemPricePanel = new Panel();
            txtItemPrice = new TextBox();
            lblItemPrice = new Label();
            pnlItemCategory = new Panel();
            txtItemCat = new TextBox();
            itemNamePanel = new Panel();
            txtItemName = new TextBox();
            lblItemCat = new Label();
            lblItemName = new Label();
            panel1 = new Panel();
            txtItemId = new TextBox();
            lblItemId = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            pnlItemQuantity.SuspendLayout();
            itemPricePanel.SuspendLayout();
            pnlItemCategory.SuspendLayout();
            itemNamePanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDelItem
            // 
            lblDelItem.BackColor = Color.FromArgb(57, 36, 103);
            lblDelItem.Dock = DockStyle.Top;
            lblDelItem.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDelItem.ForeColor = SystemColors.Control;
            lblDelItem.Location = new Point(0, 0);
            lblDelItem.Name = "lblDelItem";
            lblDelItem.Size = new Size(800, 50);
            lblDelItem.TabIndex = 0;
            lblDelItem.Text = "Delete Item";
            lblDelItem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.AllowUserToOrderColumns = true;
            dgvProduct.AllowUserToResizeColumns = false;
            dgvProduct.AllowUserToResizeRows = false;
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProduct.BackgroundColor = Color.Lavender;
            dgvProduct.BorderStyle = BorderStyle.None;
            dgvProduct.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(135, 104, 202);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(135, 104, 202);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProduct.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.GridColor = Color.FromArgb(225, 217, 242);
            dgvProduct.Location = new Point(0, 50);
            dgvProduct.Margin = new Padding(0);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.Lavender;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(225, 217, 242);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvProduct.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            dgvProduct.RowTemplate.Height = 30;
            dgvProduct.RowTemplate.ReadOnly = true;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.ShowEditingIcon = false;
            dgvProduct.Size = new Size(547, 750);
            dgvProduct.TabIndex = 13;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // rtbItemDesc
            // 
            rtbItemDesc.Anchor = AnchorStyles.None;
            rtbItemDesc.BackColor = Color.FromArgb(225, 217, 242);
            rtbItemDesc.BorderStyle = BorderStyle.None;
            rtbItemDesc.Location = new Point(561, 472);
            rtbItemDesc.Name = "rtbItemDesc";
            rtbItemDesc.ReadOnly = true;
            rtbItemDesc.Size = new Size(227, 184);
            rtbItemDesc.TabIndex = 26;
            rtbItemDesc.Text = "";
            // 
            // lblItemDesc
            // 
            lblItemDesc.Anchor = AnchorStyles.None;
            lblItemDesc.AutoSize = true;
            lblItemDesc.BackColor = Color.Transparent;
            lblItemDesc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemDesc.ForeColor = Color.Black;
            lblItemDesc.Location = new Point(561, 443);
            lblItemDesc.Margin = new Padding(5);
            lblItemDesc.Name = "lblItemDesc";
            lblItemDesc.Size = new Size(137, 21);
            lblItemDesc.TabIndex = 25;
            lblItemDesc.Text = "Item Description";
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Anchor = AnchorStyles.None;
            btnDeleteItem.BackColor = Color.FromArgb(57, 36, 103);
            btnDeleteItem.FlatAppearance.BorderColor = Color.FromArgb(57, 36, 135);
            btnDeleteItem.FlatAppearance.BorderSize = 2;
            btnDeleteItem.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 103, 177);
            btnDeleteItem.FlatStyle = FlatStyle.Flat;
            btnDeleteItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteItem.ForeColor = SystemColors.Control;
            btnDeleteItem.Location = new Point(561, 675);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(227, 45);
            btnDeleteItem.TabIndex = 24;
            btnDeleteItem.Tag = "";
            btnDeleteItem.Text = "Delete Item";
            btnDeleteItem.UseVisualStyleBackColor = false;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // pnlItemQuantity
            // 
            pnlItemQuantity.Anchor = AnchorStyles.None;
            pnlItemQuantity.BackColor = Color.FromArgb(225, 217, 242);
            pnlItemQuantity.Controls.Add(txtItemQuan);
            pnlItemQuantity.Cursor = Cursors.Hand;
            pnlItemQuantity.Location = new Point(561, 395);
            pnlItemQuantity.Name = "pnlItemQuantity";
            pnlItemQuantity.Size = new Size(227, 40);
            pnlItemQuantity.TabIndex = 23;
            // 
            // txtItemQuan
            // 
            txtItemQuan.BackColor = Color.FromArgb(225, 217, 242);
            txtItemQuan.BorderStyle = BorderStyle.None;
            txtItemQuan.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemQuan.Location = new Point(10, 12);
            txtItemQuan.Name = "txtItemQuan";
            txtItemQuan.PlaceholderText = "Item Name";
            txtItemQuan.ReadOnly = true;
            txtItemQuan.Size = new Size(210, 16);
            txtItemQuan.TabIndex = 5;
            // 
            // lblItemQuan
            // 
            lblItemQuan.Anchor = AnchorStyles.None;
            lblItemQuan.AutoSize = true;
            lblItemQuan.BackColor = Color.Transparent;
            lblItemQuan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemQuan.ForeColor = Color.Black;
            lblItemQuan.Location = new Point(561, 366);
            lblItemQuan.Margin = new Padding(5);
            lblItemQuan.Name = "lblItemQuan";
            lblItemQuan.Size = new Size(116, 21);
            lblItemQuan.TabIndex = 22;
            lblItemQuan.Text = "Item Quantity";
            // 
            // itemPricePanel
            // 
            itemPricePanel.Anchor = AnchorStyles.None;
            itemPricePanel.BackColor = Color.FromArgb(225, 217, 242);
            itemPricePanel.Controls.Add(txtItemPrice);
            itemPricePanel.Cursor = Cursors.Hand;
            itemPricePanel.Location = new Point(561, 241);
            itemPricePanel.Name = "itemPricePanel";
            itemPricePanel.Size = new Size(227, 40);
            itemPricePanel.TabIndex = 21;
            // 
            // txtItemPrice
            // 
            txtItemPrice.BackColor = Color.FromArgb(225, 217, 242);
            txtItemPrice.BorderStyle = BorderStyle.None;
            txtItemPrice.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemPrice.Location = new Point(10, 12);
            txtItemPrice.Name = "txtItemPrice";
            txtItemPrice.PlaceholderText = "Price";
            txtItemPrice.ReadOnly = true;
            txtItemPrice.Size = new Size(210, 16);
            txtItemPrice.TabIndex = 5;
            // 
            // lblItemPrice
            // 
            lblItemPrice.Anchor = AnchorStyles.None;
            lblItemPrice.AutoSize = true;
            lblItemPrice.BackColor = Color.Transparent;
            lblItemPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemPrice.ForeColor = Color.Black;
            lblItemPrice.Location = new Point(561, 212);
            lblItemPrice.Margin = new Padding(5);
            lblItemPrice.Name = "lblItemPrice";
            lblItemPrice.Size = new Size(87, 21);
            lblItemPrice.TabIndex = 20;
            lblItemPrice.Text = "Item Price";
            // 
            // pnlItemCategory
            // 
            pnlItemCategory.Anchor = AnchorStyles.None;
            pnlItemCategory.BackColor = Color.FromArgb(225, 217, 242);
            pnlItemCategory.Controls.Add(txtItemCat);
            pnlItemCategory.Location = new Point(561, 318);
            pnlItemCategory.Name = "pnlItemCategory";
            pnlItemCategory.Size = new Size(227, 40);
            pnlItemCategory.TabIndex = 19;
            // 
            // txtItemCat
            // 
            txtItemCat.BackColor = Color.FromArgb(225, 217, 242);
            txtItemCat.BorderStyle = BorderStyle.None;
            txtItemCat.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemCat.Location = new Point(10, 12);
            txtItemCat.Name = "txtItemCat";
            txtItemCat.PlaceholderText = "Category";
            txtItemCat.ReadOnly = true;
            txtItemCat.Size = new Size(210, 16);
            txtItemCat.TabIndex = 5;
            // 
            // itemNamePanel
            // 
            itemNamePanel.Anchor = AnchorStyles.None;
            itemNamePanel.BackColor = Color.FromArgb(225, 217, 242);
            itemNamePanel.Controls.Add(txtItemName);
            itemNamePanel.Location = new Point(561, 164);
            itemNamePanel.Name = "itemNamePanel";
            itemNamePanel.Size = new Size(227, 40);
            itemNamePanel.TabIndex = 18;
            // 
            // txtItemName
            // 
            txtItemName.BackColor = Color.FromArgb(225, 217, 242);
            txtItemName.BorderStyle = BorderStyle.None;
            txtItemName.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemName.Location = new Point(10, 12);
            txtItemName.Name = "txtItemName";
            txtItemName.PlaceholderText = "Name";
            txtItemName.ReadOnly = true;
            txtItemName.Size = new Size(210, 16);
            txtItemName.TabIndex = 5;
            // 
            // lblItemCat
            // 
            lblItemCat.Anchor = AnchorStyles.None;
            lblItemCat.AutoSize = true;
            lblItemCat.BackColor = Color.Transparent;
            lblItemCat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemCat.ForeColor = Color.Black;
            lblItemCat.Location = new Point(561, 289);
            lblItemCat.Margin = new Padding(5);
            lblItemCat.Name = "lblItemCat";
            lblItemCat.Size = new Size(80, 21);
            lblItemCat.TabIndex = 17;
            lblItemCat.Text = "Category";
            // 
            // lblItemName
            // 
            lblItemName.Anchor = AnchorStyles.None;
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.Transparent;
            lblItemName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemName.ForeColor = Color.Black;
            lblItemName.Location = new Point(561, 135);
            lblItemName.Margin = new Padding(5);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(99, 21);
            lblItemName.TabIndex = 16;
            lblItemName.Text = "Item Name ";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(225, 217, 242);
            panel1.Controls.Add(txtItemId);
            panel1.Location = new Point(561, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 40);
            panel1.TabIndex = 28;
            // 
            // txtItemId
            // 
            txtItemId.BackColor = Color.FromArgb(225, 217, 242);
            txtItemId.BorderStyle = BorderStyle.None;
            txtItemId.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemId.Location = new Point(10, 12);
            txtItemId.Name = "txtItemId";
            txtItemId.PlaceholderText = "Id";
            txtItemId.ReadOnly = true;
            txtItemId.Size = new Size(210, 16);
            txtItemId.TabIndex = 5;
            // 
            // lblItemId
            // 
            lblItemId.Anchor = AnchorStyles.None;
            lblItemId.AutoSize = true;
            lblItemId.BackColor = Color.Transparent;
            lblItemId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemId.ForeColor = Color.Black;
            lblItemId.Location = new Point(561, 58);
            lblItemId.Margin = new Padding(5);
            lblItemId.Name = "lblItemId";
            lblItemId.Size = new Size(64, 21);
            lblItemId.TabIndex = 27;
            lblItemId.Text = "Item Id";
            // 
            // DeleteItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 800);
            Controls.Add(panel1);
            Controls.Add(lblItemId);
            Controls.Add(rtbItemDesc);
            Controls.Add(lblItemDesc);
            Controls.Add(btnDeleteItem);
            Controls.Add(pnlItemQuantity);
            Controls.Add(lblItemQuan);
            Controls.Add(itemPricePanel);
            Controls.Add(lblItemPrice);
            Controls.Add(pnlItemCategory);
            Controls.Add(itemNamePanel);
            Controls.Add(lblItemCat);
            Controls.Add(lblItemName);
            Controls.Add(dgvProduct);
            Controls.Add(lblDelItem);
            Name = "DeleteItemForm";
            Text = "DeleteItemForm";
            Load += DeleteItemForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            pnlItemQuantity.ResumeLayout(false);
            pnlItemQuantity.PerformLayout();
            itemPricePanel.ResumeLayout(false);
            itemPricePanel.PerformLayout();
            pnlItemCategory.ResumeLayout(false);
            pnlItemCategory.PerformLayout();
            itemNamePanel.ResumeLayout(false);
            itemNamePanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDelItem;
        private DataGridView dgvProduct;
        private RichTextBox rtbItemDesc;
        private Label lblItemDesc;
        private Button btnDeleteItem;
        private Panel pnlItemQuantity;
        private TextBox txtItemQuan;
        private Label lblItemQuan;
        private Panel itemPricePanel;
        private TextBox txtItemPrice;
        private Label lblItemPrice;
        private Panel pnlItemCategory;
        private TextBox txtItemCat;
        private Panel itemNamePanel;
        private TextBox txtItemName;
        private Label lblItemCat;
        private Label lblItemName;
        private Panel panel1;
        private TextBox txtItemId;
        private Label lblItemId;
    }
}