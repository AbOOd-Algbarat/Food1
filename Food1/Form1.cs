using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Food1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DbConn db=new DbConn();
            string Sql = "Select * From items";
            db.Disconnect();
            SqlCommand cmd = new SqlCommand(Sql, db.connect());
            SqlDataReader Rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(Rd);
            dataGridView1.DataSource = dt;
        }
    }
}
