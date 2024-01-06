namespace Project.Pages.ReportsForms
{
    partial class InventoryReportForm
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
            lblInvRepo = new Label();
            SuspendLayout();
            // 
            // lblInvRepo
            // 
            lblInvRepo.BackColor = Color.FromArgb(57, 36, 103);
            lblInvRepo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblInvRepo.ForeColor = SystemColors.Control;
            lblInvRepo.Location = new Point(0, 0);
            lblInvRepo.Name = "lblInvRepo";
            lblInvRepo.Size = new Size(800, 50);
            lblInvRepo.TabIndex = 0;
            lblInvRepo.Text = "Inventory Report";
            lblInvRepo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InventoryReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 800);
            Controls.Add(lblInvRepo);
            Name = "InventoryReportForm";
            Text = "InventoryReportForm";
            ResumeLayout(false);
        }

        #endregion

        private Label lblInvRepo;
    }
}