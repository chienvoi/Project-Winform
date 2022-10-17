
namespace Quan_ly_cua_hang_TH_True_Mart
{
    partial class frmHethong
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnQLSP = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnQLHD = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(65, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ CỬA HÀNG TH TRUE MART";
            // 
            // btnQLSP
            // 
            this.btnQLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSP.Location = new System.Drawing.Point(156, 196);
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Size = new System.Drawing.Size(266, 108);
            this.btnQLSP.TabIndex = 1;
            this.btnQLSP.Text = "QUẢN LÝ SẢN PHẨM";
            this.btnQLSP.UseVisualStyleBackColor = true;
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV.Location = new System.Drawing.Point(525, 196);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(260, 108);
            this.btnQLNV.TabIndex = 2;
            this.btnQLNV.Text = "QUẢN LÝ NHÂN VIÊN";
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQLHD
            // 
            this.btnQLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHD.Location = new System.Drawing.Point(360, 371);
            this.btnQLHD.Name = "btnQLHD";
            this.btnQLHD.Size = new System.Drawing.Size(249, 109);
            this.btnQLHD.TabIndex = 3;
            this.btnQLHD.Text = "QUẢN LÝ HÓA ĐƠN";
            this.btnQLHD.UseVisualStyleBackColor = true;
            this.btnQLHD.Click += new System.EventHandler(this.btnQLHD_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Red;
            this.btnDangXuat.Location = new System.Drawing.Point(732, 513);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(170, 60);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // frmHethong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 623);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnQLHD);
            this.Controls.Add(this.btnQLNV);
            this.Controls.Add(this.btnQLSP);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHethong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQLSP;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnQLHD;
        private System.Windows.Forms.Button btnDangXuat;
    }
}