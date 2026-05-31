using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ThongKe : MyDatabase
    {
        private DataSet ds = null;

        private SqlDataAdapter daHoaDon = null;
        private SqlDataAdapter daChiTiet = null;
        private SqlDataAdapter daMon = null;
        private SqlDataAdapter daBan = null;

        public DAL_ThongKe()
        {
            loadData();
        }

        public void loadData()
        {
            ds = new DataSet();

            daHoaDon = new SqlDataAdapter("SELECT * FROM hoadon", conn);
            daChiTiet = new SqlDataAdapter("SELECT * FROM chitiethoadon", conn);
            daMon = new SqlDataAdapter("SELECT * FROM mon", conn);
            daBan = new SqlDataAdapter("SELECT * FROM ban", conn);

            daHoaDon.Fill(ds, "hoadon");
            daChiTiet.Fill(ds, "chitiethoadon");
            daMon.Fill(ds, "mon");
            daBan.Fill(ds, "ban");
        }

        public DataTable getTableHoaDon()
        {
            return ds.Tables["hoadon"];
        }

        public DataTable getTableChiTietHoaDon()
        {
            return ds.Tables["chitiethoadon"];
        }

        public DataTable getTableMon()
        {
            return ds.Tables["mon"];
        }

        public DataTable getTableBan()
        {
            return ds.Tables["ban"];
        }
    }
}
