using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongTro
{
    public class DBHelper
    {
        private static string s = @"Data Source=LAPTOP-KTJ09GK5\SQLEXPRESS;Initial Catalog=quanlyphongtro;Integrated Security=True";
        private static DBHelper _Instance;
        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DBHelper(s);
                }
                return _Instance;
            }
            private set { }
        }
        private SqlConnection cnn;
        public DBHelper(string s)
        {
            cnn = new SqlConnection(s);
        }
        public void ExecuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public DataTable GetRecordsTK(string query)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader r;
            dt.Columns.AddRange(new DataColumn[] {
                new DataColumn {ColumnName = "TenTK", DataType = typeof(string)},
                new DataColumn {ColumnName = "MKhau", DataType = typeof(string)}
            });
            cnn.Open();
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                dt.Rows.Add(
                    r[0].ToString(),
                    r[1].ToString()
                    );
            }
            cnn.Close();
            return dt;
        }
    }
}
