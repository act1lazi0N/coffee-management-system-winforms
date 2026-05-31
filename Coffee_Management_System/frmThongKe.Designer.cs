using System.Drawing;
using System.Windows.Forms;

namespace Coffee_Management_System
{
    partial class frmThongKe
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

            this.pnlFilter = new Panel();
            this.lbTuNgay = new Label();
            this.lbDenNgay = new Label();
            this.lbTrangThai = new Label();

            this.dtpTuNgay = new DateTimePicker();
            this.dtpDenNgay = new DateTimePicker();
            this.cboTrangThai = new ComboBox();

            this.btnThongKe = new Button();
            this.btnLamMoi = new Button();

            this.pnlCards = new TableLayoutPanel();

            this.lblTongHoaDon = new Label();
            this.lblTongDoanhThu = new Label();
            this.lblDaThanhToan = new Label();
            this.lblChuaThanhToan = new Label();

            this.tabThongKe = new TabControl();

            this.tabHoaDon = new TabPage();
            this.tabDoanhThuNgay = new TabPage();
            this.tabDoanhThuBan = new TabPage();
            this.tabMonBanChay = new TabPage();

            this.dgvHoaDon = new DataGridView();
            this.dgvDoanhThuNgay = new DataGridView();
            this.dgvDoanhThuBan = new DataGridView();
            this.dgvMonBanChay = new DataGridView();

            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlCards.SuspendLayout();

