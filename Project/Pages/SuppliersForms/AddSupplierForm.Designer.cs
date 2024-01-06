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
            addSupplierFormHeader = new Label();
            SuspendLayout();
            // 
            // addSupplierFormHeader
            // 
            addSupplierFormHeader.BackColor = Color.FromArgb(57, 36, 103);
            addSupplierFormHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            addSupplierFormHeader.ForeColor = SystemColors.Control;
            addSupplierFormHeader.Location = new Point(-2, -1);
            addSupplierFormHeader.Name = "addSupplierFormHeader";
            addSupplierFormHeader.Size = new Size(801, 50);
            addSupplierFormHeader.TabIndex = 0;
            addSupplierFormHeader.Text = "Add Supplier";
            addSupplierFormHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddSupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addSupplierFormHeader);
            Name = "AddSupplierForm";
            Text = "AddSupplierForm";
            ResumeLayout(false);
        }

        #endregion

        private Label addSupplierFormHeader;
    }
}