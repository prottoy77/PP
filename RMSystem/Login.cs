using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMSystem
{
    public class Login
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        public Login()
        {
            this.sqlcon = new SqlConnection(@"Data Source=DESKTOP-P2HTOSB;Initial Catalog=RMSystem;Persist Security Info=True;User ID=sa;Password=12345");
            sqlcon.Open();
        }

        private void QueryText(string query)
        {
            this.sqlcom = new SqlCommand(query, this.sqlcon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds;
        }

        public DataTable ExecuteQuwryTable(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds.Tables[0];
        }

        public int ExecuteDMLQuery(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }
            
    }
}
