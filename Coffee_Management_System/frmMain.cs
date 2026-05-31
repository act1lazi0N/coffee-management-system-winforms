using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Management_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            btnLoaiMon.Click += btnLoaiMon_Click;
            btnLoaiMonSide.Click += btnLoaiMon_Click;

            btnMon.Click += btnMon_Click;
            btnMonSide.Click += btnMon_Click;

            btnBan.Click += btnBan_Click;
            btnBanSide.Click += btnBan_Click;

            btnDangXuat.Click += btnDangXuat_Click;
        }
        private void btnLoaiMon_Click(object sender, EventArgs e)
        {
            frmLoaiMon f = new frmLoaiMon();
            f.ShowDialog();
        }

        private void btnMon_Click(object sender, EventArgs e)
        {
            frmMon f = new frmMon();
            f.ShowDialog();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            frmBan f = new frmBan();
            f.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
