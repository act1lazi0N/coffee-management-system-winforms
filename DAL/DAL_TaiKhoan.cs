using DTO;
using System;
using System.Data;
using System.Data.SqlClient;
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

        public void reloadData()
        {
            ds.Tables["taikhoan"].Clear();
            da.Fill(ds, "taikhoan");
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

        public void addRowToTaiKhoan(DataRow r)
        {
            try
            {
                ds.Tables["taikhoan"].Rows.Add(r);
                da.Update(ds, "taikhoan");
                ds.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm tài khoản: " + ex.Message);
            }
        }

        public void updateRowTaiKhoan(string tendangnhap, string matkhau, string hoten, string vaitro, bool trangthai)
        {
            try
            {
                DataRow[] rows = ds.Tables["taikhoan"].Select(
                    "tendangnhap='" + tendangnhap.Replace("'", "''") + "'"
                );

                if (rows.Length > 0)
                {
                    rows[0]["matkhau"] = matkhau;
                    rows[0]["hoten"] = hoten;
                    rows[0]["vaitro"] = vaitro;
                    rows[0]["trangthai"] = trangthai;

                    da.Update(ds, "taikhoan");
                    ds.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa tài khoản: " + ex.Message);
            }
        }

        public void deleteRowTaiKhoan(string tendangnhap)
        {
            try
            {
                DataRow[] rows = ds.Tables["taikhoan"].Select(
                    "tendangnhap='" + tendangnhap.Replace("'", "''") + "'"
                );

                if (rows.Length > 0)
                {
                    rows[0].Delete();

                    da.Update(ds, "taikhoan");
                    ds.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa tài khoản: " + ex.Message);
            }
        }
    }
}