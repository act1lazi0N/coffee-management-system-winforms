using BUS;
using DTO;
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
    public partial class frmLogin : Form
    {
        BUS_TaiKhoan bus = new BUS_TaiKhoan();
        public frmLogin()
        {
            InitializeComponent();

            btnDangNhap.Click += btnDangNhap_Click;
            btnThoat.Click += btnThoat_Click;

            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtTenDangNhap.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim();

            if (tendangnhap == "")
            {
                MessageBox.Show("Chưa nhập tên đăng nhập!");
                txtTenDangNhap.Focus();
                return;
            }

            if (matkhau == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu!");
                txtMatKhau.Focus();
                return;
            }

            TaiKhoan tk = bus.dangNhap(tendangnhap, matkhau);

            if (tk != null)
            {
                MessageBox.Show("Đăng nhập thành công!");

                frmMain f = new frmMain(tk);

                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản, mật khẩu hoặc tài khoản đã bị khóa!");
                txtMatKhau.Clear();
                txtMatKhau.Focus();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
