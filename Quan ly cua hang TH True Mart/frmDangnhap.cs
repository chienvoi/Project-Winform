using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_cua_hang_TH_True_Mart
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = txtTaikhoan.Text;
            string mk = txtMatkhau.Text;
            string query = "select count(*) as SoLuong from Nguoidung where Taikhoan = '" + tk + "' and Matkhau = '" + mk + "'";
            Ketnoi cn = new Ketnoi();
            DataSet ds = cn.Laydulieu(query, "NguoiDung");
            // Kiểm tra Số lượng trả về có bằng 1 hay không
            if ((int)ds.Tables["NguoiDung"].Rows[0].ItemArray[0] == 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                frmHethong frm = new frmHethong();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}
