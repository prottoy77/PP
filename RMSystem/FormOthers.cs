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
    public partial class FormOthers : Form
    {
        //BindingSource lbAddOthersBindingSource = new BindingSource();
         
        private Others o { get; set; }

        public FormOthers()
        {
            InitializeComponent();
            this.o = new Others();
            this.PopulateOthersView();
        }

        private void PopulateOthersView(string sql = "select * from others;")
        {
            var ds = this.o.ExecuteQuery(sql);
           // this.dgvOthers.AutoGenerateColumns = false;
            this.dgvOthers.DataSource = ds.Tables[0];
        }

        private void btnShowOthers_Click(object sender, EventArgs e)
        {
            this.PopulateOthersView();
        }

        private void dgvOthers_DoubleClick(object sender, EventArgs e)
        {
            
            this.dgvAddOthers.Rows.Add (dgvOthers.CurrentRow.Cells[1].Value.ToString(), dgvOthers.CurrentRow.Cells[2].Value.ToString());
            //this.PopulateOthersView();
        }

        private void txtSearchOthers_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Others where Items like '%" + this.txtSearchOthers.Text + "%';";
            this.PopulateOthersView(sql);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormOrders().Show();
        }
    }
}
