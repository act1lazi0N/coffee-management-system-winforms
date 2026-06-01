using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace Coffee_Management_System
{
    public partial class frmMain : Form
    {
        private TaiKhoan currentUser;

        public frmMain(TaiKhoan tk)
        {
            InitializeComponent();

            currentUser = tk;

            btnLoaiMon.Click += btnLoaiMon_Click;
            btnLoaiMonSide.Click += btnLoaiMon_Click;

            btnMon.Click += btnMon_Click;
            btnMonSide.Click += btnMon_Click;

            btnBan.Click += btnBan_Click;
            btnBanSide.Click += btnBan_Click;

            btnDangXuat.Click += btnDangXuat_Click;

            btnHoaDon.Click += btnHoaDon_Click;
            btnDoanhThu.Click += btnThongKe_Click;
            btnThongKeSide.Click += btnThongKe_Click;
            btnNhanVien.Click += btnNhanVien_Click;

            phanQuyen();
        }

        private void phanQuyen()
        {
            lblGreeting.Text = "Chào, " + currentUser.Hoten + " (" + currentUser.Vaitro + ")";

            if (currentUser.Vaitro == "Admin")
            {
                setTatCaChucNang(true);
            }
            else if (currentUser.Vaitro == "QuanLy")
            {
                setTatCaChucNang(true);

                btnNhanVien.Enabled = false;
            }
            else if (currentUser.Vaitro == "NhanVien")
            {
                btnLoaiMon.Enabled = false;
                btnLoaiMonSide.Enabled = false;

                btnMon.Enabled = false;
                btnMonSide.Enabled = false;

                btnBan.Enabled = false;
                btnBanSide.Enabled = false;

                btnDoanhThu.Enabled = false;
                btnThongKeSide.Enabled = false;

                btnNhanVien.Enabled = false;

                btnHoaDon.Enabled = true;
            }
        }

        private void setTatCaChucNang(bool value)
        {
            btnLoaiMon.Enabled = value;
            btnLoaiMonSide.Enabled = value;

            btnMon.Enabled = value;
            btnMonSide.Enabled = value;

            btnBan.Enabled = value;
            btnBanSide.Enabled = value;

            btnHoaDon.Enabled = value;

            btnDoanhThu.Enabled = value;
            btnThongKeSide.Enabled = value;

            btnNhanVien.Enabled = value;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmTaiKhoan f = new frmTaiKhoan();
            f.ShowDialog();
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

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon f = new frmHoaDon();
            f.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe f = new frmThongKe();
            f.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
