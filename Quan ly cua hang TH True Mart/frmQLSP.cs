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
    public partial class frmQLSP : Form
    {
        public frmQLSP()
        {
            InitializeComponent();
        }
        public void getdata()
        {
            string query = @"select * from Sanpham";
            Ketnoi cn = new Ketnoi();
            DataSet ds = cn.Laydulieu(query, "Sanpham");
            dgvSanpham.DataSource = ds.Tables["Sanpham"];
        }
        
        public void getloai()
        {
            string query = @"select * from LoaiSP";
            Ketnoi cn = new Ketnoi();
            DataSet ds = cn.Laydulieu(query, "LoaiSP");
            cmbLoai.DataSource = ds.Tables["LoaiSP"];
            cmbLoai.DisplayMember = "MaLoai";
            cmbLoai.ValueMember = "MaLoai";
        }
        private void frmQLSP_Load(object sender, EventArgs e)
        {
            getdata();
            getloai();
        }

        private void dgvSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaSP.Text = dgvSanpham.Rows[row].Cells["MaSP"].Value.ToString();
                txtTenSP.Text = dgvSanpham.Rows[row].Cells["TenSP"].Value.ToString();
                cmbLoai.SelectedValue = dgvSanpham.Rows[row].Cells["MaLoai"].Value.ToString();
                txtNgaynhap.Text = dgvSanpham.Rows[row].Cells["Ngaynhap"].Value.ToString();
                txtSoSP.Text = dgvSanpham.Rows[row].Cells["SoSP"].Value.ToString();
                txtGiaban.Text = dgvSanpham.Rows[row].Cells["Giaban"].Value.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string tk = txtTimkiem.Text;
            string query = @"select * from Sanpham where TenSP like N'%" + tk + "%'";
            Ketnoi cn = new Ketnoi();
            DataSet ds = cn.Laydulieu(query, "Sanpham");
            dgvSanpham.DataSource = ds.Tables["Sanpham"];
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            cmbLoai.SelectedValue = "";
            txtNgaynhap.Text = "";
            txtSoSP.Text = "";
            txtGiaban.Text = "";
            txtSLBan.Text = "";
            getdata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string msp = txtMaSP.Text;
            string tensp = txtTenSP.Text;
            string maloai = cmbLoai.SelectedValue.ToString();
            string ngaynhap = txtNgaynhap.Text;
            string sosp = txtSoSP.Text;
            string giaban = txtGiaban.Text;
            string query = 
@"insert into SanPham values('" + msp + "','" + tensp + "','" + maloai + "','" + ngaynhap + "','" + sosp + "','" + giaban + "')";
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
            string msp = txtMaSP.Text;
            string tensp = txtTenSP.Text;
            string maloai = cmbLoai.SelectedValue.ToString();
            string ngaynhap = txtNgaynhap.Text;
            string sosp = txtSoSP.Text;
            string giaban = txtGiaban.Text;
            string query = 
@"update Sanpham set TenSP='" + tensp + "',MaLoai='" + maloai + "',Ngaynhap='" + ngaynhap + "',Soluong='" + sosp + "',Giaban='" + giaban + "' where MaSP='" + msp + "'";
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
            string msp = txtMaSP.Text;
            string query = @"delete from Sanpham where MaSP='" + msp + "'";
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

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text;
            string slban = txtSLBan.Text;
            string query =
            @"update Sanpham set SoSP = SoSP - '"+ slban +"' where MaSP = '"+ masp +"'";
            Ketnoi cn = new Ketnoi();
            bool kq = cn.Thucthi(query);
            if (txtMaSP.Text != "" && txtSLBan.Text != "")
            {
                if (kq == true)
                {
                    MessageBox.Show("Cập nhật thành công");
                    getdata();
                    txtMaSP.Text = "";
                    txtTenSP.Text = "";
                    cmbLoai.SelectedValue = "";
                    txtNgaynhap.Text = "";
                    txtSoSP.Text = "";
                    txtGiaban.Text = "";
                    txtSLBan.Text = "";
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập thông tin");
            }    
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            string masp = txtMaSP.Text;
            string query =
            @"select sum(Soluong) as Tongban
                from Hoadon
                group by MaSP
                having MaSP = '"+ masp +"'";
            Ketnoi cn = new Ketnoi();
            DataSet ds = cn.Laydulieu(query, "Hoadon");
            txtSLBan.Text = ds.Tables["Hoadon"].Rows[0].ItemArray[0].ToString();
        }
    }
}
