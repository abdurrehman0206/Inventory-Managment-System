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
            lblDelSup = new Label();
            SuspendLayout();
            // 
            // lblDelSup
            // 
            lblDelSup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDelSup.BackColor = Color.FromArgb(57, 36, 103);
            lblDelSup.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDelSup.ForeColor = SystemColors.Control;
            lblDelSup.Location = new Point(0, 0);
            lblDelSup.Name = "lblDelSup";
            lblDelSup.Size = new Size(800, 50);
            lblDelSup.TabIndex = 0;
            lblDelSup.Text = "Delete Supplier";
            lblDelSup.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeleteSupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 800);
            Controls.Add(lblDelSup);
            Name = "DeleteSupplierForm";
            Text = "DeleteSupplierForm";
            ResumeLayout(false);
        }

        #endregion

        private Label lblDelSup;
    }
}