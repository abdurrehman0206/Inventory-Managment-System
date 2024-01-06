namespace Project.Pages.SuppliersForms
{
    partial class DeleteSupplierForm
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
            deleteSupplierFormHeader = new Label();
            SuspendLayout();
            // 
            // deleteSupplierFormHeader
            // 
            deleteSupplierFormHeader.BackColor = Color.FromArgb(57, 36, 103);
            deleteSupplierFormHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSupplierFormHeader.ForeColor = SystemColors.Control;
            deleteSupplierFormHeader.Location = new Point(-2, -1);
            deleteSupplierFormHeader.Name = "deleteSupplierFormHeader";
            deleteSupplierFormHeader.Size = new Size(803, 50);
            deleteSupplierFormHeader.TabIndex = 0;
            deleteSupplierFormHeader.Text = "Delete Supplier";
            deleteSupplierFormHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeleteSupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteSupplierFormHeader);
            Name = "DeleteSupplierForm";
            Text = "DeleteSupplierForm";
            ResumeLayout(false);
        }

        #endregion

        private Label deleteSupplierFormHeader;
    }
}