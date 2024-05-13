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
    public partial class FormDrinks : Form
    {
        private Drinks D { get; set; }
        public FormDrinks()
        {
            InitializeComponent();
            this.D = new Drinks();
            this.PopulateDrinksView();
        }

        private void PopulateDrinksView(string sql="select * from drinks;")
        {
            var ds = this.D.ExecuteQuery(sql);
            //this.dgvDrinks.AutoGenerateColumns = false;
            this.dgvDrinks.DataSource = ds.Tables[0];
        }

        private void btnShowDrinks_Click(object sender, EventArgs e)
        {
            this.PopulateDrinksView();
        }

        private void txtSearchDrinks_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from DRINKS where Drinks like '%" + this.txtSearchDrinks.Text + "%';";
            this.PopulateDrinksView(sql);
        }

        private void dgvAddDrinks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAddDrinks_DoubleClick(object sender, EventArgs e)
        {
           // this.dgvAddDrinks.Rows.Add(dgvDrinks.CurrentRow.Cells[1].Value.ToString(), dgvDrinks.CurrentRow.Cells[2].Value.ToString());
            //this.PopulateDrinksView();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormOrders().Show();
        }

        private void dgvDrinks_DoubleClick(object sender, EventArgs e)
        {
             this.dgvAddDrinks.Rows.Add(dgvDrinks.CurrentRow.Cells[1].Value.ToString(), dgvDrinks.CurrentRow.Cells[2].Value.ToString());

        }
    }
}
