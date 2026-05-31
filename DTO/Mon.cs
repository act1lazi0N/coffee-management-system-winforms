using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Mon
    {
        private string _mamon;
        private string _tenmon;
        private double _dongia;
        private string _maloai;
        private string _trangthai;

        public string Mamon
        {
            get { return _mamon; }
            set { _mamon = value; }
        }

        public string Tenmon
        {
            get { return _tenmon; }
            set { _tenmon = value; }
        }

        public double Dongia
        {
            get { return _dongia; }
            set { _dongia = value; }
        }

        public string Maloai
        {
            get { return _maloai; }
            set { _maloai = value; }
        }

        public string Trangthai
        {
            get { return _trangthai; }
            set { _trangthai = value; }
        }
    }
}
