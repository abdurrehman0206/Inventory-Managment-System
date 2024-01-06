namespace Project.Pages.ReportsForms
{
    partial class SaleReportForm
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
            lblSalesRepo = new Label();
            SuspendLayout();
            // 
            // lblSalesRepo
            // 
            lblSalesRepo.BackColor = Color.FromArgb(57, 36, 103);
            lblSalesRepo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSalesRepo.ForeColor = SystemColors.Control;
            lblSalesRepo.Location = new Point(0, 0);
            lblSalesRepo.Name = "lblSalesRepo";
            lblSalesRepo.Size = new Size(800, 50);
            lblSalesRepo.TabIndex = 0;
            lblSalesRepo.Text = "Sales Report";
            lblSalesRepo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SaleReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 761);
            Controls.Add(lblSalesRepo);
            Name = "SaleReportForm";
            Text = "SaleReportForm";
            ResumeLayout(false);
        }

        #endregion

        private Label lblSalesRepo;
    }
}