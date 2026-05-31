using DAL;
using DTO;
using System;
using System.Data;

namespace BUS
{
    public class BUS_Ban
    {
        private DAL_Ban dal = new DAL_Ban();

        public DataTable getTableBan()
        {
            return dal.getTableBan();
        }

        public DataTable getFilter_TenBan(string strFilter)
        {
            DataRow[] rows = dal.getTableBan().Select(strFilter);

            if (rows.Length > 0)
            {
                return rows.CopyToDataTable();
            }
            else
            {
                return dal.getTableBan().Clone();
            }
        }

        public Boolean add_New_Ban(Ban b)
        {
            Boolean kq = false;

            if (Maban_not_Exist(b.Maban))
            {
                DataRow r = dal.getTableBan().NewRow();

                r["maban"] = b.Maban;
                r["tenban"] = b.Tenban;
                r["khuvuc"] = b.Khuvuc;
                r["trangthai"] = b.Trangthai;

                dal.addRowToBan(r);

                kq = true;
            }

            return kq;
        }

        public Boolean update_Ban(Ban b)
        {
            Boolean kq = false;

            if (!Maban_not_Exist(b.Maban))
            {
                dal.updateRowBan(
                    b.Maban,
                    b.Tenban,
                    b.Khuvuc,
                    b.Trangthai
                );

                kq = true;
            }

            return kq;
        }

        public Boolean delete_Ban(string maban)
        {
            Boolean kq = false;

            if (!Maban_not_Exist(maban))
            {
                dal.deleteRowBan(maban);
                kq = true;
            }

            return kq;
        }

        private Boolean Maban_not_Exist(string maban)
        {
            Boolean kq = true;

            DataRow[] rows = dal.getTableBan().Select("maban='" + maban + "'");

            if (rows.Length > 0)
            {
                kq = false;
            }

            return kq;
        }
    }
}