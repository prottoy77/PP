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
    public partial class FormEmployee : Form
    {
        private FormLogin Fl { get; set; }

        public FormEmployee()
        {
            InitializeComponent();
        }

        public FormEmployee(string username, FormLogin fl) : this()
        {
            this.lblUsername.Text += username.ToUpper();
            this.Fl = fl;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormOrders().Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logged out from the System");
            this.Fl.Show();
        }

        private void pnlEmployee_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
