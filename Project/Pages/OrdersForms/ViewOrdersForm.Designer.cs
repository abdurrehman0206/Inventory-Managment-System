namespace Project.Pages.OrdersForms
{
    partial class ViewOrdersForm
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
            viewOrderFormHeader = new Label();
            SuspendLayout();
            // 
            // viewOrderFormHeader
            // 
            viewOrderFormHeader.BackColor = Color.FromArgb(57, 36, 103);
            viewOrderFormHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            viewOrderFormHeader.ForeColor = SystemColors.Control;
            viewOrderFormHeader.Location = new Point(-2, -1);
            viewOrderFormHeader.Name = "viewOrderFormHeader";
            viewOrderFormHeader.Size = new Size(803, 50);
            viewOrderFormHeader.TabIndex = 0;
            viewOrderFormHeader.Text = "Order Info";
            viewOrderFormHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ViewOrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(viewOrderFormHeader);
            Name = "ViewOrdersForm";
            Text = "ViewOrdersForm";
            ResumeLayout(false);
        }

        #endregion

        private Label viewOrderFormHeader;
    }
}