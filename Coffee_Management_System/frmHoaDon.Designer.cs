using System.Drawing;
using System.Windows.Forms;

namespace Coffee_Management_System
{
    partial class frmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new Panel();
            this.lblTitle = new Label();

            this.pnlHoaDonInfo = new Panel();
            this.lbMaHoaDon = new Label();
            this.lbBan = new Label();
            this.lbNgayLap = new Label();
            this.lbTrangThai = new Label();
            this.lbTongTien = new Label();

            this.txtMaHoaDon = new TextBox();
            this.cboBan = new ComboBox();
            this.dtpNgayLap = new DateTimePicker();
            this.cboTrangThai = new ComboBox();
            this.txtTongTien = new TextBox();

            this.pnlMonInfo = new Panel();
            this.lbMon = new Label();
            this.lbDonGia = new Label();
            this.lbSoLuong = new Label();
            this.lbThanhTien = new Label();

            this.cboMon = new ComboBox();
            this.txtDonGia = new TextBox();
            this.txtSoLuong = new TextBox();
            this.txtThanhTien = new TextBox();

            this.pnlAction = new Panel();
            this.btnTaoHoaDon = new Button();
            this.btnThemMon = new Button();
            this.btnTang = new Button();
            this.btnGiam = new Button();
            this.btnXoaMon = new Button();
            this.btnThanhToan = new Button();
            this.btnHuyHoaDon = new Button();
            this.btnLamMoi = new Button();

            this.pnlSearch = new Panel();
            this.lbTimKiem = new Label();
            this.txtTimKiem = new TextBox();
            this.btnTimKiem = new Button();

            this.pnlGrid = new Panel();
            this.pnlHoaDonGrid = new Panel();
            this.pnlChiTietGrid = new Panel();

            this.lblDanhSachHoaDon = new Label();
            this.lblChiTietHoaDon = new Label();

            this.dgvHoaDon = new DataGridView();
            this.dgvChiTiet = new DataGridView();

            this.pnlHeader.SuspendLayout();
            this.pnlHoaDonInfo.SuspendLayout();
            this.pnlMonInfo.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.pnlHoaDonGrid.SuspendLayout();
            this.pnlChiTietGrid.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();

