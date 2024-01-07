namespace Project.Pages.SuppliersForms
{
    partial class AddSupplierForm
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
            lblAddSup = new Label();
            lblName = new Label();
            pnlName = new Panel();
            txtName = new TextBox();
            lblNum = new Label();
            pnlNum = new Panel();
            txtNum = new TextBox();
            lblEmail = new Label();
            pnlEmail = new Panel();
            txtEmail = new TextBox();
            pnlAddress = new Panel();
            txtAddress = new TextBox();
            lblAddress = new Label();
            btnAdd = new Button();
            pnlName.SuspendLayout();
            pnlNum.SuspendLayout();
            pnlEmail.SuspendLayout();
            pnlAddress.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddSup
            // 
            lblAddSup.BackColor = Color.FromArgb(57, 36, 103);
            lblAddSup.Dock = DockStyle.Top;
            lblAddSup.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddSup.ForeColor = SystemColors.Control;
            lblAddSup.Location = new Point(0, 0);
            lblAddSup.Name = "lblAddSup";
            lblAddSup.Size = new Size(800, 50);
            lblAddSup.TabIndex = 0;
            lblAddSup.Text = "Add Supplier";
            lblAddSup.TextAlign = ContentAlignment.MiddleCenter;
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
            lblName.Size = new Size(124, 21);
            lblName.TabIndex = 3;
            lblName.Text = "Supplier Name";
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
            // lblNum
            // 
            lblNum.Anchor = AnchorStyles.None;
            lblNum.AutoSize = true;
            lblNum.BackColor = Color.Transparent;
            lblNum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNum.ForeColor = Color.Black;
            lblNum.Location = new Point(497, 101);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(136, 21);
            lblNum.TabIndex = 9;
            lblNum.Text = "Contact Number";
            // 
            // pnlNum
            // 
            pnlNum.Anchor = AnchorStyles.None;
            pnlNum.BackColor = Color.FromArgb(225, 217, 242);
            pnlNum.Controls.Add(txtNum);
            pnlNum.Location = new Point(497, 135);
            pnlNum.Name = "pnlNum";
            pnlNum.Size = new Size(227, 40);
            pnlNum.TabIndex = 10;
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
            txtNum.TextChanged += txtNum_TextChanged;
            txtNum.Leave += txtNum_Leave;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(58, 241);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 21);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email";
            // 
            // pnlEmail
            // 
            pnlEmail.Anchor = AnchorStyles.None;
            pnlEmail.BackColor = Color.FromArgb(225, 217, 242);
            pnlEmail.Controls.Add(txtEmail);
            pnlEmail.Location = new Point(58, 277);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.Size = new Size(227, 40);
            pnlEmail.TabIndex = 12;
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
            txtEmail.Validating += txtEmail_Validating;
            // 
            // pnlAddress
            // 
            pnlAddress.Anchor = AnchorStyles.None;
            pnlAddress.BackColor = Color.FromArgb(225, 217, 242);
            pnlAddress.Controls.Add(txtAddress);
            pnlAddress.Location = new Point(497, 277);
            pnlAddress.Name = "pnlAddress";
            pnlAddress.Size = new Size(227, 40);
            pnlAddress.TabIndex = 13;
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
            // lblAddress
            // 
            lblAddress.Anchor = AnchorStyles.None;
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.ForeColor = Color.Black;
            lblAddress.Location = new Point(497, 241);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 21);
            lblAddress.TabIndex = 14;
            lblAddress.Text = "Address";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.FromArgb(57, 36, 103);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(57, 36, 135);
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 103, 177);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(323, 422);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 45);
            btnAdd.TabIndex = 15;
            btnAdd.Tag = "";
            btnAdd.Text = "Add Supplier";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddSupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 800);
            Controls.Add(btnAdd);
            Controls.Add(lblAddress);
            Controls.Add(pnlAddress);
            Controls.Add(pnlEmail);
            Controls.Add(lblEmail);
            Controls.Add(pnlNum);
            Controls.Add(lblNum);
            Controls.Add(pnlName);
            Controls.Add(lblName);
            Controls.Add(lblAddSup);
            Name = "AddSupplierForm";
            Text = "AddSupplierForm";
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

        private Label lblAddSup;
        private Label lblName;
        private Panel pnlName;
        private TextBox txtName;
        private Label lblNum;
        private Panel pnlNum;
        private TextBox txtNum;
        private Label lblEmail;
        private Panel pnlEmail;
        private TextBox txtEmail;
        private Panel pnlAddress;
        private TextBox txtAddress;
        private Label lblAddress;
        private Button btnAdd;
    }
}