using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_TaiKhoan : MyDatabase
    {
        private DataSet ds = null;
        private SqlDataAdapter da = null;

        public DAL_TaiKhoan()
        {
            ds = new DataSet();
            da = new SqlDataAdapter();

            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            da.SelectCommand = new SqlCommand("SELECT * FROM dbo.taikhoan", conn);
            da.TableMappings.Add("Table", "taikhoan");
            da.Fill(ds, "taikhoan");
        }

        public DataTable getTableTaiKhoan()
        {
            return ds.Tables["taikhoan"];
        }

        public TaiKhoan getTaiKhoan(string tendangnhap, string matkhau)
        {
            TaiKhoan tk = null;

            try
            {
                string filter =
                    "tendangnhap='" + tendangnhap.Replace("'", "''") + "' AND " +
                    "matkhau='" + matkhau.Replace("'", "''") + "' AND " +
                    "trangthai=True";

                DataRow[] rows = ds.Tables["taikhoan"].Select(filter);

                if (rows.Length > 0)
                {
                    tk = new TaiKhoan();

                    tk.Tendangnhap = rows[0]["tendangnhap"].ToString();
                    tk.Matkhau = rows[0]["matkhau"].ToString();
                    tk.Hoten = rows[0]["hoten"].ToString();
                    tk.Vaitro = rows[0]["vaitro"].ToString();
                    tk.Trangthai = Convert.ToBoolean(rows[0]["trangthai"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message);
            }

            return tk;
        }
    }
}
