using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoaiMon : MyDatabase
    {
        private DataSet ds = null;
        private SqlDataAdapter da = null;

        public DAL_LoaiMon()
        {
            ds = new DataSet();
            da = new SqlDataAdapter();

            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            da.SelectCommand = new SqlCommand("SELECT * FROM loaimon", conn);
            da.TableMappings.Add("Table", "loaimon");
            da.Fill(ds, "loaimon");
        }

        public DataSet getDataset()
        {
            return ds;
        }

        public DataTable getTableLoaiMon()
        {
            return ds.Tables["loaimon"];
        }

        public void addRowToLoaiMon(DataRow r)
        {
            try
            {
                ds.Tables["loaimon"].Rows.Add(r);
                da.Update(ds, "loaimon");
                ds.AcceptChanges();
            }
            catch
            {
            }
        }

        public void updateRowLoaiMon(string maloai, string tenloai, string ghichu)
        {
            try
            {
                DataRow[] rows = ds.Tables["loaimon"].Select("maloai='" + maloai + "'");

                if (rows.Length > 0)
                {
                    rows[0]["tenloai"] = tenloai;
                    rows[0]["ghichu"] = ghichu;

                    da.Update(ds, "loaimon");
                    ds.AcceptChanges();
                }
            }
            catch
            {
            }
        }

        public void deleteRowLoaiMon(string maloai)
        {
            try
            {
                DataRow[] rows = ds.Tables["loaimon"].Select("maloai='" + maloai + "'");

                if (rows.Length > 0)
                {
                    rows[0].Delete();

                    da.Update(ds, "loaimon");
                    ds.AcceptChanges();
                }
            }
            catch
            {
            }
        }
    }
}