            this.SuspendLayout();

            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new SizeF(144F, 144F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.ClientSize = new Size(1200, 760);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn";
            this.BackColor = Color.FromArgb(245, 239, 230);
            this.Font = new Font("Segoe UI", 10F);

            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Height = 80;
            this.pnlHeader.BackColor = Color.FromArgb(78, 52, 46);

            // 
            // lblTitle
            // 
            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.Text = "QUẢN LÝ HÓA ĐƠN";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;

            this.pnlHeader.Controls.Add(this.lblTitle);

            // 
            // pnlHoaDonInfo
            // 
            this.pnlHoaDonInfo.Dock = DockStyle.Top;
            this.pnlHoaDonInfo.Height = 135;
            this.pnlHoaDonInfo.BackColor = Color.FromArgb(255, 243, 224);

            // 
            // lbMaHoaDon
            // 
            this.lbMaHoaDon.Location = new Point(45, 25);
            this.lbMaHoaDon.Size = new Size(120, 28);
            this.lbMaHoaDon.Text = "Mã hóa đơn";
            this.lbMaHoaDon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new Point(175, 25);
            this.txtMaHoaDon.Size = new Size(240, 30);
            this.txtMaHoaDon.ReadOnly = true;

            // 
            // lbBan
            // 
            this.lbBan.Location = new Point(45, 75);
            this.lbBan.Size = new Size(120, 28);
            this.lbBan.Text = "Bàn";
            this.lbBan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // 
            // cboBan
            // 
            this.cboBan.Location = new Point(175, 75);
            this.cboBan.Size = new Size(240, 30);
            this.cboBan.DropDownStyle = ComboBoxStyle.DropDownList;

            // 
            // lbNgayLap
            // 
            this.lbNgayLap.Location = new Point(460, 25);
            this.lbNgayLap.Size = new Size(120, 28);
            this.lbNgayLap.Text = "Ngày lập";
            this.lbNgayLap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new Point(590, 25);
            this.dtpNgayLap.Size = new Size(260, 30);
            this.dtpNgayLap.Format = DateTimePickerFormat.Custom;
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy HH:mm";

            // 
            // lbTrangThai
            // 
            this.lbTrangThai.Location = new Point(460, 75);
            this.lbTrangThai.Size = new Size(120, 28);
            this.lbTrangThai.Text = "Trạng thái";
            this.lbTrangThai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Location = new Point(590, 75);
            this.cboTrangThai.Size = new Size(260, 30);
            this.cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;

            // 
            // lbTongTien
            // 
            this.lbTongTien.Location = new Point(900, 25);
            this.lbTongTien.Size = new Size(120, 28);
            this.lbTongTien.Text = "Tổng tiền";
            this.lbTongTien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new Point(900, 60);
            this.txtTongTien.Size = new Size(240, 38);
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.TextAlign = HorizontalAlignment.Right;
            this.txtTongTien.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.txtTongTien.ForeColor = Color.FromArgb(183, 28, 28);

            this.pnlHoaDonInfo.Controls.Add(this.lbMaHoaDon);
            this.pnlHoaDonInfo.Controls.Add(this.txtMaHoaDon);
            this.pnlHoaDonInfo.Controls.Add(this.lbBan);
            this.pnlHoaDonInfo.Controls.Add(this.cboBan);
            this.pnlHoaDonInfo.Controls.Add(this.lbNgayLap);
            this.pnlHoaDonInfo.Controls.Add(this.dtpNgayLap);
            this.pnlHoaDonInfo.Controls.Add(this.lbTrangThai);
            this.pnlHoaDonInfo.Controls.Add(this.cboTrangThai);
            this.pnlHoaDonInfo.Controls.Add(this.lbTongTien);
            this.pnlHoaDonInfo.Controls.Add(this.txtTongTien);

            // 
            // pnlMonInfo
            // 
            this.pnlMonInfo.Dock = DockStyle.Top;
            this.pnlMonInfo.Height = 105;
            this.pnlMonInfo.BackColor = Color.FromArgb(255, 248, 225);

            // 
            // lbMon
            // 
            this.lbMon.Location = new Point(45, 35);
            this.lbMon.Size = new Size(100, 28);
            this.lbMon.Text = "Món";
            this.lbMon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // 
            // cboMon
            // 
            this.cboMon.Location = new Point(145, 35);
            this.cboMon.Size = new Size(260, 30);
            this.cboMon.DropDownStyle = ComboBoxStyle.DropDownList;

            // 
            // lbDonGia
            // 
            this.lbDonGia.Location = new Point(435, 35);
            this.lbDonGia.Size = new Size(90, 28);
            this.lbDonGia.Text = "Đơn giá";
            this.lbDonGia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new Point(525, 35);
            this.txtDonGia.Size = new Size(150, 30);
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.TextAlign = HorizontalAlignment.Right;

            // 
            // lbSoLuong
            // 
            this.lbSoLuong.Location = new Point(705, 35);
            this.lbSoLuong.Size = new Size(90, 28);
            this.lbSoLuong.Text = "Số lượng";
            this.lbSoLuong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new Point(805, 35);
            this.txtSoLuong.Size = new Size(90, 30);
            this.txtSoLuong.TextAlign = HorizontalAlignment.Right;

            // 
            // lbThanhTien
            // 
            this.lbThanhTien.Location = new Point(920, 35);
            this.lbThanhTien.Size = new Size(100, 28);
            this.lbThanhTien.Text = "Thành tiền";
            this.lbThanhTien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new Point(1020, 35);
            this.txtThanhTien.Size = new Size(140, 30);
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.TextAlign = HorizontalAlignment.Right;

            this.pnlMonInfo.Controls.Add(this.lbMon);
            this.pnlMonInfo.Controls.Add(this.cboMon);
            this.pnlMonInfo.Controls.Add(this.lbDonGia);
            this.pnlMonInfo.Controls.Add(this.txtDonGia);
            this.pnlMonInfo.Controls.Add(this.lbSoLuong);
            this.pnlMonInfo.Controls.Add(this.txtSoLuong);
            this.pnlMonInfo.Controls.Add(this.lbThanhTien);
            this.pnlMonInfo.Controls.Add(this.txtThanhTien);

            // 
            // pnlAction
            // 
            this.pnlAction.Dock = DockStyle.Top;
            this.pnlAction.Height = 80;
            this.pnlAction.BackColor = Color.FromArgb(245, 239, 230);

            this.btnTaoHoaDon = CreateActionButton("Tạo HĐ", 35, Color.FromArgb(76, 175, 80));
            this.btnThemMon = CreateActionButton("Thêm món", 170, Color.FromArgb(121, 85, 72));
            this.btnTang = CreateActionButton("+", 315, Color.FromArgb(33, 150, 243));
            this.btnGiam = CreateActionButton("-", 405, Color.FromArgb(33, 150, 243));
            this.btnXoaMon = CreateActionButton("Xóa món", 495, Color.FromArgb(183, 28, 28));
            this.btnThanhToan = CreateActionButton("Thanh toán", 645, Color.FromArgb(255, 152, 0));
            this.btnHuyHoaDon = CreateActionButton("Hủy HĐ", 810, Color.FromArgb(121, 85, 72));
            this.btnLamMoi = CreateActionButton("Làm mới", 955, Color.FromArgb(96, 125, 139));

            this.btnTang.Size = new Size(70, 45);
            this.btnGiam.Size = new Size(70, 45);
            this.btnThanhToan.Size = new Size(145, 45);

            this.pnlAction.Controls.Add(this.btnTaoHoaDon);
            this.pnlAction.Controls.Add(this.btnThemMon);
            this.pnlAction.Controls.Add(this.btnTang);
            this.pnlAction.Controls.Add(this.btnGiam);
            this.pnlAction.Controls.Add(this.btnXoaMon);
            this.pnlAction.Controls.Add(this.btnThanhToan);
            this.pnlAction.Controls.Add(this.btnHuyHoaDon);
            this.pnlAction.Controls.Add(this.btnLamMoi);

            // 
            // pnlSearch
            // 
            this.pnlSearch.Dock = DockStyle.Top;
            this.pnlSearch.Height = 65;
            this.pnlSearch.BackColor = Color.FromArgb(255, 243, 224);

            // 
            // lbTimKiem
            // 
            this.lbTimKiem.Location = new Point(45, 18);
            this.lbTimKiem.Size = new Size(120, 28);
            this.lbTimKiem.Text = "Tìm kiếm";
            this.lbTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new Point(175, 18);
            this.txtTimKiem.Size = new Size(780, 30);

            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new Point(980, 14);
            this.btnTimKiem.Size = new Size(140, 38);
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnTimKiem.BackColor = Color.FromArgb(121, 85, 72);
            this.btnTimKiem.ForeColor = Color.White;
            this.btnTimKiem.FlatStyle = FlatStyle.Flat;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;

            this.pnlSearch.Controls.Add(this.lbTimKiem);
            this.pnlSearch.Controls.Add(this.txtTimKiem);
            this.pnlSearch.Controls.Add(this.btnTimKiem);

            // 
            // pnlGrid
            // 
            this.pnlGrid.Dock = DockStyle.Fill;
            this.pnlGrid.Padding = new Padding(25);
            this.pnlGrid.BackColor = Color.FromArgb(245, 239, 230);

            // 
            // pnlHoaDonGrid
            // 
            this.pnlHoaDonGrid.Dock = DockStyle.Left;
            this.pnlHoaDonGrid.Width = 570;
            this.pnlHoaDonGrid.Padding = new Padding(0, 0, 12, 0);
            this.pnlHoaDonGrid.BackColor = Color.FromArgb(245, 239, 230);

            // 
            // lblDanhSachHoaDon
            // 
            this.lblDanhSachHoaDon.Dock = DockStyle.Top;
            this.lblDanhSachHoaDon.Height = 35;
            this.lblDanhSachHoaDon.Text = "Danh sách hóa đơn";
            this.lblDanhSachHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            this.lblDanhSachHoaDon.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblDanhSachHoaDon.ForeColor = Color.FromArgb(78, 52, 46);

            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.Dock = DockStyle.Fill;
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = Color.White;
            this.dgvHoaDon.RowHeadersWidth = 50;

            this.pnlHoaDonGrid.Controls.Add(this.dgvHoaDon);
            this.pnlHoaDonGrid.Controls.Add(this.lblDanhSachHoaDon);

            // 
            // pnlChiTietGrid
            // 
            this.pnlChiTietGrid.Dock = DockStyle.Fill;
            this.pnlChiTietGrid.Padding = new Padding(12, 0, 0, 0);
            this.pnlChiTietGrid.BackColor = Color.FromArgb(245, 239, 230);

            // 
            // lblChiTietHoaDon
            // 
            this.lblChiTietHoaDon.Dock = DockStyle.Top;
            this.lblChiTietHoaDon.Height = 35;
            this.lblChiTietHoaDon.Text = "Chi tiết hóa đơn";
            this.lblChiTietHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            this.lblChiTietHoaDon.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblChiTietHoaDon.ForeColor = Color.FromArgb(78, 52, 46);

            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.Dock = DockStyle.Fill;
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = Color.White;
            this.dgvChiTiet.RowHeadersWidth = 50;

            this.pnlChiTietGrid.Controls.Add(this.dgvChiTiet);
            this.pnlChiTietGrid.Controls.Add(this.lblChiTietHoaDon);

            this.pnlGrid.Controls.Add(this.pnlChiTietGrid);
            this.pnlGrid.Controls.Add(this.pnlHoaDonGrid);

            // 
            // Add controls
            // 
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlMonInfo);
            this.Controls.Add(this.pnlHoaDonInfo);
            this.Controls.Add(this.pnlHeader);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHoaDonInfo.ResumeLayout(false);
            this.pnlHoaDonInfo.PerformLayout();
            this.pnlMonInfo.ResumeLayout(false);
            this.pnlMonInfo.PerformLayout();
            this.pnlAction.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            this.pnlHoaDonGrid.ResumeLayout(false);
            this.pnlChiTietGrid.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();

