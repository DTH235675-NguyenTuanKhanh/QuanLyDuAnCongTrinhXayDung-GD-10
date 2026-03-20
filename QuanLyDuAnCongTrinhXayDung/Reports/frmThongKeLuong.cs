using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyDuAnCongTrinhXayDung.Data; // Đảm bảo đúng namespace dự án của bạn
using DisplayMode = Microsoft.Reporting.WinForms.DisplayMode;
namespace QuanLyDuAnCongTrinhXayDung.Reports
{
    public partial class frmThongKeLuong : Form
    {
        // 1. Khởi tạo Context và DataTable phù hợp với dữ liệu Lương
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        QLDACTXDDataSet.DanhSachLuongDataTable danhSachLuongDataTable = new QLDACTXDDataSet.DanhSachLuongDataTable();

        // 2. Cấu hình đường dẫn khớp với phiên bản .NET bạn đang dùng (net9.0)
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net9.0-windows", "Reports");
        public frmThongKeLuong()
        {
            InitializeComponent();
        }
        public void LayNhanVienVaoComboBox()
        {
            List<NhanVien> dsNhanVien = context.NhanVien.ToList();
            cboTenNhanVien.DataSource = dsNhanVien;
            cboTenNhanVien.ValueMember = "ID";
            cboTenNhanVien.DisplayMember = "HoVaTen";
            cboTenNhanVien.SelectedIndex = -1;

        }
        public void LayThangVaoComboBox()
        {
            cboThang.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cboThang.Items.Add(i);
            }
            // Mặc định chọn tháng hiện tại
            cboThang.SelectedItem = DateTime.Now.Month;
        }
        public void LayNamVaoComboBox()
        {
            var danhSachNam = context.BangLuong
                             .Select(l => l.Nam)
                             .Distinct()
                             .OrderByDescending(n => n)
                             .ToList();

            // Nếu database chưa có dữ liệu, tự thêm năm hiện tại vào để tránh lỗi trống
            if (!danhSachNam.Contains(DateTime.Now.Year))
            {
                danhSachNam.Add(DateTime.Now.Year);
            }

            cboNam.DataSource = danhSachNam;
        }
        private void frmThongKeLuong_Load(object sender, EventArgs e)
        {
            LayNhanVienVaoComboBox();
            LayThangVaoComboBox();
            LayNamVaoComboBox();
            try
            {
                // 3. Truy vấn dữ liệu từ bảng BangLuong và NhanVien
                // Flatten dữ liệu để đưa vào DataTable phẳng
                var danhSachLuong = context.BangLuong.Select(r => new DanhSachBangLuong
                {
                    ID = r.ID,
                    NhanVienID = r.NhanVienID,
                    TenNhanVien = r.NhanVien.HoVaTen, // Giả sử thuộc tính là HoTen
                    Thang = r.Thang,
                    Nam = r.Nam,
                    SoNgayCong = r.SoNgayCong,
                    TongPhuCap = r.TongPhuCap,
                    ThucLinh = r.ThucLinh

                }).ToList();

                // 4. Xóa dữ liệu cũ và đổ dữ liệu mới vào DataTable của DataSet
                danhSachLuongDataTable.Clear();
                foreach (var row in danhSachLuong)
                {
                    danhSachLuongDataTable.AddDanhSachLuongRow(
                        row.ID,
                        row.NhanVienID,
                        row.TenNhanVien,
                        row.Thang,
                        row.Nam,
                        row.SoNgayCong,
                        row.TongPhuCap,
                        row.ThucLinh

                   );
                }

                // 5. Cấu hình nguồn dữ liệu cho Report
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DanhSachLuong"; // Tên này PHẢI trùng với tên trong file .rdlc
                reportDataSource.Value = danhSachLuongDataTable;

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);

                // 6. Kết nối file rptThongKeLuong.rdlc
                string reportPath = Path.Combine(reportsFolder, "rptThongKeLuong.rdlc");
                reportViewer.LocalReport.ReportPath = reportPath;
                ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "Tất cả lương Nhân viên");
                reportViewer.LocalReport.SetParameters(reportParameter);
                // 7. Định dạng hiển thị chuyên nghiệp
                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;

                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị báo cáo lương: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            if(cboTenNhanVien.SelectedIndex == -1 && cboThang.SelectedIndex == -1 && cboNam.SelectedIndex == -1)
            {
                frmThongKeLuong_Load(sender, e); // Load lại toàn bộ dữ liệu nếu không có bộ lọc nào được chọn
            }
            else
            {
                var danhSachLuong = context.BangLuong.Select(r => new DanhSachBangLuong
                {
                    ID = r.ID,
                    NhanVienID = r.NhanVienID,
                    TenNhanVien = r.NhanVien.HoVaTen,
                    Thang = r.Thang,
                    Nam = r.Nam,
                    SoNgayCong = r.SoNgayCong,
                    TongPhuCap = r.TongPhuCap,
                    ThucLinh = r.ThucLinh
                }).ToList();
                string tenNhanVien = null;
                string thang = null;
                string nam = null;
                if (cboTenNhanVien.SelectedIndex != -1)
                {
                    int tenNhanVienID = Convert.ToInt32(cboTenNhanVien.SelectedValue);
                    tenNhanVien = "Tên Nhân Viên: " + cboTenNhanVien.Text;
                    danhSachLuong = danhSachLuong.Where(r => r.NhanVienID == tenNhanVienID).ToList();
                }
                if (cboThang.SelectedIndex != -1)
                {
                    int thangLoc = Convert.ToInt32(cboThang.SelectedItem);
                    thang = "Tháng: " + cboThang.Text;
                    danhSachLuong = danhSachLuong.Where(r => r.Thang == thangLoc).ToList();
                }
                if (cboNam.SelectedIndex != -1)
                {
                    int namLoc = Convert.ToInt32(cboNam.SelectedValue);
                    nam = "Năm: " + cboNam.Text;
                    danhSachLuong = danhSachLuong.Where(r => r.Nam == namLoc).ToList();                   
                }
                danhSachLuongDataTable.Clear();
                foreach (var row in danhSachLuong)
                {
                    danhSachLuongDataTable.AddDanhSachLuongRow(
                        row.ID,
                        row.NhanVienID,
                        row.TenNhanVien,
                        row.Thang,
                        row.Nam,
                        row.SoNgayCong,
                        row.TongPhuCap,
                        row.ThucLinh
                   );
                }
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DanhSachLuong";
                reportDataSource.Value = danhSachLuongDataTable;
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);
                reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeLuong.rdlc"); ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(" + tenNhanVien + " - " + thang + "-" + nam + ")");
                reportViewer.LocalReport.SetParameters(reportParameter);
                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;
                reportViewer.RefreshReport();
            }
        }
    }
}
