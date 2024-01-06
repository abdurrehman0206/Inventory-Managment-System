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
            updateSupplierFormHeader = new Label();
            SuspendLayout();
            // 
            // updateSupplierFormHeader
            // 
            updateSupplierFormHeader.BackColor = Color.FromArgb(57, 36, 103);
            updateSupplierFormHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            updateSupplierFormHeader.ForeColor = SystemColors.Control;
            updateSupplierFormHeader.Location = new Point(-2, -1);
            updateSupplierFormHeader.Margin = new Padding(0);
            updateSupplierFormHeader.Name = "updateSupplierFormHeader";
            updateSupplierFormHeader.Size = new Size(804, 50);
            updateSupplierFormHeader.TabIndex = 0;
            updateSupplierFormHeader.Text = "Update Supplier";
            updateSupplierFormHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UpdateSupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(updateSupplierFormHeader);
            Name = "UpdateSupplierForm";
            Text = "UpdateSupplierForm";
            ResumeLayout(false);
        }

        #endregion

        private Label updateSupplierFormHeader;
    }
}