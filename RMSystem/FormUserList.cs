using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMSystem
{
    public partial class FormUserList : Form
    {
        private UserList Ul { get; set; }


        public FormUserList()
        {
            InitializeComponent();

            this.Ul = new UserList();
            this.PopulateGridView();
           
            this.AutoIdGenerate();
        }


        private void PopulateGridView(string sql = "select * from UserInfo;")
        {
           // var query = "SELECT * FROM UserInfo;";

            var ds = this.Ul.ExecuteQuery(sql);

            this.dgvUserList.AutoGenerateColumns = false;
            this.dgvUserList.DataSource = ds.Tables[0];
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
           // string sql = "select * from UserInfo;";


           this.PopulateGridView();

        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from UserInfo where Name like '%" + this.txtSearchUser.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToSave())
                {
                    MessageBox.Show("Please Fill all the Information");
                    return;
                }

                var query = "select * from UserInfo where ID ='" + this.txtUId.Text + "';";
                var ds = this.Ul.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = "update UserInfo set Name ='" + this.txtUName.Text + "', Password = '" + this.txtUPassword.Text + "', Role = '" + this.txtURole.Text + "', Salary = '" + this.txtUSalary + "' where ID ='" + this.txtUId.Text + "';";
                    int count = this.Ul.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data Updated");
                    else
                        MessageBox.Show("Data Upgradation Failed");
                }

                else
                {
                    var sql = "insert into UserInfo values ('" + this.txtUId.Text + "','" + this.txtUName.Text + "'," + this.txtUPassword.Text + ",'" + this.txtURole.Text + "'," + this.txtUSalary.Text + ");";
                    int count = this.Ul.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Employee Added");
                    else
                        MessageBox.Show("Employee Addition Failed");
                }

                
                this.PopulateGridView();

            }
            catch (Exception) 
            {
                MessageBox.Show("Error! This Id is already existing"); 
            }


        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtUId.Text) || string.IsNullOrEmpty(this.txtUName.Text) || string.IsNullOrEmpty(this.txtUPassword.Text) || string.IsNullOrEmpty(this.txtURole.Text) || string.IsNullOrEmpty(this.txtUSalary.Text))
                return false;
            else
                return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUId.Clear(); 
            this.txtUName.Clear();
            this.txtUPassword.Clear();
            this.txtURole.Clear();
            this.txtUSalary.Clear();

            this.txtSearchUser.Clear();
            this.dgvUserList.ClearSelection();
            this.AutoIdGenerate();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {

            try 
            {

                if (this.dgvUserList.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please Select a Row First.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                DialogResult result = MessageBox.Show("Are You Sure You Want To Delete?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return;
                var ID = this.dgvUserList.CurrentRow.Cells[0].Value.ToString();
               
                var sql = "delete from UserInfo where id='" + ID + "'; ";
                int count = this.Ul.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Employee Data Deleted");
                else
                    MessageBox.Show("Employee Data Deletion Failed");

                this.PopulateGridView();

            }
            catch(Exception exc)
            {
                MessageBox.Show("There is an Error in Your Input: " + exc.Message);
            }


        }

        private void FormUserList_Load(object sender, EventArgs e)
        {
             this.dgvUserList.ClearSelection();
             
        }

       

        private void dgvUserList_DoubleClick(object sender, EventArgs e)
        {
            this.txtUId.Text = this.dgvUserList.CurrentRow.Cells[0].Value.ToString();
            this.txtUName.Text = this.dgvUserList.CurrentRow.Cells[1].Value.ToString();
            this.txtUPassword.Text = this.dgvUserList.CurrentRow.Cells[2].Value.ToString();
            this.txtURole.Text = this.dgvUserList.CurrentRow.Cells[3].Value.ToString();
            this.txtUSalary.Text = this.dgvUserList.CurrentRow.Cells[4].Value.ToString();
            this.PopulateGridView();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToSave())
                {
                    MessageBox.Show("Fill All The Fields");
                    return;
                }

                var sql = "update UserInfo set Name ='" + this.txtUName.Text + "', Password = '" + this.txtUPassword.Text + "', Role = '" + this.txtURole.Text + "', Salary = '" + this.txtUSalary.Text + "' where ID ='" + this.txtUId.Text + "';";
                int count = this.Ul.ExecuteDMLQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show("Data Successfully Updated");
                    this.PopulateGridView(); 
                }
                else
                {
                    MessageBox.Show("Data Update Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
        }



        private void AutoIdGenerate()
        {
            var sql = "select Id from UserInfo order by Id desc;";
            var dt = this.Ul.ExecuteQuwryTable(sql);
            string oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            int num = Convert.ToInt32(temp[1]);
            string newId = "r-" + (++num).ToString("d3");
            //MessageBox.Show(newId);
            this.txtUId.Text = newId;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormOwner().Show();
        }
    }
}
