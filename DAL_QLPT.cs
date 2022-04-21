using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongTro
{
    public class DAL_QLPT
    {
        private static DAL_QLPT _Instance; 
        public static DAL_QLPT Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLPT();
                }
                return _Instance;
            }
            private set { }  
        }
        public List<TK> GetAllTK()
        {
            List<TK> list = new List<TK>();
            foreach (DataRow i in DBHelper.Instance.GetRecordsTK("Select * from TaiKhoan").Rows)
            {
                list.Add(getTKByDataRow(i));
            }
            return list; 
        }
        public TK getTKByDataRow(DataRow dr)
        {
            return new TK
            {
                ID = dr["ID"].ToString(),
                TenTK = dr["TenTK"].ToString(),
                MKhau = dr["MKhau"].ToString()
            }; 
        }
    }
}
