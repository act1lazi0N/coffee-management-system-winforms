using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class MyDatabase
    {
        protected SqlConnection conn = new SqlConnection(Properties.Settings.Default.strConn);
    }
}
