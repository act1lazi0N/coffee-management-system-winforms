using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Mon : MyDatabase
    {
        private DataSet ds = null;
        private SqlDataAdapter da = null;

        public DAL_Mon()
        {
            ds = new DataSet();
            da = new SqlDataAdapter();

            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            da.SelectCommand = new SqlCommand(@"SELECT * FROM mon",conn);
            da.TableMappings.Add("Table", "mon");
            da.Fill(ds, "mon");
        }

        public DataSet getDataset()
        {
            return ds;
        }

        public DataTable getTableMon()
        {
            return ds.Tables["mon"];
        }

        public void addRowToMon(DataRow r)
        {
            try
            {
                ds.Tables["mon"].Rows.Add(r);
                da.Update(ds, "mon");
                ds.AcceptChanges();
            }
            catch
            {
            }
        }

        public void updateRowMon(string mamon, string tenmon, double dongia, string maloai, string trangthai)
        {
            try
            {
                DataRow[] rows = ds.Tables["mon"].Select("mamon='" + mamon + "'");

                if (rows.Length > 0)
                {
                    rows[0]["tenmon"] = tenmon;
                    rows[0]["dongia"] = dongia;
                    rows[0]["maloai"] = maloai;
                    rows[0]["trangthai"] = trangthai;

                    da.Update(ds, "mon");
                    ds.AcceptChanges();
                }
            }
            catch
            {
            }
        }

        public void deleteRowMon(string mamon)
        {
            try
            {
                DataRow[] rows = ds.Tables["mon"].Select("mamon='" + mamon + "'");

                if (rows.Length > 0)
                {
                    rows[0].Delete();

                    da.Update(ds, "mon");
                    ds.AcceptChanges();
                }
            }
            catch
            {
            }
        }
    }
}
