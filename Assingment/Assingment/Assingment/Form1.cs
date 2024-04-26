using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment
{
    public partial class Form1 : Form
    {
        DataTable table;
        int index;

        public Form1()
        {
            InitializeComponent();
            table = new DataTable("table");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", Type.GetType("System.Int32"));
            table.Columns.Add("Name", Type.GetType("System.String"));
            table.Columns.Add("Contact", Type.GetType("System.Int32"));
            dataGridView1.DataSource = table;
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            table.Rows.Add(idtb.Text, nametb.Text, contacttb.Text);
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            idtb.Text = String.Empty;
            nametb.Text = String.Empty;
            contacttb.Text = String.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            idtb.Text = row.Cells[0].Value.ToString();
            nametb.Text = row.Cells[1].Value.ToString();
            contacttb.Text = row.Cells[2].Value.ToString();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = idtb.Text;
            newdata.Cells[1].Value = nametb.Text;
            newdata.Cells[2].Value = contacttb.Text;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }
    }
}
