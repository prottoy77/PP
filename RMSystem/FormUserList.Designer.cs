namespace RMSystem
{
    partial class FormUserList
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
            this.pnlUserList = new System.Windows.Forms.Panel();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlShowDetails = new System.Windows.Forms.Panel();
            this.lblSearchbyName = new System.Windows.Forms.Label();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlCRUDUser = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUSalary = new System.Windows.Forms.TextBox();
            this.lblUSalary = new System.Windows.Forms.Label();
            this.txtURole = new System.Windows.Forms.TextBox();
            this.txtUPassword = new System.Windows.Forms.TextBox();
            this.lblURole = new System.Windows.Forms.Label();
            this.lblUPassword = new System.Windows.Forms.Label();
            this.txtUId = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.lblUId = new System.Windows.Forms.Label();
            this.lblUname = new System.Windows.Forms.Label();
            this.pnlUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.pnlShowDetails.SuspendLayout();
            this.pnlCRUDUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUserList
            // 
            this.pnlUserList.Controls.Add(this.dgvUserList);
            this.pnlUserList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUserList.Location = new System.Drawing.Point(0, 0);
            this.pnlUserList.Name = "pnlUserList";
            this.pnlUserList.Size = new System.Drawing.Size(563, 527);
            this.pnlUserList.TabIndex = 0;
            // 
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            this.dgvUserList.AllowUserToDeleteRows = false;
            this.dgvUserList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UserName,
            this.Password,
            this.Role,
            this.Salary});
            this.dgvUserList.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvUserList.Location = new System.Drawing.Point(0, 0);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.ReadOnly = true;
            this.dgvUserList.RowHeadersWidth = 51;
            this.dgvUserList.RowTemplate.Height = 24;
            this.dgvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserList.Size = new System.Drawing.Size(560, 527);
            this.dgvUserList.TabIndex = 0;
            this.dgvUserList.DoubleClick += new System.EventHandler(this.dgvUserList_DoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "User ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 75;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UserName.DataPropertyName = "Name";
            this.UserName.HeaderText = "User Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 97;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "User Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 118;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "User Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 90;
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "User Salary";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // pnlShowDetails
            // 
            this.pnlShowDetails.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlShowDetails.Controls.Add(this.lblSearchbyName);
            this.pnlShowDetails.Controls.Add(this.txtSearchUser);
            this.pnlShowDetails.Controls.Add(this.btnShowDetails);
            this.pnlShowDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlShowDetails.Location = new System.Drawing.Point(563, 462);
            this.pnlShowDetails.Name = "pnlShowDetails";
            this.pnlShowDetails.Size = new System.Drawing.Size(486, 65);
            this.pnlShowDetails.TabIndex = 1;
            // 
            // lblSearchbyName
            // 
            this.lblSearchbyName.AutoSize = true;
            this.lblSearchbyName.Location = new System.Drawing.Point(35, 40);
            this.lblSearchbyName.Name = "lblSearchbyName";
            this.lblSearchbyName.Size = new System.Drawing.Size(109, 16);
            this.lblSearchbyName.TabIndex = 2;
            this.lblSearchbyName.Text = "Search By Name";
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchUser.Location = new System.Drawing.Point(6, 14);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(161, 22);
            this.txtSearchUser.TabIndex = 1;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.Location = new System.Drawing.Point(333, 27);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(141, 25);
            this.btnShowDetails.TabIndex = 0;
            this.btnShowDetails.Text = "Show Details";
            this.btnShowDetails.UseVisualStyleBackColor = false;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(156, 272);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 32);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(312, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(312, 272);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 32);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlCRUDUser
            // 
            this.pnlCRUDUser.BackColor = System.Drawing.Color.Teal;
            this.pnlCRUDUser.Controls.Add(this.btnBack);
            this.pnlCRUDUser.Controls.Add(this.btnUpdate);
            this.pnlCRUDUser.Controls.Add(this.txtUSalary);
            this.pnlCRUDUser.Controls.Add(this.lblUSalary);
            this.pnlCRUDUser.Controls.Add(this.txtURole);
            this.pnlCRUDUser.Controls.Add(this.txtUPassword);
            this.pnlCRUDUser.Controls.Add(this.lblURole);
            this.pnlCRUDUser.Controls.Add(this.lblUPassword);
            this.pnlCRUDUser.Controls.Add(this.txtUId);
            this.pnlCRUDUser.Controls.Add(this.txtUName);
            this.pnlCRUDUser.Controls.Add(this.lblUId);
            this.pnlCRUDUser.Controls.Add(this.lblUname);
            this.pnlCRUDUser.Controls.Add(this.btnClear);
            this.pnlCRUDUser.Controls.Add(this.btnSave);
            this.pnlCRUDUser.Controls.Add(this.btnDelete);
            this.pnlCRUDUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCRUDUser.Location = new System.Drawing.Point(563, 0);
            this.pnlCRUDUser.Name = "pnlCRUDUser";
            this.pnlCRUDUser.Size = new System.Drawing.Size(486, 462);
            this.pnlCRUDUser.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(333, 424);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 32);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(156, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 32);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUSalary
            // 
            this.txtUSalary.Location = new System.Drawing.Point(236, 165);
            this.txtUSalary.Name = "txtUSalary";
            this.txtUSalary.Size = new System.Drawing.Size(160, 22);
            this.txtUSalary.TabIndex = 12;
            // 
            // lblUSalary
            // 
            this.lblUSalary.AutoSize = true;
            this.lblUSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSalary.ForeColor = System.Drawing.Color.White;
            this.lblUSalary.Location = new System.Drawing.Point(141, 165);
            this.lblUSalary.Name = "lblUSalary";
            this.lblUSalary.Size = new System.Drawing.Size(61, 22);
            this.lblUSalary.TabIndex = 13;
            this.lblUSalary.Text = "Salary";
            // 
            // txtURole
            // 
            this.txtURole.Location = new System.Drawing.Point(236, 137);
            this.txtURole.Name = "txtURole";
            this.txtURole.Size = new System.Drawing.Size(160, 22);
            this.txtURole.TabIndex = 8;
            // 
            // txtUPassword
            // 
            this.txtUPassword.Location = new System.Drawing.Point(236, 106);
            this.txtUPassword.Name = "txtUPassword";
            this.txtUPassword.Size = new System.Drawing.Size(160, 22);
            this.txtUPassword.TabIndex = 11;
            // 
            // lblURole
            // 
            this.lblURole.AutoSize = true;
            this.lblURole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURole.ForeColor = System.Drawing.Color.White;
            this.lblURole.Location = new System.Drawing.Point(141, 137);
            this.lblURole.Name = "lblURole";
            this.lblURole.Size = new System.Drawing.Size(47, 22);
            this.lblURole.TabIndex = 10;
            this.lblURole.Text = "Role";
            // 
            // lblUPassword
            // 
            this.lblUPassword.AutoSize = true;
            this.lblUPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUPassword.ForeColor = System.Drawing.Color.White;
            this.lblUPassword.Location = new System.Drawing.Point(141, 106);
            this.lblUPassword.Name = "lblUPassword";
            this.lblUPassword.Size = new System.Drawing.Size(89, 22);
            this.lblUPassword.TabIndex = 9;
            this.lblUPassword.Text = "Password";
            // 
            // txtUId
            // 
            this.txtUId.Location = new System.Drawing.Point(236, 50);
            this.txtUId.Name = "txtUId";
            this.txtUId.Size = new System.Drawing.Size(160, 22);
            this.txtUId.TabIndex = 1;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(236, 78);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(160, 22);
            this.txtUName.TabIndex = 7;
            // 
            // lblUId
            // 
            this.lblUId.AutoSize = true;
            this.lblUId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUId.ForeColor = System.Drawing.Color.White;
            this.lblUId.Location = new System.Drawing.Point(141, 56);
            this.lblUId.Name = "lblUId";
            this.lblUId.Size = new System.Drawing.Size(27, 22);
            this.lblUId.TabIndex = 6;
            this.lblUId.Text = "ID";
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.ForeColor = System.Drawing.Color.White;
            this.lblUname.Location = new System.Drawing.Point(141, 81);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(57, 22);
            this.lblUname.TabIndex = 5;
            this.lblUname.Text = "Name";
            // 
            // FormUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 527);
            this.Controls.Add(this.pnlCRUDUser);
            this.Controls.Add(this.pnlShowDetails);
            this.Controls.Add(this.pnlUserList);
            this.Name = "FormUserList";
            this.Text = "FormUserList";
            this.Load += new System.EventHandler(this.FormUserList_Load);
            this.pnlUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.pnlShowDetails.ResumeLayout(false);
            this.pnlShowDetails.PerformLayout();
            this.pnlCRUDUser.ResumeLayout(false);
            this.pnlCRUDUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUserList;
        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.Panel pnlShowDetails;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Label lblSearchbyName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlCRUDUser;
        private System.Windows.Forms.Label lblUId;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.TextBox txtUSalary;
        private System.Windows.Forms.Label lblUSalary;
        private System.Windows.Forms.TextBox txtURole;
        private System.Windows.Forms.TextBox txtUPassword;
        private System.Windows.Forms.Label lblURole;
        private System.Windows.Forms.Label lblUPassword;
        private System.Windows.Forms.TextBox txtUId;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
    }
}