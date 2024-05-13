namespace RMSystem
{
    partial class FormEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.BackColor = System.Drawing.Color.DarkKhaki;
            this.pnlEmployee.Controls.Add(this.pbLogout);
            this.pnlEmployee.Controls.Add(this.btnLogout);
            this.pnlEmployee.Controls.Add(this.btnOrders);
            this.pnlEmployee.Controls.Add(this.lblUsername);
            this.pnlEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployee.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(894, 509);
            this.pnlEmployee.TabIndex = 0;
            this.pnlEmployee.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEmployee_Paint);
            // 
            // pbLogout
            // 
            this.pbLogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbLogout.Image = ((System.Drawing.Image)(resources.GetObject("pbLogout.Image")));
            this.pbLogout.Location = new System.Drawing.Point(545, 221);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(44, 44);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogout.TabIndex = 3;
            this.pbLogout.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogout.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(342, 221);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(197, 44);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOrders.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.Location = new System.Drawing.Point(342, 129);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(197, 44);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Go To Menu";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(282, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(307, 31);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Welcome Employee ";
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 509);
            this.Controls.Add(this.pnlEmployee);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pbLogout;
    }
}