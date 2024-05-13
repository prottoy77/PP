namespace RMSystem
{
    partial class FormAddCart
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
            this.pnlAddCart = new System.Windows.Forms.Panel();
            this.dgvAddCart = new System.Windows.Forms.DataGridView();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAddCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddCart)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddCart
            // 
            this.pnlAddCart.Controls.Add(this.dgvAddCart);
            this.pnlAddCart.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAddCart.Location = new System.Drawing.Point(0, 0);
            this.pnlAddCart.Name = "pnlAddCart";
            this.pnlAddCart.Size = new System.Drawing.Size(356, 450);
            this.pnlAddCart.TabIndex = 0;
            // 
            // dgvAddCart
            // 
            this.dgvAddCart.AllowUserToAddRows = false;
            this.dgvAddCart.AllowUserToDeleteRows = false;
            this.dgvAddCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Items,
            this.Price});
            this.dgvAddCart.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvAddCart.Location = new System.Drawing.Point(0, 0);
            this.dgvAddCart.Name = "dgvAddCart";
            this.dgvAddCart.ReadOnly = true;
            this.dgvAddCart.RowHeadersWidth = 51;
            this.dgvAddCart.RowTemplate.Height = 24;
            this.dgvAddCart.Size = new System.Drawing.Size(354, 450);
            this.dgvAddCart.TabIndex = 0;
            // 
            // Items
            // 
            this.Items.HeaderText = "Items";
            this.Items.MinimumWidth = 6;
            this.Items.Name = "Items";
            this.Items.ReadOnly = true;
            this.Items.Width = 150;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 150;
            // 
            // FormAddCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAddCart);
            this.Name = "FormAddCart";
            this.Text = "FormAddCart";
            this.pnlAddCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddCart;
        private System.Windows.Forms.DataGridView dgvAddCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}