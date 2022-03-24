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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }        
        
        int Max_Nomber()//دالة لاخذ اعلى قيمة في قاعدة البيانات
        {
            DbConn dbConn = new DbConn();
            dbConn.Disconnect();
            string sql = "Select Max (customer_number) From customers";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dbConn.connect();
            cmd.ExecuteNonQuery();//max nomber رجعت القيمة الي استعلمت عنها وهي 
            var Max = cmd.ExecuteScalar();//خزناها في var 
            return Int32.Parse(Max.ToString());
        }
        void save()
        {
            if ((txtName_Customer.Text == "") && (txtPhon_Customer.Text == ""))
            {
                MessageBox.Show("قم بادخال معلومات المستخدم");                
            }
            else
            {

                DbConn db = new DbConn();
                db.Disconnect();
                string Sql = "insert into customers (customer_number,customer_name,customer_phone) values (@customer_number,@customer_name,@customer_phone)";
                SqlCommand cmd = new SqlCommand(Sql);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = db.connect();
                cmd.Parameters.AddWithValue("@customer_number", txtNomber_Customer.Text);
                cmd.Parameters.AddWithValue("@customer_name", txtName_Customer.Text);
                cmd.Parameters.AddWithValue("@customer_phone", txtPhon_Customer.Text);
                cmd.ExecuteNonQuery();
                db.conn.Close();
                MessageBox.Show("تم اضافة المستخدم بنجاح  ");
            }
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {          
            save();           
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {                       
            int x = Max_Nomber();
            x++;
            txtNomber_Customer.Text = x.ToString();
        }

        private void btn_Out_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من الخروج ؟", "!تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if ((txtName_Customer.Text == "") && (txtNomber_Customer.Text == "") && (txtPhon_Customer.Text == ""))
            {
                MessageBox.Show(" قم بتحديدالمستخدم الذي تريد حذفة");
            }
            else
            {
                DbConn db = new DbConn();
                db.Disconnect();
                string Sql = "Delete from customers where customer_number='" + txtNomber_Customer.Text + "'";
                SqlCommand cmd = new SqlCommand(Sql, db.connect());
                cmd.ExecuteNonQuery();//تقوم بالتنفيذ النهائي
                db.conn.Close();
                DialogResult result = MessageBox.Show("\n هل انت متاكد من حذف المستخدم ؟", "تحذير ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if ((txtName_Customer.Text == "") &&  (txtPhon_Customer.Text == ""))
            {
                MessageBox.Show(" قم بتحديدالمستخدم الذي تريد التعديل علية");
            }
            else
            {
                DbConn db = new DbConn();
                db.Disconnect();
                string Sql = "Update customers set customer_number=@customer_number,customer_name=@customer_name,customer_phone=@customer_phone where customer_number= '" + txtNomber_Customer.Text + "'";
                SqlCommand cmd = new SqlCommand(Sql);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = db.connect();
                cmd.Parameters.AddWithValue("@customer_number", txtNomber_Customer.Text);
                cmd.Parameters.AddWithValue("@customer_name", txtName_Customer.Text);
                cmd.Parameters.AddWithValue("@customer_phone", txtPhon_Customer.Text);
                cmd.ExecuteNonQuery();
                db.conn.Close();

                DialogResult result = MessageBox.Show("\n هل انت متاكد من التعديل على هذا المستخدم ؟", "تحذير ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            }
        }

        private void btn_Show_All_Customer_Click(object sender, EventArgs e)
        {
            DataCollection.Sql = "Select * from customers";// يقوم بتخزين واستدعاء الاستعلام الخاص بجدول الزبائن
            DataCollection.Sql_Where = "Select * From customers where customer_name  like '% ";
            FrmSearch frm= new FrmSearch();
            frm.Show();
        }
    }
}
