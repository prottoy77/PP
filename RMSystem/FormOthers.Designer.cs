namespace RMSystem
{
    partial class FormOthers
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
            this.pnlOthers = new System.Windows.Forms.Panel();
            this.dgvOthers = new System.Windows.Forms.DataGridView();
            this.FoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlShowOthers = new System.Windows.Forms.Panel();
            this.lblSearchOthers = new System.Windows.Forms.Label();
            this.txtSearchOthers = new System.Windows.Forms.TextBox();
            this.btnShowOthers = new System.Windows.Forms.Button();
            this.pnlAddOthers = new System.Windows.Forms.Panel();
            this.dgvAddOthers = new System.Windows.Forms.DataGridView();
            this.FoodItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAddFood = new System.Windows.Forms.Label();
            this.pnlOthers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOthers)).BeginInit();
            this.pnlShowOthers.SuspendLayout();
            this.pnlAddOthers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddOthers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOthers
            // 
            this.pnlOthers.Controls.Add(this.dgvOthers);
            this.pnlOthers.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOthers.Location = new System.Drawing.Point(0, 0);
            this.pnlOthers.Name = "pnlOthers";
            this.pnlOthers.Size = new System.Drawing.Size(410, 471);
            this.pnlOthers.TabIndex = 0;
            // 
            // dgvOthers
            // 
            this.dgvOthers.AllowUserToAddRows = false;
            this.dgvOthers.AllowUserToDeleteRows = false;
            this.dgvOthers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOthers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodId,
            this.Items,
            this.Price});
            this.dgvOthers.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvOthers.Location = new System.Drawing.Point(0, 0);
            this.dgvOthers.Name = "dgvOthers";
            this.dgvOthers.ReadOnly = true;
            this.dgvOthers.RowHeadersWidth = 51;
            this.dgvOthers.RowTemplate.Height = 24;
            this.dgvOthers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOthers.Size = new System.Drawing.Size(407, 471);
            this.dgvOthers.TabIndex = 0;
            this.dgvOthers.DoubleClick += new System.EventHandler(this.dgvOthers_DoubleClick);
            // 
            // FoodId
            // 
            this.FoodId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FoodId.DataPropertyName = "FoodId";
            this.FoodId.HeaderText = "Food Id";
            this.FoodId.MinimumWidth = 6;
            this.FoodId.Name = "FoodId";
            this.FoodId.ReadOnly = true;
            this.FoodId.Width = 82;
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
            this.Price.HeaderText = "price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 90;
            // 
            // pnlShowOthers
            // 
            this.pnlShowOthers.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlShowOthers.Controls.Add(this.lblSearchOthers);
            this.pnlShowOthers.Controls.Add(this.txtSearchOthers);
            this.pnlShowOthers.Controls.Add(this.btnShowOthers);
            this.pnlShowOthers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlShowOthers.Location = new System.Drawing.Point(410, 412);
            this.pnlShowOthers.Name = "pnlShowOthers";
            this.pnlShowOthers.Size = new System.Drawing.Size(468, 59);
            this.pnlShowOthers.TabIndex = 1;
            // 
            // lblSearchOthers
            // 
            this.lblSearchOthers.AutoSize = true;
            this.lblSearchOthers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchOthers.Location = new System.Drawing.Point(30, 28);
            this.lblSearchOthers.Name = "lblSearchOthers";
            this.lblSearchOthers.Size = new System.Drawing.Size(116, 18);
            this.lblSearchOthers.TabIndex = 2;
            this.lblSearchOthers.Text = "Search By Items";
            // 
            // txtSearchOthers
            // 
            this.txtSearchOthers.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSearchOthers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchOthers.Location = new System.Drawing.Point(6, 6);
            this.txtSearchOthers.Name = "txtSearchOthers";
            this.txtSearchOthers.Size = new System.Drawing.Size(164, 22);
            this.txtSearchOthers.TabIndex = 1;
            this.txtSearchOthers.TextChanged += new System.EventHandler(this.txtSearchOthers_TextChanged);
            // 
            // btnShowOthers
            // 
            this.btnShowOthers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowOthers.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnShowOthers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowOthers.Location = new System.Drawing.Point(302, 6);
            this.btnShowOthers.Name = "btnShowOthers";
            this.btnShowOthers.Size = new System.Drawing.Size(144, 30);
            this.btnShowOthers.TabIndex = 0;
            this.btnShowOthers.Text = "Show Others";
            this.btnShowOthers.UseVisualStyleBackColor = false;
            this.btnShowOthers.Click += new System.EventHandler(this.btnShowOthers_Click);
            // 
            // pnlAddOthers
            // 
            this.pnlAddOthers.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlAddOthers.Controls.Add(this.lblAddFood);
            this.pnlAddOthers.Controls.Add(this.btnBack);
            this.pnlAddOthers.Controls.Add(this.dgvAddOthers);
            this.pnlAddOthers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddOthers.Location = new System.Drawing.Point(410, 0);
            this.pnlAddOthers.Name = "pnlAddOthers";
            this.pnlAddOthers.Size = new System.Drawing.Size(468, 412);
            this.pnlAddOthers.TabIndex = 2;
            // 
            // dgvAddOthers
            // 
            this.dgvAddOthers.AllowUserToAddRows = false;
            this.dgvAddOthers.AllowUserToDeleteRows = false;
            this.dgvAddOthers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddOthers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodItems,
            this.FoodPrice});
            this.dgvAddOthers.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvAddOthers.Location = new System.Drawing.Point(0, 0);
            this.dgvAddOthers.Name = "dgvAddOthers";
            this.dgvAddOthers.ReadOnly = true;
            this.dgvAddOthers.RowHeadersWidth = 51;
            this.dgvAddOthers.RowTemplate.Height = 24;
            this.dgvAddOthers.Size = new System.Drawing.Size(283, 412);
            this.dgvAddOthers.TabIndex = 0;
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
            // FoodPrice
            // 
            this.FoodPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodPrice.HeaderText = "Food Price";
            this.FoodPrice.MinimumWidth = 6;
            this.FoodPrice.Name = "FoodPrice";
            this.FoodPrice.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(331, 374);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 32);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAddFood
            // 
            this.lblAddFood.AutoSize = true;
            this.lblAddFood.Location = new System.Drawing.Point(289, 35);
            this.lblAddFood.Name = "lblAddFood";
            this.lblAddFood.Size = new System.Drawing.Size(169, 16);
            this.lblAddFood.TabIndex = 2;
            this.lblAddFood.Text = "Double Click For Add Food";
            // 
            // FormOthers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 471);
            this.Controls.Add(this.pnlAddOthers);
            this.Controls.Add(this.pnlShowOthers);
            this.Controls.Add(this.pnlOthers);
            this.Name = "FormOthers";
            this.Text = "FormOthers";
            this.pnlOthers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOthers)).EndInit();
            this.pnlShowOthers.ResumeLayout(false);
            this.pnlShowOthers.PerformLayout();
            this.pnlAddOthers.ResumeLayout(false);
            this.pnlAddOthers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddOthers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOthers;
        private System.Windows.Forms.DataGridView dgvOthers;
        private System.Windows.Forms.Panel pnlShowOthers;
        private System.Windows.Forms.Button btnShowOthers;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label lblSearchOthers;
        private System.Windows.Forms.TextBox txtSearchOthers;
        private System.Windows.Forms.Panel pnlAddOthers;
        private System.Windows.Forms.DataGridView dgvAddOthers;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodPrice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAddFood;
    }
}