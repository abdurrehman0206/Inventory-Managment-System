namespace Project.Pages.SuppliersForms
{
    partial class ViewSupplierForm
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
            lblSupInfo = new Label();
            dgvSupplier = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            SuspendLayout();
            // 
            // lblSupInfo
            // 
            lblSupInfo.BackColor = Color.FromArgb(57, 36, 103);
            lblSupInfo.Dock = DockStyle.Top;
            lblSupInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSupInfo.ForeColor = SystemColors.Control;
            lblSupInfo.Location = new Point(0, 0);
            lblSupInfo.Name = "lblSupInfo";
            lblSupInfo.Size = new Size(800, 50);
            lblSupInfo.TabIndex = 0;
            lblSupInfo.Text = "Supplier Info";
            lblSupInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvSupplier
            // 
            dgvSupplier.AllowUserToDeleteRows = false;
            dgvSupplier.AllowUserToOrderColumns = true;
            dgvSupplier.AllowUserToResizeColumns = false;
            dgvSupplier.AllowUserToResizeRows = false;
            dgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupplier.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSupplier.BackgroundColor = Color.Lavender;
            dgvSupplier.BorderStyle = BorderStyle.None;
            dgvSupplier.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvSupplier.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(135, 104, 202);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvSupplier.DefaultCellStyle = dataGridViewCellStyle5;
            dgvSupplier.Dock = DockStyle.Fill;
            dgvSupplier.EnableHeadersVisualStyles = false;
            dgvSupplier.GridColor = Color.FromArgb(225, 217, 242);
            dgvSupplier.Location = new Point(0, 50);
            dgvSupplier.Margin = new Padding(0);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.Lavender;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(225, 217, 242);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgvSupplier.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvSupplier.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            dgvSupplier.RowTemplate.Height = 30;
            dgvSupplier.RowTemplate.ReadOnly = true;
            dgvSupplier.ShowEditingIcon = false;
            dgvSupplier.Size = new Size(800, 750);
            dgvSupplier.TabIndex = 13;
            // 
            // ViewSupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 800);
            Controls.Add(dgvSupplier);
            Controls.Add(lblSupInfo);
            Name = "ViewSupplierForm";
            Text = "ViewSupplierForm";
            Load += ViewSupplierForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSupInfo;
        private DataGridView dgvSupplier;
    }
}