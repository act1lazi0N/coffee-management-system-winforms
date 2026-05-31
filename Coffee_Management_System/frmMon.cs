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
    public partial class frmMon : Form
    {
        BUS_Mon busMon = new BUS_Mon();
        BUS_LoaiMon busLoaiMon = new BUS_LoaiMon();
        public frmMon()
        {
            InitializeComponent();

            this.Load += frmMon_Load;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnTimKiem.Click += btnTimKiem_Click;

            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            dgvDanhSach.CellClick += dgvDanhSach_CellClick;
        }

        private void frmMon_Load(object sender, EventArgs e)
        {
            loadTrangThai();
            getLoaiMon();
            getGridMon();
            clearInput();
        }

        private void loadTrangThai()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Đang bán");
            cboTrangThai.Items.Add("Tạm ngưng");
            cboTrangThai.Items.Add("Hết hàng");
        }

        private void getLoaiMon()
        {
            cboTenLoai.Items.Clear();
            cboMaLoai.Items.Clear();

            List<LoaiMon> dsLoaiMon = busLoaiMon.getDsLoaiMon();

            foreach (LoaiMon lm in dsLoaiMon)
            {
                cboTenLoai.Items.Add(lm.Tenloai);
                cboMaLoai.Items.Add(lm.Maloai);
            }
        }

        private void getGridMon()
        {
            dgvDanhSach.DataSource = busMon.getTableMon();

            dgvDanhSach.Columns["mamon"].HeaderText = "Mã món";
            dgvDanhSach.Columns["tenmon"].HeaderText = "Tên món";
            dgvDanhSach.Columns["dongia"].HeaderText = "Đơn giá";
            dgvDanhSach.Columns["maloai"].HeaderText = "Mã loại";
            dgvDanhSach.Columns["trangthai"].HeaderText = "Trạng thái";

            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSach.AllowUserToAddRows = false;
            dgvDanhSach.ReadOnly = true;
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private bool checkInput()
        {
            if (txtMaMon.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã món!");
                txtMaMon.Focus();
                return false;
            }

            if (txtTenMon.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên món!");
                txtTenMon.Focus();
                return false;
            }

            if (txtDonGia.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập đơn giá!");
                txtDonGia.Focus();
                return false;
            }

            double dongia;

            if (!double.TryParse(txtDonGia.Text.Trim(), out dongia))
            {
                MessageBox.Show("Đơn giá phải là số!");
                txtDonGia.Focus();
                return false;
            }

            if (dongia < 0)
            {
                MessageBox.Show("Đơn giá không được nhỏ hơn 0!");
                txtDonGia.Focus();
                return false;
            }

            if (cboTenLoai.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn loại món!");
                cboTenLoai.Focus();
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

        private Mon getMonFromInput()
        {
            Mon m = new Mon();

            m.Mamon = txtMaMon.Text.Trim();
            m.Tenmon = txtTenMon.Text.Trim();
            m.Dongia = Convert.ToDouble(txtDonGia.Text.Trim());
            m.Maloai = cboMaLoai.Items[cboTenLoai.SelectedIndex].ToString();
            m.Trangthai = cboTrangThai.Text.Trim();

            return m;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                Mon m = getMonFromInput();

                Boolean kq = busMon.add_New_Mon(m);

                if (kq)
                {
                    MessageBox.Show("Thêm món thành công!");
                    getGridMon();
                    clearInput();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại. Có thể mã món đã tồn tại!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                Mon m = getMonFromInput();

                Boolean kq = busMon.update_Mon(m);

                if (kq)
                {
                    MessageBox.Show("Sửa món thành công!");
                    getGridMon();
                    clearInput();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại. Mã món không tồn tại!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn món cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa món này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Boolean kq = busMon.delete_Mon(txtMaMon.Text.Trim());

                if (kq)
                {
                    MessageBox.Show("Xóa món thành công!");
                    getGridMon();
                    clearInput();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Mã món không tồn tại!");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            getLoaiMon();
            getGridMon();
            clearInput();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            filterMon();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            filterMon();
        }

        private void filterMon()
        {
            string tukhoa = txtTimKiem.Text.Trim().Replace("'", "''");

            if (tukhoa == "")
            {
                getGridMon();
            }
            else
            {
                string strFilter =
                    "mamon LIKE '%" + tukhoa + "%' OR " +
                    "tenmon LIKE '%" + tukhoa + "%' OR " +
                    "maloai LIKE '%" + tukhoa + "%' OR " +
                    "trangthai LIKE '%" + tukhoa + "%'";

                dgvDanhSach.DataSource = busMon.getFilter_TenMon(strFilter);
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];

                txtMaMon.Text = row.Cells["mamon"].Value.ToString();
                txtTenMon.Text = row.Cells["tenmon"].Value.ToString();
                txtDonGia.Text = row.Cells["dongia"].Value.ToString();
                cboTrangThai.Text = row.Cells["trangthai"].Value.ToString();

                string maloai = row.Cells["maloai"].Value.ToString();

                for (int i = 0; i < cboMaLoai.Items.Count; i++)
                {
                    if (cboMaLoai.Items[i].ToString().Trim() == maloai.Trim())
                    {
                        cboTenLoai.SelectedIndex = i;
                        cboMaLoai.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void clearInput()
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtDonGia.Clear();

            cboTenLoai.SelectedIndex = -1;
            cboMaLoai.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;

            txtMaMon.Focus();
        }
    }
}
