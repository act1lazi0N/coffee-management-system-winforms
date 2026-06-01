using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
