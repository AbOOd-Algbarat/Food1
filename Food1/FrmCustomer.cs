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
        int i = 0;
        DataSet ds;
        public FrmCustomer()
        {
            InitializeComponent();
        }
        public void Enalbe_Controls()
        {
            btn_Save.Enabled = true;
            btn_Delet.Enabled = true;
            btn_Updat.Enabled = true;
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
                txtName_Customer.Enabled = true;
                txtName_Customer.Focus();
                txtPhon_Customer.Enabled = true;              
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

                int x = Max_Nomber();
                x++;
                txtNomber_Customer.Text = x.ToString();
                txtName_Customer.Text = "";
                txtPhon_Customer.Text = "";
                txtName_Customer.Enabled = false;
                txtPhon_Customer.Enabled = false;
            }          
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
             save();
        }
        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            DbConn db = new DbConn();
            string Sql = " ", Value = " ";
            FrmSearch frm = new FrmSearch();
            DataCollection.Sql = "Select * from customers";// يقوم بتخزين واستدعاء الاستعلام الخاص بجدول الزبائن
            DataCollection.Sql_Where = "Select * From customers where customer_name  like '% ";
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                Value = frm.txt_Search.Text;
            }
            Sql = "select * from customers where customer_name='" + Value + "'";
            db.Disconnect();
            SqlCommand cmd = new SqlCommand(Sql, db.connect());
            SqlDataReader rd = cmd.ExecuteReader();//تنفيذ الأمر مع ارجاع من نوع IDataReader
            while (rd.Read() == true)
            {
                txtNomber_Customer.Text = rd[0].ToString();
                txtName_Customer.Text = rd[1].ToString();
                txtPhon_Customer.Text = rd[2].ToString();

                txtName_Customer.Focus();
                txtName_Customer.Enabled = true;
                txtPhon_Customer.Enabled = true;
                btn_Save.Enabled = false;
            }
        }
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            DbConn db = new DbConn();
            ds = new DataSet();
            int x = Max_Nomber();
            x++;
            txtNomber_Customer.Text = x.ToString();
            string Sql = "Select * From customers";
            db.Disconnect();
            SqlCommand cmd = new SqlCommand(Sql, db.connect());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Table");
        }

        private void btn_Delet_Click(object sender, EventArgs e)
        {
            if ((txtName_Customer.Text == "") && (txtPhon_Customer.Text == ""))
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
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("تم حذف المستخدم بنجاح");
                    Enalbe_Controls();
                    txtName_Customer.Text = "";
                    txtPhon_Customer.Text = "";
                }
            }
        }

        private void btn_Updat_Click(object sender, EventArgs e)
        {
            if ((txtName_Customer.Text == "") && (txtPhon_Customer.Text == ""))
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
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("تمت عملية التعديل");
                    Enalbe_Controls();
                    txtName_Customer.Text = "";
                    txtName_Customer.Enabled = false;
                    txtPhon_Customer.Text = "";
                    txtPhon_Customer.Enabled = false;
                }
            }
        }       
        private void btn_First_Co_Click(object sender, EventArgs e)
        {
            i = 0;
            txtNomber_Customer.Text = ds.Tables[0].Rows[i][0].ToString();
            txtName_Customer.Text = ds.Tables[0].Rows[i][1].ToString();
            txtPhon_Customer.Text = ds.Tables[0].Rows[i][2].ToString();
            txtName_Customer.Enabled = false;
            txtPhon_Customer.Enabled = false;
            MessageBox.Show("F I R S T  C U S T O M R E" + "\n\n" + "Number Customer: " + txtNomber_Customer.Text + "\n\n" + "Name Customre: " + txtName_Customer.Text + "\n\n" + "Phone Customre: " + txtPhon_Customer.Text);

            txtName_Customer.Enabled = false;
            txtPhon_Customer.Enabled = false;
        }

        private void btn_previous_Co_Click(object sender, EventArgs e)
        {
            if (i < ds.Tables[0].Rows.Count - 1)
            {
                i++;
                txtNomber_Customer.Text = ds.Tables[0].Rows[i][0].ToString();
                txtName_Customer.Text = ds.Tables[0].Rows[i][1].ToString();
                txtPhon_Customer.Text = ds.Tables[0].Rows[i][2].ToString();

                txtName_Customer.Enabled = false;
                txtPhon_Customer.Enabled = false;
            }
        }

        private void btn_Next_Co_Click(object sender, EventArgs e)
        {

            if (i != 0)
            {
                i--;
                txtNomber_Customer.Text = ds.Tables[0].Rows[i][0].ToString();
                txtName_Customer.Text = ds.Tables[0].Rows[i][1].ToString();
                txtPhon_Customer.Text = ds.Tables[0].Rows[i][2].ToString();

                txtName_Customer.Enabled = false;
                txtPhon_Customer.Enabled = false;
            }
        }

        private void btn_Last_Co_Click(object sender, EventArgs e)
        {
            i = ds.Tables[0].Rows.Count - 1;//  تقوم بارجاع عدد السجلات مخزنه ب  -1 count  الدالة 
            txtNomber_Customer.Text = ds.Tables[0].Rows[i][0].ToString();
            txtName_Customer.Text = ds.Tables[0].Rows[i][1].ToString();
            txtPhon_Customer.Text = ds.Tables[0].Rows[i][2].ToString();
            txtName_Customer.Enabled = false;
            txtPhon_Customer.Enabled = false;
            MessageBox.Show("L A S T   C U S T O M R R" + "\n\n" + "Nomber Customer: " + txtNomber_Customer.Text + "\n\n" + "Name Customer: " + txtName_Customer.Text + "\n\n" + "Phone Customer: " + txtPhon_Customer.Text);

            txtName_Customer.Enabled = false;
            txtPhon_Customer.Enabled = false;
        }

        private void btn_Out_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من الخروج ؟", "!تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
