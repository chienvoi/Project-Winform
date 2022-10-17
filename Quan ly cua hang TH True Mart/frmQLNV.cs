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
    public partial class frmQLNV : Form
    {
        public frmQLNV()
        {
            InitializeComponent();
        }
        public void getdata()
        {
            string query = @"select * from Nhanvien";
            Ketnoi cn = new Ketnoi();
            DataSet ds = cn.Laydulieu(query, "Nhanvien");
            dgvNhanvien.DataSource = ds.Tables["Nhanvien"];
        }
        private void frmQLSP_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaNV.Text = dgvNhanvien.Rows[row].Cells["MaNV"].Value.ToString();
                txtTenNV.Text = dgvNhanvien.Rows[row].Cells["TenNV"].Value.ToString();
                txtNgaysinh.Text = dgvNhanvien.Rows[row].Cells["Ngaysinh"].Value.ToString();
                txtCMND.Text = dgvNhanvien.Rows[row].Cells["CMND"].Value.ToString();
                txtDiachi.Text = dgvNhanvien.Rows[row].Cells["Diachi"].Value.ToString();
                txtSDT.Text = dgvNhanvien.Rows[row].Cells["SDT"].Value.ToString();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string tk = txtTimkiem.Text;
            string query = @"select * from Nhanvien where TenNV like N'%" + tk + "%'";
            Ketnoi cn = new Ketnoi();
            DataSet ds = cn.Laydulieu(query, "Nhanvien");
            dgvNhanvien.DataSource = ds.Tables["Nhanvien"];
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtNgaysinh.Text = "";
            txtCMND.Text = "";
            txtDiachi.Text = "";
            txtSDT.Text = "";
            getdata();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            string tennv = txtTenNV.Text;
            string ngaysinh = txtNgaysinh.Text;
            string cmnd = txtCMND.Text;
            string diachi = txtDiachi.Text;
            string sdt = txtSDT.Text;
            string query = 
@"insert into Nhanvien values('" + manv + "','" + tennv + "','" + ngaysinh + "','" + cmnd + "','" + diachi + "','" + sdt + "')";
            Ketnoi cn = new Ketnoi();
            bool kq = cn.Thucthi(query);
            if (kq == true)
            {
                MessageBox.Show("Thêm thành công");
                getdata();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            string tennv = txtTenNV.Text;
            string ngaysinh = txtNgaysinh.Text;
            string cmnd = txtCMND.Text;
            string diachi = txtDiachi.Text;
            string sdt = txtSDT.Text;
            string query = 
@"update Nhanvien set TenNV='" + tennv + "',Ngaysinh='" + ngaysinh + "',CMND='" + cmnd + "',Diachi='" + diachi + "',SDT='" + sdt + "' where MaNV='" + manv + "'";
            Ketnoi cn = new Ketnoi();
            bool kq = cn.Thucthi(query);
            if (kq == true)
            {
                MessageBox.Show("Sửa thành công");
                getdata();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            string query = @"delete from Nhanvien where MaNV='" + manv + "'";
            Ketnoi cn = new Ketnoi();
            bool kq = cn.Thucthi(query);
            if (kq == true)
            {
                MessageBox.Show("Xoá thành công");
                getdata();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
