using System.Drawing;
using System.Windows.Forms;

namespace Coffee_Management_System
{
    partial class frmMain
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
            this.pnlSidebar = new Panel();
            this.lblLogo = new Label();
            this.lblAppName = new Label();
            this.lblQuickMenu = new Label();

            this.btnLoaiMonSide = new Button();
            this.btnMonSide = new Button();
            this.btnBanSide = new Button();
            this.btnThongKeSide = new Button();
            this.btnDangXuat = new Button();

            this.pnlMain = new Panel();
            this.lblGreeting = new Label();
            this.lblInstruction = new Label();

            this.pnlCards = new TableLayoutPanel();

            this.btnLoaiMon = new Button();
            this.btnMon = new Button();
            this.btnBan = new Button();
            this.btnHoaDon = new Button();
            this.btnNhanVien = new Button();
            this.btnDoanhThu = new Button();

            this.lblFooterTitle = new Label();
            this.lblFooterInfo = new Label();

            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.SuspendLayout();

            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new SizeF(144F, 144F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.ClientSize = new Size(1100, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán cà phê";
            this.BackColor = Color.FromArgb(245, 239, 230);
            this.Font = new Font("Segoe UI", 10F);

            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Dock = DockStyle.Left;
            this.pnlSidebar.Width = 230;
            this.pnlSidebar.BackColor = Color.FromArgb(78, 52, 46);

            // 
            // lblLogo
            // 
            this.lblLogo.Location = new Point(0, 25);
            this.lblLogo.Size = new Size(230, 75);
            this.lblLogo.Text = "☕";
            this.lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            this.lblLogo.Font = new Font("Segoe UI Emoji", 38F, FontStyle.Bold);
            this.lblLogo.ForeColor = Color.FromArgb(255, 224, 178);

            // 
            // lblAppName
            // 
            this.lblAppName.Location = new Point(10, 100);
            this.lblAppName.Size = new Size(210, 55);
            this.lblAppName.Text = "COFFEE\r\nMANAGEMENT";
            this.lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            this.lblAppName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            this.lblAppName.ForeColor = Color.White;

            // 
            // lblQuickMenu
            // 
            this.lblQuickMenu.Location = new Point(20, 180);
            this.lblQuickMenu.Size = new Size(190, 30);
            this.lblQuickMenu.Text = "Phím tắt nhanh";
            this.lblQuickMenu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblQuickMenu.ForeColor = Color.FromArgb(255, 224, 178);

            // 
            // Sidebar buttons
            // 
            this.btnLoaiMonSide = CreateSidebarButton("Quản lý loại món", 225);
            this.btnMonSide = CreateSidebarButton("Quản lý món", 280);
            this.btnBanSide = CreateSidebarButton("Quản lý bàn", 335);
            this.btnThongKeSide = CreateSidebarButton("Xem thống kê", 390);
            this.btnDangXuat = CreateSidebarButton("Đăng xuất", 500);
            this.btnDangXuat.BackColor = Color.FromArgb(183, 28, 28);

            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.lblAppName);
            this.pnlSidebar.Controls.Add(this.lblQuickMenu);
            this.pnlSidebar.Controls.Add(this.btnLoaiMonSide);
            this.pnlSidebar.Controls.Add(this.btnMonSide);
            this.pnlSidebar.Controls.Add(this.btnBanSide);
            this.pnlSidebar.Controls.Add(this.btnThongKeSide);
            this.pnlSidebar.Controls.Add(this.btnDangXuat);

            // 
            // pnlMain
            // 
            this.pnlMain.Dock = DockStyle.Fill;
            this.pnlMain.BackColor = Color.FromArgb(245, 239, 230);

            // 
            // lblGreeting
            // 
            this.lblGreeting.Location = new Point(0, 45);
            this.lblGreeting.Size = new Size(870, 45);
            this.lblGreeting.Text = "Chào, Admin";
            this.lblGreeting.TextAlign = ContentAlignment.MiddleCenter;
            this.lblGreeting.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.lblGreeting.ForeColor = Color.FromArgb(62, 39, 35);

            // 
            // lblInstruction
            // 
            this.lblInstruction.Location = new Point(0, 95);
            this.lblInstruction.Size = new Size(870, 35);
            this.lblInstruction.Text = "Chọn chức năng bạn muốn làm";
            this.lblInstruction.TextAlign = ContentAlignment.MiddleCenter;
            this.lblInstruction.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblInstruction.ForeColor = Color.FromArgb(93, 64, 55);

            // 
            // pnlCards
            // 
            this.pnlCards.Location = new Point(95, 160);
            this.pnlCards.Size = new Size(680, 310);
            this.pnlCards.ColumnCount = 3;
            this.pnlCards.RowCount = 2;
            this.pnlCards.BackColor = Color.Transparent;

            this.pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            this.pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            this.pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));

            this.pnlCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.pnlCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            this.btnLoaiMon = CreateCardButton("📂\r\nLoại món");
            this.btnMon = CreateCardButton("🍵\r\nMón");
            this.btnBan = CreateCardButton("🪑\r\nBàn");
            this.btnHoaDon = CreateCardButton("🧾\r\nHóa đơn");
            this.btnNhanVien = CreateCardButton("👤\r\nNhân viên");
            this.btnDoanhThu = CreateCardButton("📊\r\nDoanh thu");

            this.pnlCards.Controls.Add(this.btnLoaiMon, 0, 0);
            this.pnlCards.Controls.Add(this.btnMon, 1, 0);
            this.pnlCards.Controls.Add(this.btnBan, 2, 0);
            this.pnlCards.Controls.Add(this.btnHoaDon, 0, 1);
            this.pnlCards.Controls.Add(this.btnNhanVien, 1, 1);
            this.pnlCards.Controls.Add(this.btnDoanhThu, 2, 1);

            // 
            // lblFooterTitle
            // 
            this.lblFooterTitle.Location = new Point(0, 505);
            this.lblFooterTitle.Size = new Size(870, 35);
            this.lblFooterTitle.Text = "COFFEE MANAGEMENT SYSTEM";
            this.lblFooterTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblFooterTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            this.lblFooterTitle.ForeColor = Color.FromArgb(183, 28, 28);

            // 
            // lblFooterInfo
            // 
            this.lblFooterInfo.Location = new Point(0, 540);
            this.lblFooterInfo.Size = new Size(870, 60);
            this.lblFooterInfo.Text = "Quản lý loại món - món - bàn - hóa đơn - doanh thu\r\nPhiên bản học tập theo mô hình 3 lớp";
            this.lblFooterInfo.TextAlign = ContentAlignment.TopCenter;
            this.lblFooterInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblFooterInfo.ForeColor = Color.FromArgb(121, 85, 72);

            this.pnlMain.Controls.Add(this.lblGreeting);
            this.pnlMain.Controls.Add(this.lblInstruction);
            this.pnlMain.Controls.Add(this.pnlCards);
            this.pnlMain.Controls.Add(this.lblFooterTitle);
            this.pnlMain.Controls.Add(this.lblFooterInfo);

            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);

            this.pnlSidebar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlCards.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private Button CreateSidebarButton(string text, int y)
        {
            Button btn = new Button();

            btn.Location = new Point(20, y);
            btn.Size = new Size(190, 42);
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn.BackColor = Color.FromArgb(121, 85, 72);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;

            return btn;
        }

        private Button CreateCardButton(string text)
        {
            Button btn = new Button();

            btn.Dock = DockStyle.Fill;
            btn.Margin = new Padding(16);
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn.BackColor = Color.White;
            btn.ForeColor = Color.FromArgb(62, 39, 35);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(215, 204, 200);
            btn.FlatAppearance.BorderSize = 1;
            btn.Cursor = Cursors.Hand;
            btn.TextAlign = ContentAlignment.MiddleCenter;

            return btn;
        }


        #endregion

        private Panel pnlSidebar;
        private Panel pnlMain;
        private Panel pnlHeader;

        private Label lblLogo;
        private Label lblAppName;
        private Label lblQuickMenu;

        private Button btnLoaiMonSide;
        private Button btnMonSide;
        private Button btnBanSide;
        private Button btnThongKeSide;
        private Button btnDangXuat;

        private Label lblGreeting;
        private Label lblInstruction;

        private TableLayoutPanel pnlCards;

        private Button btnLoaiMon;
        private Button btnMon;
        private Button btnBan;
        private Button btnHoaDon;
        private Button btnNhanVien;
        private Button btnDoanhThu;

        private Label lblFooterTitle;
        private Label lblFooterInfo;
    }
}

