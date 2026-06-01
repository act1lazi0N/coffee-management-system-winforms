using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string _tendangnhap;
        private string _matkhau;
        private string _hoten;
        private string _vaitro;
        private bool _trangthai;

        public string Tendangnhap
        {
            get { return _tendangnhap; }
            set { _tendangnhap = value; }
        }

        public string Matkhau
        {
            get { return _matkhau; }
            set { _matkhau = value; }
        }

        public string Hoten
        {
            get { return _hoten; }
            set { _hoten = value; }
        }

        public string Vaitro
        {
            get { return _vaitro; }
            set { _vaitro = value; }
        }

        public bool Trangthai
        {
            get { return _trangthai; }
            set { _trangthai = value; }
        }
    }
}
