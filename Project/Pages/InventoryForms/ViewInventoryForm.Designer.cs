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
            viewInventoryHeader = new Label();
            SuspendLayout();
            // 
            // viewInventoryHeader
            // 
            viewInventoryHeader.BackColor = Color.FromArgb(57, 36, 103);
            viewInventoryHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            viewInventoryHeader.ForeColor = SystemColors.Control;
            viewInventoryHeader.Location = new Point(-4, -2);
            viewInventoryHeader.Name = "viewInventoryHeader";
            viewInventoryHeader.Size = new Size(807, 50);
            viewInventoryHeader.TabIndex = 0;
            viewInventoryHeader.Text = "Inventory Info";
            viewInventoryHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ViewInventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(viewInventoryHeader);
            Name = "ViewInventoryForm";
            Text = "ViewInventory";
            ResumeLayout(false);
        }

        #endregion

        private Label viewInventoryHeader;
    }
}