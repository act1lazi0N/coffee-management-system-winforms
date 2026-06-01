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
    public partial class frmTaiKhoan : Form
    {
        BUS_TaiKhoan bus = new BUS_TaiKhoan();
        public frmTaiKhoan()
        {
            InitializeComponent();
            this.Load += frmTaiKhoan_Load;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnKhoaMo.Click += btnKhoaMo_Click;
            btnTimKiem.Click += btnTimKiem_Click;

            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            dgvDanhSach.CellClick += dgvDanhSach_CellClick;

        }
        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            loadVaiTro();
            loadTrangThai();
            getGridTaiKhoan();
            clearInput();
        }

        private void loadVaiTro()
        {
            cboVaiTro.Items.Clear();
            cboVaiTro.Items.Add("Admin");
            cboVaiTro.Items.Add("QuanLy");
            cboVaiTro.Items.Add("NhanVien");
        }

        private void loadTrangThai()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Hoạt động");
            cboTrangThai.Items.Add("Bị khóa");
        }

        private void getGridTaiKhoan()
        {
            dgvDanhSach.DataSource = bus.getTableTaiKhoan();

            dgvDanhSach.Columns["tendangnhap"].HeaderText = "Tên đăng nhập";
            dgvDanhSach.Columns["matkhau"].HeaderText = "Mật khẩu";
            dgvDanhSach.Columns["hoten"].HeaderText = "Họ tên";
            dgvDanhSach.Columns["vaitro"].HeaderText = "Vai trò";
            dgvDanhSach.Columns["trangthai"].HeaderText = "Trạng thái";

            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private bool checkInput()
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên đăng nhập!");
                txtTenDangNhap.Focus();
                return false;
            }

            if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu!");
                txtMatKhau.Focus();
                return false;
            }

            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập họ tên!");
                txtHoTen.Focus();
                return false;
            }

            if (cboVaiTro.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn vai trò!");
                cboVaiTro.Focus();
                return false;
            }

            if (cboTrangThai.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn trạng thái!");
                cboTrangThai.Focus();
                return false;
            }

            return true;
        }

        private TaiKhoan getTaiKhoanFromInput()
        {
            TaiKhoan tk = new TaiKhoan();

            tk.Tendangnhap = txtTenDangNhap.Text.Trim();
            tk.Matkhau = txtMatKhau.Text.Trim();
            tk.Hoten = txtHoTen.Text.Trim();
            tk.Vaitro = cboVaiTro.Text.Trim();
            tk.Trangthai = cboTrangThai.Text == "Hoạt động";

            return tk;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                TaiKhoan tk = getTaiKhoanFromInput();

                Boolean kq = bus.add_New_TaiKhoan(tk);

                if (kq)
                {
                    MessageBox.Show("Thêm tài khoản thành công!");
                    bus.reload();
                    getGridTaiKhoan();
                    clearInput();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại. Tên đăng nhập đã tồn tại!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                TaiKhoan tk = getTaiKhoanFromInput();

                Boolean kq = bus.update_TaiKhoan(tk);

                if (kq)
                {
                    MessageBox.Show("Sửa tài khoản thành công!");
                    bus.reload();
                    getGridTaiKhoan();
                    clearInput();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại. Tài khoản không tồn tại!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn tài khoản cần xóa!");
                return;
            }

            if (txtTenDangNhap.Text.Trim() == "admin")
            {
                MessageBox.Show("Không nên xóa tài khoản admin mặc định!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa tài khoản này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Boolean kq = bus.delete_TaiKhoan(txtTenDangNhap.Text.Trim());

                if (kq)
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                    bus.reload();
                    getGridTaiKhoan();
                    clearInput();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnKhoaMo_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn tài khoản!");
                return;
            }

            if (txtTenDangNhap.Text.Trim() == "admin")
            {
                MessageBox.Show("Không nên khóa tài khoản admin mặc định!");
                return;
            }

            TaiKhoan tk = getTaiKhoanFromInput();

            tk.Trangthai = !tk.Trangthai;

            Boolean kq = bus.update_TaiKhoan(tk);

            if (kq)
            {
                MessageBox.Show("Cập nhật trạng thái tài khoản thành công!");
                bus.reload();
                getGridTaiKhoan();
                clearInput();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            bus.reload();
            getGridTaiKhoan();
            clearInput();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            filterTaiKhoan();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            filterTaiKhoan();
        }

        private void filterTaiKhoan()
        {
            string tukhoa = txtTimKiem.Text.Trim();

            if (tukhoa == "")
            {
                getGridTaiKhoan();
            }
            else
            {
                dgvDanhSach.DataSource = bus.searchTaiKhoan(tukhoa);
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];

                txtTenDangNhap.Text = row.Cells["tendangnhap"].Value.ToString();
                txtMatKhau.Text = row.Cells["matkhau"].Value.ToString();
                txtHoTen.Text = row.Cells["hoten"].Value.ToString();
                cboVaiTro.Text = row.Cells["vaitro"].Value.ToString();

                bool trangthai = Convert.ToBoolean(row.Cells["trangthai"].Value);

                if (trangthai)
                {
                    cboTrangThai.Text = "Hoạt động";
                }
                else
                {
                    cboTrangThai.Text = "Bị khóa";
                }
            }
        }

        private void clearInput()
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtHoTen.Clear();

            cboVaiTro.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;

            txtTenDangNhap.Focus();
        }
    }
}
