namespace Project.Pages.OrdersForms
{
    partial class PlaceOrderForm
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
            placeOrderFormHeader = new Label();
            SuspendLayout();
            // 
            // placeOrderFormHeader
            // 
            placeOrderFormHeader.BackColor = Color.FromArgb(57, 36, 103);
            placeOrderFormHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            placeOrderFormHeader.ForeColor = SystemColors.Control;
            placeOrderFormHeader.Location = new Point(-2, -1);
            placeOrderFormHeader.Name = "placeOrderFormHeader";
            placeOrderFormHeader.Size = new Size(800, 50);
            placeOrderFormHeader.TabIndex = 0;
            placeOrderFormHeader.Text = "Place Order";
            placeOrderFormHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlaceOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(placeOrderFormHeader);
            Name = "PlaceOrderForm";
            Text = "PlaceOrderForm";
            ResumeLayout(false);
        }

        #endregion

        private Label placeOrderFormHeader;
    }
}