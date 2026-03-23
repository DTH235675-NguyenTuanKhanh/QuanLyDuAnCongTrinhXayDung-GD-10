using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QuanLyDuAnCongTrinhXayDung.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QuanLyDuAnCongTrinhXayDung.Reports
{
    public partial class frmInPhanPhoi : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        QLDACTXDDataSet.DanhSachPhanPhoiChiTietDataTable danhSachPhanPhoiChiTietDataTable = new QLDACTXDDataSet.DanhSachPhanPhoiChiTietDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net9.0-windows", "Reports");
        int id;
        public frmInPhanPhoi(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;
        }

        private void frmInPhanPhoi_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ID đang tìm: " + id);
            // 1. Lấy thông tin bảng cha (DanhSachPhanPhoi)
            var phanPhoi = context.PhanPhoi
                                  .Include(p => p.DuAn)
                                  .Include(r => r.ChiTietPhanPhoi)
                                  .Where(r => r.ID == id)
                                  .SingleOrDefault();

            if (phanPhoi != null)
            {
                // 2. Lấy danh sách chi tiết theo ID phân phối
                var chiTiet = context.PhanPhoiChiTiet
                      .Include(r => r.VatTu) // QUAN TRỌNG: Phải nạp bảng Vật Tư
                      .Include(r => r.DuAn)  // QUAN TRỌNG: Phải nạp bảng Dự Án
                      .Where(r => r.PhanPhoiID == id) // Mở comment dòng này để lọc đúng theo ID = 1
                      .Select(r => new DanhSachPhanPhoiChiTiet
                      {
                          ID = r.ID,
                          PhanPhoiID = r.PhanPhoiID,
                          TenVatTu = r.VatTu.TenVatTu, // Sẽ bị null nếu không có Include
                          SoLuong = r.SoLuong,
                          DonGia = r.VatTu.DonGia,
                          TenDuAn = r.DuAn.TenDuAn,   // Sẽ bị null nếu không có Include
                          TongChiPhi = r.SoLuong * r.VatTu.DonGia
                      }).ToList();

                danhSachPhanPhoiChiTietDataTable.Clear();
                foreach (var row in chiTiet)
                {
                    danhSachPhanPhoiChiTietDataTable.AddDanhSachPhanPhoiChiTietRow(
                        row.ID,
                        row.PhanPhoiID,
                        row.TenVatTu,
                        row.SoLuong,
                        row.DonGia,
                        row.TenDuAn,
                        row.TongChiPhi);
                }
                MessageBox.Show("Tìm thấy " + danhSachPhanPhoiChiTietDataTable.Rows.Count + " dòng vật tư.");
                // 3. Cấu hình Report Viewer
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DanhSachPhanPhoiChiTiet"; // Khớp với Name trong RDLC
                reportDataSource.Value = danhSachPhanPhoiChiTietDataTable;

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);
                reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptInPhanPhoi.rdlc");

                // 4. Thiết lập Parameters cho báo cáo
                IList<ReportParameter> param = new List<ReportParameter>
                {
                    new ReportParameter("NgayLap", phanPhoi.NgayLap.ToString("dd/MM/yyyy")),
                    new ReportParameter("NguoiPhanPhoi", "CÔNG TY TNHH KIEN HUNG NAM LONG"),
                    new ReportParameter("SoThue_PhanPhoi", "04387655432"),
                    new ReportParameter("DiaChi_PhanPhoi", "Mỹ Phước, TP. Long Xuyên, An Giang"),
                    new ReportParameter("NguoiNhan", phanPhoi.DuAn.TenDuAn),
                    new ReportParameter("SoThue_NguoiNhan", "0123456789"),
                    new ReportParameter("DiaChi_NguoiNhan", phanPhoi.DuAn.DiaDiem),
                    // Tổng chi phí của cả phiếu phân phối
                    new ReportParameter("TongCong", phanPhoi.ChiTietPhanPhoi.Sum(r => r.SoLuong * r.DonGia).ToString("N0"))
                };

                reportViewer.LocalReport.SetParameters(param);
                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;
                reportViewer.RefreshReport();
            }
        }
    }
}
