using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongTro
{
    public class BLL_QLPT
    {
        private static BLL_QLPT _Instance;
        public static BLL_QLPT Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLPT();
                }
                return _Instance;
            }
            private set { }
        }
        public bool ktTK(string tenTK, string mk)
        {
            foreach (TK tk in DAL_QLPT.Instance.GetAllTK())
            {
                if (tk.TenTK == tenTK&&tk.MKhau == mk)
                {
                    return true; break; 
                }
            }
            return false;
        }
    }
}
