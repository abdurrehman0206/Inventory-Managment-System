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
            lblSupInfo = new Label();
            SuspendLayout();
            // 
            // lblSupInfo
            // 
            lblSupInfo.BackColor = Color.FromArgb(57, 36, 103);
            lblSupInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSupInfo.ForeColor = SystemColors.Control;
            lblSupInfo.Location = new Point(0, 0);
            lblSupInfo.Name = "lblSupInfo";
            lblSupInfo.Size = new Size(800, 50);
            lblSupInfo.TabIndex = 0;
            lblSupInfo.Text = "Supplier Info";
            lblSupInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ViewSupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 761);
            Controls.Add(lblSupInfo);
            Name = "ViewSupplierForm";
            Text = "ViewSupplierForm";
            ResumeLayout(false);
        }

        #endregion

        private Label lblSupInfo;
    }
}