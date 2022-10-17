
namespace Quan_ly_cua_hang_TH_True_Mart
{
    partial class frmQLSP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvSanpham = new System.Windows.Forms.DataGridView();
            this.txtSoSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNgaynhap = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSLBan = new System.Windows.Forms.TextBox();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(777, 45);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 40);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCapnhat);
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnLamMoi);
            this.groupBox3.Location = new System.Drawing.Point(9, 597);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(1083, 112);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(576, 45);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(165, 40);
            this.btnCapnhat.TabIndex = 5;
            this.btnCapnhat.Text = "Cập nhật số lượng";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(433, 45);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 40);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(292, 45);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 40);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(156, 45);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 40);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(27, 45);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(107, 40);
            this.btnLamMoi.TabIndex = 0;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // dgvSanpham
            // 
            this.dgvSanpham.AllowUserToAddRows = false;
            this.dgvSanpham.AllowUserToDeleteRows = false;
            this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.MaLoai,
            this.Ngaynhap,
            this.SoSP,
            this.Giaban});
            this.dgvSanpham.Location = new System.Drawing.Point(8, 89);
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.ReadOnly = true;
            this.dgvSanpham.RowHeadersWidth = 51;
            this.dgvSanpham.RowTemplate.Height = 24;
            this.dgvSanpham.Size = new System.Drawing.Size(1075, 451);
            this.dgvSanpham.TabIndex = 5;
            this.dgvSanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanpham_CellClick);
            // 
            // txtSoSP
            // 
            this.txtSoSP.Location = new System.Drawing.Point(173, 237);
            this.txtSoSP.Name = "txtSoSP";
            this.txtSoSP.Size = new System.Drawing.Size(226, 22);
            this.txtSoSP.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Số sản phẩm:";
            // 
            // txtNgaynhap
            // 
            this.txtNgaynhap.Location = new System.Drawing.Point(173, 186);
            this.txtNgaynhap.Name = "txtNgaynhap";
            this.txtNgaynhap.Size = new System.Drawing.Size(226, 22);
            this.txtNgaynhap.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSanpham);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.txtTimkiem);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(442, 39);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(1094, 548);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(582, 26);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(107, 40);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(178, 35);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(351, 22);
            this.txtTimkiem.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên sản phẩm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày nhập:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHienthi);
            this.groupBox1.Controls.Add(this.txtSLBan);
            this.groupBox1.Controls.Add(this.cmbLoai);
            this.groupBox1.Controls.Add(this.txtGiaban);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoSP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNgaynhap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(423, 548);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cmbLoai
            // 
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Location = new System.Drawing.Point(173, 141);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(226, 24);
            this.cmbLoai.TabIndex = 18;
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(173, 291);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(226, 22);
            this.txtGiaban.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Giá bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã loại:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(173, 89);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(226, 22);
            this.txtTenSP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(173, 47);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(226, 22);
            this.txtMaSP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tổng số đã bán:";
            // 
            // txtSLBan
            // 
            this.txtSLBan.Enabled = false;
            this.txtSLBan.Location = new System.Drawing.Point(173, 345);
            this.txtSLBan.Name = "txtSLBan";
            this.txtSLBan.Size = new System.Drawing.Size(226, 22);
            this.txtSLBan.TabIndex = 20;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 125;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 125;
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Mã loại";
            this.MaLoai.MinimumWidth = 6;
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.ReadOnly = true;
            this.MaLoai.Width = 125;
            // 
            // Ngaynhap
            // 
            this.Ngaynhap.DataPropertyName = "Ngaynhap";
            this.Ngaynhap.HeaderText = "Ngày nhập";
            this.Ngaynhap.MinimumWidth = 6;
            this.Ngaynhap.Name = "Ngaynhap";
            this.Ngaynhap.ReadOnly = true;
            this.Ngaynhap.Width = 125;
            // 
            // SoSP
            // 
            this.SoSP.DataPropertyName = "SoSP";
            this.SoSP.HeaderText = "Số sản phẩm";
            this.SoSP.MinimumWidth = 6;
            this.SoSP.Name = "SoSP";
            this.SoSP.ReadOnly = true;
            this.SoSP.Width = 125;
            // 
            // Giaban
            // 
            this.Giaban.DataPropertyName = "Giaban";
            this.Giaban.HeaderText = "Giá bán";
            this.Giaban.MinimumWidth = 6;
            this.Giaban.Name = "Giaban";
            this.Giaban.ReadOnly = true;
            this.Giaban.Width = 125;
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(229, 403);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(107, 40);
            this.btnHienthi.TabIndex = 6;
            this.btnHienthi.Text = "Hiển thị";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // frmQLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 749);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQLSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SẢN PHẨM";
            this.Load += new System.EventHandler(this.frmQLSP_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvSanpham;
        private System.Windows.Forms.TextBox txtSoSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNgaynhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.TextBox txtSLBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giaban;
        private System.Windows.Forms.Button btnHienthi;
    }
}