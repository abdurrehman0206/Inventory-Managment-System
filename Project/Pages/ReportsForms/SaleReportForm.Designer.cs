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
            saleReportFormHeader = new Label();
            SuspendLayout();
            // 
            // saleReportFormHeader
            // 
            saleReportFormHeader.BackColor = Color.FromArgb(57, 36, 103);
            saleReportFormHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            saleReportFormHeader.ForeColor = SystemColors.Control;
            saleReportFormHeader.Location = new Point(-2, -1);
            saleReportFormHeader.Name = "saleReportFormHeader";
            saleReportFormHeader.Size = new Size(805, 50);
            saleReportFormHeader.TabIndex = 0;
            saleReportFormHeader.Text = "Sales Report";
            saleReportFormHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SaleReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saleReportFormHeader);
            Name = "SaleReportForm";
            Text = "SaleReportForm";
            ResumeLayout(false);
        }

        #endregion

        private Label saleReportFormHeader;
    }
}