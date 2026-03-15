using QuanLyDuAnCongTrinhXayDung.Data;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLyDuAnCongTrinhXayDung.Reports
{
    public partial class frmThongKeVatTu : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        QLDACTXDDataSet.DanhSachVatTuDataTable danhSachVatTuDataTable = new QLDACTXDDataSet.DanhSachVatTuDataTable();

        // 2. Cấu hình đường dẫn (Đã sửa từ net5.0 thành net8.0 để khớp với lỗi thực tế bạn gặp)
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net9.0-windows", "Reports");
        public frmThongKeVatTu()
        {
            InitializeComponent();
        }
        
        private void frmThongKeVatTu_Load(object sender, EventArgs e)
        {
            try
            {
                // 3. Truy vấn dữ liệu từ bảng VatTu (Dựa trên class VatTu trong code của bạn)
                var danhSachVatTu = context.VatTu.Select(r => new DanhSachVatTu
                {
                    ID = r.ID,
                    TenVatTu = r.TenVatTu,
                    DonViTinh = r.DonViTinh,
                    DonGia = r.DonGia,
                    HinhAnh = r.HinhAnh
                }).ToList();

                // 4. Xóa dữ liệu cũ và đổ dữ liệu mới vào DataTable của DataSet
                danhSachVatTuDataTable.Clear();
                foreach (var row in danhSachVatTu)
                {
                    danhSachVatTuDataTable.AddDanhSachVatTuRow(
                        row.ID,
                        row.TenVatTu,
                        row.DonViTinh,
                        row.DonGia,
                        row.HinhAnh ?? "" // Xử lý null nếu cần
                    );
                }

                // 5. Cấu hình ReportViewer để hiển thị file .rdlc
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DanhSachVatTu"; 
                reportDataSource.Value = danhSachVatTuDataTable;

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);

                // 6. Kết nối đường dẫn file rptVatTu.rdlc
                string reportPath = Path.Combine(reportsFolder, "rptThongKeVatTu.rdlc");
                reportViewer.LocalReport.ReportPath = reportPath;

                // 7. Định dạng hiển thị
                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;

                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị báo cáo: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
