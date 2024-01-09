namespace Project.Pages.InventoryForms
{
    partial class UpdateInventoryForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblUpdateItem = new Label();
            pnlItemId = new Panel();
            txtItemId = new TextBox();
            rtbItemDesc = new RichTextBox();
            lblItemDesc = new Label();
            btnUpdateItem = new Button();
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
            lblItemId = new Label();
            dgvProduct = new DataGridView();
            pnlDesc = new Panel();
            pnlItemId.SuspendLayout();
            pnlItemQuantity.SuspendLayout();
            itemPricePanel.SuspendLayout();
            pnlItemCategory.SuspendLayout();
            itemNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            pnlDesc.SuspendLayout();
            SuspendLayout();
            // 
            // lblUpdateItem
            // 
            lblUpdateItem.BackColor = Color.FromArgb(57, 36, 103);
            lblUpdateItem.Dock = DockStyle.Top;
            lblUpdateItem.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUpdateItem.ForeColor = SystemColors.Control;
            lblUpdateItem.Location = new Point(0, 0);
            lblUpdateItem.Name = "lblUpdateItem";
            lblUpdateItem.Size = new Size(800, 50);
            lblUpdateItem.TabIndex = 0;
            lblUpdateItem.Text = "Update Item";
            lblUpdateItem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlItemId
            // 
            pnlItemId.Anchor = AnchorStyles.None;
            pnlItemId.BackColor = Color.FromArgb(225, 217, 242);
            pnlItemId.Controls.Add(txtItemId);
            pnlItemId.Location = new Point(561, 87);
            pnlItemId.Name = "pnlItemId";
            pnlItemId.Size = new Size(227, 40);
            pnlItemId.TabIndex = 41;
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
            // rtbItemDesc
            // 
            rtbItemDesc.Anchor = AnchorStyles.None;
            rtbItemDesc.BackColor = Color.FromArgb(225, 217, 242);
            rtbItemDesc.BorderStyle = BorderStyle.None;
            rtbItemDesc.Location = new Point(0, 0);
            rtbItemDesc.Name = "rtbItemDesc";
            rtbItemDesc.Size = new Size(227, 184);
            rtbItemDesc.TabIndex = 40;
            rtbItemDesc.Text = "";
            rtbItemDesc.MouseClick += rtbItemDesc_MouseClick;
            rtbItemDesc.Leave += rtbItemDesc_Leave;
            // 
            // lblItemDesc
            // 
            lblItemDesc.Anchor = AnchorStyles.None;
            lblItemDesc.AutoSize = true;
            lblItemDesc.BackColor = Color.Transparent;
            lblItemDesc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemDesc.ForeColor = Color.Black;
            lblItemDesc.Location = new Point(561, 452);
            lblItemDesc.Margin = new Padding(5);
            lblItemDesc.Name = "lblItemDesc";
            lblItemDesc.Size = new Size(137, 21);
            lblItemDesc.TabIndex = 39;
            lblItemDesc.Text = "Item Description";
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.Anchor = AnchorStyles.None;
            btnUpdateItem.BackColor = Color.FromArgb(57, 36, 103);
            btnUpdateItem.Cursor = Cursors.Hand;
            btnUpdateItem.FlatAppearance.BorderColor = Color.FromArgb(57, 36, 135);
            btnUpdateItem.FlatAppearance.BorderSize = 2;
            btnUpdateItem.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 103, 177);
            btnUpdateItem.FlatStyle = FlatStyle.Flat;
            btnUpdateItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateItem.ForeColor = SystemColors.Control;
            btnUpdateItem.Location = new Point(561, 695);
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.Size = new Size(227, 45);
            btnUpdateItem.TabIndex = 38;
            btnUpdateItem.Tag = "";
            btnUpdateItem.Text = "Update Item";
            btnUpdateItem.UseVisualStyleBackColor = false;
            btnUpdateItem.Click += btnUpdateItem_Click;
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
            pnlItemQuantity.TabIndex = 37;
            // 
            // txtItemQuan
            // 
            txtItemQuan.BackColor = Color.FromArgb(225, 217, 242);
            txtItemQuan.BorderStyle = BorderStyle.None;
            txtItemQuan.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemQuan.Location = new Point(10, 12);
            txtItemQuan.Name = "txtItemQuan";
            txtItemQuan.PlaceholderText = "Quantity";
            txtItemQuan.Size = new Size(210, 16);
            txtItemQuan.TabIndex = 5;
            txtItemQuan.MouseClick += txtItemQuan_MouseClick;
            txtItemQuan.TextChanged += txtItemQuan_TextChanged;
            txtItemQuan.Leave += txtItemQuan_Leave;
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
            lblItemQuan.TabIndex = 36;
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
            itemPricePanel.TabIndex = 35;
            // 
            // txtItemPrice
            // 
            txtItemPrice.BackColor = Color.FromArgb(225, 217, 242);
            txtItemPrice.BorderStyle = BorderStyle.None;
            txtItemPrice.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemPrice.Location = new Point(10, 12);
            txtItemPrice.Name = "txtItemPrice";
            txtItemPrice.PlaceholderText = "Price";
            txtItemPrice.Size = new Size(210, 16);
            txtItemPrice.TabIndex = 5;
            txtItemPrice.MouseClick += txtItemPrice_MouseClick;
            txtItemPrice.TextChanged += txtItemPrice_TextChanged;
            txtItemPrice.Leave += txtItemPrice_Leave;
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
            lblItemPrice.TabIndex = 34;
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
            pnlItemCategory.TabIndex = 33;
            pnlItemCategory.Leave += pnlItemCategory_Leave;
            // 
            // txtItemCat
            // 
            txtItemCat.BackColor = Color.FromArgb(225, 217, 242);
            txtItemCat.BorderStyle = BorderStyle.None;
            txtItemCat.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemCat.Location = new Point(10, 12);
            txtItemCat.Name = "txtItemCat";
            txtItemCat.PlaceholderText = "Category";
            txtItemCat.Size = new Size(210, 16);
            txtItemCat.TabIndex = 5;
            txtItemCat.MouseClick += txtItemCat_MouseClick;
            // 
            // itemNamePanel
            // 
            itemNamePanel.Anchor = AnchorStyles.None;
            itemNamePanel.BackColor = Color.FromArgb(225, 217, 242);
            itemNamePanel.Controls.Add(txtItemName);
            itemNamePanel.Location = new Point(561, 164);
            itemNamePanel.Name = "itemNamePanel";
            itemNamePanel.Size = new Size(227, 40);
            itemNamePanel.TabIndex = 32;
            // 
            // txtItemName
            // 
            txtItemName.BackColor = Color.FromArgb(225, 217, 242);
            txtItemName.BorderStyle = BorderStyle.None;
            txtItemName.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemName.Location = new Point(10, 12);
            txtItemName.Name = "txtItemName";
            txtItemName.PlaceholderText = "Name";
            txtItemName.Size = new Size(210, 16);
            txtItemName.TabIndex = 5;
            txtItemName.MouseClick += txtItemName_MouseClick;
            txtItemName.Leave += txtItemName_Leave;
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
            lblItemCat.TabIndex = 31;
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
            lblItemName.TabIndex = 30;
            lblItemName.Text = "Item Name ";
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
            lblItemId.TabIndex = 42;
            lblItemId.Text = "Item Id";
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(135, 104, 202);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(135, 104, 202);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvProduct.DefaultCellStyle = dataGridViewCellStyle5;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.GridColor = Color.FromArgb(225, 217, 242);
            dgvProduct.Location = new Point(0, 50);
            dgvProduct.Margin = new Padding(0);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.Lavender;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(225, 217, 242);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvProduct.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            dgvProduct.RowTemplate.Height = 30;
            dgvProduct.RowTemplate.ReadOnly = true;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.ShowEditingIcon = false;
            dgvProduct.Size = new Size(547, 750);
            dgvProduct.TabIndex = 43;
            dgvProduct.CellClick += dgvProduct_CellClick_1;
            // 
            // pnlDesc
            // 
            pnlDesc.Controls.Add(rtbItemDesc);
            pnlDesc.Location = new Point(561, 481);
            pnlDesc.Name = "pnlDesc";
            pnlDesc.Size = new Size(227, 184);
            pnlDesc.TabIndex = 44;
            // 
            // UpdateInventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 800);
            Controls.Add(pnlDesc);
            Controls.Add(dgvProduct);
            Controls.Add(btnUpdateItem);
            Controls.Add(lblItemId);
            Controls.Add(lblItemDesc);
            Controls.Add(pnlItemId);
            Controls.Add(pnlItemQuantity);
            Controls.Add(itemNamePanel);
            Controls.Add(lblItemQuan);
            Controls.Add(lblItemPrice);
            Controls.Add(pnlItemCategory);
            Controls.Add(itemPricePanel);
            Controls.Add(lblItemCat);
            Controls.Add(lblItemName);
            Controls.Add(lblUpdateItem);
            Name = "UpdateInventoryForm";
            Text = "UpdateInventory";
            Load += UpdateInventoryForm_Load;
            pnlItemId.ResumeLayout(false);
            pnlItemId.PerformLayout();
            pnlItemQuantity.ResumeLayout(false);
            pnlItemQuantity.PerformLayout();
            itemPricePanel.ResumeLayout(false);
            itemPricePanel.PerformLayout();
            pnlItemCategory.ResumeLayout(false);
            pnlItemCategory.PerformLayout();
            itemNamePanel.ResumeLayout(false);
            itemNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            pnlDesc.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUpdateItem;
        private Panel pnlItemId;
        private TextBox txtItemId;
        private RichTextBox rtbItemDesc;
        private Label lblItemDesc;
        private Button btnUpdateItem;
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
        private Label lblItemId;
        private DataGridView dgvProduct;
        private Panel pnlDesc;
    }
}