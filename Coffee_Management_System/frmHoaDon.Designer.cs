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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHoaDonInfo = new System.Windows.Forms.Panel();
            this.lbMaHoaDon = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.lbBan = new System.Windows.Forms.Label();
            this.cboBan = new System.Windows.Forms.ComboBox();
            this.lbNgayLap = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.pnlMonInfo = new System.Windows.Forms.Panel();
            this.lbMon = new System.Windows.Forms.Label();
            this.cboMon = new System.Windows.Forms.ComboBox();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuyHoaDon = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.pnlChiTietGrid = new System.Windows.Forms.Panel();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.lblChiTietHoaDon = new System.Windows.Forms.Label();
            this.pnlHoaDonGrid = new System.Windows.Forms.Panel();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.lblDanhSachHoaDon = new System.Windows.Forms.Label();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.btnXuatCSV = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlHoaDonInfo.SuspendLayout();
            this.pnlMonInfo.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.pnlChiTietGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.pnlHoaDonGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 80);
            this.pnlHeader.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1200, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ HÓA ĐƠN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHoaDonInfo
            // 
            this.pnlHoaDonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
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
            this.pnlHoaDonInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHoaDonInfo.Location = new System.Drawing.Point(0, 80);
            this.pnlHoaDonInfo.Name = "pnlHoaDonInfo";
            this.pnlHoaDonInfo.Size = new System.Drawing.Size(1200, 135);
            this.pnlHoaDonInfo.TabIndex = 4;
            // 
            // lbMaHoaDon
            // 
            this.lbMaHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbMaHoaDon.Location = new System.Drawing.Point(45, 25);
            this.lbMaHoaDon.Name = "lbMaHoaDon";
            this.lbMaHoaDon.Size = new System.Drawing.Size(120, 28);
            this.lbMaHoaDon.TabIndex = 0;
            this.lbMaHoaDon.Text = "Mã hóa đơn";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(175, 25);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.ReadOnly = true;
            this.txtMaHoaDon.Size = new System.Drawing.Size(240, 34);
            this.txtMaHoaDon.TabIndex = 1;
            // 
            // lbBan
            // 
            this.lbBan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbBan.Location = new System.Drawing.Point(45, 75);
            this.lbBan.Name = "lbBan";
            this.lbBan.Size = new System.Drawing.Size(120, 28);
            this.lbBan.TabIndex = 2;
            this.lbBan.Text = "Bàn";
            // 
            // cboBan
            // 
            this.cboBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBan.Location = new System.Drawing.Point(175, 75);
            this.cboBan.Name = "cboBan";
            this.cboBan.Size = new System.Drawing.Size(240, 36);
            this.cboBan.TabIndex = 3;
            // 
            // lbNgayLap
            // 
            this.lbNgayLap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbNgayLap.Location = new System.Drawing.Point(460, 25);
            this.lbNgayLap.Name = "lbNgayLap";
            this.lbNgayLap.Size = new System.Drawing.Size(120, 28);
            this.lbNgayLap.TabIndex = 4;
            this.lbNgayLap.Text = "Ngày lập";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(590, 25);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(260, 34);
            this.dtpNgayLap.TabIndex = 5;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbTrangThai.Location = new System.Drawing.Point(460, 75);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(120, 28);
            this.lbTrangThai.TabIndex = 6;
            this.lbTrangThai.Text = "Trạng thái";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Location = new System.Drawing.Point(590, 75);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(260, 36);
            this.cboTrangThai.TabIndex = 7;
            // 
            // lbTongTien
            // 
            this.lbTongTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbTongTien.Location = new System.Drawing.Point(900, 25);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(120, 28);
            this.lbTongTien.TabIndex = 8;
            this.lbTongTien.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtTongTien.Location = new System.Drawing.Point(900, 60);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(240, 45);
            this.txtTongTien.TabIndex = 9;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlMonInfo
            // 
            this.pnlMonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.pnlMonInfo.Controls.Add(this.lbMon);
            this.pnlMonInfo.Controls.Add(this.cboMon);
            this.pnlMonInfo.Controls.Add(this.lbDonGia);
            this.pnlMonInfo.Controls.Add(this.txtDonGia);
            this.pnlMonInfo.Controls.Add(this.lbSoLuong);
            this.pnlMonInfo.Controls.Add(this.txtSoLuong);
            this.pnlMonInfo.Controls.Add(this.lbThanhTien);
            this.pnlMonInfo.Controls.Add(this.txtThanhTien);
            this.pnlMonInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMonInfo.Location = new System.Drawing.Point(0, 215);
            this.pnlMonInfo.Name = "pnlMonInfo";
            this.pnlMonInfo.Size = new System.Drawing.Size(1200, 105);
            this.pnlMonInfo.TabIndex = 3;
            // 
            // lbMon
            // 
            this.lbMon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbMon.Location = new System.Drawing.Point(45, 35);
            this.lbMon.Name = "lbMon";
            this.lbMon.Size = new System.Drawing.Size(100, 28);
            this.lbMon.TabIndex = 0;
            this.lbMon.Text = "Món";
            // 
            // cboMon
            // 
            this.cboMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMon.Location = new System.Drawing.Point(145, 35);
            this.cboMon.Name = "cboMon";
            this.cboMon.Size = new System.Drawing.Size(260, 36);
            this.cboMon.TabIndex = 1;
            // 
            // lbDonGia
            // 
            this.lbDonGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbDonGia.Location = new System.Drawing.Point(435, 35);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(90, 28);
            this.lbDonGia.TabIndex = 2;
            this.lbDonGia.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(525, 35);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(150, 34);
            this.txtDonGia.TabIndex = 3;
            this.txtDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbSoLuong.Location = new System.Drawing.Point(705, 35);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(90, 28);
            this.lbSoLuong.TabIndex = 4;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(805, 35);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(90, 34);
            this.txtSoLuong.TabIndex = 5;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbThanhTien.Location = new System.Drawing.Point(920, 35);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(100, 28);
            this.lbThanhTien.TabIndex = 6;
            this.lbThanhTien.Text = "Thành tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(1020, 35);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(140, 34);
            this.txtThanhTien.TabIndex = 7;
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlAction
            // 
            this.pnlAction.Dock = DockStyle.Top;
            this.pnlAction.Height = 90;
            this.pnlAction.BackColor = Color.FromArgb(245, 239, 230);

            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.Location = new Point(35, 20);
            this.btnTaoHoaDon.Size = new Size(120, 45);
            this.btnTaoHoaDon.Text = "Tạo HĐ";
            this.btnTaoHoaDon.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnTaoHoaDon.BackColor = Color.FromArgb(76, 175, 80);
            this.btnTaoHoaDon.ForeColor = Color.White;
            this.btnTaoHoaDon.FlatStyle = FlatStyle.Flat;
            this.btnTaoHoaDon.FlatAppearance.BorderSize = 0;

            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new Point(170, 20);
            this.btnThemMon.Size = new Size(120, 45);
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnThemMon.BackColor = Color.FromArgb(121, 85, 72);
            this.btnThemMon.ForeColor = Color.White;
            this.btnThemMon.FlatStyle = FlatStyle.Flat;
            this.btnThemMon.FlatAppearance.BorderSize = 0;

            // 
            // btnTang
            // 
            this.btnTang.Location = new Point(305, 20);
            this.btnTang.Size = new Size(70, 45);
            this.btnTang.Text = "+";
            this.btnTang.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.btnTang.BackColor = Color.FromArgb(33, 150, 243);
            this.btnTang.ForeColor = Color.White;
            this.btnTang.FlatStyle = FlatStyle.Flat;
            this.btnTang.FlatAppearance.BorderSize = 0;

            // 
            // btnGiam
            // 
            this.btnGiam.Location = new Point(390, 20);
            this.btnGiam.Size = new Size(70, 45);
            this.btnGiam.Text = "-";
            this.btnGiam.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.btnGiam.BackColor = Color.FromArgb(33, 150, 243);
            this.btnGiam.ForeColor = Color.White;
            this.btnGiam.FlatStyle = FlatStyle.Flat;
            this.btnGiam.FlatAppearance.BorderSize = 0;

            // 
            // btnXoaMon
            // 
            this.btnXoaMon.Location = new Point(475, 20);
            this.btnXoaMon.Size = new Size(120, 45);
            this.btnXoaMon.Text = "Xóa món";
            this.btnXoaMon.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnXoaMon.BackColor = Color.FromArgb(183, 28, 28);
            this.btnXoaMon.ForeColor = Color.White;
            this.btnXoaMon.FlatStyle = FlatStyle.Flat;
            this.btnXoaMon.FlatAppearance.BorderSize = 0;

            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new Point(610, 20);
            this.btnThanhToan.Size = new Size(145, 45);
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnThanhToan.BackColor = Color.FromArgb(255, 152, 0);
            this.btnThanhToan.ForeColor = Color.White;
            this.btnThanhToan.FlatStyle = FlatStyle.Flat;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;

            // 
            // btnHuyHoaDon
            // 
            this.btnHuyHoaDon.Location = new Point(770, 20);
            this.btnHuyHoaDon.Size = new Size(120, 45);
            this.btnHuyHoaDon.Text = "Hủy HĐ";
            this.btnHuyHoaDon.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnHuyHoaDon.BackColor = Color.FromArgb(121, 85, 72);
            this.btnHuyHoaDon.ForeColor = Color.White;
            this.btnHuyHoaDon.FlatStyle = FlatStyle.Flat;
            this.btnHuyHoaDon.FlatAppearance.BorderSize = 0;

            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new Point(905, 20);
            this.btnLamMoi.Size = new Size(120, 45);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnLamMoi.BackColor = Color.FromArgb(96, 125, 139);
            this.btnLamMoi.ForeColor = Color.White;
            this.btnLamMoi.FlatStyle = FlatStyle.Flat;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;

            this.pnlAction.Controls.Clear();

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
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.pnlSearch.Controls.Add(this.btnXuatCSV);
            this.pnlSearch.Controls.Add(this.btnXuatHoaDon);
            this.pnlSearch.Controls.Add(this.lbTimKiem);
            this.pnlSearch.Controls.Add(this.txtTimKiem);
            this.pnlSearch.Controls.Add(this.btnTimKiem);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 400);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1200, 65);
            this.pnlSearch.TabIndex = 1;
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbTimKiem.Location = new System.Drawing.Point(45, 18);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(120, 28);
            this.lbTimKiem.TabIndex = 0;
            this.lbTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(175, 18);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(564, 34);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(755, 16);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(140, 38);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.pnlGrid.Controls.Add(this.pnlChiTietGrid);
            this.pnlGrid.Controls.Add(this.pnlHoaDonGrid);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 465);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(25);
            this.pnlGrid.Size = new System.Drawing.Size(1200, 295);
            this.pnlGrid.TabIndex = 0;
            // 
            // pnlChiTietGrid
            // 
            this.pnlChiTietGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.pnlChiTietGrid.Controls.Add(this.dgvChiTiet);
            this.pnlChiTietGrid.Controls.Add(this.lblChiTietHoaDon);
            this.pnlChiTietGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChiTietGrid.Location = new System.Drawing.Point(595, 25);
            this.pnlChiTietGrid.Name = "pnlChiTietGrid";
            this.pnlChiTietGrid.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.pnlChiTietGrid.Size = new System.Drawing.Size(580, 245);
            this.pnlChiTietGrid.TabIndex = 0;
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.ColumnHeadersHeight = 34;
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.Location = new System.Drawing.Point(12, 35);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersWidth = 50;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(568, 210);
            this.dgvChiTiet.TabIndex = 0;
            // 
            // lblChiTietHoaDon
            // 
            this.lblChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChiTietHoaDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblChiTietHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.lblChiTietHoaDon.Location = new System.Drawing.Point(12, 0);
            this.lblChiTietHoaDon.Name = "lblChiTietHoaDon";
            this.lblChiTietHoaDon.Size = new System.Drawing.Size(568, 35);
            this.lblChiTietHoaDon.TabIndex = 1;
            this.lblChiTietHoaDon.Text = "Chi tiết hóa đơn";
            this.lblChiTietHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlHoaDonGrid
            // 
            this.pnlHoaDonGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.pnlHoaDonGrid.Controls.Add(this.dgvHoaDon);
            this.pnlHoaDonGrid.Controls.Add(this.lblDanhSachHoaDon);
            this.pnlHoaDonGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHoaDonGrid.Location = new System.Drawing.Point(25, 25);
            this.pnlHoaDonGrid.Name = "pnlHoaDonGrid";
            this.pnlHoaDonGrid.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.pnlHoaDonGrid.Size = new System.Drawing.Size(570, 245);
            this.pnlHoaDonGrid.TabIndex = 1;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.ColumnHeadersHeight = 34;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 35);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersWidth = 50;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(558, 210);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // lblDanhSachHoaDon
            // 
            this.lblDanhSachHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDanhSachHoaDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDanhSachHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.lblDanhSachHoaDon.Location = new System.Drawing.Point(0, 0);
            this.lblDanhSachHoaDon.Name = "lblDanhSachHoaDon";
            this.lblDanhSachHoaDon.Size = new System.Drawing.Size(558, 35);
            this.lblDanhSachHoaDon.TabIndex = 1;
            this.lblDanhSachHoaDon.Text = "Danh sách hóa đơn";
            this.lblDanhSachHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.btnXuatHoaDon.FlatAppearance.BorderSize = 0;
            this.btnXuatHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXuatHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnXuatHoaDon.Location = new System.Drawing.Point(901, 16);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(140, 38);
            this.btnXuatHoaDon.TabIndex = 3;
            this.btnXuatHoaDon.Text = "Xuất HĐ";
            this.btnXuatHoaDon.UseVisualStyleBackColor = false;
            // 
            // btnXuatCSV
            // 
            this.btnXuatCSV.BackColor = System.Drawing.Color.Green;
            this.btnXuatCSV.FlatAppearance.BorderSize = 0;
            this.btnXuatCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatCSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXuatCSV.ForeColor = System.Drawing.Color.White;
            this.btnXuatCSV.Location = new System.Drawing.Point(1048, 16);
            this.btnXuatCSV.Name = "btnXuatCSV";
            this.btnXuatCSV.Size = new System.Drawing.Size(140, 38);
            this.btnXuatCSV.TabIndex = 4;
            this.btnXuatCSV.Text = "Xuất CSV";
            this.btnXuatCSV.UseVisualStyleBackColor = false;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlMonInfo);
            this.Controls.Add(this.pnlHoaDonInfo);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHoaDonInfo.ResumeLayout(false);
            this.pnlHoaDonInfo.PerformLayout();
            this.pnlMonInfo.ResumeLayout(false);
            this.pnlMonInfo.PerformLayout();
            this.pnlAction.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            this.pnlChiTietGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.pnlHoaDonGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
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
        private Button btnXuatHoaDon;
        private Button btnXuatCSV;
    }
}