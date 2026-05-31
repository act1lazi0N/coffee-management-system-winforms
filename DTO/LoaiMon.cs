using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiMon
    {
        private string _maloai;
        private string _tenloai;
        private string _ghichu;

        public string Maloai
        {
            get { return _maloai; }
            set { _maloai = value; }
        }

        public string Tenloai
        {
            get { return _tenloai; }
            set { _tenloai = value; }
        }

        public string Ghichu
        {
            get { return _ghichu; }
            set { _ghichu = value; }
        }
    }
}
