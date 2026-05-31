using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ban
    {
        private string _maban;
        private string _tenban;
        private string _khuvuc;
        private string _trangthai;

        public string Maban
        {
            get { return _maban; }
            set { _maban = value; }
        }

        public string Tenban
        {
            get { return _tenban; }
            set { _tenban = value; }
        }

        public string Khuvuc
        {
            get { return _khuvuc; }
            set { _khuvuc = value; }
        }

        public string Trangthai
        {
            get { return _trangthai; }
            set { _trangthai = value; }
        }
    }
}
