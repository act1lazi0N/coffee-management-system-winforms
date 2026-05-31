using DAL;
using DTO;
using System;
using System.Data;

namespace BUS
{
    public class BUS_Mon
    {
        private DAL_Mon dal = new DAL_Mon();

        public DataTable getTableMon()
        {
            return dal.getTableMon();
        }

        public DataTable getFilter_TenMon(string strFilter)
        {
            DataRow[] rows = dal.getTableMon().Select(strFilter);

            if (rows.Length > 0)
            {
                return rows.CopyToDataTable();
            }
            else
            {
                return dal.getTableMon().Clone();
            }
        }

        public Boolean add_New_Mon(Mon m)
        {
            Boolean kq = false;

            if (Mamon_not_Exist(m.Mamon))
            {
                DataRow r = dal.getTableMon().NewRow();

                r["mamon"] = m.Mamon;
                r["tenmon"] = m.Tenmon;
                r["dongia"] = m.Dongia;
                r["maloai"] = m.Maloai;
                r["trangthai"] = m.Trangthai;

                dal.addRowToMon(r);

                kq = true;
            }

            return kq;
        }

        public Boolean update_Mon(Mon m)
        {
            Boolean kq = false;

            if (!Mamon_not_Exist(m.Mamon))
            {
                dal.updateRowMon(
                    m.Mamon,
                    m.Tenmon,
                    m.Dongia,
                    m.Maloai,
                    m.Trangthai
                );

                kq = true;
            }

            return kq;
        }

        public Boolean delete_Mon(string mamon)
        {
            Boolean kq = false;

            if (!Mamon_not_Exist(mamon))
            {
                dal.deleteRowMon(mamon);
                kq = true;
            }

            return kq;
        }

        private Boolean Mamon_not_Exist(string mamon)
        {
            Boolean kq = true;

            DataRow[] rows = dal.getTableMon().Select("mamon='" + mamon + "'");

            if (rows.Length > 0)
            {
                kq = false;
            }

            return kq;
        }
    }
}