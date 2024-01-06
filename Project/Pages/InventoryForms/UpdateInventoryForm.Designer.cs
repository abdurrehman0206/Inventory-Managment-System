namespace Project.InventoryForms
{
    partial class UpdateInventoryForm
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
            lblUpdateItem = new Label();
            SuspendLayout();
            // 
            // lblUpdateItem
            // 
            lblUpdateItem.BackColor = Color.FromArgb(57, 36, 103);
            lblUpdateItem.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUpdateItem.ForeColor = SystemColors.Control;
            lblUpdateItem.Location = new Point(0, 0);
            lblUpdateItem.Name = "lblUpdateItem";
            lblUpdateItem.Size = new Size(800, 50);
            lblUpdateItem.TabIndex = 0;
            lblUpdateItem.Text = "Update Item";
            lblUpdateItem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UpdateInventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 800);
            Controls.Add(lblUpdateItem);
            Name = "UpdateInventoryForm";
            Text = "UpdateInventory";
            ResumeLayout(false);
        }

        #endregion

        private Label lblUpdateItem;
    }
}