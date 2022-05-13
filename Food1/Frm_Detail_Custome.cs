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
    public partial class Frm_Detail_Custome : Form
    {
        public Frm_Detail_Custome()
        {
            InitializeComponent();
        }

        private void Frm_Detail_Custome_Load(object sender, EventArgs e)
        {
            string Sql= "SELECT        head_order.Order_Number'رقم الطلب', customers.customer_name'اسم الزبون', head_order.Oreder_Date'تاريخ شراءالطلب', items.name_items'نوع الطلب', detail_order.Account'العدد', detail_order.Price'الاجمالي ', detail_order.Total 'الكلي '" +
            "FROM customers INNER JOIN "+
                        " head_order ON customers.customer_number = head_order.customer_number INNER JOIN" +
                        " detail_order ON head_order.Order_Number = detail_order.Order_Number INNER JOIN" +
                        " items ON detail_order.no_items = items.no_items ";

            DbConn db=new DbConn();   
            db.Disconnect();
            SqlCommand cmd=new SqlCommand(Sql,db.connect());
            SqlDataReader dr=cmd.ExecuteReader();   
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
