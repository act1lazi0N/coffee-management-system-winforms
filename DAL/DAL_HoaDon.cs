using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDon : MyDatabase
    {
        private DataSet ds = null;

        private SqlDataAdapter daHoaDon = null;
        private SqlDataAdapter daChiTiet = null;
        private SqlDataAdapter daBan = null;
        private SqlDataAdapter daMon = null;

        public DAL_HoaDon()
        {
            ds = new DataSet();

            daHoaDon = new SqlDataAdapter();
            daChiTiet = new SqlDataAdapter();
            daBan = new SqlDataAdapter();
            daMon = new SqlDataAdapter();

            SqlCommandBuilder cbHoaDon = new SqlCommandBuilder(daHoaDon);
            SqlCommandBuilder cbChiTiet = new SqlCommandBuilder(daChiTiet);
            SqlCommandBuilder cbBan = new SqlCommandBuilder(daBan);
            SqlCommandBuilder cbMon = new SqlCommandBuilder(daMon);

            daHoaDon.SelectCommand = new SqlCommand("SELECT * FROM hoadon", conn);
            daHoaDon.TableMappings.Add("Table", "hoadon");
            daHoaDon.Fill(ds, "hoadon");

            daChiTiet.SelectCommand = new SqlCommand("SELECT * FROM chitiethoadon", conn);
            daChiTiet.TableMappings.Add("Table", "chitiethoadon");
            daChiTiet.Fill(ds, "chitiethoadon");

            daBan.SelectCommand = new SqlCommand("SELECT * FROM ban", conn);
            daBan.TableMappings.Add("Table", "ban");
            daBan.Fill(ds, "ban");

            daMon.SelectCommand = new SqlCommand("SELECT * FROM mon", conn);
            daMon.TableMappings.Add("Table", "mon");
            daMon.Fill(ds, "mon");
        }

        public DataSet getDataset()
        {
            return ds;
        }

        public DataTable getTableHoaDon()
        {
            return ds.Tables["hoadon"];
        }

        public DataTable getTableChiTietHoaDon()
        {
            return ds.Tables["chitiethoadon"];
        }

        public DataTable getTableBan()
        {
            return ds.Tables["ban"];
        }

        public DataTable getTableMon()
        {
            return ds.Tables["mon"];
        }

        public void addRowToHoaDon(DataRow r)
        {
            try
            {
                ds.Tables["hoadon"].Rows.Add(r);
                daHoaDon.Update(ds, "hoadon");
                ds.AcceptChanges();
            }
            catch
            {
            }
        }

        public void addRowToChiTietHoaDon(DataRow r)
        {
            try
            {
                ds.Tables["chitiethoadon"].Rows.Add(r);
                daChiTiet.Update(ds, "chitiethoadon");
                ds.AcceptChanges();
            }
            catch
            {
            }
        }

        public void updateHoaDonTongTien(string mahd, double tongtien)
        {
            try
            {
                DataRow[] rows = ds.Tables["hoadon"].Select("mahd='" + mahd + "'");

                if (rows.Length > 0)
                {
                    rows[0]["tongtien"] = tongtien;

                    daHoaDon.Update(ds, "hoadon");
                    ds.AcceptChanges();
                }
            }
            catch
            {
            }
        }

        public void updateHoaDonTrangThai(string mahd, string trangthai)
        {
            try
            {
                DataRow[] rows = ds.Tables["hoadon"].Select("mahd='" + mahd + "'");

                if (rows.Length > 0)
                {
                    rows[0]["trangthai"] = trangthai;

                    daHoaDon.Update(ds, "hoadon");
                    ds.AcceptChanges();
                }
            }
            catch
            {
            }
        }

        public void updateBanTrangThai(string maban, string trangthai)
        {
            try
            {
                DataRow[] rows = ds.Tables["ban"].Select("maban='" + maban + "'");

                if (rows.Length > 0)
                {
                    rows[0]["trangthai"] = trangthai;

                    daBan.Update(ds, "ban");
                    ds.AcceptChanges();
                }
            }
            catch
            {
            }
        }

        public void updateChiTietHoaDon(string mahd, string mamon, int soluong, double thanhtien)
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

                    daChiTiet.Update(ds, "chitiethoadon");
                    ds.AcceptChanges();
                }
            }
            catch
            {
            }
        }

        public void deleteChiTietHoaDon(string mahd, string mamon)
        {
            try
            {
                DataRow[] rows = ds.Tables["chitiethoadon"].Select(
                    "mahd='" + mahd + "' AND mamon='" + mamon + "'"
                );

                if (rows.Length > 0)
                {
                    rows[0].Delete();

                    daChiTiet.Update(ds, "chitiethoadon");
                    ds.AcceptChanges();
                }
            }
            catch
            {
            }
        }

        public void deleteHoaDon(string mahd)
        {
            try
            {
                DataRow[] rowsCT = ds.Tables["chitiethoadon"].Select("mahd='" + mahd + "'");

                foreach (DataRow r in rowsCT)
                {
                    r.Delete();
                }

                daChiTiet.Update(ds, "chitiethoadon");

                DataRow[] rowsHD = ds.Tables["hoadon"].Select("mahd='" + mahd + "'");

                if (rowsHD.Length > 0)
                {
                    rowsHD[0].Delete();
                    daHoaDon.Update(ds, "hoadon");
                }

                ds.AcceptChanges();
            }
            catch
            {
            }
        }
    }
}
