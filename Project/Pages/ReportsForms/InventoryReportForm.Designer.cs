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
            inventoryReportHeader = new Label();
            SuspendLayout();
            // 
            // inventoryReportHeader
            // 
            inventoryReportHeader.BackColor = Color.FromArgb(57, 36, 103);
            inventoryReportHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            inventoryReportHeader.ForeColor = SystemColors.Control;
            inventoryReportHeader.Location = new Point(-2, -1);
            inventoryReportHeader.Name = "inventoryReportHeader";
            inventoryReportHeader.Size = new Size(804, 50);
            inventoryReportHeader.TabIndex = 0;
            inventoryReportHeader.Text = "Inventory Report";
            inventoryReportHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InventoryReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inventoryReportHeader);
            Name = "InventoryReportForm";
            Text = "InventoryReportForm";
            ResumeLayout(false);
        }

        #endregion

        private Label inventoryReportHeader;
    }
}