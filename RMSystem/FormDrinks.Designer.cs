namespace RMSystem
{
    partial class FormDrinks
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
            this.pnlDrinks = new System.Windows.Forms.Panel();
            this.dgvDrinks = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drinks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlShowDrinks = new System.Windows.Forms.Panel();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.txtSearchDrinks = new System.Windows.Forms.TextBox();
            this.btnShowDrinks = new System.Windows.Forms.Button();
            this.pnlAddDrinks = new System.Windows.Forms.Panel();
            this.dgvAddDrinks = new System.Windows.Forms.DataGridView();
            this.DrinksItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrinksPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAddDrinks = new System.Windows.Forms.Label();
            this.pnlDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrinks)).BeginInit();
            this.pnlShowDrinks.SuspendLayout();
            this.pnlAddDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddDrinks)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDrinks
            // 
            this.pnlDrinks.Controls.Add(this.dgvDrinks);
            this.pnlDrinks.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDrinks.Location = new System.Drawing.Point(0, 0);
            this.pnlDrinks.Name = "pnlDrinks";
            this.pnlDrinks.Size = new System.Drawing.Size(437, 510);
            this.pnlDrinks.TabIndex = 0;
            // 
            // dgvDrinks
            // 
            this.dgvDrinks.AllowUserToAddRows = false;
            this.dgvDrinks.AllowUserToDeleteRows = false;
            this.dgvDrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrinks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.Drinks,
            this.Price});
            this.dgvDrinks.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDrinks.Location = new System.Drawing.Point(0, 0);
            this.dgvDrinks.Name = "dgvDrinks";
            this.dgvDrinks.ReadOnly = true;
            this.dgvDrinks.RowHeadersWidth = 51;
            this.dgvDrinks.RowTemplate.Height = 24;
            this.dgvDrinks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrinks.Size = new System.Drawing.Size(432, 510);
            this.dgvDrinks.TabIndex = 0;
            this.dgvDrinks.DoubleClick += new System.EventHandler(this.dgvDrinks_DoubleClick);
            // 
            // ProductId
            // 
            this.ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "Product Id";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Width = 96;
            // 
            // Drinks
            // 
            this.Drinks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Drinks.DataPropertyName = "Drinks";
            this.Drinks.HeaderText = "Drinks";
            this.Drinks.MinimumWidth = 6;
            this.Drinks.Name = "Drinks";
            this.Drinks.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // pnlShowDrinks
            // 
            this.pnlShowDrinks.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlShowDrinks.Controls.Add(this.lblSearchName);
            this.pnlShowDrinks.Controls.Add(this.txtSearchDrinks);
            this.pnlShowDrinks.Controls.Add(this.btnShowDrinks);
            this.pnlShowDrinks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlShowDrinks.Location = new System.Drawing.Point(437, 448);
            this.pnlShowDrinks.Name = "pnlShowDrinks";
            this.pnlShowDrinks.Size = new System.Drawing.Size(464, 62);
            this.pnlShowDrinks.TabIndex = 1;
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchName.Location = new System.Drawing.Point(17, 33);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(123, 18);
            this.lblSearchName.TabIndex = 2;
            this.lblSearchName.Text = "Search By Drinks";
            // 
            // txtSearchDrinks
            // 
            this.txtSearchDrinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchDrinks.Location = new System.Drawing.Point(6, 8);
            this.txtSearchDrinks.Name = "txtSearchDrinks";
            this.txtSearchDrinks.Size = new System.Drawing.Size(157, 22);
            this.txtSearchDrinks.TabIndex = 1;
            this.txtSearchDrinks.TextChanged += new System.EventHandler(this.txtSearchDrinks_TextChanged);
            // 
            // btnShowDrinks
            // 
            this.btnShowDrinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDrinks.Location = new System.Drawing.Point(320, 8);
            this.btnShowDrinks.Name = "btnShowDrinks";
            this.btnShowDrinks.Size = new System.Drawing.Size(132, 32);
            this.btnShowDrinks.TabIndex = 0;
            this.btnShowDrinks.Text = "Show Drinks";
            this.btnShowDrinks.UseVisualStyleBackColor = true;
            this.btnShowDrinks.Click += new System.EventHandler(this.btnShowDrinks_Click);
            // 
            // pnlAddDrinks
            // 
            this.pnlAddDrinks.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlAddDrinks.Controls.Add(this.lblAddDrinks);
            this.pnlAddDrinks.Controls.Add(this.btnBack);
            this.pnlAddDrinks.Controls.Add(this.dgvAddDrinks);
            this.pnlAddDrinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddDrinks.Location = new System.Drawing.Point(437, 0);
            this.pnlAddDrinks.Name = "pnlAddDrinks";
            this.pnlAddDrinks.Size = new System.Drawing.Size(464, 448);
            this.pnlAddDrinks.TabIndex = 2;
            // 
            // dgvAddDrinks
            // 
            this.dgvAddDrinks.AllowUserToAddRows = false;
            this.dgvAddDrinks.AllowUserToDeleteRows = false;
            this.dgvAddDrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddDrinks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrinksItems,
            this.DrinksPrice});
            this.dgvAddDrinks.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvAddDrinks.Location = new System.Drawing.Point(0, 0);
            this.dgvAddDrinks.Name = "dgvAddDrinks";
            this.dgvAddDrinks.ReadOnly = true;
            this.dgvAddDrinks.RowHeadersWidth = 51;
            this.dgvAddDrinks.RowTemplate.Height = 24;
            this.dgvAddDrinks.Size = new System.Drawing.Size(320, 448);
            this.dgvAddDrinks.TabIndex = 0;
            this.dgvAddDrinks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddDrinks_CellContentClick);
            this.dgvAddDrinks.DoubleClick += new System.EventHandler(this.dgvAddDrinks_DoubleClick);
            // 
            // DrinksItems
            // 
            this.DrinksItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DrinksItems.HeaderText = "Drinks Items";
            this.DrinksItems.MinimumWidth = 6;
            this.DrinksItems.Name = "DrinksItems";
            this.DrinksItems.ReadOnly = true;
            this.DrinksItems.Width = 109;
            // 
            // DrinksPrice
            // 
            this.DrinksPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DrinksPrice.HeaderText = "Drinks Price";
            this.DrinksPrice.MinimumWidth = 6;
            this.DrinksPrice.Name = "DrinksPrice";
            this.DrinksPrice.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(342, 411);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 31);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAddDrinks
            // 
            this.lblAddDrinks.AutoSize = true;
            this.lblAddDrinks.Location = new System.Drawing.Point(326, 35);
            this.lblAddDrinks.Name = "lblAddDrinks";
            this.lblAddDrinks.Size = new System.Drawing.Size(109, 32);
            this.lblAddDrinks.TabIndex = 1;
            this.lblAddDrinks.Text = "Double Click For \r\nAdd Drinks";
            // 
            // FormDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 510);
            this.Controls.Add(this.pnlAddDrinks);
            this.Controls.Add(this.pnlShowDrinks);
            this.Controls.Add(this.pnlDrinks);
            this.Name = "FormDrinks";
            this.Text = "FormDrinks";
            this.pnlDrinks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrinks)).EndInit();
            this.pnlShowDrinks.ResumeLayout(false);
            this.pnlShowDrinks.PerformLayout();
            this.pnlAddDrinks.ResumeLayout(false);
            this.pnlAddDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddDrinks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrinks;
        private System.Windows.Forms.DataGridView dgvDrinks;
        private System.Windows.Forms.Panel pnlShowDrinks;
        private System.Windows.Forms.Button btnShowDrinks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drinks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox txtSearchDrinks;
        private System.Windows.Forms.Panel pnlAddDrinks;
        private System.Windows.Forms.DataGridView dgvAddDrinks;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrinksItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrinksPrice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAddDrinks;
    }
}