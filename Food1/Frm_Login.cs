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
    public partial class Frm_Login : Form
    {
        DbConn db;
        public Frm_Login()
        {
            db = new DbConn();
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string Sql = "Select user_Password From Users Where user_Name ='" + combo_UseName.Text + "'";
            db.Disconnect();
            SqlCommand cmd = new SqlCommand(Sql,db.connect());
            var pass=cmd.ExecuteScalar();
            if(combo_UseName.Text == "" || !txt_Password.Text.Equals(pass.ToString()))
            {
                MessageBox.Show(" اسم المستخدم او كلمة المرور خاطئة يرجى اعادة المحاولة");
            }              
            else            
                this.Close();
            
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            string Sql = "Select user_Name From Users";
            db.Disconnect();
            SqlCommand cmd = new SqlCommand(Sql,db.connect());
            SqlDataReader dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                combo_UseName.Items.Add(dr[0].ToString());
            }
        }
    }
}
