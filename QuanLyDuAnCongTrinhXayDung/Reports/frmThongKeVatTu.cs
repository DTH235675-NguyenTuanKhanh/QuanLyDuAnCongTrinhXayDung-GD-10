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
        public void LayVatTuVaoComboBox()
        {
            var dsVatTu = context.VatTu.ToList();
            cboTenVatTu.DataSource = dsVatTu;
            cboTenVatTu.ValueMember = "ID";
            cboTenVatTu.DisplayMember = "TenVatTu";
            cboTenVatTu.SelectedIndex = -1; 
        }
        private void frmThongKeVatTu_Load(object sender, EventArgs e)
        {
            LayVatTuVaoComboBox();
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
                ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả Vật Tư)");
                reportViewer.LocalReport.SetParameters(reportParameter);

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

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            if (cboTenVatTu.Text == "" && cboTenVatTu.Text == "")
            {
                // Nếu cả 2 ComboBox đều bỏ trống thì hiển thị tất cả
                frmThongKeVatTu_Load(sender, e);
            }
            else
            {
                try
                {
                    int vatTuID = (int)cboTenVatTu.SelectedValue;
                    var danhSachVatTu = context.VatTu.Where(r => r.ID == vatTuID).Select(r => new DanhSachVatTu
                    {
                        ID = r.ID,
                        TenVatTu = r.TenVatTu,
                        DonViTinh = r.DonViTinh,
                        DonGia = r.DonGia,
                        HinhAnh = r.HinhAnh
                    }).ToList();
                    // Cập nhật DataTable và ReportViewer tương tự như trong frmThongKeVatTu_Load
                    danhSachVatTuDataTable.Clear();
                    foreach (var row in danhSachVatTu)
                    {
                        danhSachVatTuDataTable.AddDanhSachVatTuRow(
                            row.ID,
                            row.TenVatTu,
                            row.DonViTinh,
                            row.DonGia,
                            row.HinhAnh ?? ""
                        );
                    }
                    ReportDataSource reportDataSource = new ReportDataSource();
                    reportDataSource.Name = "DanhSachVatTu";
                    reportDataSource.Value = danhSachVatTuDataTable;
                    reportViewer.LocalReport.DataSources.Clear();
                    reportViewer.LocalReport.DataSources.Add(reportDataSource);
                    string reportPath = Path.Combine(reportsFolder, "rptThongKeVatTu.rdlc");
                    reportViewer.LocalReport.ReportPath = reportPath;
                    ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", $"(Lọc theo Vật Tư: {cboTenVatTu.Text})");
                    reportViewer.LocalReport.SetParameters(reportParameter);
                    reportViewer.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lọc báo cáo: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
