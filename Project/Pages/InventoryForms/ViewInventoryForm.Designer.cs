namespace Project.InventoryForms
{
    partial class ViewInventoryForm
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
            lblViewInv = new Label();
            SuspendLayout();
            // 
            // lblViewInv
            // 
            lblViewInv.BackColor = Color.FromArgb(57, 36, 103);
            lblViewInv.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblViewInv.ForeColor = SystemColors.Control;
            lblViewInv.Location = new Point(0, 0);
            lblViewInv.Name = "lblViewInv";
            lblViewInv.Size = new Size(800, 50);
            lblViewInv.TabIndex = 0;
            lblViewInv.Text = "Inventory Info";
            lblViewInv.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ViewInventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 839);
            Controls.Add(lblViewInv);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewInventoryForm";
            Text = "ViewInventory";
            ResumeLayout(false);
        }

        #endregion

        private Label lblViewInv;
    }
}