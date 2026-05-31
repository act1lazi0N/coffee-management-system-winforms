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
    public class BUS_LoaiMon
    {
        private DAL_LoaiMon dal = new DAL_LoaiMon();

        public DataTable getTableLoaiMon()
        {
            return dal.getTableLoaiMon();
        }

        public List<LoaiMon> getDsLoaiMon()
        {
            List<LoaiMon> dsLoaiMon = new List<LoaiMon>();

            DataTable dt = dal.getTableLoaiMon();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiMon lm = new LoaiMon();

                lm.Maloai = dt.Rows[i]["maloai"].ToString();
                lm.Tenloai = dt.Rows[i]["tenloai"].ToString();
                lm.Ghichu = dt.Rows[i]["ghichu"].ToString();

                dsLoaiMon.Add(lm);
            }

            return dsLoaiMon;
        }

        public DataTable getFilter_TenLoai(string strFilter)
        {
            DataRow[] rows = dal.getTableLoaiMon().Select(strFilter);

            if (rows.Length > 0)
            {
                return rows.CopyToDataTable();
            }
            else
            {
                return dal.getTableLoaiMon().Clone();
            }
        }

        public Boolean add_New_LoaiMon(LoaiMon lm)
        {
            Boolean kq = false;

            if (Maloai_not_Exist(lm.Maloai))
            {
                DataRow r = dal.getTableLoaiMon().NewRow();

                r["maloai"] = lm.Maloai;
                r["tenloai"] = lm.Tenloai;
                r["ghichu"] = lm.Ghichu;

                dal.addRowToLoaiMon(r);

                kq = true;
            }

            return kq;
        }

        public Boolean update_LoaiMon(LoaiMon lm)
        {
            Boolean kq = false;

            if (!Maloai_not_Exist(lm.Maloai))
            {
                dal.updateRowLoaiMon(lm.Maloai, lm.Tenloai, lm.Ghichu);
                kq = true;
            }

            return kq;
        }

        public Boolean delete_LoaiMon(string maloai)
        {
            Boolean kq = false;

            if (!Maloai_not_Exist(maloai))
            {
                dal.deleteRowLoaiMon(maloai);
                kq = true;
            }

            return kq;
        }

        private Boolean Maloai_not_Exist(string maloai)
        {
            Boolean kq = true;

            DataRow[] rows = dal.getTableLoaiMon().Select("maloai='" + maloai + "'");

            if (rows.Length > 0)
            {
                kq = false;
            }

            return kq;
        }
    }
}
