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
            viewSupplierFormHeader = new Label();
            SuspendLayout();
            // 
            // viewSupplierFormHeader
            // 
            viewSupplierFormHeader.BackColor = Color.FromArgb(57, 36, 103);
            viewSupplierFormHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            viewSupplierFormHeader.ForeColor = SystemColors.Control;
            viewSupplierFormHeader.Location = new Point(-2, -1);
            viewSupplierFormHeader.Name = "viewSupplierFormHeader";
            viewSupplierFormHeader.Size = new Size(801, 50);
            viewSupplierFormHeader.TabIndex = 0;
            viewSupplierFormHeader.Text = "Supplier Info";
            viewSupplierFormHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ViewSupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(viewSupplierFormHeader);
            Name = "ViewSupplierForm";
            Text = "ViewSupplierForm";
            ResumeLayout(false);
        }

        #endregion

        private Label viewSupplierFormHeader;
    }
}