using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Ban : MyDatabase
    {
        private DataSet ds = null;
        private SqlDataAdapter da = null;

        public DAL_Ban()
        {
            ds = new DataSet();
            da = new SqlDataAdapter();

            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            da.SelectCommand = new SqlCommand("SELECT * FROM dbo.ban", conn);
            da.TableMappings.Add("Table", "ban");
            da.Fill(ds, "ban");
        }

        public DataSet getDataset()
        {
            return ds;
        }

        public DataTable getTableBan()
        {
            return ds.Tables["ban"];
        }

        public void addRowToBan(DataRow r)
        {
            try
            {
                ds.Tables["ban"].Rows.Add(r);
                da.Update(ds, "ban");
                ds.AcceptChanges();
            }
            catch
            {
            }
        }

        public void updateRowBan(string maban, string tenban, string khuvuc, string trangthai)
        {
            try
            {
                DataRow[] rows = ds.Tables["ban"].Select("maban='" + maban + "'");

                if (rows.Length > 0)
                {
                    rows[0]["tenban"] = tenban;
                    rows[0]["khuvuc"] = khuvuc;
                    rows[0]["trangthai"] = trangthai;

                    da.Update(ds, "ban");
                    ds.AcceptChanges();
                }
            }
            catch
            {
            }
        }

        public void deleteRowBan(string maban)
        {
            try
            {
                DataRow[] rows = ds.Tables["ban"].Select("maban='" + maban + "'");

                if (rows.Length > 0)
                {
                    rows[0].Delete();

                    da.Update(ds, "ban");
                    ds.AcceptChanges();
                }
            }
            catch
            {
            }
        }
    }
}
