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
    public partial class FormOwner : Form
    {
        private FormLogin Fl { get; set; }
        public FormOwner()
        {
            InitializeComponent();
        }

        public FormOwner(string username, FormLogin fl) : this()
        {
            this.lblUsername.Text += username.ToUpper();
            this.Fl = fl;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {

                if (Fl != null && Fl is Form)
                {
                    Form formToShow = Fl as Form;
                    formToShow.Show(); 
                    MessageBox.Show("Logged out from the System");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error: Unable to logout. Form reference is invalid.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnUserList_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormUserList().Show();

        }

        private void btnGotoMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormOrders().Show();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().Show();
        }
    }
}
