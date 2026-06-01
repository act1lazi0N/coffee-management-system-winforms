using System.Drawing;
using System.Windows.Forms;

namespace Coffee_Management_System
{
    partial class frmTaiKhoan
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

            this.pnlInput = new Panel();
            this.lbTenDangNhap = new Label();
            this.lbMatKhau = new Label();
            this.lbHoTen = new Label();
            this.lbVaiTro = new Label();
            this.lbTrangThai = new Label();
            this.lbTimKiem = new Label();

            this.txtTenDangNhap = new TextBox();
            this.txtMatKhau = new TextBox();
            this.txtHoTen = new TextBox();
            this.cboVaiTro = new ComboBox();
            this.cboTrangThai = new ComboBox();
            this.txtTimKiem = new TextBox();

            this.btnTimKiem = new Button();

            this.pnlAction = new Panel();
            this.btnThem = new Button();
            this.btnSua = new Button();
            this.btnXoa = new Button();
            this.btnLamMoi = new Button();
            this.btnKhoaMo = new Button();

            this.pnlGrid = new Panel();
            this.dgvDanhSach = new DataGridView();

            this.pnlHeader.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();

            this.SuspendLayout();

            // frmTaiKhoan
            this.AutoScaleDimensions = new SizeF(144F, 144F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.ClientSize = new Size(1050, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.BackColor = Color.FromArgb(245, 239, 230);
            this.Font = new Font("Segoe UI", 10F);

            // pnlHeader
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Height = 85;
            this.pnlHeader.BackColor = Color.FromArgb(78, 52, 46);

            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.Text = "QUẢN LÝ TÀI KHOẢN";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;

            this.pnlHeader.Controls.Add(this.lblTitle);

            // pnlInput
            this.pnlInput.Dock = DockStyle.Top;
            this.pnlInput.Height = 220;
            this.pnlInput.BackColor = Color.FromArgb(255, 243, 224);

            this.lbTenDangNhap.Location = new Point(50, 30);
            this.lbTenDangNhap.Size = new Size(150, 28);
            this.lbTenDangNhap.Text = "Tên đăng nhập";
            this.lbTenDangNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.txtTenDangNhap.Location = new Point(210, 30);
            this.txtTenDangNhap.Size = new Size(270, 30);

            this.lbMatKhau.Location = new Point(50, 80);
            this.lbMatKhau.Size = new Size(150, 28);
            this.lbMatKhau.Text = "Mật khẩu";
            this.lbMatKhau.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.txtMatKhau.Location = new Point(210, 80);
            this.txtMatKhau.Size = new Size(270, 30);

            this.lbHoTen.Location = new Point(50, 130);
            this.lbHoTen.Size = new Size(150, 28);
            this.lbHoTen.Text = "Họ tên";
            this.lbHoTen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.txtHoTen.Location = new Point(210, 130);
            this.txtHoTen.Size = new Size(270, 30);

            this.lbVaiTro.Location = new Point(550, 30);
            this.lbVaiTro.Size = new Size(130, 28);
            this.lbVaiTro.Text = "Vai trò";
            this.lbVaiTro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.cboVaiTro.Location = new Point(690, 30);
            this.cboVaiTro.Size = new Size(270, 30);
            this.cboVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;

            this.lbTrangThai.Location = new Point(550, 80);
            this.lbTrangThai.Size = new Size(130, 28);
            this.lbTrangThai.Text = "Trạng thái";
            this.lbTrangThai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.cboTrangThai.Location = new Point(690, 80);
            this.cboTrangThai.Size = new Size(270, 30);
            this.cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;

            this.lbTimKiem.Location = new Point(50, 180);
            this.lbTimKiem.Size = new Size(150, 28);
            this.lbTimKiem.Text = "Tìm kiếm";
            this.lbTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.txtTimKiem.Location = new Point(210, 180);
            this.txtTimKiem.Size = new Size(600, 30);

            this.btnTimKiem.Location = new Point(830, 176);
            this.btnTimKiem.Size = new Size(130, 38);
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnTimKiem.BackColor = Color.FromArgb(121, 85, 72);
            this.btnTimKiem.ForeColor = Color.White;
            this.btnTimKiem.FlatStyle = FlatStyle.Flat;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;

            this.pnlInput.Controls.Add(this.lbTenDangNhap);
            this.pnlInput.Controls.Add(this.txtTenDangNhap);
            this.pnlInput.Controls.Add(this.lbMatKhau);
            this.pnlInput.Controls.Add(this.txtMatKhau);
            this.pnlInput.Controls.Add(this.lbHoTen);
            this.pnlInput.Controls.Add(this.txtHoTen);
            this.pnlInput.Controls.Add(this.lbVaiTro);
            this.pnlInput.Controls.Add(this.cboVaiTro);
            this.pnlInput.Controls.Add(this.lbTrangThai);
            this.pnlInput.Controls.Add(this.cboTrangThai);
            this.pnlInput.Controls.Add(this.lbTimKiem);
            this.pnlInput.Controls.Add(this.txtTimKiem);
            this.pnlInput.Controls.Add(this.btnTimKiem);

            // pnlAction
            this.pnlAction.Dock = DockStyle.Top;
            this.pnlAction.Height = 85;
            this.pnlAction.BackColor = Color.FromArgb(245, 239, 230);

            this.btnThem = CreateActionButton("Thêm", 170, Color.FromArgb(76, 175, 80));
            this.btnSua = CreateActionButton("Sửa", 320, Color.FromArgb(255, 152, 0));
            this.btnXoa = CreateActionButton("Xóa", 470, Color.FromArgb(183, 28, 28));
            this.btnKhoaMo = CreateActionButton("Khóa/Mở", 620, Color.FromArgb(121, 85, 72));
            this.btnLamMoi = CreateActionButton("Làm mới", 770, Color.FromArgb(96, 125, 139));

            this.pnlAction.Controls.Add(this.btnThem);
            this.pnlAction.Controls.Add(this.btnSua);
            this.pnlAction.Controls.Add(this.btnXoa);
            this.pnlAction.Controls.Add(this.btnKhoaMo);
            this.pnlAction.Controls.Add(this.btnLamMoi);

            // pnlGrid
            this.pnlGrid.Dock = DockStyle.Fill;
            this.pnlGrid.Padding = new Padding(25);
            this.pnlGrid.BackColor = Color.FromArgb(245, 239, 230);

            this.dgvDanhSach.Dock = DockStyle.Fill;
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.BackgroundColor = Color.White;

            this.pnlGrid.Controls.Add(this.dgvDanhSach);

            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlHeader);

            this.pnlHeader.ResumeLayout(false);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlAction.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();

            this.ResumeLayout(false);
        }
        private Button CreateActionButton(string text, int x, Color color)
        {
            Button btn = new Button();

            btn.Location = new Point(x, 20);
            btn.Size = new Size(130, 45);
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            return btn;
        }
        #endregion

        private Panel pnlHeader;
        private Label lblTitle;

        private Panel pnlInput;
        private Label lbTenDangNhap;
        private Label lbMatKhau;
        private Label lbHoTen;
        private Label lbVaiTro;
        private Label lbTrangThai;
        private Label lbTimKiem;

        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private TextBox txtHoTen;
        private ComboBox cboVaiTro;
        private ComboBox cboTrangThai;
        private TextBox txtTimKiem;
        private Button btnTimKiem;

        private Panel pnlAction;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnKhoaMo;

        private Panel pnlGrid;
        private DataGridView dgvDanhSach;


    }
}