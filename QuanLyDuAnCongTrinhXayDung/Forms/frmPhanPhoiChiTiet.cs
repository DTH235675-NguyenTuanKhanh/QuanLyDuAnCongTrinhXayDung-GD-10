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

namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    public partial class frmPhanPhoiChiTiet : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        int id; // Lấy mã hóa đơn (dùng cho Sửa và Xóa)
        BindingList<DanhSachPhanPhoiChiTiet> phanPhoiChiTiet = new BindingList<DanhSachPhanPhoiChiTiet>();
        public frmPhanPhoiChiTiet(int maPhanPhoi)
        {
            InitializeComponent();
            id = maPhanPhoi;
        }
        public void LayVatTuVaoComboBox()
        {
            cboVatTu.DataSource = context.VatTu.ToList();
            cboVatTu.ValueMember = "ID";
            cboVatTu.DisplayMember = "TenVatTu";
            cboVatTu.SelectedIndex = -1; // Không chọn gì lúc đầu
        }
        public void BatTatChucNang()
        {
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
            // Bạn có thể thêm btnLuu.Enabled tại đây nếu cần
        }

        private void TinhTongChiPhiHienThoi()
        {
            // Tính tổng tiền cho dòng đang nhập trên TextBox/Numeric
            decimal tongDong = numSoLuong.Value * numDonGia.Value;
            txtTongChiPhi.Text = tongDong.ToString("#,##0");
        }

        private void frmPhanPhoiChiTiet_Load(object sender, EventArgs e)
        {
            LayVatTuVaoComboBox();
            dataGridView.AutoGenerateColumns = false;

            if (id != 0) // Chế độ Sửa: Load dữ liệu từ CSDL
            {
                var query = context.PhanPhoiChiTiet
                    .Where(r => r.PhanPhoiID == id)
                    .Select(r => new DanhSachPhanPhoiChiTiet
                    {
                        ID = r.ID,
                        PhanPhoiID = r.PhanPhoiID,
                        VatTuID = r.VatTuID,
                        TenVatTu = r.VatTu.TenVatTu,
                        SoLuong = r.SoLuong,
                        DonGia = r.VatTu.DonGia,
                        TongChiPhi = (decimal)r.SoLuong * r.VatTu.DonGia
                    }).ToList();

                // Nạp kết quả vào BindingList đã khai báo ở đầu Form
                phanPhoiChiTiet = new BindingList<DanhSachPhanPhoiChiTiet>(query);
            }
            else
            {
                // Nếu là thêm mới, đảm bảo danh sách được khởi tạo trống
                phanPhoiChiTiet = new BindingList<DanhSachPhanPhoiChiTiet>();
            }

            // QUAN TRỌNG: Dòng này phải nằm ngoài IF để Grid luôn nhận diện danh sách
            dataGridView.DataSource = phanPhoiChiTiet;

            BatTatChucNang();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cboVatTu.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn vật tư.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numDonGia.Value <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 2. Lấy ID vật tư đang chọn
                int maVatTu = Convert.ToInt32(cboVatTu.SelectedValue.ToString());

                // 3. Tìm xem vật tư này đã có trong danh sách tạm (BindingList) chưa
                var chiTiet = phanPhoiChiTiet.FirstOrDefault(x => x.VatTuID == maVatTu);

                if (chiTiet != null)
                {
                    // --- TRƯỜNG HỢP ĐÃ CÓ: Cập nhật thông tin ---
                    chiTiet.SoLuong = Convert.ToInt32(numSoLuong.Value);
                    chiTiet.DonGia = numDonGia.Value;
                    // Tính toán tổng chi phí (Số lượng * Đơn giá)
                    chiTiet.TongChiPhi = numSoLuong.Value * numDonGia.Value;

                    // Làm mới DataGridView để hiển thị số liệu mới cập nhật
                    dataGridView.Refresh();
                }
                else
                {
                    // --- TRƯỜNG HỢP CHƯA CÓ: Thêm dòng mới ---
                    DanhSachPhanPhoiChiTiet ct = new DanhSachPhanPhoiChiTiet
                    {
                        ID = 0, // ID tạm, sẽ được DB cấp khi lưu chính thức
                        PhanPhoiID = id,
                        VatTuID = maVatTu,
                        TenVatTu = cboVatTu.Text,
                        SoLuong = Convert.ToInt32(numSoLuong.Value),
                        DonGia = numDonGia.Value,
                        TongChiPhi = numSoLuong.Value * numDonGia.Value
                    };

                    phanPhoiChiTiet.Add(ct);
                }

                // 4. Cập nhật lại trạng thái các nút (nếu có hàm này)
                BatTatChucNang();

                // (Tùy chọn) Xóa trắng hoặc reset ô nhập sau khi xác nhận thành công
                // cboVatTu.SelectedIndex = -1;
                // numSoLuong.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo");
                return;
            }

            // 2. Xác nhận trước khi xóa (Nên có để tránh bấm nhầm)
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa vật tư này khỏi danh sách chi tiết?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // 3. Lấy ID Vật tư của dòng đang chọn (Dựa vào cột VatTuID ẩn hoặc cột ID hiển thị)
                    // Lưu ý: "colVatTuID" là tên (Name) của cột chứa mã vật tư trong DataGridView
                    int maVT = Convert.ToInt32(dataGridView.CurrentRow.Cells["colVatTuID"].Value.ToString());

                    // 4. Tìm đối tượng trong BindingList khớp với mã vừa lấy
                    var chiTiet = phanPhoiChiTiet.FirstOrDefault(x => x.VatTuID == maVT);

                    if (chiTiet != null)
                    {
                        // 5. Xóa khỏi danh sách tạm (Giao diện sẽ tự cập nhật nhờ BindingList)
                        phanPhoiChiTiet.Remove(chiTiet);
                    }

                    // 6. Cập nhật lại trạng thái các nút (Ẩn nút Xóa nếu danh sách trống)
                    BatTatChucNang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Giả sử biến 'id' lưu mã Phân Phối truyền từ form danh sách
                if (id != 0) // Cập nhật phiếu cũ
                {
                    var pp = context.PhanPhoi.Find(id);
                    if (pp != null)
                    {
                        // Cập nhật thông tin phiếu (Ngày, Ghi chú...) nếu cần
                        // context.PhanPhoi.Update(pp);

                        // 1. Xóa chi tiết cũ của phiếu này
                        var oldDetails = context.PhanPhoiChiTiet.Where(r => r.PhanPhoiID == id).ToList();
                        context.PhanPhoiChiTiet.RemoveRange(oldDetails);

                        // 2. Thêm lại chi tiết mới từ list trên Grid
                        foreach (var item in phanPhoiChiTiet)
                        {
                            PhanPhoiChiTiet ct = new PhanPhoiChiTiet();
                            ct.PhanPhoiID = id;
                            ct.VatTuID = item.VatTuID;
                            ct.SoLuong = item.SoLuong;
                            // Nếu bảng chi tiết của bạn có cột DonGia thì thêm vào đây:
                            // ct.DonGia = item.DonGia; 
                            context.PhanPhoiChiTiet.Add(ct);
                        }
                        context.SaveChanges();
                    }
                }
                else // Thêm phiếu mới hoàn toàn
                {
                    PhanPhoi pp = new PhanPhoi();
                    pp.NgayLap = DateTime.Now;
                    // pp.DuAnID = ... (Lấy từ ComboBox dự án nếu có)

                    context.PhanPhoi.Add(pp);
                    context.SaveChanges(); // Lưu để lấy ID tự sinh

                    foreach (var item in phanPhoiChiTiet)
                    {
                        PhanPhoiChiTiet ct = new PhanPhoiChiTiet();
                        ct.PhanPhoiID = pp.ID; // Gán ID vừa tạo
                        ct.VatTuID = item.VatTuID;
                        ct.SoLuong = item.SoLuong;
                        context.PhanPhoiChiTiet.Add(ct);
                    }
                    context.SaveChanges();
                }
                MessageBox.Show("Lưu chi tiết phân phối thành công!", "Thông báo");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVatTu.SelectedValue != null)
            {
                // Kiểm tra xem SelectedValue có thực sự là số không trước khi ép kiểu
                if (int.TryParse(cboVatTu.SelectedValue.ToString(), out int maVT))
                {
                    var vt = context.VatTu.Find(maVT);
                    if (vt != null)
                    {
                        numDonGia.Value = vt.DonGia;
                        TinhTongChiPhiHienThoi();
                    }
                }
            }
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            TinhTongChiPhiHienThoi();
        }
    }
}
