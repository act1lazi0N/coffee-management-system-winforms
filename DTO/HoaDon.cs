using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private string _mahd;
        private string _maban;
        private DateTime _ngaylap;
        private string _trangthai;
        private double _tongtien;

        public string Mahd
        {
            get { return _mahd; }
            set { _mahd = value; }
        }

        public string Maban
        {
            get { return _maban; }
            set { _maban = value; }
        }

        public DateTime Ngaylap
        {
            get { return _ngaylap; }
            set { _ngaylap = value; }
        }

        public string Trangthai
        {
            get { return _trangthai; }
            set { _trangthai = value; }
        }

        public double Tongtien
        {
            get { return _tongtien; }
            set { _tongtien = value; }
        }
    }
}
