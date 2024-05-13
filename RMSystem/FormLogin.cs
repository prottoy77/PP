using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMSystem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from UserInfo where ID = '" + this.txtUserId.Text + "'and Password = '" + this.txtPassword.Text + "';";
            Login da = new Login();
            DataSet ds = da.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Press OK For Login");
               

                if(ds.Tables[0].Rows[0][3].ToString().Equals("owner"))
                {
                    this.Hide();
                    new FormOwner(ds.Tables[0].Rows[0][1].ToString(), this).Show();
                }

                else if (ds.Tables[0].Rows[0][3].ToString() == "employee")
                {
                    this.Hide();
                    new FormEmployee(ds.Tables[0].Rows[0][1].ToString(), this).Show();
                }
               
            }

            else
                MessageBox.Show("Invalid User");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserId.Clear();
            txtPassword.Clear();
        }
    }
}
