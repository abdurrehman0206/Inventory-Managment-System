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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            viewOrderFormHeader = new Label();
            dgvOrder = new DataGridView();
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
            viewOrderFormHeader.Size = new Size(784, 50);
            viewOrderFormHeader.TabIndex = 0;
            viewOrderFormHeader.Text = "Order Info";
            viewOrderFormHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToDeleteRows = false;
            dgvOrder.AllowUserToOrderColumns = true;
            dgvOrder.AllowUserToResizeColumns = false;
            dgvOrder.AllowUserToResizeRows = false;
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvOrder.DefaultCellStyle = dataGridViewCellStyle2;
            dgvOrder.Dock = DockStyle.Fill;
            dgvOrder.EnableHeadersVisualStyles = false;
            dgvOrder.GridColor = Color.FromArgb(225, 217, 242);
            dgvOrder.Location = new Point(0, 50);
            dgvOrder.Margin = new Padding(0);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.Lavender;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(225, 217, 242);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvOrder.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvOrder.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            dgvOrder.RowTemplate.Height = 30;
            dgvOrder.RowTemplate.ReadOnly = true;
            dgvOrder.ShowEditingIcon = false;
            dgvOrder.Size = new Size(784, 711);
            dgvOrder.TabIndex = 13;
            // 
            // lblViewOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 761);
            Controls.Add(dgvOrder);
            Controls.Add(viewOrderFormHeader);
            Name = "lblViewOrder";
            Text = "ViewOrdersForm";
            Load += lblViewOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label viewOrderFormHeader;
        private DataGridView dgvOrder;
    }
}