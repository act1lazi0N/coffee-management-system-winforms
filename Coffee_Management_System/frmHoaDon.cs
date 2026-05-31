using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Management_System
{
    public partial class frmHoaDon : Form
    {
        BUS_HoaDon bus = new BUS_HoaDon();
        public frmHoaDon()
        {
            InitializeComponent();

            this.Load += frmHoaDon_Load;

            btnTaoHoaDon.Click += btnTaoHoaDon_Click;
            btnThemMon.Click += btnThemMon_Click;
            btnTang.Click += btnTang_Click;
            btnGiam.Click += btnGiam_Click;
            btnXoaMon.Click += btnXoaMon_Click;
            btnThanhToan.Click += btnThanhToan_Click;
            btnHuyHoaDon.Click += btnHuyHoaDon_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnTimKiem.Click += btnTimKiem_Click;

            cboMon.SelectedIndexChanged += cboMon_SelectedIndexChanged;
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;

            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            dgvChiTiet.CellClick += dgvChiTiet_CellClick;

            btnXuatHoaDon.Click += btnXuatHoaDon_Click;
            btnXuatCSV.Click += btnXuatCSV_Click;
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loadBan();
            loadMon();
            loadTrangThai();
            getGridHoaDon();
            clearInput();
        }

        private void loadBan()
        {
            cboBan.DataSource = bus.getTableBan();
            cboBan.DisplayMember = "tenban";
            cboBan.ValueMember = "maban";
            cboBan.SelectedIndex = -1;
        }

        private void loadMon()
        {
            cboMon.DataSource = bus.getTableMon();
            cboMon.DisplayMember = "tenmon";
            cboMon.ValueMember = "mamon";
            cboMon.SelectedIndex = -1;
        }

        private void loadTrangThai()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Chưa thanh toán");
            cboTrangThai.Items.Add("Đã thanh toán");
            cboTrangThai.SelectedIndex = -1;
        }

        private void getGridHoaDon()
        {
            dgvHoaDon.DataSource = bus.getTableHoaDon();

            dgvHoaDon.Columns["mahd"].HeaderText = "Mã HĐ";
            dgvHoaDon.Columns["maban"].HeaderText = "Mã bàn";
            dgvHoaDon.Columns["ngaylap"].HeaderText = "Ngày lập";
            dgvHoaDon.Columns["trangthai"].HeaderText = "Trạng thái";
            dgvHoaDon.Columns["tongtien"].HeaderText = "Tổng tiền";

            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void getGridChiTiet(string mahd)
        {
            dgvChiTiet.DataSource = bus.getChiTietHoaDonCoTenMon(mahd);

            dgvChiTiet.Columns["mahd"].HeaderText = "Mã HĐ";
            dgvChiTiet.Columns["mamon"].HeaderText = "Mã món";
            dgvChiTiet.Columns["tenmon"].HeaderText = "Tên món";
            dgvChiTiet.Columns["soluong"].HeaderText = "Số lượng";
            dgvChiTiet.Columns["dongia"].HeaderText = "Đơn giá";
            dgvChiTiet.Columns["thanhtien"].HeaderText = "Thành tiền";

            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            if (cboBan.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn bàn!");
                return;
            }

            HoaDon hd = new HoaDon();

            hd.Mahd = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");
            hd.Maban = cboBan.SelectedValue.ToString();
            hd.Ngaylap = DateTime.Now;
            hd.Trangthai = "Chưa thanh toán";
            hd.Tongtien = 0;

            Boolean kq = bus.add_New_HoaDon(hd);

            if (kq)
            {
                MessageBox.Show("Tạo hóa đơn thành công!");

                txtMaHoaDon.Text = hd.Mahd;
                dtpNgayLap.Value = hd.Ngaylap;
                cboTrangThai.Text = hd.Trangthai;
                txtTongTien.Text = "0";

                getGridHoaDon();
                loadBan();
            }
            else
            {
                MessageBox.Show("Tạo hóa đơn thất bại!");
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa tạo hoặc chọn hóa đơn!");
                return;
            }

            if (cboMon.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn món!");
                return;
            }

            int soluong;

            if (!int.TryParse(txtSoLuong.Text.Trim(), out soluong))
            {
                MessageBox.Show("Số lượng phải là số nguyên!");
                return;
            }

            if (soluong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!");
                return;
            }

            double dongia = Convert.ToDouble(txtDonGia.Text);
            double thanhtien = soluong * dongia;

            ChiTietHoaDon ct = new ChiTietHoaDon();

            ct.Mahd = txtMaHoaDon.Text.Trim();
            ct.Mamon = cboMon.SelectedValue.ToString();
            ct.Soluong = soluong;
            ct.Dongia = dongia;
            ct.Thanhtien = thanhtien;

            Boolean kq = bus.add_ChiTietHoaDon(ct);

            if (kq)
            {
                getGridChiTiet(txtMaHoaDon.Text.Trim());
                refreshTongTien();
                getGridHoaDon();
            }
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow == null)
            {
                return;
            }

            string mahd = dgvChiTiet.CurrentRow.Cells["mahd"].Value.ToString();
            string mamon = dgvChiTiet.CurrentRow.Cells["mamon"].Value.ToString();

            bus.tangSoLuong(mahd, mamon);

            getGridChiTiet(mahd);
            refreshTongTien();
            getGridHoaDon();
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow == null)
            {
                return;
            }

            string mahd = dgvChiTiet.CurrentRow.Cells["mahd"].Value.ToString();
            string mamon = dgvChiTiet.CurrentRow.Cells["mamon"].Value.ToString();

            bus.giamSoLuong(mahd, mamon);

            getGridChiTiet(mahd);
            refreshTongTien();
            getGridHoaDon();
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow == null)
            {
                return;
            }

            string mahd = dgvChiTiet.CurrentRow.Cells["mahd"].Value.ToString();
            string mamon = dgvChiTiet.CurrentRow.Cells["mamon"].Value.ToString();

            bus.delete_ChiTietHoaDon(mahd, mamon);

            getGridChiTiet(mahd);
            refreshTongTien();
            getGridHoaDon();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Xác nhận thanh toán hóa đơn này?",
                "Thanh toán",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Boolean kq = bus.thanhToanHoaDon(txtMaHoaDon.Text.Trim());

                if (kq)
                {
                    MessageBox.Show("Thanh toán thành công!");
                    getGridHoaDon();
                    getGridChiTiet(txtMaHoaDon.Text.Trim());
                    loadBan();
                    refreshTongTien();
                }
            }
        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn hủy hóa đơn này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Boolean kq = bus.huyHoaDon(txtMaHoaDon.Text.Trim());

                if (kq)
                {
                    MessageBox.Show("Hủy hóa đơn thành công!");
                    getGridHoaDon();
                    dgvChiTiet.DataSource = null;
                    loadBan();
                    clearInput();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearInput();
            getGridHoaDon();
            dgvChiTiet.DataSource = null;
            loadBan();
            loadMon();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text.Trim().Replace("'", "''");

            if (tukhoa == "")
            {
                getGridHoaDon();
            }
            else
            {
                dgvHoaDon.DataSource = bus.getHoaDonTheoTuKhoa(tukhoa);
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];

                txtMaHoaDon.Text = row.Cells["mahd"].Value.ToString();
                cboBan.SelectedValue = row.Cells["maban"].Value.ToString();
                dtpNgayLap.Value = Convert.ToDateTime(row.Cells["ngaylap"].Value);
                cboTrangThai.Text = row.Cells["trangthai"].Value.ToString();
                txtTongTien.Text = Convert.ToDouble(row.Cells["tongtien"].Value).ToString("N0");

                getGridChiTiet(txtMaHoaDon.Text);
            }
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChiTiet.Rows[e.RowIndex];

                cboMon.SelectedValue = row.Cells["mamon"].Value.ToString();
                txtSoLuong.Text = row.Cells["soluong"].Value.ToString();
                txtDonGia.Text = row.Cells["dongia"].Value.ToString();
                txtThanhTien.Text = row.Cells["thanhtien"].Value.ToString();
            }
        }

        private void cboMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMon.SelectedIndex >= 0)
            {
                DataRowView drv = cboMon.SelectedItem as DataRowView;

                if (drv != null)
                {
                    txtDonGia.Text = drv["dongia"].ToString();
                    tinhThanhTien();
                }
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            tinhThanhTien();
        }

        private void tinhThanhTien()
        {
            int soluong;
            double dongia;

            if (int.TryParse(txtSoLuong.Text.Trim(), out soluong) &&
                double.TryParse(txtDonGia.Text.Trim(), out dongia))
            {
                txtThanhTien.Text = (soluong * dongia).ToString();
            }
            else
            {
                txtThanhTien.Text = "";
            }
        }

        private void refreshTongTien()
        {
            if (txtMaHoaDon.Text.Trim() != "")
            {
                double tong = bus.tinhTongTien(txtMaHoaDon.Text.Trim());
                txtTongTien.Text = tong.ToString("N0");
            }
        }

        private void clearInput()
        {
            txtMaHoaDon.Clear();
            txtTongTien.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtThanhTien.Clear();
            txtTimKiem.Clear();

            cboBan.SelectedIndex = -1;
            cboMon.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;

            dtpNgayLap.Value = DateTime.Now;
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn cần xuất!");
                return;
            }

            if (dgvChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Hóa đơn chưa có chi tiết món!");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();

            save.Title = "Xuất hóa đơn";
            save.Filter = "Text file (*.txt)|*.txt";
            save.FileName = txtMaHoaDon.Text.Trim() + ".txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();

                    sb.AppendLine("========================================");
                    sb.AppendLine("          HÓA ĐƠN QUÁN CÀ PHÊ");
                    sb.AppendLine("========================================");
                    sb.AppendLine("Mã hóa đơn : " + txtMaHoaDon.Text);
                    sb.AppendLine("Bàn        : " + cboBan.Text);
                    sb.AppendLine("Ngày lập   : " + dtpNgayLap.Value.ToString("dd/MM/yyyy HH:mm"));
                    sb.AppendLine("Trạng thái : " + cboTrangThai.Text);
                    sb.AppendLine("----------------------------------------");
                    sb.AppendLine("DANH SÁCH MÓN");
                    sb.AppendLine("----------------------------------------");

                    foreach (DataGridViewRow row in dgvChiTiet.Rows)
                    {
                        if (row.IsNewRow == false)
                        {
                            string mamon = row.Cells["mamon"].Value.ToString();
                            string soluong = row.Cells["soluong"].Value.ToString();
                            string dongia = Convert.ToDouble(row.Cells["dongia"].Value).ToString("N0");
                            string thanhtien = Convert.ToDouble(row.Cells["thanhtien"].Value).ToString("N0");

                            sb.AppendLine("Mã món     : " + mamon);
                            sb.AppendLine("Số lượng   : " + soluong);
                            sb.AppendLine("Đơn giá    : " + dongia + "đ");
                            sb.AppendLine("Thành tiền : " + thanhtien + "đ");
                            sb.AppendLine("----------------------------------------");
                        }
                    }

                    sb.AppendLine("TỔNG TIỀN  : " + txtTongTien.Text + "đ");
                    sb.AppendLine("========================================");
                    sb.AppendLine("        Cảm ơn quý khách!");
                    sb.AppendLine("========================================");

                    File.WriteAllText(save.FileName, sb.ToString(), Encoding.UTF8);

                    MessageBox.Show("Xuất hóa đơn thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất hóa đơn: " + ex.Message);
                }
            }
        }

        private void btnXuatCSV_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn!");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();

            save.Title = "Xuất hóa đơn CSV";
            save.Filter = "CSV file (*.csv)|*.csv";
            save.FileName = txtMaHoaDon.Text.Trim() + ".csv";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Ma hoa don," + txtMaHoaDon.Text);
                sb.AppendLine("Ban," + cboBan.Text);
                sb.AppendLine("Ngay lap," + dtpNgayLap.Value.ToString("dd/MM/yyyy HH:mm"));
                sb.AppendLine("Trang thai," + cboTrangThai.Text);
                sb.AppendLine();
                sb.AppendLine("Ma mon,So luong,Don gia,Thanh tien");

                foreach (DataGridViewRow row in dgvChiTiet.Rows)
                {
                    if (row.IsNewRow == false)
                    {
                        sb.AppendLine(
                            row.Cells["mamon"].Value.ToString() + "," +
                            row.Cells["soluong"].Value.ToString() + "," +
                            row.Cells["dongia"].Value.ToString() + "," +
                            row.Cells["thanhtien"].Value.ToString()
                        );
                    }
                }

                sb.AppendLine();
                sb.AppendLine("Tong tien," + txtTongTien.Text);

                File.WriteAllText(save.FileName, sb.ToString(), Encoding.UTF8);

                MessageBox.Show("Xuất CSV thành công!");
            }
        }
    }
}
