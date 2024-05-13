namespace RMSystem
{
    partial class FormOwner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOwner));
            this.pnlOwner = new System.Windows.Forms.Panel();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.btnGotoMenu = new System.Windows.Forms.Button();
            this.btnUserList = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.pnlOwner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOwner
            // 
            this.pnlOwner.BackColor = System.Drawing.Color.BurlyWood;
            this.pnlOwner.Controls.Add(this.backbtn);
            this.pnlOwner.Controls.Add(this.pbLogout);
            this.pnlOwner.Controls.Add(this.btnGotoMenu);
            this.pnlOwner.Controls.Add(this.btnUserList);
            this.pnlOwner.Controls.Add(this.btnLogout);
            this.pnlOwner.Controls.Add(this.lblUsername);
            this.pnlOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOwner.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlOwner.Location = new System.Drawing.Point(0, 0);
            this.pnlOwner.Name = "pnlOwner";
            this.pnlOwner.Size = new System.Drawing.Size(898, 551);
            this.pnlOwner.TabIndex = 0;
            // 
            // pbLogout
            // 
            this.pbLogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbLogout.Image = ((System.Drawing.Image)(resources.GetObject("pbLogout.Image")));
            this.pbLogout.Location = new System.Drawing.Point(591, 287);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(34, 40);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogout.TabIndex = 4;
            this.pbLogout.TabStop = false;
            // 
            // btnGotoMenu
            // 
            this.btnGotoMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGotoMenu.BackColor = System.Drawing.Color.Tan;
            this.btnGotoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGotoMenu.Location = new System.Drawing.Point(348, 195);
            this.btnGotoMenu.Name = "btnGotoMenu";
            this.btnGotoMenu.Size = new System.Drawing.Size(237, 40);
            this.btnGotoMenu.TabIndex = 3;
            this.btnGotoMenu.Text = "Go To Menu";
            this.btnGotoMenu.UseVisualStyleBackColor = false;
            this.btnGotoMenu.Click += new System.EventHandler(this.btnGotoMenu_Click);
            // 
            // btnUserList
            // 
            this.btnUserList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUserList.BackColor = System.Drawing.Color.Tan;
            this.btnUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserList.Location = new System.Drawing.Point(348, 96);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Size = new System.Drawing.Size(237, 40);
            this.btnUserList.TabIndex = 2;
            this.btnUserList.Text = "User List";
            this.btnUserList.UseVisualStyleBackColor = false;
            this.btnUserList.Click += new System.EventHandler(this.btnUserList_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogout.BackColor = System.Drawing.Color.Tan;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(348, 287);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(237, 40);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(342, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(243, 31);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Welcome Owner ";
            // 
            // backbtn
            // 
            this.backbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backbtn.BackColor = System.Drawing.Color.Tan;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(748, 499);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(138, 40);
            this.backbtn.TabIndex = 5;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // FormOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 551);
            this.Controls.Add(this.pnlOwner);
            this.Name = "FormOwner";
            this.Text = "Owner";
            this.pnlOwner.ResumeLayout(false);
            this.pnlOwner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOwner;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUserList;
        private System.Windows.Forms.Button btnGotoMenu;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.Button backbtn;
    }
}