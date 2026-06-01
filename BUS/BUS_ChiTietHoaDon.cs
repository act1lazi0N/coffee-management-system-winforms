using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChiTietHoaDon
    {
        private DAL_ChiTietHoaDon dal = new DAL_ChiTietHoaDon();

        public DataTable getTableChiTietHoaDon()
        {
            return dal.getTableChiTietHoaDon();
        }

        public DataTable getChiTietTheoMaHD(string mahd)
        {
            return dal.getChiTietTheoMaHD(mahd);
        }

        public Boolean add_ChiTietHoaDon(ChiTietHoaDon ct)
        {
            Boolean kq = false;

            DataRow[] rows = dal.getTableChiTietHoaDon().Select(
                "mahd='" + ct.Mahd + "' AND mamon='" + ct.Mamon + "'"
            );

            if (rows.Length > 0)
            {
                int soluongCu = Convert.ToInt32(rows[0]["soluong"]);
                double dongia = Convert.ToDouble(rows[0]["dongia"]);

                int soluongMoi = soluongCu + ct.Soluong;
                double thanhtienMoi = soluongMoi * dongia;

                dal.updateRowChiTietHoaDon(
                    ct.Mahd,
                    ct.Mamon,
                    soluongMoi,
                    thanhtienMoi
                );

                kq = true;
            }
            else
            {
                DataRow r = dal.getTableChiTietHoaDon().NewRow();

                r["mahd"] = ct.Mahd;
                r["mamon"] = ct.Mamon;
                r["soluong"] = ct.Soluong;
                r["dongia"] = ct.Dongia;
                r["thanhtien"] = ct.Thanhtien;

                dal.addRowToChiTietHoaDon(r);

                kq = true;
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

                dal.updateRowChiTietHoaDon(mahd, mamon, soluong, thanhtien);

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
                    dal.deleteRowChiTietHoaDon(mahd, mamon);
                }
                else
                {
                    double thanhtien = soluong * dongia;
                    dal.updateRowChiTietHoaDon(mahd, mamon, soluong, thanhtien);
                }

                return true;
            }

            return false;
        }

        public Boolean delete_ChiTietHoaDon(string mahd, string mamon)
        {
            dal.deleteRowChiTietHoaDon(mahd, mamon);
            return true;
        }

        public Boolean delete_All_By_MaHD(string mahd)
        {
            dal.deleteAllChiTietByMaHD(mahd);
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
    }
}
