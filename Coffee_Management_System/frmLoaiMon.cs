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
    public partial class frmLoaiMon : Form
    {
        BUS_LoaiMon bus = new BUS_LoaiMon();

        public frmLoaiMon()
        {
            InitializeComponent();

            this.Load += frmLoaiMon_Load;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnTimKiem.Click += btnTimKiem_Click;

            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            dgvDanhSach.CellClick += dgvDanhSach_CellClick;
        }

        private void frmLoaiMon_Load(object sender, EventArgs e)
        {
            getGridLoaiMon();
            clearInput();
        }

        private void getGridLoaiMon()
        {
            dgvDanhSach.DataSource = bus.getTableLoaiMon();

            dgvDanhSach.Columns["maloai"].HeaderText = "Mã loại";
            dgvDanhSach.Columns["tenloai"].HeaderText = "Tên loại";
            dgvDanhSach.Columns["ghichu"].HeaderText = "Ghi chú";

            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSach.AllowUserToAddRows = false;
            dgvDanhSach.ReadOnly = true;
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private bool checkInput()
        {
            if (txtMaLoai.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã loại!");
                txtMaLoai.Focus();
                return false;
            }

            if (txtTenLoai.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên loại!");
                txtTenLoai.Focus();
                return false;
            }

            return true;
        }

        private LoaiMon getLoaiMonFromInput()
        {
            LoaiMon lm = new LoaiMon();

            lm.Maloai = txtMaLoai.Text.Trim();
            lm.Tenloai = txtTenLoai.Text.Trim();
            lm.Ghichu = txtGhiChu.Text.Trim();

            return lm;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                LoaiMon lm = getLoaiMonFromInput();

                Boolean kq = bus.add_New_LoaiMon(lm);

                if (kq)
                {
                    MessageBox.Show("Thêm loại món thành công!");
                    getGridLoaiMon();
                    clearInput();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại. Có thể mã loại đã tồn tại!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                LoaiMon lm = getLoaiMonFromInput();

                Boolean kq = bus.update_LoaiMon(lm);

                if (kq)
                {
                    MessageBox.Show("Sửa loại món thành công!");
                    getGridLoaiMon();
                    clearInput();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại. Mã loại không tồn tại!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn loại món cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa loại món này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Boolean kq = bus.delete_LoaiMon(txtMaLoai.Text.Trim());

                if (kq)
                {
                    MessageBox.Show("Xóa loại món thành công!");
                    getGridLoaiMon();
                    clearInput();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Mã loại không tồn tại!");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            getGridLoaiMon();
            clearInput();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            filterLoaiMon();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            filterLoaiMon();
        }

        private void filterLoaiMon()
        {
            string tukhoa = txtTimKiem.Text.Trim().Replace("'", "''");

            if (tukhoa == "")
            {
                getGridLoaiMon();
            }
            else
            {
                string strFilter =
                    "maloai LIKE '%" + tukhoa + "%' OR " +
                    "tenloai LIKE '%" + tukhoa + "%' OR " +
                    "ghichu LIKE '%" + tukhoa + "%'";

                dgvDanhSach.DataSource = bus.getFilter_TenLoai(strFilter);
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];

                txtMaLoai.Text = row.Cells["maloai"].Value.ToString();
                txtTenLoai.Text = row.Cells["tenloai"].Value.ToString();
                txtGhiChu.Text = row.Cells["ghichu"].Value.ToString();
            }
        }

        private void clearInput()
        {
            txtMaLoai.Clear();
            txtTenLoai.Clear();
            txtGhiChu.Clear();

            txtMaLoai.Focus();
        }
    }
}
