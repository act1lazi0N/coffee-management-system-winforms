using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        private string _mahd;
        private string _mamon;
        private int _soluong;
        private double _dongia;
        private double _thanhtien;

        public string Mahd
        {
            get { return _mahd; }
            set { _mahd = value; }
        }

        public string Mamon
        {
            get { return _mamon; }
            set { _mamon = value; }
        }

        public int Soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }

        public double Dongia
        {
            get { return _dongia; }
            set { _dongia = value; }
        }

        public double Thanhtien
        {
            get { return _thanhtien; }
            set { _thanhtien = value; }
        }
    }
}
