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
    public partial class FrmOrder : Form
    {
        static double Am = 0;
        public FrmOrder()
        {
            InitializeComponent();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {        
                this.Close();
        }       
        private string Max(string Sql)
        {
            int x = 0;
            DbConn db=new DbConn();
            db.Disconnect();
            SqlCommand cmd = new SqlCommand(Sql,db.connect());
            SqlDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                if(x<Int32.Parse(dr[0].ToString()))//اذا كان x اقل من قيمة الحقل خذها وخزنها في
                    x=Int32.Parse(dr[0].ToString());
            }
            x++;
            return x.ToString();
        }
        private void FillDataGride()
        {
            try
            {
                string Sql = "Select no_items,name_items From items";
                DataGridViewComboBoxColumn column1 = (DataGridViewComboBoxColumn)this.dataGridView1.Columns["No_Items"];// استخدمت هذا الكلاس لتحويل (تحوير)العمود الاول الىcomboBox
                DataGridViewComboBoxColumn column2 = (DataGridViewComboBoxColumn)this.dataGridView1.Columns["Name_Items"];
                DbConn db = new DbConn();
                db.Disconnect();
                SqlCommand cmd = new SqlCommand(Sql, db.connect());//الكلاس الخاص بتنفيد الاستعلام
                SqlDataReader dr = cmd.ExecuteReader();//الكلاس الخاص بجلب داتا           
                while (dr.Read())// dataGrid ملئ البيانات من جدول الاصناف في 
                {
                    column1.Items.Add(dr[0].ToString());
                    column2.Items.Add(dr[1].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error | \n\n" + ex.Message.ToString());
            }           
        }
        private void FrmOrder_Load(object sender, EventArgs e)
        {
            try
            {
                string Sql = "Select customer_number,customer_name From customers ";
                DbConn db = new DbConn();
                db.Disconnect();
                SqlCommand cmd = new SqlCommand(Sql, db.connect());
                SqlDataReader reader = cmd.ExecuteReader();//يقرا البيانات ويجلها من الجدول عن طريق   cmd
                while (reader.Read())// لوب لقرائة البيانات بس يخلص 
                {// هنا رح نعبي البيانات داخل comb Items.Add من خلال كلاسوميثود 
                    comb_NoCustomer.Items.Add(reader["customer_number"].ToString());//هنا قمنا بتعئة ارقام المستخدمين في combo number 
                    comb_NameCostumer.Items.Add(reader["customer_name"].ToString());////هنا قمنا بتعئة ارقام المستخدمين في combo name 

                }

                int x = 0;
                string max = Max("select Order_Number From head_order");
                if (max == null || max == "")
                {
                    x = 0;
                    DialogResult result = MessageBox.Show("قاعدة البيانات فارغة \n\n هل تريد اضافة بيانات جديدة", "!تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    { }
                    else if (result == DialogResult.No)
                        this.Close();
                }
                else
                    x = Int32.Parse(Max(Sql));//convart from string to int
                x++;
                txt_No_order.Text = x.ToString();
                FillDataGride();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error | \n\n" +"ex.ToString(): "+ ex.Message.ToString());
            }           
        }
        private void comb_NoCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //هنا قمت باضافة حدث يحيث اذا اخترت رقم المستخدم يظهر اسمه 
            comb_NameCostumer.SelectedIndex = comb_NoCustomer.SelectedIndex;
        }
        private void comb_NameCostumer_SelectedIndexChanged(object sender, EventArgs e)
        {
            comb_NoCustomer.SelectedIndex = comb_NameCostumer.SelectedIndex;
        }
        private void Savehead()
        {
            try
            {
                if ((comb_NameCostumer.Text == "") && (comb_NoCustomer.Text == ""))
                {
                    MessageBox.Show("قم بتعبئة اسم المستخدم او رقم المستخدم");
                    comb_NameCostumer.Focus();
                }
                else
                {
                    DbConn db = new DbConn();
                    db.Disconnect();
                    SqlCommand cmd = new SqlCommand("insert into head_order (Order_Number,Oreder_Date,customer_number,Total) values (@Order_Number,@Oreder_Date,@customer_number@,@Total)");///كل حقل رح ياخد المعامل المقابل له
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = db.connect();
                    cmd.Parameters.AddWithValue("@Order_Number", txt_No_order.Text);
                    cmd.Parameters.AddWithValue("@Oreder_Date", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    cmd.Parameters.AddWithValue("@customer_number", comb_NoCustomer.Text);
                    cmd.Parameters.AddWithValue("@Total", txt_Total.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تمت عملية الحفظ بنجاح");

                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Error | \n\n" + ex.Message.ToString());
            }            
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Savehead();           
            this.Close();  
        }
        private void Savedetails()
        { 
            try
            {
                DbConn db = new DbConn();
                string x1 = Max("Select Nomber_Det_Order From detail_order");
                int x;
                if (x1 == "")
                    x = 0;
                else
                    x = int.Parse(x1);
                x++;

                int count = dataGridView1.Rows.Count;//الحصول على عدد الصفوف
                for (int i = 0; i < count; i++)
                {
                    db.Disconnect();
                    SqlCommand cmd = new SqlCommand("insert into detail_order (Nomber_Det_Order,Order_Number,no_items,Account,Price,Total,Descount) values (@Nomber_Det_Order,@Order_Number,@no_items,@Account,@Price,@Total,@Descount)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = db.connect();
                    cmd.Parameters.AddWithValue("@Nomber_Det_Order", x);
                    cmd.Parameters.AddWithValue("@Order_Number", txt_No_order.Text);
                    cmd.Parameters.AddWithValue("@no_items", dataGridView1.Rows[i].Cells["No_Items"].Value);
                    cmd.Parameters.AddWithValue("@Account", dataGridView1.Rows[i].Cells["Account"].Value);
                    cmd.Parameters.AddWithValue("@Price", dataGridView1.Rows[i].Cells["Price"].Value);
                    cmd.Parameters.AddWithValue("@Total", dataGridView1.Rows[i].Cells["Total"].Value);
                    cmd.Parameters.AddWithValue("@Descount", dataGridView1.Rows[i].Cells["Descount"].Value);
                    x++;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error | \n\n" + ex.Message.ToString());
            }
        }

        private void Show_Items(string s,int colm,int indx)//قمت ببناء دالة تقوم باختبار السجل من جدول حسب رقم الصنف الذي تم اختيارة items
        {//s هي القيمة التي اختارها المستخدم سواء كانت رقم الصنف او اسم الصنف
            //يشير الى رقم الصف indx
            
            try
            {
                string Sql = "";
                if (colm == 0)
                    Sql = "Select * From items where no_items='" + s + "' ";//ااذا المستخدم اختار رقم الصنف نفذ هاي
                if (colm == 1)
                    Sql = "Select * From items where name_items='" + s + "' ";//ااذا المستخدم اختار اسم الصنف نفذ هاي

                DbConn db = new DbConn();
                db.Disconnect();
                SqlCommand cmd = new SqlCommand(Sql, db.connect());
                SqlDataReader dr = cmd.ExecuteReader();

                dataGridView1.Rows[indx].Cells["Account"].Value = "1";//عبية قيم افتراضية للصفوف قبل استدعاء البيانات 
                dataGridView1.Rows[indx].Cells["Total"].Value = "0";
                dataGridView1.Rows[indx].Cells["Descount"].Value = "0";
                dataGridView1.Rows[indx].Cells["Amount"].Value = "0";


                if (dr.Read())//هنا بنعبي البيانات في data grid 
                {
                    dataGridView1.Rows[indx].Cells["no_items"].Value = dr[0].ToString();
                    dataGridView1.Rows[indx].Cells["name_items"].Value = dr[1].ToString();
                    dataGridView1.Rows[indx].Cells["Price"].Value = dr[2].ToString();

                    double x1 = double.Parse(dataGridView1.Rows[indx].Cells["Price"].Value.ToString());//انشائت عملية حسابية بين السعر والعدد
                    double x2 = double.Parse(dataGridView1.Rows[indx].Cells["Account"].Value.ToString());
                    double x3 = x1 * x2;
                    dataGridView1.Rows[indx].Cells["Total"].Value = x3.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error | \n\n" + ex.Message.ToString());
            }           
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)// اذا كان رقم الصف>> العمود
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["No_Items"].Value != null)
                {
                    string NoItem = (dataGridView1.Rows[e.RowIndex].Cells["No_Items"].Value.ToString());
                    Show_Items(NoItem, e.ColumnIndex, e.RowIndex);
                }
            }

            if (e.ColumnIndex == 1)//اذا كان رقم اسم الصف >> العمود
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["Name_Items"].Value != null)
                {
                    string NamItem = (dataGridView1.Rows[e.RowIndex].Cells["Name_Items"].Value.ToString());
                    Show_Items(NamItem, e.ColumnIndex, e.RowIndex);
                }
            }

            if (e.ColumnIndex == 3)//  اذا كان رقم الصف >> العمود عملية ضرب
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["Account"].Value != null)//هنا قمت بعمل شرط بحيث اذا تغيرت قيمة العدد اثناء التعبئة يرجع يعمل عملية حسابية بين السعر والعدد
                {
                    double x1 = double.Parse(dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString());
                    double x2 = double.Parse(dataGridView1.Rows[e.RowIndex].Cells["Account"].Value.ToString());
                    double x3 = x1 * x2;
                    dataGridView1.Rows[e.RowIndex].Cells["Total"].Value = x3.ToString();
                }
            }
            if (e.ColumnIndex == 5)//  اذا كان رقم الصف >> العمود عملية ضرب
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["Descount"].Value != null)//هنا قمت بعمل شرط بحيث اذا تغيرت قيمة العدد اثناء التعبئة يرجع يعمل عملية حسابية بين السعر والعدد
                {
                    double x1 = double.Parse(dataGridView1.Rows[e.RowIndex].Cells["Total"].Value.ToString());
                    double x2 = double.Parse(dataGridView1.Rows[e.RowIndex].Cells["Descount"].Value.ToString()); 
                    double x3 = x1*x2;
                    dataGridView1.Rows[e.RowIndex].Cells["Amount"].Value = x3.ToString();
                }
            }
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                double x1 = double.Parse(dataGridView1.Rows[e.RowIndex].Cells["Total"].Value.ToString());
                double x2 = double.Parse(dataGridView1.Rows[e.RowIndex].Cells["Descount"].Value.ToString());
                double x3=x1 - x2;
                dataGridView1.Rows[e.RowIndex].Cells["Amount"].Value = x3.ToString();
                Am+=double.Parse( dataGridView1.Rows[e.RowIndex].Cells["Amount"].Value.ToString());
                txt_Total.Text=Am.ToString();                
            }
        }       
    }
}
