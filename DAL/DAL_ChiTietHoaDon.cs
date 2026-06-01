using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietHoaDon : MyDatabase
    {
        private DataSet ds = null;
        private SqlDataAdapter da = null;

        public DAL_ChiTietHoaDon()
        {
            ds = new DataSet();
            da = new SqlDataAdapter();

            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            da.SelectCommand = new SqlCommand("SELECT * FROM dbo.chitiethoadon", conn);
            da.TableMappings.Add("Table", "chitiethoadon");
            da.Fill(ds, "chitiethoadon");
        }

        public DataSet getDataset()
        {
            return ds;
        }

        public DataTable getTableChiTietHoaDon()
        {
            return ds.Tables["chitiethoadon"];
        }

        public DataTable getChiTietTheoMaHD(string mahd)
        {
            DataRow[] rows = ds.Tables["chitiethoadon"].Select("mahd='" + mahd + "'");

            if (rows.Length > 0)
            {
                return rows.CopyToDataTable();
            }
            else
            {
                return ds.Tables["chitiethoadon"].Clone();
            }
        }

        public void addRowToChiTietHoaDon(DataRow r)
        {
            try
            {
                ds.Tables["chitiethoadon"].Rows.Add(r);
                da.Update(ds, "chitiethoadon");
                ds.AcceptChanges();
            }
            catch
            {
            }
        }

        public void updateRowChiTietHoaDon(string mahd, string mamon, int soluong, double thanhtien)
        {
            try
            {
                DataRow[] rows = ds.Tables["chitiethoadon"].Select(
                    "mahd='" + mahd + "' AND mamon='" + mamon + "'"
                );

                if (rows.Length > 0)
                {
                    rows[0]["soluong"] = soluong;
                    rows[0]["thanhtien"] = thanhtien;

                    da.Update(ds, "chitiethoadon");
                    ds.AcceptChanges();
                }
            }
            catch
            {
            }
        }

        public void deleteRowChiTietHoaDon(string mahd, string mamon)
        {
            try
            {
                DataRow[] rows = ds.Tables["chitiethoadon"].Select(
                    "mahd='" + mahd + "' AND mamon='" + mamon + "'"
                );

                if (rows.Length > 0)
                {
                    rows[0].Delete();

                    da.Update(ds, "chitiethoadon");
                    ds.AcceptChanges();
                }
            }
            catch
            {
            }
        }

        public void deleteAllChiTietByMaHD(string mahd)
        {
            try
            {
                DataRow[] rows = ds.Tables["chitiethoadon"].Select("mahd='" + mahd + "'");

                foreach (DataRow r in rows)
                {
                    r.Delete();
                }

                da.Update(ds, "chitiethoadon");
                ds.AcceptChanges();
            }
            catch
            {
            }
        }
    }
}
