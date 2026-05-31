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
    public partial class frmBan : Form
    {
        BUS_Ban bus = new BUS_Ban();

        public frmBan()
        {
            InitializeComponent();

            this.Load += frmBan_Load;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnTimKiem.Click += btnTimKiem_Click;

            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            dgvDanhSach.CellClick += dgvDanhSach_CellClick;
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            loadTrangThai();
            getGridBan();
            clearInput();
        }

        private void loadTrangThai()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Trống");
            cboTrangThai.Items.Add("Đang sử dụng");
            cboTrangThai.Items.Add("Đã đặt trước");
        }

        private void getGridBan()
        {
            dgvDanhSach.DataSource = bus.getTableBan();

            dgvDanhSach.Columns["maban"].HeaderText = "Mã bàn";
            dgvDanhSach.Columns["tenban"].HeaderText = "Tên bàn";
            dgvDanhSach.Columns["khuvuc"].HeaderText = "Khu vực";
            dgvDanhSach.Columns["trangthai"].HeaderText = "Trạng thái";

            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSach.AllowUserToAddRows = false;
            dgvDanhSach.ReadOnly = true;
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private bool checkInput()
        {
            if (txtMaBan.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã bàn!");
                txtMaBan.Focus();
                return false;
            }

            if (txtTenBan.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên bàn!");
                txtTenBan.Focus();
                return false;
            }

            if (txtKhuVuc.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập khu vực!");
                txtKhuVuc.Focus();
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

        private Ban getBanFromInput()
        {
            Ban b = new Ban();

            b.Maban = txtMaBan.Text.Trim();
            b.Tenban = txtTenBan.Text.Trim();
            b.Khuvuc = txtKhuVuc.Text.Trim();
            b.Trangthai = cboTrangThai.Text.Trim();

            return b;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                Ban b = getBanFromInput();

                Boolean kq = bus.add_New_Ban(b);

                if (kq)
                {
                    MessageBox.Show("Thêm bàn thành công!");
                    getGridBan();
                    clearInput();
                }
                else
                {
                    MessageBox.Show("Thêm bàn thất bại. Có thể mã bàn đã tồn tại!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                Ban b = getBanFromInput();

                Boolean kq = bus.update_Ban(b);

                if (kq)
                {
                    MessageBox.Show("Sửa bàn thành công!");
                    getGridBan();
                    clearInput();
                }
                else
                {
                    MessageBox.Show("Sửa bàn thất bại. Mã bàn không tồn tại!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaBan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bàn cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa bàn này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Boolean kq = bus.delete_Ban(txtMaBan.Text.Trim());

                if (kq)
                {
                    MessageBox.Show("Xóa bàn thành công!");
                    getGridBan();
                    clearInput();
                }
                else
                {
                    MessageBox.Show("Xóa bàn thất bại. Mã bàn không tồn tại!");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            getGridBan();
            clearInput();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            filterBan();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            filterBan();
        }

        private void filterBan()
        {
            string tukhoa = txtTimKiem.Text.Trim().Replace("'", "''");

            if (tukhoa == "")
            {
                getGridBan();
            }
            else
            {
                string strFilter =
                    "maban LIKE '%" + tukhoa + "%' OR " +
                    "tenban LIKE '%" + tukhoa + "%' OR " +
                    "khuvuc LIKE '%" + tukhoa + "%' OR " +
                    "trangthai LIKE '%" + tukhoa + "%'";

                dgvDanhSach.DataSource = bus.getFilter_TenBan(strFilter);
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];

                txtMaBan.Text = row.Cells["maban"].Value.ToString();
                txtTenBan.Text = row.Cells["tenban"].Value.ToString();
                txtKhuVuc.Text = row.Cells["khuvuc"].Value.ToString();
                cboTrangThai.Text = row.Cells["trangthai"].Value.ToString();
            }
        }

        private void clearInput()
        {
            txtMaBan.Clear();
            txtTenBan.Clear();
            txtKhuVuc.Clear();

            cboTrangThai.SelectedIndex = -1;

            txtMaBan.Focus();
        }
    }
}
