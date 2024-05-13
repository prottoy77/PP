namespace RMSystem
{
    partial class FormFastFood
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
            this.pnlFastFood = new System.Windows.Forms.Panel();
            this.dgvFastFood = new System.Windows.Forms.DataGridView();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlShowFood = new System.Windows.Forms.Panel();
            this.lblSearchFastFood = new System.Windows.Forms.Label();
            this.txtSearchFastFood = new System.Windows.Forms.TextBox();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.pnlAddFastFood = new System.Windows.Forms.Panel();
            this.dgvAddFastFood = new System.Windows.Forms.DataGridView();
            this.FoodItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foodprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAddFastFood = new System.Windows.Forms.Label();
            this.pnlFastFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFastFood)).BeginInit();
            this.pnlShowFood.SuspendLayout();
            this.pnlAddFastFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddFastFood)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFastFood
            // 
            this.pnlFastFood.Controls.Add(this.dgvFastFood);
            this.pnlFastFood.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFastFood.Location = new System.Drawing.Point(0, 0);
            this.pnlFastFood.Name = "pnlFastFood";
            this.pnlFastFood.Size = new System.Drawing.Size(460, 466);
            this.pnlFastFood.TabIndex = 0;
            // 
            // dgvFastFood
            // 
            this.dgvFastFood.AllowUserToAddRows = false;
            this.dgvFastFood.AllowUserToDeleteRows = false;
            this.dgvFastFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFastFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.Items,
            this.Price});
            this.dgvFastFood.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvFastFood.Location = new System.Drawing.Point(0, 0);
            this.dgvFastFood.Name = "dgvFastFood";
            this.dgvFastFood.ReadOnly = true;
            this.dgvFastFood.RowHeadersWidth = 51;
            this.dgvFastFood.RowTemplate.Height = 24;
            this.dgvFastFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFastFood.Size = new System.Drawing.Size(457, 466);
            this.dgvFastFood.TabIndex = 0;
            this.dgvFastFood.DoubleClick += new System.EventHandler(this.dgvFastFood_DoubleClick);
            // 
            // ProductCode
            // 
            this.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.MinimumWidth = 6;
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.Width = 118;
            // 
            // Items
            // 
            this.Items.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Items.DataPropertyName = "Items";
            this.Items.HeaderText = "Items";
            this.Items.MinimumWidth = 6;
            this.Items.Name = "Items";
            this.Items.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 90;
            // 
            // pnlShowFood
            // 
            this.pnlShowFood.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlShowFood.Controls.Add(this.lblSearchFastFood);
            this.pnlShowFood.Controls.Add(this.txtSearchFastFood);
            this.pnlShowFood.Controls.Add(this.btnShowFood);
            this.pnlShowFood.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlShowFood.Location = new System.Drawing.Point(460, 400);
            this.pnlShowFood.Name = "pnlShowFood";
            this.pnlShowFood.Size = new System.Drawing.Size(533, 66);
            this.pnlShowFood.TabIndex = 1;
            // 
            // lblSearchFastFood
            // 
            this.lblSearchFastFood.AutoSize = true;
            this.lblSearchFastFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFastFood.Location = new System.Drawing.Point(24, 37);
            this.lblSearchFastFood.Name = "lblSearchFastFood";
            this.lblSearchFastFood.Size = new System.Drawing.Size(116, 18);
            this.lblSearchFastFood.TabIndex = 2;
            this.lblSearchFastFood.Text = "Search By Items";
            // 
            // txtSearchFastFood
            // 
            this.txtSearchFastFood.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSearchFastFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchFastFood.Location = new System.Drawing.Point(6, 12);
            this.txtSearchFastFood.Name = "txtSearchFastFood";
            this.txtSearchFastFood.Size = new System.Drawing.Size(155, 22);
            this.txtSearchFastFood.TabIndex = 1;
            this.txtSearchFastFood.TextChanged += new System.EventHandler(this.txtSearchFastFood_TextChanged);
            // 
            // btnShowFood
            // 
            this.btnShowFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowFood.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnShowFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFood.Location = new System.Drawing.Point(400, 6);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(115, 31);
            this.btnShowFood.TabIndex = 0;
            this.btnShowFood.Text = "Show Food";
            this.btnShowFood.UseVisualStyleBackColor = false;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            // 
            // pnlAddFastFood
            // 
            this.pnlAddFastFood.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlAddFastFood.Controls.Add(this.lblAddFastFood);
            this.pnlAddFastFood.Controls.Add(this.btnBack);
            this.pnlAddFastFood.Controls.Add(this.dgvAddFastFood);
            this.pnlAddFastFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddFastFood.Location = new System.Drawing.Point(460, 0);
            this.pnlAddFastFood.Name = "pnlAddFastFood";
            this.pnlAddFastFood.Size = new System.Drawing.Size(533, 400);
            this.pnlAddFastFood.TabIndex = 2;
            // 
            // dgvAddFastFood
            // 
            this.dgvAddFastFood.AllowUserToAddRows = false;
            this.dgvAddFastFood.AllowUserToDeleteRows = false;
            this.dgvAddFastFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddFastFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodItems,
            this.Foodprice});
            this.dgvAddFastFood.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvAddFastFood.Location = new System.Drawing.Point(0, 0);
            this.dgvAddFastFood.Name = "dgvAddFastFood";
            this.dgvAddFastFood.ReadOnly = true;
            this.dgvAddFastFood.RowHeadersWidth = 51;
            this.dgvAddFastFood.RowTemplate.Height = 24;
            this.dgvAddFastFood.Size = new System.Drawing.Size(354, 400);
            this.dgvAddFastFood.TabIndex = 0;
            // 
            // FoodItems
            // 
            this.FoodItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FoodItems.HeaderText = "Food Items";
            this.FoodItems.MinimumWidth = 6;
            this.FoodItems.Name = "FoodItems";
            this.FoodItems.ReadOnly = true;
            this.FoodItems.Width = 103;
            // 
            // Foodprice
            // 
            this.Foodprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Foodprice.HeaderText = "Food Price";
            this.Foodprice.MinimumWidth = 6;
            this.Foodprice.Name = "Foodprice";
            this.Foodprice.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(400, 364);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 30);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAddFastFood
            // 
            this.lblAddFastFood.AutoSize = true;
            this.lblAddFastFood.Location = new System.Drawing.Point(360, 35);
            this.lblAddFastFood.Name = "lblAddFastFood";
            this.lblAddFastFood.Size = new System.Drawing.Size(137, 32);
            this.lblAddFastFood.TabIndex = 2;
            this.lblAddFastFood.Text = "Double Click For Add \r\nFast Food";
            // 
            // FormFastFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 466);
            this.Controls.Add(this.pnlAddFastFood);
            this.Controls.Add(this.pnlShowFood);
            this.Controls.Add(this.pnlFastFood);
            this.Name = "FormFastFood";
            this.Text = "FormFastFood";
            this.pnlFastFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFastFood)).EndInit();
            this.pnlShowFood.ResumeLayout(false);
            this.pnlShowFood.PerformLayout();
            this.pnlAddFastFood.ResumeLayout(false);
            this.pnlAddFastFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddFastFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFastFood;
        private System.Windows.Forms.DataGridView dgvFastFood;
        private System.Windows.Forms.Panel pnlShowFood;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label lblSearchFastFood;
        private System.Windows.Forms.TextBox txtSearchFastFood;
        private System.Windows.Forms.Panel pnlAddFastFood;
        private System.Windows.Forms.DataGridView dgvAddFastFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foodprice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAddFastFood;
    }
}