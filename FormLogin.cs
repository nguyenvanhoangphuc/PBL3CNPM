using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyPhongTro
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (BLL_QLPT.Instance.ktTK(txtTenTK.Text,txtMK.Text))
            {
                //tao form menu của chủ trọ hoặc nhân viên sửa chữa
            }
            else
            {
                MessageBox.Show("Thông tin bạn đã nhập không chính xác.");
            }
        }
    }
}
