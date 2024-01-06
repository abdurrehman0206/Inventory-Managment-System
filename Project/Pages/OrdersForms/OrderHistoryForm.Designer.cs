namespace Project.Pages.OrdersForms
{
    partial class OrderHistoryForm
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
            lblOrderHistory = new Label();
            SuspendLayout();
            // 
            // lblOrderHistory
            // 
            lblOrderHistory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblOrderHistory.BackColor = Color.FromArgb(57, 36, 103);
            lblOrderHistory.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderHistory.ForeColor = SystemColors.Control;
            lblOrderHistory.ImageAlign = ContentAlignment.MiddleRight;
            lblOrderHistory.Location = new Point(0, 0);
            lblOrderHistory.Name = "lblOrderHistory";
            lblOrderHistory.Size = new Size(800, 50);
            lblOrderHistory.TabIndex = 0;
            lblOrderHistory.Text = "Order History";
            lblOrderHistory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 800);
            Controls.Add(lblOrderHistory);
            Name = "OrderHistoryForm";
            Text = "OrderHistoryForm";
            ResumeLayout(false);
        }

        #endregion

        private Label lblOrderHistory;
    }
}