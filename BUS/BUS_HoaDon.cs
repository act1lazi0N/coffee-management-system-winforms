using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HoaDon
    {
        private DAL_HoaDon dal = new DAL_HoaDon();
        private BUS_ChiTietHoaDon busCT = new BUS_ChiTietHoaDon();

        public DataTable getTableHoaDon()
        {
            return dal.getTableHoaDon();
        }

        public DataTable getTableChiTietHoaDon()
        {
            return dal.getTableChiTietHoaDon();
        }

        public DataTable getTableBan()
        {
            return dal.getTableBan();
        }

        public DataTable getTableMon()
        {
            return dal.getTableMon();
        }

        public DataTable getChiTietTheoMaHD(string mahd)
        {
            DataRow[] rows = dal.getTableChiTietHoaDon().Select("mahd='" + mahd + "'");

            if (rows.Length > 0)
            {
                return rows.CopyToDataTable();
            }
            else
            {
                return dal.getTableChiTietHoaDon().Clone();
            }
        }

        public DataTable getHoaDonTheoTuKhoa(string tukhoa)
        {
            DataRow[] rows = dal.getTableHoaDon().Select(
                "mahd LIKE '%" + tukhoa + "%' OR " +
                "maban LIKE '%" + tukhoa + "%' OR " +
                "trangthai LIKE '%" + tukhoa + "%'"
            );

            if (rows.Length > 0)
            {
                return rows.CopyToDataTable();
            }
            else
            {
                return dal.getTableHoaDon().Clone();
            }
        }

        public Boolean add_New_HoaDon(HoaDon hd)
        {
            Boolean kq = false;

            if (Mahd_not_Exist(hd.Mahd))
            {
                DataRow r = dal.getTableHoaDon().NewRow();

                r["mahd"] = hd.Mahd;
                r["maban"] = hd.Maban;
                r["ngaylap"] = hd.Ngaylap;
                r["trangthai"] = hd.Trangthai;
                r["tongtien"] = hd.Tongtien;

                dal.addRowToHoaDon(r);
                dal.updateBanTrangThai(hd.Maban, "Đang sử dụng");

                kq = true;
            }

            return kq;
        }

        public Boolean add_ChiTietHoaDon(ChiTietHoaDon ct)
        {
            Boolean kq = busCT.add_ChiTietHoaDon(ct);

            if (kq)
            {
                double tong = busCT.tinhTongTien(ct.Mahd);
                dal.updateHoaDonTongTien(ct.Mahd, tong);
            }

            return kq;
        }

        public Boolean tangSoLuong(string mahd, string mamon)
        {
            DataRow[] rows = dal.getTableChiTietHoaDon().Select(
                "mahd='" + mahd + "' AND mamon='" + mamon + "'"
            );

            if (rows.Length > 0)
            {
                int soluong = Convert.ToInt32(rows[0]["soluong"]) + 1;
                double dongia = Convert.ToDouble(rows[0]["dongia"]);
                double thanhtien = soluong * dongia;

                dal.updateChiTietHoaDon(mahd, mamon, soluong, thanhtien);
                capNhatTongTien(mahd);

                return true;
            }

            return false;
        }

        public Boolean giamSoLuong(string mahd, string mamon)
        {
            DataRow[] rows = dal.getTableChiTietHoaDon().Select(
                "mahd='" + mahd + "' AND mamon='" + mamon + "'"
            );

            if (rows.Length > 0)
            {
                int soluong = Convert.ToInt32(rows[0]["soluong"]) - 1;
                double dongia = Convert.ToDouble(rows[0]["dongia"]);

                if (soluong <= 0)
                {
                    dal.deleteChiTietHoaDon(mahd, mamon);
                }
                else
                {
                    double thanhtien = soluong * dongia;
                    dal.updateChiTietHoaDon(mahd, mamon, soluong, thanhtien);
                }

                capNhatTongTien(mahd);

                return true;
            }

            return false;
        }

        public Boolean delete_ChiTietHoaDon(string mahd, string mamon)
        {
            dal.deleteChiTietHoaDon(mahd, mamon);
            capNhatTongTien(mahd);

            return true;
        }

        public double tinhTongTien(string mahd)
        {
            double tong = 0;

            DataRow[] rows = dal.getTableChiTietHoaDon().Select("mahd='" + mahd + "'");

            foreach (DataRow r in rows)
            {
                tong += Convert.ToDouble(r["thanhtien"]);
            }

            return tong;
        }

        public void capNhatTongTien(string mahd)
        {
            double tong = tinhTongTien(mahd);
            dal.updateHoaDonTongTien(mahd, tong);
        }

        public Boolean thanhToanHoaDon(string mahd)
        {
            DataRow[] rows = dal.getTableHoaDon().Select("mahd='" + mahd + "'");

            if (rows.Length > 0)
            {
                string maban = rows[0]["maban"].ToString();

                capNhatTongTien(mahd);

                dal.updateHoaDonTrangThai(mahd, "Đã thanh toán");
                dal.updateBanTrangThai(maban, "Trống");

                return true;
            }

            return false;
        }

        public Boolean huyHoaDon(string mahd)
        {
            DataRow[] rows = dal.getTableHoaDon().Select("mahd='" + mahd + "'");

            if (rows.Length > 0)
            {
                string maban = rows[0]["maban"].ToString();

                dal.deleteHoaDon(mahd);
                dal.updateBanTrangThai(maban, "Trống");

                return true;
            }

            return false;
        }

        private Boolean Mahd_not_Exist(string mahd)
        {
            Boolean kq = true;

            DataRow[] rows = dal.getTableHoaDon().Select("mahd='" + mahd + "'");

            if (rows.Length > 0)
            {
                kq = false;
            }

            return kq;
        }

        public DataTable getChiTietHoaDonCoTenMon(string mahd)
        {
            DataTable result = new DataTable();

            result.Columns.Add("mahd");
            result.Columns.Add("mamon");
            result.Columns.Add("tenmon");
            result.Columns.Add("soluong", typeof(int));
            result.Columns.Add("dongia", typeof(double));
            result.Columns.Add("thanhtien", typeof(double));

            DataRow[] rowsCT = dal.getTableChiTietHoaDon().Select("mahd='" + mahd + "'");

            foreach (DataRow ct in rowsCT)
            {
                string mamon = ct["mamon"].ToString();

                DataRow[] rowsMon = dal.getTableMon().Select("mamon='" + mamon + "'");

                string tenmon = "";

                if (rowsMon.Length > 0)
                {
                    tenmon = rowsMon[0]["tenmon"].ToString();
                }

                DataRow r = result.NewRow();

                r["mahd"] = ct["mahd"].ToString();
                r["mamon"] = mamon;
                r["tenmon"] = tenmon;
                r["soluong"] = Convert.ToInt32(ct["soluong"]);
                r["dongia"] = Convert.ToDouble(ct["dongia"]);
                r["thanhtien"] = Convert.ToDouble(ct["thanhtien"]);

                result.Rows.Add(r);
            }

            return result;
        }
        public void reload()
        {
            dal.reloadData();
        }
    }
}
