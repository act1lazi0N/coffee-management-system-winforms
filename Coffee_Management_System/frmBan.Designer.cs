using System.Drawing;
using System.Windows.Forms;

namespace Coffee_Management_System
{
    partial class frmBan
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
            this.lblTitle = new Label();

            this.lbMaBan = new Label();
            this.lbTenBan = new Label();
            this.lbKhuVuc = new Label();
            this.lbTrangThai = new Label();
            this.lbTimKiem = new Label();

            this.txtMaBan = new TextBox();
            this.txtTenBan = new TextBox();
            this.txtKhuVuc = new TextBox();
            this.cboTrangThai = new ComboBox();
            this.txtTimKiem = new TextBox();

            this.btnThem = new Button();
            this.btnSua = new Button();
            this.btnXoa = new Button();
            this.btnLamMoi = new Button();
            this.btnTimKiem = new Button();

            this.dgvDanhSach = new DataGridView();

            this.pnlHeader = new Panel();
            this.pnlInput = new Panel();
            this.pnlAction = new Panel();
            this.pnlGrid = new Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.SuspendLayout();

            // 
            // frmBan
            // 
            this.AutoScaleDimensions = new SizeF(144F, 144F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.ClientSize = new Size(1000, 620);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản lý bàn";
            this.BackColor = Color.FromArgb(245, 239, 230);
            this.Font = new Font("Segoe UI", 10F);

            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Height = 85;
            this.pnlHeader.BackColor = Color.FromArgb(78, 52, 46);

            // 
            // lblTitle
            // 
            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.Text = "QUẢN LÝ BÀN";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;

            this.pnlHeader.Controls.Add(this.lblTitle);

            // 
            // pnlInput
            // 
            this.pnlInput.Dock = DockStyle.Top;
            this.pnlInput.Height = 190;
            this.pnlInput.BackColor = Color.FromArgb(255, 243, 224);

            // 
            // lbMaBan
            // 
            this.lbMaBan.Location = new Point(60, 30);
            this.lbMaBan.Size = new Size(120, 28);
            this.lbMaBan.Text = "Mã bàn";
            this.lbMaBan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // 
            // txtMaBan
            // 
            this.txtMaBan.Location = new Point(190, 30);
            this.txtMaBan.Size = new Size(270, 30);

            // 
            // lbTenBan
            // 
            this.lbTenBan.Location = new Point(60, 80);
            this.lbTenBan.Size = new Size(120, 28);
            this.lbTenBan.Text = "Tên bàn";
            this.lbTenBan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new Point(190, 80);
            this.txtTenBan.Size = new Size(270, 30);

            // 
            // lbKhuVuc
            // 
            this.lbKhuVuc.Location = new Point(530, 30);
            this.lbKhuVuc.Size = new Size(120, 28);
            this.lbKhuVuc.Text = "Khu vực";
            this.lbKhuVuc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // 
            // txtKhuVuc
            // 
            this.txtKhuVuc.Location = new Point(660, 30);
            this.txtKhuVuc.Size = new Size(270, 30);

            // 
            // lbTrangThai
            // 
            this.lbTrangThai.Location = new Point(530, 80);
            this.lbTrangThai.Size = new Size(120, 28);
            this.lbTrangThai.Text = "Trạng thái";
            this.lbTrangThai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Location = new Point(660, 80);
            this.cboTrangThai.Size = new Size(270, 30);
            this.cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;

            // 
            // lbTimKiem
            // 
            this.lbTimKiem.Location = new Point(60, 140);
            this.lbTimKiem.Size = new Size(120, 28);
            this.lbTimKiem.Text = "Tìm kiếm";
            this.lbTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new Point(190, 140);
            this.txtTimKiem.Size = new Size(600, 30);

            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new Point(810, 136);
            this.btnTimKiem.Size = new Size(120, 38);
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnTimKiem.BackColor = Color.FromArgb(121, 85, 72);
            this.btnTimKiem.ForeColor = Color.White;
            this.btnTimKiem.FlatStyle = FlatStyle.Flat;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;

            this.pnlInput.Controls.Add(this.lbMaBan);
            this.pnlInput.Controls.Add(this.txtMaBan);
            this.pnlInput.Controls.Add(this.lbTenBan);
            this.pnlInput.Controls.Add(this.txtTenBan);
            this.pnlInput.Controls.Add(this.lbKhuVuc);
            this.pnlInput.Controls.Add(this.txtKhuVuc);
            this.pnlInput.Controls.Add(this.lbTrangThai);
            this.pnlInput.Controls.Add(this.cboTrangThai);
            this.pnlInput.Controls.Add(this.lbTimKiem);
            this.pnlInput.Controls.Add(this.txtTimKiem);
            this.pnlInput.Controls.Add(this.btnTimKiem);

            // 
            // pnlAction
            // 
            this.pnlAction.Dock = DockStyle.Top;
            this.pnlAction.Height = 80;
            this.pnlAction.BackColor = Color.FromArgb(245, 239, 230);

            // 
            // btnThem
            // 
            this.btnThem.Location = new Point(190, 18);
            this.btnThem.Size = new Size(130, 45);
            this.btnThem.Text = "Thêm";
            this.btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnThem.BackColor = Color.FromArgb(76, 175, 80);
            this.btnThem.ForeColor = Color.White;
            this.btnThem.FlatStyle = FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;

            // 
            // btnSua
            // 
            this.btnSua.Location = new Point(340, 18);
            this.btnSua.Size = new Size(130, 45);
            this.btnSua.Text = "Sửa";
            this.btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSua.BackColor = Color.FromArgb(255, 152, 0);
            this.btnSua.ForeColor = Color.White;
            this.btnSua.FlatStyle = FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 0;

            // 
            // btnXoa
            // 
            this.btnXoa.Location = new Point(490, 18);
            this.btnXoa.Size = new Size(130, 45);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnXoa.BackColor = Color.FromArgb(183, 28, 28);
            this.btnXoa.ForeColor = Color.White;
            this.btnXoa.FlatStyle = FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;

            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new Point(640, 18);
            this.btnLamMoi.Size = new Size(130, 45);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLamMoi.BackColor = Color.FromArgb(96, 125, 139);
            this.btnLamMoi.ForeColor = Color.White;
            this.btnLamMoi.FlatStyle = FlatStyle.Flat;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;

            this.pnlAction.Controls.Add(this.btnThem);
            this.pnlAction.Controls.Add(this.btnSua);
            this.pnlAction.Controls.Add(this.btnXoa);
            this.pnlAction.Controls.Add(this.btnLamMoi);

            // 
            // pnlGrid
            // 
            this.pnlGrid.Dock = DockStyle.Fill;
            this.pnlGrid.Padding = new Padding(25);
            this.pnlGrid.BackColor = Color.FromArgb(245, 239, 230);

            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.Dock = DockStyle.Fill;
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.BackgroundColor = Color.White;
            this.dgvDanhSach.RowHeadersWidth = 55;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.pnlGrid.Controls.Add(this.dgvDanhSach);

            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlHeader);

            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlAction.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlInput;
        private Panel pnlAction;
        private Panel pnlGrid;

        private Label lblTitle;
        private Label lbMaBan;
        private Label lbTenBan;
        private Label lbKhuVuc;
        private Label lbTrangThai;
        private Label lbTimKiem;

        private TextBox txtMaBan;
        private TextBox txtTenBan;
        private TextBox txtKhuVuc;
        private ComboBox cboTrangThai;
        private TextBox txtTimKiem;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnTimKiem;

        private DataGridView dgvDanhSach;


    }
}