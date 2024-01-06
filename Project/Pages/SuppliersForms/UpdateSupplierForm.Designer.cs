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
            lblUpdateSup = new Label();
            SuspendLayout();
            // 
            // lblUpdateSup
            // 
            lblUpdateSup.BackColor = Color.FromArgb(57, 36, 103);
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
            // UpdateSupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 761);
            Controls.Add(lblUpdateSup);
            Name = "UpdateSupplierForm";
            Text = "UpdateSupplierForm";
            ResumeLayout(false);
        }

        #endregion

        private Label lblUpdateSup;
    }
}