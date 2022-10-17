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
    public partial class frmMaQLNV : Form
    {
        public frmMaQLNV()
        {
            InitializeComponent();
        }

        private void btnThuchien_Click(object sender, EventArgs e)
        {
            string maql = txtMaQL.Text;
            string query = "select count(*) as SoLuong from Nguoidung where Maquanly = '" + maql + "'";
            Ketnoi cn = new Ketnoi();
            DataSet ds = cn.Laydulieu(query, "NguoiDung");
            // Kiểm tra Số lượng trả về có bằng 1 hay không
            if ((int)ds.Tables["NguoiDung"].Rows[0].ItemArray[0] == 1)
            {
                frmQLNV frm = new frmQLNV();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mã quản lý không đúng hoặc không có quyền truy cập");
            }
        }
    }
}
