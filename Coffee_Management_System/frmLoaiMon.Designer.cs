using System.Drawing;
using System.Windows.Forms;

namespace Coffee_Management_System
{
    partial class frmLoaiMon
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
            this.pnlInput = new Panel();
            this.pnlAction = new Panel();
            this.pnlGrid = new Panel();

            this.lblTitle = new Label();

            this.lbMaLoai = new Label();
            this.lbTenLoai = new Label();
            this.lbGhiChu = new Label();
            this.lbTimKiem = new Label();

            this.txtMaLoai = new TextBox();
            this.txtTenLoai = new TextBox();
            this.txtGhiChu = new TextBox();
            this.txtTimKiem = new TextBox();

            this.btnThem = new Button();
            this.btnSua = new Button();
            this.btnXoa = new Button();
            this.btnLamMoi = new Button();
            this.btnTimKiem = new Button();

            this.dgvDanhSach = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.SuspendLayout();

            // frmLoaiMon
            this.AutoScaleDimensions = new SizeF(144F, 144F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.ClientSize = new Size(1000, 620);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản lý loại món";
            this.BackColor = Color.FromArgb(245, 239, 230);
            this.Font = new Font("Segoe UI", 10F);

            // pnlHeader
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Height = 85;
            this.pnlHeader.BackColor = Color.FromArgb(78, 52, 46);

            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.Text = "QUẢN LÝ LOẠI MÓN";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;

            this.pnlHeader.Controls.Add(this.lblTitle);

            // pnlInput
            this.pnlInput.Dock = DockStyle.Top;
            this.pnlInput.Height = 190;
            this.pnlInput.BackColor = Color.FromArgb(255, 243, 224);

            this.lbMaLoai.Location = new Point(60, 30);
            this.lbMaLoai.Size = new Size(120, 28);
            this.lbMaLoai.Text = "Mã loại";
            this.lbMaLoai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.txtMaLoai.Location = new Point(190, 30);
            this.txtMaLoai.Size = new Size(270, 30);

            this.lbTenLoai.Location = new Point(60, 80);
            this.lbTenLoai.Size = new Size(120, 28);
            this.lbTenLoai.Text = "Tên loại";
            this.lbTenLoai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.txtTenLoai.Location = new Point(190, 80);
            this.txtTenLoai.Size = new Size(270, 30);

            this.lbGhiChu.Location = new Point(530, 30);
            this.lbGhiChu.Size = new Size(120, 28);
            this.lbGhiChu.Text = "Ghi chú";
            this.lbGhiChu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.txtGhiChu.Location = new Point(660, 30);
            this.txtGhiChu.Size = new Size(270, 80);
            this.txtGhiChu.Multiline = true;

            this.lbTimKiem.Location = new Point(60, 140);
            this.lbTimKiem.Size = new Size(120, 28);
            this.lbTimKiem.Text = "Tìm kiếm";
            this.lbTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.txtTimKiem.Location = new Point(190, 140);
            this.txtTimKiem.Size = new Size(600, 30);

            this.btnTimKiem.Location = new Point(810, 136);
            this.btnTimKiem.Size = new Size(120, 38);
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnTimKiem.BackColor = Color.FromArgb(121, 85, 72);
            this.btnTimKiem.ForeColor = Color.White;
            this.btnTimKiem.FlatStyle = FlatStyle.Flat;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;

            this.pnlInput.Controls.Add(this.lbMaLoai);
            this.pnlInput.Controls.Add(this.txtMaLoai);
            this.pnlInput.Controls.Add(this.lbTenLoai);
            this.pnlInput.Controls.Add(this.txtTenLoai);
            this.pnlInput.Controls.Add(this.lbGhiChu);
            this.pnlInput.Controls.Add(this.txtGhiChu);
            this.pnlInput.Controls.Add(this.lbTimKiem);
            this.pnlInput.Controls.Add(this.txtTimKiem);
            this.pnlInput.Controls.Add(this.btnTimKiem);

            // pnlAction
            this.pnlAction.Dock = DockStyle.Top;
            this.pnlAction.Height = 80;
            this.pnlAction.BackColor = Color.FromArgb(245, 239, 230);

            this.btnThem = CreateActionButton("Thêm", 190, Color.FromArgb(76, 175, 80));
            this.btnSua = CreateActionButton("Sửa", 340, Color.FromArgb(255, 152, 0));
            this.btnXoa = CreateActionButton("Xóa", 490, Color.FromArgb(183, 28, 28));
            this.btnLamMoi = CreateActionButton("Làm mới", 640, Color.FromArgb(96, 125, 139));

            this.pnlAction.Controls.Add(this.btnThem);
            this.pnlAction.Controls.Add(this.btnSua);
            this.pnlAction.Controls.Add(this.btnXoa);
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

            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlAction.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private Button CreateActionButton(string text, int x, Color color)
        {
            Button btn = new Button();

            btn.Location = new Point(x, 18);
            btn.Size = new Size(130, 45);
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            return btn;
        }

        private Panel pnlHeader;
        private Panel pnlInput;
        private Panel pnlAction;
        private Panel pnlGrid;

        private Label lblTitle;
        private Label lbMaLoai;
        private Label lbTenLoai;
        private Label lbGhiChu;
        private Label lbTimKiem;

        private TextBox txtMaLoai;
        private TextBox txtTenLoai;
        private TextBox txtGhiChu;
        private TextBox txtTimKiem;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnTimKiem;

        private DataGridView dgvDanhSach;

        #endregion
    }
}