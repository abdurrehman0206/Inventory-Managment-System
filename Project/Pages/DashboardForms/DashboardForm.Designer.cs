namespace Project
{
    partial class DashboardForm
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
            lblTotalItems = new Label();
            lblTotalPrice = new Label();
            lblTotalOrders = new Label();
            lblTotalOrdersPrice = new Label();
            lblTotalSales = new Label();
            lblTotalSuppliers = new Label();
            SuspendLayout();
            // 
            // lblTotalItems
            // 
            lblTotalItems.AutoSize = true;
            lblTotalItems.Location = new Point(305, 89);
            lblTotalItems.Name = "lblTotalItems";
            lblTotalItems.Size = new Size(38, 15);
            lblTotalItems.TabIndex = 0;
            lblTotalItems.Text = "label1";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(324, 126);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(38, 15);
            lblTotalPrice.TabIndex = 1;
            lblTotalPrice.Text = "label2";
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.AutoSize = true;
            lblTotalOrders.Location = new Point(368, 199);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(38, 15);
            lblTotalOrders.TabIndex = 2;
            lblTotalOrders.Text = "label3";
            // 
            // lblTotalOrdersPrice
            // 
            lblTotalOrdersPrice.AutoSize = true;
            lblTotalOrdersPrice.Location = new Point(323, 272);
            lblTotalOrdersPrice.Name = "lblTotalOrdersPrice";
            lblTotalOrdersPrice.Size = new Size(38, 15);
            lblTotalOrdersPrice.TabIndex = 3;
            lblTotalOrdersPrice.Text = "label4";
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Location = new Point(329, 336);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(38, 15);
            lblTotalSales.TabIndex = 4;
            lblTotalSales.Text = "label5";
            // 
            // lblTotalSuppliers
            // 
            lblTotalSuppliers.AutoSize = true;
            lblTotalSuppliers.Location = new Point(329, 391);
            lblTotalSuppliers.Name = "lblTotalSuppliers";
            lblTotalSuppliers.Size = new Size(38, 15);
            lblTotalSuppliers.TabIndex = 5;
            lblTotalSuppliers.Text = "label1";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 800);
            Controls.Add(lblTotalSuppliers);
            Controls.Add(lblTotalSales);
            Controls.Add(lblTotalOrdersPrice);
            Controls.Add(lblTotalOrders);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblTotalItems);
            Name = "DashboardForm";
            Text = "DashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalItems;
        private Label lblTotalPrice;
        private Label lblTotalOrders;
        private Label lblTotalOrdersPrice;
        private Label lblTotalSales;
        private Label lblTotalSuppliers;
    }
}