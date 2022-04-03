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
    public partial class FrmFood : Form
    {

        int i = 0;
        DataSet ds;
        public FrmFood()
        {
            InitializeComponent();
        }             
        
        public void Enalbe_Controls()
        {
            btn_Updat.Enabled = true;
            btn_Delet.Enabled = true;
            btn_Save.Enabled = true;
        }
       
        int Max_Nomber()//دالة لاخذ اعلى قيمة في قاعدة البيانات
        {
            DbConn dbConn =new DbConn();
            dbConn.Disconnect();
            string sql = "Select Max (no_items) From items";//بنينا عملية الاستعلام
            SqlCommand cmd = new SqlCommand(sql);//قمنا بتنفيذ الجملة
            cmd.CommandType = CommandType.Text;//حددنا نوعية التنفيذ 
            cmd.Connection = dbConn.connect();//الاتصال بالقاعدة
            cmd.ExecuteNonQuery();//تنفيذ الأمر بدون ارجاع أي مخرجات
            var Max=cmd.ExecuteScalar();//استخلاص القيمة ووضعناها بمتفير تنفيذ الأمر مع ارجاع قيمة واحدة max           
            return Int32.Parse(Max.ToString());//تحويل القيمة من نصية الى عددية           
        }
        void save()
        {
            if ((txtNa_Item.Text == "") && (txtPrice_Item.Text == ""))
            {
                txtNa_Item.Focus();
                txtNa_Item.Text = "";
                txtPrice_Item.Text = "";
                MessageBox.Show(" قم بادخال معلومات الصنف ");
                txtNa_Item.Enabled = true;
                txtPrice_Item.Enabled = true;                
            }
            else
            {               
                DbConn db = new DbConn();
                db.Disconnect();
                string Sql = "insert into items (no_items,name_items,item_price) values (@no_items,@name_items,@item_price)";
                SqlCommand cmd = new SqlCommand(Sql);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = db.connect();
                cmd.Parameters.AddWithValue("@no_items", txtNo_Item.Text);
                cmd.Parameters.AddWithValue("@name_items", txtNa_Item.Text);
                cmd.Parameters.AddWithValue("@item_price", txtPrice_Item.Text);
                cmd.ExecuteNonQuery();
                db.conn.Close();
                MessageBox.Show("تم اضافة الصنف بنجاح  ");
                int x = Max_Nomber();
                x++;
                txtNo_Item.Text = x.ToString();
                txtNa_Item.Text = "";
                txtPrice_Item.Text = "";
                txtNa_Item.Enabled = false;
                txtPrice_Item.Enabled = false;

            }             
        }
        public void FrmFood_Load(object sender, EventArgs e)//عند بدء عمل الفورم تبدا عملية الزيادة
        {
            DbConn db = new DbConn();
            ds=new DataSet();
            int max = Max_Nomber();
            max++;
            txtNo_Item.Text = max.ToString();
            string Sql = "Select * From items";
            db.Disconnect();
            SqlCommand cmd = new SqlCommand(Sql,db.connect());
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            da.Fill(ds, "Table");            
        }              
        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            DbConn db = new DbConn();
            string Sql = " ", Value = " ";
            FrmSearch frm = new FrmSearch();
            DataCollection.Sql = "Select * from items";// يقوم بتخزين واستدعاء الاستعلام الخاص بجدول الاصناف
            DataCollection.Sql_Where = "Select * From items where name_items like '% ";
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                Value = frm.txt_Search.Text;
            }
            Sql = "select * from items where name_items='" + Value + "'";
            db.Disconnect();
            SqlCommand cmd = new SqlCommand(Sql, db.connect());
            SqlDataReader rd = cmd.ExecuteReader();//تنفيذ الأمر مع ارجاع من نوع IDataReader
            while (rd.Read() == true)
            {
                txtNo_Item.Text = rd[0].ToString();
                txtNa_Item.Text = rd[1].ToString();
                txtPrice_Item.Text = rd[2].ToString();

                txtNa_Item.Focus();
                txtNa_Item.Enabled = true;
                txtPrice_Item.Enabled = true;
                btn_Save.Enabled = false;
            }
        }      
        private void btn_Save_Click(object sender, EventArgs e)//استدعاء دالة الحفظ
        {
            save();
        }

        private void btn_Delet_Click(object sender, EventArgs e)
        {
            if ((txtNa_Item.Text == "") && (txtPrice_Item.Text == ""))
            {
                MessageBox.Show("الرجاء قم بتحديدالصنف الذي تريد حذفة");

            }
            else
            {
                DbConn db = new DbConn();
                db.Disconnect();
                string Sql = "Delete from items where no_items='" + txtNo_Item.Text + "'";
                SqlCommand cmd = new SqlCommand(Sql, db.connect());
                cmd.ExecuteNonQuery();//تقوم بالتنفيذ النهائي
                db.conn.Close();
                DialogResult result = MessageBox.Show("\n هل انت متاكد من حذف هذا الصنف ؟", "تحذير ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("تم الحذف");

                    Enalbe_Controls();
                    txtPrice_Item.Text = "";
                    txtNa_Item.Text = "";
                    txtNa_Item.Enabled = false;
                    txtPrice_Item.Enabled = false;                   
                }
            }
        }

        private void btn_Updat_Click(object sender, EventArgs e)
        {
            if ((txtNa_Item.Text == "") && (txtPrice_Item.Text == ""))
            {
                MessageBox.Show("الرجاء قم بتحديدالصنف الذي تريد التعديل علية");
            }
            else
            {
                DbConn db = new DbConn();
                db.Disconnect();
                string Sql = "Update items set no_items=@no_items,name_items=@name_items,item_price=@item_price where no_items= '" + txtNo_Item.Text + "'";
                SqlCommand cmd = new SqlCommand(Sql);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = db.connect();
                cmd.Parameters.AddWithValue("@no_items", txtNo_Item.Text);
                cmd.Parameters.AddWithValue("@name_items", txtNa_Item.Text);
                cmd.Parameters.AddWithValue("@item_price", txtPrice_Item.Text);
                cmd.ExecuteNonQuery();
                db.conn.Close();

                DialogResult result = MessageBox.Show("هل انت متاكد من التعديل على هذا الصنف ؟", "تحذير ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("تمت عملية التعديل");
                    Enalbe_Controls();
                    txtPrice_Item.Text = "";
                    txtNa_Item.Text = "";
                    txtNa_Item.Enabled = false;
                    txtPrice_Item.Enabled = false;
                }
                else { }
            }
        }
        private void btn_First_It_Click(object sender, EventArgs e)
        {
            i = 0;
            txtNo_Item.Text = ds.Tables[0].Rows[i][0].ToString();
            txtNa_Item.Text = ds.Tables[0].Rows[i][1].ToString();
            txtPrice_Item.Text = ds.Tables[0].Rows[i][2].ToString();
            txtNa_Item.Enabled = false;
            txtPrice_Item.Enabled = false;
            MessageBox.Show("F I R S T  I T E M S" + "\n\n" + "Nomber Items: " + txtNo_Item.Text + "\n\n" + "Name Items: " + txtNa_Item.Text + "\n\n" + "Price Items: " + txtPrice_Item.Text);
        }

        private void btn_previous_IT_Click(object sender, EventArgs e)
        {
            if (i < ds.Tables[0].Rows.Count - 1)
            {
                i++;
                txtNo_Item.Text = ds.Tables[0].Rows[i][0].ToString();
                txtNa_Item.Text = ds.Tables[0].Rows[i][1].ToString();
                txtPrice_Item.Text = ds.Tables[0].Rows[i][2].ToString();
            }
        }

        private void btn_Next_IT_Click(object sender, EventArgs e)
        {
            if (i != 0)
            {
                i--;
                txtNo_Item.Text = ds.Tables[0].Rows[i][0].ToString();
                txtNa_Item.Text = ds.Tables[0].Rows[i][1].ToString();
                txtPrice_Item.Text = ds.Tables[0].Rows[i][2].ToString();
            }
        }

        private void btn_Last_IT_Click(object sender, EventArgs e)
        {

            i = ds.Tables[0].Rows.Count - 1;//  تقوم بارجاع عدد السجلات مخزنه ب  -1 count  الدالة 
            txtNo_Item.Text = ds.Tables[0].Rows[i][0].ToString();
            txtNa_Item.Text = ds.Tables[0].Rows[i][1].ToString();
            txtPrice_Item.Text = ds.Tables[0].Rows[i][2].ToString();
            txtNa_Item.Enabled = false;
            txtPrice_Item.Enabled = false;
            MessageBox.Show("L A S T  I T E M S" + "\n\n" + "Nomber Items: " + txtNo_Item.Text + "\n\n" + "Name Items: " + txtNa_Item.Text + "\n\n" + "Price Items: " + txtPrice_Item.Text);
        }

        private void btn_Out_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من الخروج ؟", "!تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }    
}
