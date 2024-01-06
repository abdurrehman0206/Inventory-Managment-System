namespace Project
{
    partial class InventoryAddItemForm
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
            addItemHeader = new Label();
            itemNameLabel = new Label();
            itemCategoryLabel = new Label();
            itemNamePanel = new Panel();
            itemNameTextField = new TextBox();
            itemCategoryPanel = new Panel();
            itemCategoryTextField = new TextBox();
            itemPriceLabel = new Label();
            itemPricePanel = new Panel();
            itemPriceTextField = new TextBox();
            itemQuantityLabel = new Label();
            itemQuantityPanel = new Panel();
            itemQuantityTextField = new TextBox();
            itemAddBtn = new Button();
            itemDescLabel = new Label();
            itemDescRichTextBox = new RichTextBox();
            itemNamePanel.SuspendLayout();
            itemCategoryPanel.SuspendLayout();
            itemPricePanel.SuspendLayout();
            itemQuantityPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addItemHeader
            // 
            addItemHeader.BackColor = Color.FromArgb(57, 36, 103);
            addItemHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            addItemHeader.ForeColor = SystemColors.Control;
            addItemHeader.Location = new Point(-2, -1);
            addItemHeader.Name = "addItemHeader";
            addItemHeader.Size = new Size(803, 50);
            addItemHeader.TabIndex = 0;
            addItemHeader.Text = "Add New Item";
            addItemHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.BackColor = Color.Transparent;
            itemNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            itemNameLabel.ForeColor = Color.Black;
            itemNameLabel.Location = new Point(66, 121);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(99, 21);
            itemNameLabel.TabIndex = 2;
            itemNameLabel.Text = "Item Name ";
            // 
            // itemCategoryLabel
            // 
            itemCategoryLabel.AutoSize = true;
            itemCategoryLabel.BackColor = Color.Transparent;
            itemCategoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            itemCategoryLabel.ForeColor = Color.Black;
            itemCategoryLabel.Location = new Point(505, 121);
            itemCategoryLabel.Name = "itemCategoryLabel";
            itemCategoryLabel.Size = new Size(80, 21);
            itemCategoryLabel.TabIndex = 4;
            itemCategoryLabel.Text = "Category";
            // 
            // itemNamePanel
            // 
            itemNamePanel.BackColor = SystemColors.ButtonFace;
            itemNamePanel.Controls.Add(itemNameTextField);
            itemNamePanel.Location = new Point(66, 155);
            itemNamePanel.Name = "itemNamePanel";
            itemNamePanel.Size = new Size(227, 40);
            itemNamePanel.TabIndex = 7;
            // 
            // itemNameTextField
            // 
            itemNameTextField.BackColor = SystemColors.ButtonFace;
            itemNameTextField.BorderStyle = BorderStyle.None;
            itemNameTextField.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            itemNameTextField.Location = new Point(14, 10);
            itemNameTextField.Name = "itemNameTextField";
            itemNameTextField.PlaceholderText = "name";
            itemNameTextField.Size = new Size(210, 16);
            itemNameTextField.TabIndex = 5;
            itemNameTextField.MouseClick += itemNameTextField_MouseClick;
            itemNameTextField.Leave += itemNameTextField_Leave;
            // 
            // itemCategoryPanel
            // 
            itemCategoryPanel.BackColor = SystemColors.ButtonFace;
            itemCategoryPanel.Controls.Add(itemCategoryTextField);
            itemCategoryPanel.Location = new Point(505, 155);
            itemCategoryPanel.Name = "itemCategoryPanel";
            itemCategoryPanel.Size = new Size(227, 40);
            itemCategoryPanel.TabIndex = 8;
            // 
            // itemCategoryTextField
            // 
            itemCategoryTextField.BackColor = SystemColors.ButtonFace;
            itemCategoryTextField.BorderStyle = BorderStyle.None;
            itemCategoryTextField.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            itemCategoryTextField.Location = new Point(14, 10);
            itemCategoryTextField.Name = "itemCategoryTextField";
            itemCategoryTextField.PlaceholderText = "category";
            itemCategoryTextField.Size = new Size(210, 16);
            itemCategoryTextField.TabIndex = 5;
            itemCategoryTextField.MouseClick += itemCategoryTextField_MouseClick;
            itemCategoryTextField.Leave += itemCategoryTextField_Leave;
            // 
            // itemPriceLabel
            // 
            itemPriceLabel.AutoSize = true;
            itemPriceLabel.BackColor = Color.Transparent;
            itemPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            itemPriceLabel.ForeColor = Color.Black;
            itemPriceLabel.Location = new Point(66, 261);
            itemPriceLabel.Name = "itemPriceLabel";
            itemPriceLabel.Size = new Size(87, 21);
            itemPriceLabel.TabIndex = 9;
            itemPriceLabel.Text = "Item Price";
            // 
            // itemPricePanel
            // 
            itemPricePanel.BackColor = SystemColors.ButtonFace;
            itemPricePanel.Controls.Add(itemPriceTextField);
            itemPricePanel.Cursor = Cursors.Hand;
            itemPricePanel.Location = new Point(66, 297);
            itemPricePanel.Name = "itemPricePanel";
            itemPricePanel.Size = new Size(227, 40);
            itemPricePanel.TabIndex = 10;
            // 
            // itemPriceTextField
            // 
            itemPriceTextField.BackColor = SystemColors.ButtonFace;
            itemPriceTextField.BorderStyle = BorderStyle.None;
            itemPriceTextField.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            itemPriceTextField.Location = new Point(14, 10);
            itemPriceTextField.Name = "itemPriceTextField";
            itemPriceTextField.PlaceholderText = "price";
            itemPriceTextField.Size = new Size(210, 16);
            itemPriceTextField.TabIndex = 5;
            itemPriceTextField.MouseClick += itemPriceTextField_MouseClick;
            itemPriceTextField.TextChanged += itemPriceTextField_TextChanged;
            itemPriceTextField.Leave += itemPriceTextField_Leave;
            // 
            // itemQuantityLabel
            // 
            itemQuantityLabel.AutoSize = true;
            itemQuantityLabel.BackColor = Color.Transparent;
            itemQuantityLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            itemQuantityLabel.ForeColor = Color.Black;
            itemQuantityLabel.Location = new Point(505, 261);
            itemQuantityLabel.Name = "itemQuantityLabel";
            itemQuantityLabel.Size = new Size(116, 21);
            itemQuantityLabel.TabIndex = 11;
            itemQuantityLabel.Text = "Item Quantity";
            // 
            // itemQuantityPanel
            // 
            itemQuantityPanel.BackColor = SystemColors.ButtonFace;
            itemQuantityPanel.Controls.Add(itemQuantityTextField);
            itemQuantityPanel.Cursor = Cursors.Hand;
            itemQuantityPanel.Location = new Point(505, 297);
            itemQuantityPanel.Name = "itemQuantityPanel";
            itemQuantityPanel.Size = new Size(227, 40);
            itemQuantityPanel.TabIndex = 12;
            // 
            // itemQuantityTextField
            // 
            itemQuantityTextField.BackColor = SystemColors.ButtonFace;
            itemQuantityTextField.BorderStyle = BorderStyle.None;
            itemQuantityTextField.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            itemQuantityTextField.Location = new Point(14, 10);
            itemQuantityTextField.Name = "itemQuantityTextField";
            itemQuantityTextField.PlaceholderText = "Item Name";
            itemQuantityTextField.Size = new Size(210, 16);
            itemQuantityTextField.TabIndex = 5;
            itemQuantityTextField.MouseClick += itemQuantityTextField_MouseClick;
            itemQuantityTextField.TextChanged += itemQuantityTextField_TextChanged;
            itemQuantityTextField.Leave += itemQuantityTextField_Leave;
            // 
            // itemAddBtn
            // 
            itemAddBtn.BackColor = Color.FromArgb(57, 36, 103);
            itemAddBtn.FlatAppearance.BorderColor = Color.FromArgb(57, 36, 135);
            itemAddBtn.FlatAppearance.BorderSize = 2;
            itemAddBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 103, 177);
            itemAddBtn.FlatStyle = FlatStyle.Flat;
            itemAddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemAddBtn.ForeColor = SystemColors.Control;
            itemAddBtn.Location = new Point(281, 642);
            itemAddBtn.Name = "itemAddBtn";
            itemAddBtn.Size = new Size(149, 45);
            itemAddBtn.TabIndex = 13;
            itemAddBtn.Tag = "";
            itemAddBtn.Text = "Add Item";
            itemAddBtn.UseVisualStyleBackColor = false;
            // 
            // itemDescLabel
            // 
            itemDescLabel.AutoSize = true;
            itemDescLabel.BackColor = Color.Transparent;
            itemDescLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            itemDescLabel.ForeColor = Color.Black;
            itemDescLabel.Location = new Point(66, 395);
            itemDescLabel.Name = "itemDescLabel";
            itemDescLabel.Size = new Size(137, 21);
            itemDescLabel.TabIndex = 14;
            itemDescLabel.Text = "Item Description";
            // 
            // itemDescRichTextBox
            // 
            itemDescRichTextBox.BackColor = SystemColors.ButtonFace;
            itemDescRichTextBox.BorderStyle = BorderStyle.None;
            itemDescRichTextBox.Location = new Point(66, 446);
            itemDescRichTextBox.Name = "itemDescRichTextBox";
            itemDescRichTextBox.Size = new Size(666, 158);
            itemDescRichTextBox.TabIndex = 15;
            itemDescRichTextBox.Text = "";
            itemDescRichTextBox.MouseClick += itemDescRichTextBox_MouseClick;
            itemDescRichTextBox.Leave += itemDescRichTextBox_Leave;
            // 
            // InventoryAddItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 699);
            Controls.Add(itemDescRichTextBox);
            Controls.Add(itemDescLabel);
            Controls.Add(itemAddBtn);
            Controls.Add(itemQuantityPanel);
            Controls.Add(itemQuantityLabel);
            Controls.Add(itemPricePanel);
            Controls.Add(itemPriceLabel);
            Controls.Add(itemCategoryPanel);
            Controls.Add(itemNamePanel);
            Controls.Add(itemCategoryLabel);
            Controls.Add(itemNameLabel);
            Controls.Add(addItemHeader);
            Cursor = Cursors.Hand;
            Name = "InventoryAddItemForm";
            Text = "InventoryAddItemForm";
            itemNamePanel.ResumeLayout(false);
            itemNamePanel.PerformLayout();
            itemCategoryPanel.ResumeLayout(false);
            itemCategoryPanel.PerformLayout();
            itemPricePanel.ResumeLayout(false);
            itemPricePanel.PerformLayout();
            itemQuantityPanel.ResumeLayout(false);
            itemQuantityPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addItemHeader;
        private Label itemNameLabel;
        private Label itemCategoryLabel;
        private Panel itemNamePanel;
        private TextBox itemNameTextField;
        private Panel itemCategoryPanel;
        private TextBox itemCategoryTextField;
        private Label itemPriceLabel;
        private Panel itemPricePanel;
        private TextBox itemPriceTextField;
        private Label itemQuantityLabel;
        private Panel itemQuantityPanel;
        private TextBox itemQuantityTextField;
        private Button itemAddBtn;
        private Label itemDescLabel;
        private RichTextBox itemDescRichTextBox;
    }
}