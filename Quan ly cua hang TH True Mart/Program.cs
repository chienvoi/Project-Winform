using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_cua_hang_TH_True_Mart
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangnhap());
            //Application.Run(new frmHethong());
            //Application.Run(new frmQLNV());
            //Application.Run(new frmQLSP());
            //Application.Run(new frmQLHD());
        }
    }
}
