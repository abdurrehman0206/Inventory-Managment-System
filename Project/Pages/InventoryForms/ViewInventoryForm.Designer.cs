namespace Project.Pages.InventoryForms
{
    partial class ViewInventoryForm
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
            lblViewInv = new Label();
            dgvProduct = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // lblViewInv
            // 
            lblViewInv.BackColor = Color.FromArgb(57, 36, 103);
            lblViewInv.Dock = DockStyle.Top;
            lblViewInv.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblViewInv.ForeColor = SystemColors.Control;
            lblViewInv.Location = new Point(0, 0);
            lblViewInv.Name = "lblViewInv";
            lblViewInv.Size = new Size(800, 50);
            lblViewInv.TabIndex = 0;
            lblViewInv.Text = "Inventory Info";
            lblViewInv.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvProduct
            // 
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
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Cursor = Cursors.Default;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProduct.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProduct.Dock = DockStyle.Fill;
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
            dgvProduct.ShowEditingIcon = false;
            dgvProduct.Size = new Size(800, 750);
            dgvProduct.TabIndex = 12;
            // 
            // ViewInventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 800);
            Controls.Add(dgvProduct);
            Controls.Add(lblViewInv);
            Cursor = Cursors.Hand;
            Name = "ViewInventoryForm";
            Text = "ViewInventory";
            Load += ViewInventoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblViewInv;
        private DataGridView dgvProduct;
    }
}