using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Quan_ly_cua_hang_TH_True_Mart
{
    class Ketnoi
    {
        private string con_str = "";
        private SqlConnection conn = null;
        public Ketnoi()
        {
            con_str = @"Data Source=DESKTOP-JF78K98\SQLEXPRESS;Initial Catalog=QL TH True Mart;Integrated Security=True";
            conn = new SqlConnection(con_str);
        }
        public bool Thucthi(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataSet Laydulieu(string sql, string table_name)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, table_name);
            }
            catch
            {

            }
            return ds;
        }
    }
}
