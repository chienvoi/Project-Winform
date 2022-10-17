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
    public partial class frmQLHD : Form
    {
        public frmQLHD()
        {
            InitializeComponent();
        }
        public void getdata()
        {
            string query = @"select * from Hoadon";
            Ketnoi cn = new Ketnoi();
            DataSet ds = cn.Laydulieu(query, "Hoadon");
            dgvHoadon.DataSource = ds.Tables["Hoadon"];
        }
        public void getMaNV()
        {
            string query = @"select * from Nhanvien";
            Ketnoi cn = new Ketnoi();
            DataSet ds = cn.Laydulieu(query, "Nhanvien");
            cmbMaNV.DataSource = ds.Tables["Nhanvien"];
            cmbMaNV.DisplayMember = "MaNV";
            cmbMaNV.ValueMember = "MaNV";
        }
        public void getMaSP()
        {
            string query = @"select * from Sanpham";
            Ketnoi cn = new Ketnoi();
            DataSet ds = cn.Laydulieu(query, "Sanpham");
            cmbMaSP.DataSource = ds.Tables["Sanpham"];
            cmbMaSP.DisplayMember = "MaSP";
            cmbMaSP.ValueMember = "MaSP";
        }

        private void frmQLHD_Load(object sender, EventArgs e)
        {
            getdata();
            getMaNV();
            getMaSP();
        }

        private void dgvHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaHD.Text = dgvHoadon.Rows[row].Cells["MaHD"].Value.ToString();
                cmbMaNV.SelectedValue = dgvHoadon.Rows[row].Cells["MaNV"].Value.ToString();
                txtNgayban.Text = dgvHoadon.Rows[row].Cells["Ngayban"].Value.ToString();
                cmbMaSP.SelectedValue = dgvHoadon.Rows[row].Cells["MaSP"].Value.ToString();
                txtDongia.Text = dgvHoadon.Rows[row].Cells["Dongia"].Value.ToString();
                txtSoluong.Text = dgvHoadon.Rows[row].Cells["Soluong"].Value.ToString();
                txtThanhtien.Text = dgvHoadon.Rows[row].Cells["Thanhtien"].Value.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string tk = txtTimkiem.Text;
            string query = @"select * from Hoadon where Ngayban like N'%" + tk + "%'";
            Ketnoi cn = new Ketnoi();
            DataSet ds = cn.Laydulieu(query, "Hoadon");
            dgvHoadon.DataSource = ds.Tables["Hoadon"];
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            cmbMaNV.SelectedValue = "";
            txtNgayban.Text = "";
            cmbMaSP.SelectedValue = "";
            txtDongia.Text = "";
            txtSoluong.Text = "";
            getdata();
        }
        
        private void btnTinh_Click(object sender, EventArgs e)
        {
            float dongia = float.Parse(txtDongia.Text);
            float soluong = float.Parse(txtSoluong.Text);
            float thanhtien = 0;
            thanhtien = dongia * soluong;
            txtThanhtien.Text = thanhtien.ToString();
            string mahd = txtMaHD.Text;
            string tt = txtThanhtien.Text;
            string query = @"update Hoadon set Thanhtien='" + tt + "' where MaHD='" + mahd + "'";
            Ketnoi cn = new Ketnoi();
            bool kq = cn.Thucthi(query);
            getdata();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text;
            string manv = cmbMaNV.SelectedValue.ToString();
            string masp = cmbMaSP.SelectedValue.ToString();
            string ngayban = txtNgayban.Text;
            string dongia = txtDongia.Text;
            string soluong = txtSoluong.Text;
            string thanhtien = txtThanhtien.Text;
            string query = 
@"insert into Hoadon values('" + mahd + "','" + manv + "','" + ngayban + "','" + masp + "','" + dongia + "','" + soluong + "','"+ thanhtien +"')";
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
            string mahd = txtMaHD.Text;
            string manv = cmbMaNV.SelectedValue.ToString();
            string ngayban = txtNgayban.Text;
            string masp = cmbMaSP.SelectedValue.ToString();
            string dongia = txtDongia.Text;
            string soluong = txtSoluong.Text;
            string query =
@"update Hoadon set MaNV='" + manv + "',Ngayban='" + ngayban + "',MaSP='" + masp + "',Dongia='" + dongia + "',Soluong='" + soluong + "' where MaHD='" + mahd + "'";
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
            string mahd = txtMaHD.Text;
            string query = @"delete from Hoadon where MaHD='" + mahd + "'";
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
