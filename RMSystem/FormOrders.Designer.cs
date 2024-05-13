namespace RMSystem
{
    partial class FormOrders
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
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.btnOthers = new System.Windows.Forms.Button();
            this.btnFastFood = new System.Windows.Forms.Button();
            this.lblOrders = new System.Windows.Forms.Label();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.pnlOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrders
            // 
            this.pnlOrders.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlOrders.Controls.Add(this.btnOthers);
            this.pnlOrders.Controls.Add(this.btnFastFood);
            this.pnlOrders.Controls.Add(this.lblOrders);
            this.pnlOrders.Controls.Add(this.btnDrinks);
            this.pnlOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlOrders.Location = new System.Drawing.Point(0, 0);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(800, 450);
            this.pnlOrders.TabIndex = 0;
            // 
            // btnOthers
            // 
            this.btnOthers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOthers.Location = new System.Drawing.Point(352, 195);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.Size = new System.Drawing.Size(131, 44);
            this.btnOthers.TabIndex = 3;
            this.btnOthers.Text = "Others";
            this.btnOthers.UseVisualStyleBackColor = false;
            this.btnOthers.Click += new System.EventHandler(this.btnOthers_Click);
            // 
            // btnFastFood
            // 
            this.btnFastFood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFastFood.Location = new System.Drawing.Point(352, 133);
            this.btnFastFood.Name = "btnFastFood";
            this.btnFastFood.Size = new System.Drawing.Size(131, 44);
            this.btnFastFood.TabIndex = 2;
            this.btnFastFood.Text = "Fast Food";
            this.btnFastFood.UseVisualStyleBackColor = false;
            this.btnFastFood.Click += new System.EventHandler(this.btnFastFood_Click);
            // 
            // lblOrders
            // 
            this.lblOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.Location = new System.Drawing.Point(346, 9);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(148, 32);
            this.lblOrders.TabIndex = 1;
            this.lblOrders.Text = "Order List";
            // 
            // btnDrinks
            // 
            this.btnDrinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDrinks.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrinks.Location = new System.Drawing.Point(352, 71);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(131, 44);
            this.btnDrinks.TabIndex = 0;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = false;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlOrders);
            this.Name = "FormOrders";
            this.Text = "FormOrders";
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnFastFood;
        private System.Windows.Forms.Button btnOthers;
    }
}