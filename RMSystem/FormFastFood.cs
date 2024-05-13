using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMSystem
{
    
    public partial class FormFastFood : Form
    {
        public FastFood f { get; set; }
        public FormFastFood()
        {
            InitializeComponent();
            this.f = new FastFood();
            this.PopulateFoodView();
        }

        private void PopulateFoodView(string sql = "select * from fastfood;")
        {
            var ds = this.f.ExecuteQuery(sql);
            this.dgvFastFood.DataSource = ds.Tables[0];
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            this.PopulateFoodView();
        }

        private void txtSearchFastFood_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from FastFood where Items like '%" + this.txtSearchFastFood.Text + "%';";
            this.PopulateFoodView(sql);
        }

        private void dgvFastFood_DoubleClick(object sender, EventArgs e)
        {
            this.dgvAddFastFood.Rows.Add(dgvFastFood.CurrentRow.Cells[1].Value.ToString(), dgvFastFood.CurrentRow.Cells[2].Value.ToString());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormOrders().Show();
        }
    }
}
