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
    public partial class frmDuAn : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        bool xulyThem = false;
        int id;
        public frmDuAn()
        {
            InitializeComponent();
        }
        public void LayKhachHangVaoComboBox()
        {
            List<KhachHang> dsKhachHang = context.KhachHang.ToList();
            cboKhachHang.DataSource = dsKhachHang;
            cboKhachHang.DisplayMember = "TenCongTy";
            cboKhachHang.ValueMember = "ID";
        }
        public void LayLoaiDuAnVaoComboBox()
        {
            List<LoaiDuAn> dsLoaiDuAn = context.LoaiDuAn.ToList();
            cboTenLoai.DataSource = dsLoaiDuAn;
            cboTenLoai.DisplayMember = "TenLoai";
            cboTenLoai.ValueMember = "ID";
        }
        public void LayNhaDauTuVaoComboBox()
        {
            List<NhaDauTu> dsNhaDauTu = context.NhaDauTu.ToList();
            cboNhaDauTu.DataSource = dsNhaDauTu;
            cboNhaDauTu.DisplayMember = "TenNhaDauTu";
            cboNhaDauTu.ValueMember = "ID";
        }
        private void BatTatChucNang(bool b)
        {
            btnThem.Enabled = !b;
            btnSua.Enabled = !b;
            btnXoa.Enabled = !b;
            btnLuu.Enabled = b;
            btnHuyBo.Enabled = b;
            btnTimKiem.Enabled = !b;
            btnThoat.Enabled = !b;
            btnNhap.Enabled = !b;
            btnXuat.Enabled = !b;
            cboKhachHang.Enabled = b;
            cboNhaDauTu.Enabled = b;
            cboTenLoai.Enabled = b;
            txtTenDuAn.Enabled = b;
            txtNganSach.Enabled = b;
            txtDiaDiem.Enabled = b;
            dtpNgayBatDau.Enabled = b;
            dtpNgayKetThuc.Enabled = b;
            dataGridView.Enabled = !b;
        }
        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmDuAn_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            // 1. Nạp các danh sách vào ComboBox trước
            LayLoaiDuAnVaoComboBox();
            LayKhachHangVaoComboBox();
            LayNhaDauTuVaoComboBox();

            dataGridView.AutoGenerateColumns = false;

            // 2. Lấy dữ liệu và map vào class DanhSachDuAn để hiện tên thay vì ID
            List<DanhSachDuAn> ds = context.DuAn.Select(r => new DanhSachDuAn
            {
                ID = r.ID,
                TenDuAn = r.TenDuAn,
                DiaDiem = r.DiaDiem,
                NgayBatDau = r.NgayBatDau,
                NgayKetThuc = r.NgayKetThuc,
                NganSach = r.NganSach,
                LoaiDuAnID = r.LoaiDuAnID,
                TenLoai = r.LoaiDuAn.TenLoai, // Hiện tên loại dự án
                KhachHangID = r.KhachHangID,
                TenKhachHang = r.KhachHang.TenCongTy, // Hiện tên khách hàng
                NhaDauTuID = r.NhaDauTuID,
                TenNhaDauTu = r.NhaDauTu.TenNhaDauTu // Hiện tên nhà đầu tư
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ds;

            // 3. Binding các ComboBox (Kết nối ID dự án với ComboBox)
            cboTenLoai.DataBindings.Clear();
            cboTenLoai.DataBindings.Add("SelectedValue", bindingSource, "LoaiDuAnID", true, DataSourceUpdateMode.Never);

            cboKhachHang.DataBindings.Clear();
            cboKhachHang.DataBindings.Add("SelectedValue", bindingSource, "KhachHangID", true, DataSourceUpdateMode.Never);

            // 4. Binding các TextBox và DateTimePicker
            txtTenDuAn.DataBindings.Clear();
            txtTenDuAn.DataBindings.Add("Text", bindingSource, "TenDuAn", true, DataSourceUpdateMode.Never);

            txtDiaDiem.DataBindings.Clear();
            txtDiaDiem.DataBindings.Add("Text", bindingSource, "DiaDiem", true, DataSourceUpdateMode.Never);

            txtNganSach.DataBindings.Clear();
            txtNganSach.DataBindings.Add("Text", bindingSource, "NganSach", true, DataSourceUpdateMode.Never);

            dtpNgayBatDau.DataBindings.Clear();
            dtpNgayBatDau.DataBindings.Add("Value", bindingSource, "NgayBatDau", true, DataSourceUpdateMode.Never);

            // 5. Gán Source cho Grid
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtTenDuAn.DataBindings.Clear();
            txtDiaDiem.DataBindings.Clear();
            txtNganSach.DataBindings.Clear();
            cboKhachHang.SelectedIndex = -1;
            cboNhaDauTu.SelectedIndex = -1;
            cboTenLoai.SelectedIndex = -1;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra đầu vào cơ bản
                if (string.IsNullOrWhiteSpace(txtTenDuAn.Text) || cboTenLoai.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng nhập tên dự án và chọn loại dự án!");
                    return;
                }

                // 2. Lấy dữ liệu từ giao diện
                int idLoai = Convert.ToInt32(cboTenLoai.SelectedValue);
                int idKH = Convert.ToInt32(cboKhachHang.SelectedValue);
                int idNhaDT = Convert.ToInt32(cboNhaDauTu.SelectedValue);

                decimal nganSach = 0;
                decimal.TryParse(txtNganSach.Text, out nganSach);

                DateTime ngayBD = dtpNgayBatDau.Value;
                DateTime ngayKT = dtpNgayKetThuc.Value;

                // Kiểm tra logic ngày tháng
                if (ngayKT < ngayBD)
                {
                    MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu!");
                    return;
                }

                // 3. Thực hiện Lưu (Thêm mới hoặc Sửa)
                if (xulyThem) // Biến flag xác định chế độ thêm mới
                {
                    DuAn da = new DuAn
                    {
                        TenDuAn = txtTenDuAn.Text,
                        DiaDiem = txtDiaDiem.Text,
                        NgayBatDau = ngayBD, //
                        NgayKetThuc = ngayKT, //
                        NganSach = nganSach,
                        LoaiDuAnID = idLoai,
                        KhachHangID = idKH,
                        NhaDauTuID = idNhaDT
                    };
                    context.DuAn.Add(da);
                    MessageBox.Show("Thêm dự án mới thành công!");
                }
                else
                {
                    // Trường hợp Sửa: Sử dụng biến 'id' đã lấy khi nhấn nút Sửa
                    var daEdit = context.DuAn.Find(id);
                    if (daEdit != null)
                    {
                        daEdit.TenDuAn = txtTenDuAn.Text;
                        daEdit.DiaDiem = txtDiaDiem.Text;
                        daEdit.NgayBatDau = ngayBD;
                        daEdit.NgayKetThuc = ngayKT;
                        daEdit.NganSach = nganSach;
                        daEdit.LoaiDuAnID = idLoai;
                        daEdit.KhachHangID = idKH;
                        daEdit.NhaDauTuID = idNhaDT;
                    }
                    MessageBox.Show("Cập nhật thông tin dự án thành công!");
                }

                // 4. Cập nhật vào Cơ sở dữ liệu và làm mới Grid
                context.SaveChanges();
                frmDuAn_Load(sender, e); // Gọi lại hàm Load để nạp lại class DanhSachDuAn
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmDuAn_Load(sender, e); // Tải lại dữ liệu để hủy bỏ mọi thay đổi trên giao diện
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dự án này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value);
                DuAn da = context.DuAn.Find(id);
                if (da != null)
                {
                    context.DuAn.Remove(da);
                    context.SaveChanges();
                    MessageBox.Show("Xóa dự án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDuAn_Load(sender, e); // Tải lại dữ liệu sau khi xóa
                }
            }
        }
    }
}