            this.ResumeLayout(false);
        }
        private Button CreateActionButton(string text, int x, Color color)
        {
            Button btn = new Button();

            btn.Location = new Point(x, 18);
            btn.Size = new Size(120, 45);
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            return btn;
        }
        #endregion

        private Panel pnlHeader;
        private Label lblTitle;

        private Panel pnlHoaDonInfo;
        private Label lbMaHoaDon;
        private Label lbBan;
        private Label lbNgayLap;
        private Label lbTrangThai;
        private Label lbTongTien;

        private TextBox txtMaHoaDon;
        private ComboBox cboBan;
        private DateTimePicker dtpNgayLap;
        private ComboBox cboTrangThai;
        private TextBox txtTongTien;

        private Panel pnlMonInfo;
        private Label lbMon;
        private Label lbDonGia;
        private Label lbSoLuong;
        private Label lbThanhTien;

        private ComboBox cboMon;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private TextBox txtThanhTien;

        private Panel pnlAction;
        private Button btnTaoHoaDon;
        private Button btnThemMon;
        private Button btnTang;
        private Button btnGiam;
        private Button btnXoaMon;
        private Button btnThanhToan;
        private Button btnHuyHoaDon;
        private Button btnLamMoi;

        private Panel pnlSearch;
        private Label lbTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;

        private Panel pnlGrid;
        private Panel pnlHoaDonGrid;
        private Panel pnlChiTietGrid;

        private Label lblDanhSachHoaDon;
        private Label lblChiTietHoaDon;

        private DataGridView dgvHoaDon;
        private DataGridView dgvChiTiet;
    }
}