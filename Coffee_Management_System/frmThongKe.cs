using BUS;
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
    public partial class frmThongKe : Form
    {
        BUS_ThongKe bus = new BUS_ThongKe();

        public frmThongKe()
        {
            InitializeComponent();

            this.Load += frmThongKe_Load;

            btnThongKe.Click += btnThongKe_Click;
            btnLamMoi.Click += btnLamMoi_Click;
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Tất cả");
            cboTrangThai.Items.Add("Chưa thanh toán");
            cboTrangThai.Items.Add("Đã thanh toán");

            cboTrangThai.SelectedIndex = 0;

            dtpTuNgay.Value = DateTime.Now.AddDays(-30);
            dtpDenNgay.Value = DateTime.Now;

            thongKe();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            thongKe();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            bus.reload();
            thongKe();
        }

        private void thongKe()
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;
            string trangthai = cboTrangThai.Text;

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Từ ngày không được lớn hơn đến ngày!");
                return;
            }

            dgvHoaDon.DataSource = bus.getHoaDonTheoDieuKien(tuNgay, denNgay, trangthai);
            dgvDoanhThuNgay.DataSource = bus.getDoanhThuTheoNgay(tuNgay, denNgay, trangthai);
            dgvDoanhThuBan.DataSource = bus.getDoanhThuTheoBan(tuNgay, denNgay, trangthai);
            dgvMonBanChay.DataSource = bus.getMonBanChay(tuNgay, denNgay, trangthai);

            int tongHD = bus.getTongHoaDon(tuNgay, denNgay, trangthai);
            double tongDT = bus.getTongDoanhThu(tuNgay, denNgay, trangthai);
            int daTT = bus.getSoHoaDonTheoTrangThai(tuNgay, denNgay, "Đã thanh toán");
            int chuaTT = bus.getSoHoaDonTheoTrangThai(tuNgay, denNgay, "Chưa thanh toán");

            lblTongHoaDon.Text = "Tổng hóa đơn\n" + tongHD;
            lblTongDoanhThu.Text = "Tổng doanh thu\n" + tongDT.ToString("N0") + "đ";
            lblDaThanhToan.Text = "Đã thanh toán\n" + daTT;
            lblChuaThanhToan.Text = "Chưa thanh toán\n" + chuaTT;

            formatGrid();
        }

        private void formatGrid()
        {
            if (dgvHoaDon.Columns.Contains("mahd"))
                dgvHoaDon.Columns["mahd"].HeaderText = "Mã HĐ";

            if (dgvHoaDon.Columns.Contains("maban"))
                dgvHoaDon.Columns["maban"].HeaderText = "Mã bàn";

            if (dgvHoaDon.Columns.Contains("ngaylap"))
                dgvHoaDon.Columns["ngaylap"].HeaderText = "Ngày lập";

            if (dgvHoaDon.Columns.Contains("trangthai"))
                dgvHoaDon.Columns["trangthai"].HeaderText = "Trạng thái";

            if (dgvHoaDon.Columns.Contains("tongtien"))
                dgvHoaDon.Columns["tongtien"].HeaderText = "Tổng tiền";

            if (dgvDoanhThuNgay.Columns.Contains("ngay"))
                dgvDoanhThuNgay.Columns["ngay"].HeaderText = "Ngày";

            if (dgvDoanhThuNgay.Columns.Contains("sohoadon"))
                dgvDoanhThuNgay.Columns["sohoadon"].HeaderText = "Số hóa đơn";

            if (dgvDoanhThuNgay.Columns.Contains("doanhthu"))
                dgvDoanhThuNgay.Columns["doanhthu"].HeaderText = "Doanh thu";

            if (dgvDoanhThuBan.Columns.Contains("maban"))
                dgvDoanhThuBan.Columns["maban"].HeaderText = "Mã bàn";

            if (dgvDoanhThuBan.Columns.Contains("tenban"))
                dgvDoanhThuBan.Columns["tenban"].HeaderText = "Tên bàn";

            if (dgvDoanhThuBan.Columns.Contains("sohoadon"))
                dgvDoanhThuBan.Columns["sohoadon"].HeaderText = "Số hóa đơn";

            if (dgvDoanhThuBan.Columns.Contains("doanhthu"))
                dgvDoanhThuBan.Columns["doanhthu"].HeaderText = "Doanh thu";

            if (dgvMonBanChay.Columns.Contains("mamon"))
                dgvMonBanChay.Columns["mamon"].HeaderText = "Mã món";

            if (dgvMonBanChay.Columns.Contains("tenmon"))
                dgvMonBanChay.Columns["tenmon"].HeaderText = "Tên món";

            if (dgvMonBanChay.Columns.Contains("soluongban"))
                dgvMonBanChay.Columns["soluongban"].HeaderText = "Số lượng bán";

            if (dgvMonBanChay.Columns.Contains("doanhthu"))
                dgvMonBanChay.Columns["doanhthu"].HeaderText = "Doanh thu";
        }
    }
}
