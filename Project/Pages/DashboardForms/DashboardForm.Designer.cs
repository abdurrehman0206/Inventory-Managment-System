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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            lblTotalItems = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblItem = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            lblPrice = new Label();
            lblTotalPrice = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            lblOrders = new Label();
            lblTotalOrders = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            lblTotalOrdersPrice = new Label();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            lblSales = new Label();
            lblTotalSales = new Label();
            panel6 = new Panel();
            pictureBox6 = new PictureBox();
            lblTotalSuppliers = new Label();
            lblSuppliers = new Label();
            lblAddItem = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // lblTotalItems
            // 
            lblTotalItems.BackColor = Color.Transparent;
            lblTotalItems.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalItems.ForeColor = Color.Black;
            lblTotalItems.Location = new Point(97, 16);
            lblTotalItems.Name = "lblTotalItems";
            lblTotalItems.Size = new Size(97, 29);
            lblTotalItems.TabIndex = 0;
            lblTotalItems.Text = "$ 0";
            lblTotalItems.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 217, 242);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblItem);
            panel1.Controls.Add(lblTotalItems);
            panel1.Location = new Point(38, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblItem
            // 
            lblItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblItem.ForeColor = Color.DarkGray;
            lblItem.Location = new Point(97, 61);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(100, 23);
            lblItem.TabIndex = 1;
            lblItem.Text = "Total Items";
            lblItem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(225, 217, 242);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblPrice);
            panel2.Controls.Add(lblTotalPrice);
            panel2.Location = new Point(305, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.DarkGray;
            lblPrice.Location = new Point(97, 61);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 23);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Total Price";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.BackColor = Color.Transparent;
            lblTotalPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPrice.ForeColor = Color.Black;
            lblTotalPrice.Location = new Point(97, 16);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(97, 29);
            lblTotalPrice.TabIndex = 0;
            lblTotalPrice.Text = "$ 0";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(225, 217, 242);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(lblOrders);
            panel3.Controls.Add(lblTotalOrders);
            panel3.Location = new Point(567, 159);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(25, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // lblOrders
            // 
            lblOrders.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrders.ForeColor = Color.DarkGray;
            lblOrders.Location = new Point(97, 61);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(100, 23);
            lblOrders.TabIndex = 1;
            lblOrders.Text = "Total Orders";
            lblOrders.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.BackColor = Color.Transparent;
            lblTotalOrders.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalOrders.ForeColor = Color.Black;
            lblTotalOrders.Location = new Point(97, 16);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(97, 29);
            lblTotalOrders.TabIndex = 0;
            lblTotalOrders.Text = "0";
            lblTotalOrders.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(225, 217, 242);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(lblTotalOrdersPrice);
            panel4.Location = new Point(38, 340);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 9;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(25, 27);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(97, 61);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 1;
            label1.Text = "Order Price";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalOrdersPrice
            // 
            lblTotalOrdersPrice.BackColor = Color.Transparent;
            lblTotalOrdersPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalOrdersPrice.ForeColor = Color.Black;
            lblTotalOrdersPrice.ImageAlign = ContentAlignment.MiddleRight;
            lblTotalOrdersPrice.Location = new Point(71, 16);
            lblTotalOrdersPrice.Name = "lblTotalOrdersPrice";
            lblTotalOrdersPrice.Size = new Size(123, 29);
            lblTotalOrdersPrice.TabIndex = 0;
            lblTotalOrdersPrice.Text = "$ 0";
            lblTotalOrdersPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(225, 217, 242);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(lblSales);
            panel5.Controls.Add(lblTotalSales);
            panel5.Location = new Point(305, 340);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 100);
            panel5.TabIndex = 10;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(25, 27);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(66, 46);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // lblSales
            // 
            lblSales.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSales.ForeColor = Color.DarkGray;
            lblSales.Location = new Point(97, 61);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(100, 23);
            lblSales.TabIndex = 1;
            lblSales.Text = "Total Sales";
            lblSales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalSales
            // 
            lblTotalSales.BackColor = Color.Transparent;
            lblTotalSales.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalSales.ForeColor = Color.Black;
            lblTotalSales.Location = new Point(71, 16);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(123, 29);
            lblTotalSales.TabIndex = 0;
            lblTotalSales.Text = "$ 0";
            lblTotalSales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(225, 217, 242);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(lblTotalSuppliers);
            panel6.Controls.Add(lblSuppliers);
            panel6.Location = new Point(567, 340);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 100);
            panel6.TabIndex = 11;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(25, 27);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(66, 46);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // lblTotalSuppliers
            // 
            lblTotalSuppliers.BackColor = Color.Transparent;
            lblTotalSuppliers.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalSuppliers.ForeColor = Color.Black;
            lblTotalSuppliers.Location = new Point(72, 16);
            lblTotalSuppliers.Name = "lblTotalSuppliers";
            lblTotalSuppliers.Size = new Size(123, 29);
            lblTotalSuppliers.TabIndex = 12;
            lblTotalSuppliers.Text = "0";
            lblTotalSuppliers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSuppliers
            // 
            lblSuppliers.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSuppliers.ForeColor = Color.DarkGray;
            lblSuppliers.Location = new Point(97, 61);
            lblSuppliers.Name = "lblSuppliers";
            lblSuppliers.Size = new Size(100, 23);
            lblSuppliers.TabIndex = 1;
            lblSuppliers.Text = "Total Suppliers";
            lblSuppliers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddItem
            // 
            lblAddItem.BackColor = Color.FromArgb(57, 36, 103);
            lblAddItem.Dock = DockStyle.Top;
            lblAddItem.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddItem.ForeColor = SystemColors.Control;
            lblAddItem.Location = new Point(0, 0);
            lblAddItem.Name = "lblAddItem";
            lblAddItem.Size = new Size(800, 50);
            lblAddItem.TabIndex = 12;
            lblAddItem.Text = "DashBoard";
            lblAddItem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 800);
            Controls.Add(lblAddItem);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DashboardForm";
            Text = "DashboardForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTotalItems;
        private Label lblTotalSales;
        private Label lblTotalSuppliers;
        private Panel panel1;
        private Label lblItem;
        private Panel panel2;
        private Label lblPrice;
        private Label lblTotalPrice;
        private Panel panel3;
        private Label lblOrders;
        private Label lblTotalOrders;
        private Panel panel4;
        private Label label1;
        private Label lblTotalOrdersPrice;
        private Panel panel5;
        private Label lblSales;
        private Panel panel6;
        private Label lblSuppliers;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label lblAddItem;
    }
}