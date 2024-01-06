namespace Project.InventoryForms
{
    partial class DeleteItemForm
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
            lblDelItem = new Label();
            SuspendLayout();
            // 
            // lblDelItem
            // 
            lblDelItem.BackColor = Color.FromArgb(57, 36, 103);
            lblDelItem.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDelItem.ForeColor = SystemColors.Control;
            lblDelItem.Location = new Point(0, 0);
            lblDelItem.Name = "lblDelItem";
            lblDelItem.Size = new Size(800, 50);
            lblDelItem.TabIndex = 0;
            lblDelItem.Text = "Delete Item";
            lblDelItem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeleteItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 800);
            Controls.Add(lblDelItem);
            Name = "DeleteItemForm";
            Text = "DeleteItemForm";
            ResumeLayout(false);
        }

        #endregion

        private Label lblDelItem;
    }
}