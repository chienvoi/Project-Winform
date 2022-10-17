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
    public partial class frmHethong : Form
    {
        public frmHethong()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            frmQLSP frm = new frmQLSP();
            frm.Show();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            frmMaQLNV frm = new frmMaQLNV();
            frm.Show();
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            frmQLHD frm = new frmQLHD();
            frm.Show();
        }
    }
}
