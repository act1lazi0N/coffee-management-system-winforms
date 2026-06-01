using DAL;
using DTO;
using System;
using System.Data;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        private DAL_TaiKhoan dal = new DAL_TaiKhoan();

        public TaiKhoan dangNhap(string tendangnhap, string matkhau)
        {
            if (tendangnhap.Trim() == "" || matkhau.Trim() == "")
            {
                return null;
            }

            return dal.getTaiKhoan(tendangnhap.Trim(), matkhau.Trim());
        }

        public DataTable getTableTaiKhoan()
        {
            return dal.getTableTaiKhoan();
        }

        public void reload()
        {
            dal.reloadData();
        }

        public DataTable searchTaiKhoan(string tukhoa)
        {
            tukhoa = tukhoa.Replace("'", "''");

            DataRow[] rows = dal.getTableTaiKhoan().Select(
                "tendangnhap LIKE '%" + tukhoa + "%' OR " +
                "hoten LIKE '%" + tukhoa + "%' OR " +
                "vaitro LIKE '%" + tukhoa + "%'"
            );

            if (rows.Length > 0)
            {
                return rows.CopyToDataTable();
            }

            return dal.getTableTaiKhoan().Clone();
        }

        public Boolean add_New_TaiKhoan(TaiKhoan tk)
        {
            if (!TaiKhoan_Not_Exist(tk.Tendangnhap))
            {
                return false;
            }

            DataRow r = dal.getTableTaiKhoan().NewRow();

            r["tendangnhap"] = tk.Tendangnhap;
            r["matkhau"] = tk.Matkhau;
            r["hoten"] = tk.Hoten;
            r["vaitro"] = tk.Vaitro;
            r["trangthai"] = tk.Trangthai;

            dal.addRowToTaiKhoan(r);

            return true;
        }

        public Boolean update_TaiKhoan(TaiKhoan tk)
        {
            if (TaiKhoan_Not_Exist(tk.Tendangnhap))
            {
                return false;
            }

            dal.updateRowTaiKhoan(
                tk.Tendangnhap,
                tk.Matkhau,
                tk.Hoten,
                tk.Vaitro,
                tk.Trangthai
            );

            return true;
        }

        public Boolean delete_TaiKhoan(string tendangnhap)
        {
            if (TaiKhoan_Not_Exist(tendangnhap))
            {
                return false;
            }

            dal.deleteRowTaiKhoan(tendangnhap);

            return true;
        }

        private Boolean TaiKhoan_Not_Exist(string tendangnhap)
        {
            DataRow[] rows = dal.getTableTaiKhoan().Select(
                "tendangnhap='" + tendangnhap.Replace("'", "''") + "'"
            );

            return rows.Length == 0;
        }
    }
}