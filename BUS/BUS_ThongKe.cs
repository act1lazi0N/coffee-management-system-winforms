using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ThongKe
    {
        private DAL_ThongKe dal = new DAL_ThongKe();

        public void reload()
        {
            dal.loadData();
        }

        public DataTable getHoaDonTheoDieuKien(DateTime tuNgay, DateTime denNgay, string trangthai)
        {
            DataTable source = dal.getTableHoaDon();
            DataTable result = source.Clone();

            foreach (DataRow r in source.Rows)
            {
                DateTime ngaylap = Convert.ToDateTime(r["ngaylap"]);

                bool hopLeNgay = ngaylap.Date >= tuNgay.Date && ngaylap.Date <= denNgay.Date;
                bool hopLeTrangThai = trangthai == "Tất cả" || r["trangthai"].ToString() == trangthai;

                if (hopLeNgay && hopLeTrangThai)
                {
                    result.ImportRow(r);
                }
            }

            return result;
        }

        public int getTongHoaDon(DateTime tuNgay, DateTime denNgay, string trangthai)
        {
            return getHoaDonTheoDieuKien(tuNgay, denNgay, trangthai).Rows.Count;
        }

        public double getTongDoanhThu(DateTime tuNgay, DateTime denNgay, string trangthai)
        {
            double tong = 0;
            DataTable dt = getHoaDonTheoDieuKien(tuNgay, denNgay, trangthai);

            foreach (DataRow r in dt.Rows)
            {
                tong += Convert.ToDouble(r["tongtien"]);
            }

            return tong;
        }

        public int getSoHoaDonTheoTrangThai(DateTime tuNgay, DateTime denNgay, string trangthaiCanDem)
        {
            return getHoaDonTheoDieuKien(tuNgay, denNgay, trangthaiCanDem).Rows.Count;
        }

        public DataTable getDoanhThuTheoNgay(DateTime tuNgay, DateTime denNgay, string trangthai)
        {
            DataTable result = new DataTable();

            result.Columns.Add("ngay", typeof(string));
            result.Columns.Add("sohoadon", typeof(int));
            result.Columns.Add("doanhthu", typeof(double));

            DataTable hd = getHoaDonTheoDieuKien(tuNgay, denNgay, trangthai);

            DateTime d = tuNgay.Date;

            while (d <= denNgay.Date)
            {
                int soHD = 0;
                double doanhthu = 0;

                foreach (DataRow r in hd.Rows)
                {
                    DateTime ngaylap = Convert.ToDateTime(r["ngaylap"]);

                    if (ngaylap.Date == d.Date)
                    {
                        soHD++;
                        doanhthu += Convert.ToDouble(r["tongtien"]);
                    }
                }

                DataRow row = result.NewRow();
                row["ngay"] = d.ToString("dd/MM/yyyy");
                row["sohoadon"] = soHD;
                row["doanhthu"] = doanhthu;

                result.Rows.Add(row);

                d = d.AddDays(1);
            }

            return result;
        }

        public DataTable getDoanhThuTheoBan(DateTime tuNgay, DateTime denNgay, string trangthai)
        {
            DataTable result = new DataTable();

            result.Columns.Add("maban", typeof(string));
            result.Columns.Add("tenban", typeof(string));
            result.Columns.Add("sohoadon", typeof(int));
            result.Columns.Add("doanhthu", typeof(double));

            DataTable hd = getHoaDonTheoDieuKien(tuNgay, denNgay, trangthai);
            DataTable ban = dal.getTableBan();

            foreach (DataRow b in ban.Rows)
            {
                string maban = b["maban"].ToString();
                string tenban = b["tenban"].ToString();

                int soHD = 0;
                double doanhthu = 0;

                foreach (DataRow r in hd.Rows)
                {
                    if (r["maban"].ToString() == maban)
                    {
                        soHD++;
                        doanhthu += Convert.ToDouble(r["tongtien"]);
                    }
                }

                if (soHD > 0)
                {
                    DataRow row = result.NewRow();

                    row["maban"] = maban;
                    row["tenban"] = tenban;
                    row["sohoadon"] = soHD;
                    row["doanhthu"] = doanhthu;

                    result.Rows.Add(row);
                }
            }

            return result;
        }

        public DataTable getMonBanChay(DateTime tuNgay, DateTime denNgay, string trangthai)
        {
            DataTable result = new DataTable();

            result.Columns.Add("mamon", typeof(string));
            result.Columns.Add("tenmon", typeof(string));
            result.Columns.Add("soluongban", typeof(int));
            result.Columns.Add("doanhthu", typeof(double));

            DataTable hd = getHoaDonTheoDieuKien(tuNgay, denNgay, trangthai);
            DataTable ct = dal.getTableChiTietHoaDon();
            DataTable mon = dal.getTableMon();

            foreach (DataRow m in mon.Rows)
            {
                string mamon = m["mamon"].ToString();
                string tenmon = m["tenmon"].ToString();

                int soluongban = 0;
                double doanhthu = 0;

                foreach (DataRow h in hd.Rows)
                {
                    string mahd = h["mahd"].ToString();

                    foreach (DataRow c in ct.Rows)
                    {
                        if (c["mahd"].ToString() == mahd && c["mamon"].ToString() == mamon)
                        {
                            soluongban += Convert.ToInt32(c["soluong"]);
                            doanhthu += Convert.ToDouble(c["thanhtien"]);
                        }
                    }
                }

                if (soluongban > 0)
                {
                    DataRow row = result.NewRow();

                    row["mamon"] = mamon;
                    row["tenmon"] = tenmon;
                    row["soluongban"] = soluongban;
                    row["doanhthu"] = doanhthu;

                    result.Rows.Add(row);
                }
            }

            return result;
        }
    }
}

