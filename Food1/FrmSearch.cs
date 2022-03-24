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
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        void Search()//دالة البحث 
        {
            string Sql =DataCollection.Sql_Where + txt_Search.Text + "%'";            
            DbConn db = new DbConn();
            DataTable dt = new DataTable();//يستخدم لاحتواء البيانات
            db.Disconnect();
            SqlCommand cmd = new SqlCommand(Sql, db.connect()); //قمنا بتنفيذ اي الجملة سواء كانت Updat,Select,Delet,Insert
            SqlDataReader rd = cmd.ExecuteReader();//عن طريق  cmd تعمل على استخلاص البيانات او الحصول على البيانات او قراءة البيانات وتنفيذها من  
            dt.Load(rd);//حملنا البيانات ووضعناها في 
            dataGridView1.DataSource = dt;//واعرضها dt حمل البيانات من 
            db.conn.Close();            
        }
      
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
          Search();
        }              

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {               
            txt_Search.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();            
        }

        private void FrmSearch_Load_1(object sender, EventArgs e)// عند عمل الفوم يقوم بتحميل البيانات في data gridview
        {
            string Sql = DataCollection.Sql;
            DbConn db = new DbConn();
            DataTable dt = new DataTable();
            db.Disconnect();
            SqlCommand cmd = new SqlCommand(Sql, db.connect()); //قمنا بتنفيذ اي الجملة سواء كانت Updat,Select,Delet,Insert
            SqlDataReader rd = cmd.ExecuteReader();//عن طريق  cmd تعمل على استخلاص البيانات او الحصول على البيانات من  
            dt.Load(rd);//حملنا البيانات ووضعناها في 
            dataGridView1.DataSource = dt;//واعرضها dt حمل البيانات من 
            db.conn.Close();
        }

        private void btn_Out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            FrmSearch frm=new FrmSearch();
            frm.
            if (txt_Search.Text == "")
            {
                DialogResult result = MessageBox.Show("اختر صنف لاتمام عملية التعديل", "!تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);                
            }            
        }
    }
}
