namespace Project.Pages.InventoryForms
{
    partial class AddItemForm
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
            lblAddItem = new Label();
            lblItemName = new Label();
            lblItemCat = new Label();
            itemNamePanel = new Panel();
            tfItemName = new TextBox();
            pnlItemCategory = new Panel();
            tfItemCat = new TextBox();
            lblItemPrice = new Label();
            itemPricePanel = new Panel();
            tfItemPrice = new TextBox();
            lblItemQuan = new Label();
            pnlItemQuantity = new Panel();
            tfItemQuan = new TextBox();
            btnAddItem = new Button();
            lblItemDesc = new Label();
            rtbItemDesc = new RichTextBox();
            itemNamePanel.SuspendLayout();
            pnlItemCategory.SuspendLayout();
            itemPricePanel.SuspendLayout();
            pnlItemQuantity.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddItem
            // 
            lblAddItem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAddItem.BackColor = Color.FromArgb(57, 36, 103);
            lblAddItem.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddItem.ForeColor = SystemColors.Control;
            lblAddItem.Location = new Point(0, 0);
            lblAddItem.Name = "lblAddItem";
            lblAddItem.Size = new Size(800, 50);
            lblAddItem.TabIndex = 0;
            lblAddItem.Text = "Add New Item";
            lblAddItem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblItemName
            // 
            lblItemName.Anchor = AnchorStyles.None;
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.Transparent;
            lblItemName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemName.ForeColor = Color.Black;
            lblItemName.Location = new Point(66, 121);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(99, 21);
            lblItemName.TabIndex = 2;
            lblItemName.Text = "Item Name ";
            // 
            // lblItemCat
            // 
            lblItemCat.Anchor = AnchorStyles.None;
            lblItemCat.AutoSize = true;
            lblItemCat.BackColor = Color.Transparent;
            lblItemCat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemCat.ForeColor = Color.Black;
            lblItemCat.Location = new Point(505, 121);
            lblItemCat.Name = "lblItemCat";
            lblItemCat.Size = new Size(80, 21);
            lblItemCat.TabIndex = 4;
            lblItemCat.Text = "Category";
            // 
            // itemNamePanel
            // 
            itemNamePanel.Anchor = AnchorStyles.None;
            itemNamePanel.BackColor = Color.FromArgb(225, 217, 242);
            itemNamePanel.Controls.Add(tfItemName);
            itemNamePanel.Location = new Point(66, 155);
            itemNamePanel.Name = "itemNamePanel";
            itemNamePanel.Size = new Size(227, 40);
            itemNamePanel.TabIndex = 7;
            // 
            // tfItemName
            // 
            tfItemName.BackColor = Color.FromArgb(225, 217, 242);
            tfItemName.BorderStyle = BorderStyle.None;
            tfItemName.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tfItemName.Location = new Point(10, 12);
            tfItemName.Name = "tfItemName";
            tfItemName.PlaceholderText = "Name";
            tfItemName.Size = new Size(210, 16);
            tfItemName.TabIndex = 5;
            tfItemName.MouseClick += tfItemName_MouseClick;
            tfItemName.Leave += tfItemName_Leave;
            // 
            // pnlItemCategory
            // 
            pnlItemCategory.Anchor = AnchorStyles.None;
            pnlItemCategory.BackColor = Color.FromArgb(225, 217, 242);
            pnlItemCategory.Controls.Add(tfItemCat);
            pnlItemCategory.Location = new Point(505, 155);
            pnlItemCategory.Name = "pnlItemCategory";
            pnlItemCategory.Size = new Size(227, 40);
            pnlItemCategory.TabIndex = 8;
            // 
            // tfItemCat
            // 
            tfItemCat.BackColor = Color.FromArgb(225, 217, 242);
            tfItemCat.BorderStyle = BorderStyle.None;
            tfItemCat.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tfItemCat.Location = new Point(10, 12);
            tfItemCat.Name = "tfItemCat";
            tfItemCat.PlaceholderText = "Category";
            tfItemCat.Size = new Size(210, 16);
            tfItemCat.TabIndex = 5;
            tfItemCat.MouseClick += tfItemCat_MouseClick;
            tfItemCat.Leave += tfItemCat_Leave;
            // 
            // lblItemPrice
            // 
            lblItemPrice.Anchor = AnchorStyles.None;
            lblItemPrice.AutoSize = true;
            lblItemPrice.BackColor = Color.Transparent;
            lblItemPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemPrice.ForeColor = Color.Black;
            lblItemPrice.Location = new Point(66, 261);
            lblItemPrice.Name = "lblItemPrice";
            lblItemPrice.Size = new Size(87, 21);
            lblItemPrice.TabIndex = 9;
            lblItemPrice.Text = "Item Price";
            // 
            // itemPricePanel
            // 
            itemPricePanel.Anchor = AnchorStyles.None;
            itemPricePanel.BackColor = Color.FromArgb(225, 217, 242);
            itemPricePanel.Controls.Add(tfItemPrice);
            itemPricePanel.Cursor = Cursors.Hand;
            itemPricePanel.Location = new Point(66, 297);
            itemPricePanel.Name = "itemPricePanel";
            itemPricePanel.Size = new Size(227, 40);
            itemPricePanel.TabIndex = 10;
            // 
            // tfItemPrice
            // 
            tfItemPrice.BackColor = Color.FromArgb(225, 217, 242);
            tfItemPrice.BorderStyle = BorderStyle.None;
            tfItemPrice.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tfItemPrice.Location = new Point(10, 12);
            tfItemPrice.Name = "tfItemPrice";
            tfItemPrice.PlaceholderText = "Price";
            tfItemPrice.Size = new Size(210, 16);
            tfItemPrice.TabIndex = 5;
            tfItemPrice.MouseClick += tfItemPrice_MouseClick;
            tfItemPrice.TextChanged += tfItemPrice_TextChanged;
            tfItemPrice.Leave += tfItemPrice_Leave;
            // 
            // lblItemQuan
            // 
            lblItemQuan.Anchor = AnchorStyles.None;
            lblItemQuan.AutoSize = true;
            lblItemQuan.BackColor = Color.Transparent;
            lblItemQuan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemQuan.ForeColor = Color.Black;
            lblItemQuan.Location = new Point(505, 261);
            lblItemQuan.Name = "lblItemQuan";
            lblItemQuan.Size = new Size(116, 21);
            lblItemQuan.TabIndex = 11;
            lblItemQuan.Text = "Item Quantity";
            // 
            // pnlItemQuantity
            // 
            pnlItemQuantity.Anchor = AnchorStyles.None;
            pnlItemQuantity.BackColor = Color.FromArgb(225, 217, 242);
            pnlItemQuantity.Controls.Add(tfItemQuan);
            pnlItemQuantity.Cursor = Cursors.Hand;
            pnlItemQuantity.Location = new Point(505, 297);
            pnlItemQuantity.Name = "pnlItemQuantity";
            pnlItemQuantity.Size = new Size(227, 40);
            pnlItemQuantity.TabIndex = 12;
            // 
            // tfItemQuan
            // 
            tfItemQuan.BackColor = Color.FromArgb(225, 217, 242);
            tfItemQuan.BorderStyle = BorderStyle.None;
            tfItemQuan.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tfItemQuan.Location = new Point(10, 12);
            tfItemQuan.Name = "tfItemQuan";
            tfItemQuan.PlaceholderText = "Item Name";
            tfItemQuan.Size = new Size(210, 16);
            tfItemQuan.TabIndex = 5;
            tfItemQuan.MouseClick += tfItemQuan_MouseClick;
            tfItemQuan.TextChanged += tfItemQuan_TextChanged;
            tfItemQuan.Leave += tfItemQuan_Leave;
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = AnchorStyles.None;
            btnAddItem.BackColor = Color.FromArgb(57, 36, 103);
            btnAddItem.FlatAppearance.BorderColor = Color.FromArgb(57, 36, 135);
            btnAddItem.FlatAppearance.BorderSize = 2;
            btnAddItem.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 103, 177);
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddItem.ForeColor = SystemColors.Control;
            btnAddItem.Location = new Point(331, 642);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(149, 45);
            btnAddItem.TabIndex = 13;
            btnAddItem.Tag = "";
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            // 
            // lblItemDesc
            // 
            lblItemDesc.Anchor = AnchorStyles.None;
            lblItemDesc.AutoSize = true;
            lblItemDesc.BackColor = Color.Transparent;
            lblItemDesc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemDesc.ForeColor = Color.Black;
            lblItemDesc.Location = new Point(66, 395);
            lblItemDesc.Name = "lblItemDesc";
            lblItemDesc.Size = new Size(137, 21);
            lblItemDesc.TabIndex = 14;
            lblItemDesc.Text = "Item Description";
            // 
            // rtbItemDesc
            // 
            rtbItemDesc.Anchor = AnchorStyles.None;
            rtbItemDesc.BackColor = Color.FromArgb(225, 217, 242);
            rtbItemDesc.BorderStyle = BorderStyle.None;
            rtbItemDesc.Location = new Point(66, 446);
            rtbItemDesc.Name = "rtbItemDesc";
            rtbItemDesc.Size = new Size(666, 158);
            rtbItemDesc.TabIndex = 15;
            rtbItemDesc.Text = "";
            rtbItemDesc.MouseClick += rtbItemDesc_MouseClick;
            rtbItemDesc.Leave += rtbItemDesc_Leave;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 800);
            Controls.Add(rtbItemDesc);
            Controls.Add(lblItemDesc);
            Controls.Add(btnAddItem);
            Controls.Add(pnlItemQuantity);
            Controls.Add(lblItemQuan);
            Controls.Add(itemPricePanel);
            Controls.Add(lblItemPrice);
            Controls.Add(pnlItemCategory);
            Controls.Add(itemNamePanel);
            Controls.Add(lblItemCat);
            Controls.Add(lblItemName);
            Controls.Add(lblAddItem);
            Cursor = Cursors.Hand;
            Name = "AddItemForm";
            Text = "InventoryAddItemForm";
            itemNamePanel.ResumeLayout(false);
            itemNamePanel.PerformLayout();
            pnlItemCategory.ResumeLayout(false);
            pnlItemCategory.PerformLayout();
            itemPricePanel.ResumeLayout(false);
            itemPricePanel.PerformLayout();
            pnlItemQuantity.ResumeLayout(false);
            pnlItemQuantity.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddItem;
        private Label lblItemName;
        private Label lblItemCat;
        private Panel itemNamePanel;
        private TextBox tfItemName;
        private Panel pnlItemCategory;
        private TextBox tfItemCat;
        private Label lblItemPrice;
        private Panel itemPricePanel;
        private TextBox tfItemPrice;
        private Label lblItemQuan;
        private Panel pnlItemQuantity;
        private TextBox tfItemQuan;
        private Button btnAddItem;
        private Label lblItemDesc;
        private RichTextBox rtbItemDesc;
    }
}