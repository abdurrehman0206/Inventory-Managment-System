namespace Project.Pages.SuppliersForms
{
    partial class UpdateSupplierForm
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
            lblUpdateSup = new Label();
            dgvSupplier = new DataGridView();
            lblId = new Label();
            pnlId = new Panel();
            txtId = new TextBox();
            lblName = new Label();
            pnlName = new Panel();
            txtName = new TextBox();
            lblNum = new Label();
            pnlNum = new Panel();
            txtNum = new TextBox();
            lblEmail = new Label();
            pnlEmail = new Panel();
            txtEmail = new TextBox();
            lblAddress = new Label();
            pnlAddress = new Panel();
            txtAddress = new TextBox();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            pnlId.SuspendLayout();
            pnlName.SuspendLayout();
            pnlNum.SuspendLayout();
            pnlEmail.SuspendLayout();
            pnlAddress.SuspendLayout();
            SuspendLayout();
            // 
            // lblUpdateSup
            // 
            lblUpdateSup.BackColor = Color.FromArgb(57, 36, 103);
            lblUpdateSup.Dock = DockStyle.Top;
            lblUpdateSup.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUpdateSup.ForeColor = SystemColors.Control;
            lblUpdateSup.Location = new Point(0, 0);
            lblUpdateSup.Margin = new Padding(0);
            lblUpdateSup.Name = "lblUpdateSup";
            lblUpdateSup.Size = new Size(800, 50);
            lblUpdateSup.TabIndex = 0;
            lblUpdateSup.Text = "Update Supplier";
            lblUpdateSup.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvSupplier
            // 
            dgvSupplier.AllowUserToAddRows = false;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(135, 104, 202);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(135, 104, 202);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSupplier.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSupplier.EnableHeadersVisualStyles = false;
            dgvSupplier.GridColor = Color.FromArgb(225, 217, 242);
            dgvSupplier.Location = new Point(0, 50);
            dgvSupplier.Margin = new Padding(0);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.Lavender;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(225, 217, 242);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvSupplier.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvSupplier.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            dgvSupplier.RowTemplate.Height = 30;
            dgvSupplier.RowTemplate.ReadOnly = true;
            dgvSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSupplier.ShowEditingIcon = false;
            dgvSupplier.Size = new Size(547, 750);
            dgvSupplier.TabIndex = 30;
            dgvSupplier.CellClick += dgvSupplier_CellClick;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.ForeColor = Color.Black;
            lblId.Location = new Point(561, 58);
            lblId.Margin = new Padding(5);
            lblId.Name = "lblId";
            lblId.Size = new Size(93, 21);
            lblId.TabIndex = 43;
            lblId.Text = "Supplier Id";
            // 
            // pnlId
            // 
            pnlId.Anchor = AnchorStyles.None;
            pnlId.BackColor = Color.FromArgb(225, 217, 242);
            pnlId.Controls.Add(txtId);
            pnlId.Location = new Point(561, 87);
            pnlId.Name = "pnlId";
            pnlId.Size = new Size(227, 40);
            pnlId.TabIndex = 44;
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(225, 217, 242);
            txtId.BorderStyle = BorderStyle.None;
            txtId.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(10, 12);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Id";
            txtId.ReadOnly = true;
            txtId.Size = new Size(210, 16);
            txtId.TabIndex = 5;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(561, 135);
            lblName.Margin = new Padding(5);
            lblName.Name = "lblName";
            lblName.Size = new Size(128, 21);
            lblName.TabIndex = 45;
            lblName.Text = "Supplier Name ";
            // 
            // pnlName
            // 
            pnlName.Anchor = AnchorStyles.None;
            pnlName.BackColor = Color.FromArgb(225, 217, 242);
            pnlName.Controls.Add(txtName);
            pnlName.Location = new Point(561, 164);
            pnlName.Name = "pnlName";
            pnlName.Size = new Size(227, 40);
            pnlName.TabIndex = 46;
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
            // lblNum
            // 
            lblNum.Anchor = AnchorStyles.None;
            lblNum.AutoSize = true;
            lblNum.BackColor = Color.Transparent;
            lblNum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNum.ForeColor = Color.Black;
            lblNum.Location = new Point(561, 212);
            lblNum.Margin = new Padding(5);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(136, 21);
            lblNum.TabIndex = 47;
            lblNum.Text = "Contact Number";
            // 
            // pnlNum
            // 
            pnlNum.Anchor = AnchorStyles.None;
            pnlNum.BackColor = Color.FromArgb(225, 217, 242);
            pnlNum.Controls.Add(txtNum);
            pnlNum.Cursor = Cursors.Hand;
            pnlNum.Location = new Point(561, 241);
            pnlNum.Name = "pnlNum";
            pnlNum.Size = new Size(227, 40);
            pnlNum.TabIndex = 48;
            // 
            // txtNum
            // 
            txtNum.BackColor = Color.FromArgb(225, 217, 242);
            txtNum.BorderStyle = BorderStyle.None;
            txtNum.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNum.Location = new Point(10, 12);
            txtNum.Name = "txtNum";
            txtNum.PlaceholderText = "Number";
            txtNum.Size = new Size(210, 16);
            txtNum.TabIndex = 5;
            txtNum.MouseClick += txtNum_MouseClick;
            txtNum.Leave += txtNum_Leave;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(561, 289);
            lblEmail.Margin = new Padding(5);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 21);
            lblEmail.TabIndex = 49;
            lblEmail.Text = "Email";
            // 
            // pnlEmail
            // 
            pnlEmail.Anchor = AnchorStyles.None;
            pnlEmail.BackColor = Color.FromArgb(225, 217, 242);
            pnlEmail.Controls.Add(txtEmail);
            pnlEmail.Location = new Point(561, 318);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.Size = new Size(227, 40);
            pnlEmail.TabIndex = 50;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(225, 217, 242);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(10, 12);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(210, 16);
            txtEmail.TabIndex = 5;
            txtEmail.MouseClick += txtEmail_MouseClick;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // lblAddress
            // 
            lblAddress.Anchor = AnchorStyles.None;
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.ForeColor = Color.Black;
            lblAddress.Location = new Point(561, 366);
            lblAddress.Margin = new Padding(5);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 21);
            lblAddress.TabIndex = 51;
            lblAddress.Text = "Address";
            // 
            // pnlAddress
            // 
            pnlAddress.Anchor = AnchorStyles.None;
            pnlAddress.BackColor = Color.FromArgb(225, 217, 242);
            pnlAddress.Controls.Add(txtAddress);
            pnlAddress.Cursor = Cursors.Hand;
            pnlAddress.Location = new Point(561, 395);
            pnlAddress.Name = "pnlAddress";
            pnlAddress.Size = new Size(227, 40);
            pnlAddress.TabIndex = 52;
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
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.FromArgb(57, 36, 103);
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(57, 36, 135);
            btnUpdate.FlatAppearance.BorderSize = 2;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 103, 177);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(561, 490);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(227, 45);
            btnUpdate.TabIndex = 53;
            btnUpdate.Tag = "";
            btnUpdate.Text = "Update Supplier";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // UpdateSupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 800);
            Controls.Add(btnUpdate);
            Controls.Add(pnlAddress);
            Controls.Add(lblAddress);
            Controls.Add(pnlEmail);
            Controls.Add(lblEmail);
            Controls.Add(pnlNum);
            Controls.Add(lblNum);
            Controls.Add(pnlName);
            Controls.Add(lblName);
            Controls.Add(pnlId);
            Controls.Add(lblId);
            Controls.Add(dgvSupplier);
            Controls.Add(lblUpdateSup);
            Name = "UpdateSupplierForm";
            Text = "UpdateSupplierForm";
            Load += UpdateSupplierForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            pnlId.ResumeLayout(false);
            pnlId.PerformLayout();
            pnlName.ResumeLayout(false);
            pnlName.PerformLayout();
            pnlNum.ResumeLayout(false);
            pnlNum.PerformLayout();
            pnlEmail.ResumeLayout(false);
            pnlEmail.PerformLayout();
            pnlAddress.ResumeLayout(false);
            pnlAddress.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUpdateSup;
        private DataGridView dgvSupplier;
        private Label lblId;
        private Panel pnlId;
        private TextBox txtId;
        private Label lblName;
        private Panel pnlName;
        private TextBox txtName;
        private Label lblNum;
        private Panel pnlNum;
        private TextBox txtNum;
        private Label lblEmail;
        private Panel pnlEmail;
        private TextBox txtEmail;
        private Label lblAddress;
        private Panel pnlAddress;
        private TextBox txtAddress;
        private Button btnUpdate;
    }
}