            this.tabThongKe.SuspendLayout();
            this.tabHoaDon.SuspendLayout();
            this.tabDoanhThuNgay.SuspendLayout();
            this.tabDoanhThuBan.SuspendLayout();
            this.tabMonBanChay.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonBanChay)).BeginInit();

            this.SuspendLayout();

            // frmThongKe
            this.AutoScaleDimensions = new SizeF(144F, 144F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.ClientSize = new Size(1150, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.BackColor = Color.FromArgb(245, 239, 230);
            this.Font = new Font("Segoe UI", 10F);

            // pnlHeader
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Height = 80;
            this.pnlHeader.BackColor = Color.FromArgb(78, 52, 46);

            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.Text = "THỐNG KÊ QUÁN CÀ PHÊ";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;

            this.pnlHeader.Controls.Add(this.lblTitle);

            // pnlFilter
            this.pnlFilter.Dock = DockStyle.Top;
            this.pnlFilter.Height = 90;
            this.pnlFilter.BackColor = Color.FromArgb(255, 243, 224);

            this.lbTuNgay.Location = new Point(40, 30);
            this.lbTuNgay.Size = new Size(90, 28);
            this.lbTuNgay.Text = "Từ ngày";
            this.lbTuNgay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.dtpTuNgay.Location = new Point(130, 30);
            this.dtpTuNgay.Size = new Size(180, 30);
            this.dtpTuNgay.Format = DateTimePickerFormat.Custom;
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";

            this.lbDenNgay.Location = new Point(340, 30);
            this.lbDenNgay.Size = new Size(100, 28);
            this.lbDenNgay.Text = "Đến ngày";
            this.lbDenNgay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.dtpDenNgay.Location = new Point(445, 30);
            this.dtpDenNgay.Size = new Size(180, 30);
            this.dtpDenNgay.Format = DateTimePickerFormat.Custom;
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";

            this.lbTrangThai.Location = new Point(655, 30);
            this.lbTrangThai.Size = new Size(100, 28);
            this.lbTrangThai.Text = "Trạng thái";
            this.lbTrangThai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.cboTrangThai.Location = new Point(765, 30);
            this.cboTrangThai.Size = new Size(170, 30);
            this.cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;

            this.btnThongKe.Location = new Point(960, 25);
            this.btnThongKe.Size = new Size(120, 40);
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnThongKe.BackColor = Color.FromArgb(121, 85, 72);
            this.btnThongKe.ForeColor = Color.White;
            this.btnThongKe.FlatStyle = FlatStyle.Flat;
            this.btnThongKe.FlatAppearance.BorderSize = 0;

            this.btnLamMoi.Location = new Point(1090, 25);
            this.btnLamMoi.Size = new Size(45, 40);
            this.btnLamMoi.Text = "↻";
            this.btnLamMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnLamMoi.BackColor = Color.FromArgb(96, 125, 139);
            this.btnLamMoi.ForeColor = Color.White;
            this.btnLamMoi.FlatStyle = FlatStyle.Flat;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;

            this.pnlFilter.Controls.Add(this.lbTuNgay);
            this.pnlFilter.Controls.Add(this.dtpTuNgay);
            this.pnlFilter.Controls.Add(this.lbDenNgay);
            this.pnlFilter.Controls.Add(this.dtpDenNgay);
            this.pnlFilter.Controls.Add(this.lbTrangThai);
            this.pnlFilter.Controls.Add(this.cboTrangThai);
            this.pnlFilter.Controls.Add(this.btnThongKe);
            this.pnlFilter.Controls.Add(this.btnLamMoi);

            // pnlCards
            this.pnlCards.Dock = DockStyle.Top;
            this.pnlCards.Height = 110;
            this.pnlCards.Padding = new Padding(25, 15, 25, 15);
            this.pnlCards.ColumnCount = 4;
            this.pnlCards.RowCount = 1;
            this.pnlCards.BackColor = Color.FromArgb(245, 239, 230);

            this.pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            this.lblTongHoaDon = CreateCardLabel("Tổng hóa đơn\n0");
            this.lblTongDoanhThu = CreateCardLabel("Tổng doanh thu\n0đ");
            this.lblDaThanhToan = CreateCardLabel("Đã thanh toán\n0");
            this.lblChuaThanhToan = CreateCardLabel("Chưa thanh toán\n0");

            this.pnlCards.Controls.Add(this.lblTongHoaDon, 0, 0);
            this.pnlCards.Controls.Add(this.lblTongDoanhThu, 1, 0);
            this.pnlCards.Controls.Add(this.lblDaThanhToan, 2, 0);
            this.pnlCards.Controls.Add(this.lblChuaThanhToan, 3, 0);

            // tabThongKe
            this.tabThongKe.Dock = DockStyle.Fill;
            this.tabThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.tabHoaDon.Text = "Hóa đơn";
            this.tabDoanhThuNgay.Text = "Doanh thu theo ngày";
            this.tabDoanhThuBan.Text = "Doanh thu theo bàn";
            this.tabMonBanChay.Text = "Món bán chạy";

            SetupGrid(this.dgvHoaDon);
            SetupGrid(this.dgvDoanhThuNgay);
            SetupGrid(this.dgvDoanhThuBan);
            SetupGrid(this.dgvMonBanChay);

            this.tabHoaDon.Controls.Add(this.dgvHoaDon);
            this.tabDoanhThuNgay.Controls.Add(this.dgvDoanhThuNgay);
            this.tabDoanhThuBan.Controls.Add(this.dgvDoanhThuBan);
            this.tabMonBanChay.Controls.Add(this.dgvMonBanChay);

            this.tabThongKe.Controls.Add(this.tabHoaDon);
            this.tabThongKe.Controls.Add(this.tabDoanhThuNgay);
            this.tabThongKe.Controls.Add(this.tabDoanhThuBan);
            this.tabThongKe.Controls.Add(this.tabMonBanChay);

            this.Controls.Add(this.tabThongKe);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);

            this.pnlHeader.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlCards.ResumeLayout(false);

            this.tabThongKe.ResumeLayout(false);
            this.tabHoaDon.ResumeLayout(false);
            this.tabDoanhThuNgay.ResumeLayout(false);
            this.tabDoanhThuBan.ResumeLayout(false);
            this.tabMonBanChay.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonBanChay)).EndInit();

            this.ResumeLayout(false);
        }
        private void SetupGrid(DataGridView dgv)
        {
            dgv.Dock = DockStyle.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.RowHeadersWidth = 50;
        }
        private Label CreateCardLabel(string text)
        {
            Label lbl = new Label();

            lbl.Dock = DockStyle.Fill;
            lbl.Margin = new Padding(10);
            lbl.Text = text;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl.BackColor = Color.White;
            lbl.ForeColor = Color.FromArgb(78, 52, 46);

            return lbl;
        }

        #endregion
        private Panel pnlHeader;
        private Label lblTitle;

        private Panel pnlFilter;
        private Label lbTuNgay;
        private Label lbDenNgay;
        private Label lbTrangThai;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private ComboBox cboTrangThai;
        private Button btnThongKe;
        private Button btnLamMoi;

        private TableLayoutPanel pnlCards;
        private Label lblTongHoaDon;
        private Label lblTongDoanhThu;
        private Label lblDaThanhToan;
        private Label lblChuaThanhToan;

        private TabControl tabThongKe;
        private TabPage tabHoaDon;
        private TabPage tabDoanhThuNgay;
        private TabPage tabDoanhThuBan;
        private TabPage tabMonBanChay;

        private DataGridView dgvHoaDon;
        private DataGridView dgvDoanhThuNgay;
        private DataGridView dgvDoanhThuBan;
        private DataGridView dgvMonBanChay;
    }
}