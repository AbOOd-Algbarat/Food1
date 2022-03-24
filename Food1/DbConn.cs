using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Food1
{
    internal class DbConn
    {
        //SqlCommand لإجراء عمليات القراءة والكتابة في قاعدة البيانات

        public SqlConnection conn;
        public DbConn()
        {
            conn = new SqlConnection(@"Data Source=ABOOD\MSSQLSERVER01;Initial Catalog=food;Integrated Security=True");
        }
        public SqlConnection connect()   //هذه الدالة تقوم بفتح الاتصتال بقاعدة البيانات 
        {
            conn.Open();
            return conn;           
        }
        public void Disconnect()  // This Method Do Disconnected With Data Base 
        {
            if (conn.State == ConnectionState.Open == true)
            {
                conn.Close();
            }
        }
        
    }

}
