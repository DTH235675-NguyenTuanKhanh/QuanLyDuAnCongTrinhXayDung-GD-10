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
    public partial class frmThongKeChiPhi : Form
    {
        // 1. Khởi tạo Context để kết nối cơ sở dữ liệu
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        QLDACTXDDataSet.DanhSachPhanPhoiDataTable danhSachPhanPhoiDataTable = new QLDACTXDDataSet.DanhSachPhanPhoiDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net9.0-windows", "Reports");
        public frmThongKeChiPhi()
        {
            InitializeComponent();
        }

        private void frmThongKeChiPhi_Load(object sender, EventArgs e)
        {
            try
            {

                var query = context.PhanPhoi.Select(r => new DanhSachPhanPhoi
                {

                    // Nếu DataSet của bạn có cột Dự án hoặc Ngày, hãy thêm vào đây
                    ID = r.ID,
                    DuAnID = r.DuAnID,
                    TenDuAn = r.DuAn.TenDuAn,
                    NgayLap = r.NgayLap,
                    TongChiPhi = r.ChiTietPhanPhoi.Sum(ct => ct.SoLuong * ct.VatTu.DonGia)
                }).ToList();

                // 2. Làm sạch DataTable
                danhSachPhanPhoiDataTable.Clear();

                // 3. Nạp dữ liệu vào DataTable
                foreach (var row in query)
                {
                    // LƯU Ý: Bạn phải truyền ĐỦ tham số mà DataTable yêu cầu
                    // Chuột phải vào AddDanhSachChiPhiRow -> Go to Definition để xem thứ tự cột
                    danhSachPhanPhoiDataTable.AddDanhSachPhanPhoiRow(
                      row.ID,
                      row.DuAnID,
                        row.TenDuAn,
                        row.NgayLap,
                        row.GhiChu ?? string.Empty, // Nếu GhiChu có thể null, hãy xử lý để tránh lỗi
                        row.TongChiPhi
                    );
                }

                // 4. Đổ dữ liệu vào ReportViewer
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DanhSachPhanPhoi"; // Phải khớp với Dataset Name trong file .rdlc
                rds.Value = danhSachPhanPhoiDataTable;

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(rds);

                // 5. Thiết lập đường dẫn và chế độ hiển thị
                string reportPath = Path.Combine(reportsFolder, "rptThongKeChiPhi.rdlc");
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("Không tìm thấy file báo cáo tại: " + reportPath);
                    return;
                }
                reportViewer.LocalReport.ReportPath = reportPath;

                // SAU ĐÓ MỚI SET PARAMETER
                ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả thời gian)");
                reportViewer.LocalReport.SetParameters(reportParameter);

                // CÁC THIẾT LẬP CÒN LẠI
                reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;

                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Lỗi hiển thị báo cáo: " + msg);
            }
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            var danhSachPhanPhoi = context.PhanPhoi.Where(r => r.NgayLap >= dtpTuNgay.Value && r.NgayLap <= dtpDenNgay.Value).Select(r => new DanhSachPhanPhoi
            {
                ID = r.ID,
                DuAnID = r.DuAnID,
                TenDuAn = r.DuAn.TenDuAn,
                NgayLap = r.NgayLap,
                GhiChu = r.GhiChu ?? string.Empty,
                TongChiPhi = r.ChiTietPhanPhoi.Sum(ct => ct.SoLuong * ct.VatTu.DonGia)
            }).ToList();
            danhSachPhanPhoiDataTable.Clear();
            foreach (var row in danhSachPhanPhoi)
            {
                danhSachPhanPhoiDataTable.AddDanhSachPhanPhoiRow(
                    row.ID,
                    row.DuAnID,
                    row.TenDuAn,
                    row.NgayLap,
                    row.GhiChu ?? string.Empty,
                    row.TongChiPhi
                );
            }
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachPhanPhoi";
            reportDataSource.Value = danhSachPhanPhoiDataTable;
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            string reportPath = Path.Combine(reportsFolder, "rptThongKeChiPhi.rdlc");
            if (!File.Exists(reportPath))
            {
                MessageBox.Show("Không tìm thấy file báo cáo tại: " + reportPath);
                return;
            }
            reportViewer.LocalReport.ReportPath = reportPath;

            // SAU ĐÓ MỚI SET PARAMETER
            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả thời gian)");
            reportViewer.LocalReport.SetParameters(reportParameter);

            // CÁC THIẾT LẬP CÒN LẠI
            reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;

            reportViewer.RefreshReport();
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            frmThongKeChiPhi_Load(sender, e);
        }
    }
}
