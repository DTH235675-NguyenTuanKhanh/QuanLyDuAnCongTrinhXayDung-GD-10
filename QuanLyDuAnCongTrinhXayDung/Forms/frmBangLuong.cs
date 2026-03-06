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
    public partial class frmBangLuong : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        bool xulyThem = false;
        int id;
        public frmBangLuong()
        {
            InitializeComponent();
        }
        public void LayNhanVienVaoComboBox()
        {
            List<NhanVien> dsNhanVien = context.NhanVien.ToList();
            cboNhanVien.DataSource = dsNhanVien;
            cboNhanVien.DisplayMember = "HoaVaTen";
            cboNhanVien.ValueMember = "ID";
        }
        public void layLuongCoBan()
        {
            int idNhanVien = Convert.ToInt32(cboNhanVien.SelectedValue);
            NhanVien nv = context.NhanVien.Find(idNhanVien);
            if (nv != null)
            {
                txtLuongCoBan.Text = nv.LuongCoBan.ToString();
            }
        }
        public void layphuCap()
        {
            int idNhanVien = Convert.ToInt32(cboNhanVien.SelectedValue);
            decimal tongPhuCap = context.PhanCong
                .Where(pc => pc.NhanVienID == idNhanVien)
                .Sum(pc => pc.PhuCap) ?? 0; // Nếu null thì bằng 0
            txtTongPhuCap.Text = tongPhuCap.ToString();
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
            cboNhanVien.Enabled = b;
            txtNam.Enabled = b;
            txtThang.Enabled = b;
            txtSoNgayCong.Enabled = b;
            txtTongPhuCap.Enabled = b;
            txtThucLinh.Enabled = b;
            txtLuongCoBan.Enabled = b;
        }
        private void ClearText()
        {
            cboNhanVien.Text = "";
            txtNam.DataBindings.Clear();
            txtThang.DataBindings.Clear();
            txtSoNgayCong.DataBindings.Clear();
            txtTongPhuCap.DataBindings.Clear();
            txtThucLinh.DataBindings.Clear();
            txtLuongCoBan.DataBindings.Clear();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            ClearText();
        }

        private void frmBangLuong_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            ClearText();

            // 1. Nạp danh sách NV vào combo
            LayNhanVienVaoComboBox();

            // 2. Lấy dữ liệu phẳng hóa
            dataGridView.AutoGenerateColumns = false;
            var dsLuong = context.BangLuong.Select(r => new {
                id = r.ID,
                NhanVienID = r.NhanVien.ID,
                NhanVien = r.NhanVien.HoVaTen, // Lấy từ thuộc tính HoVaTen
                Thang = r.Thang,
                Nam = r.Nam,
                SoNgayCong = r.SoNgayCong,
                TongPhuCap = r.TongPhuCap,
                ThucLinh = r.ThucLinh
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dsLuong;

            // 3. Binding ComboBox (Kết nối ID của bảng lương với ID của combobox)
            cboNhanVien.DataBindings.Clear();
            cboNhanVien.DataBindings.Add("SelectedValue", bindingSource, "NhanVienID", true, DataSourceUpdateMode.Never);

            // 4. Binding các TextBox
            txtThang.DataBindings.Clear();
            txtThang.DataBindings.Add("Text", bindingSource, "Thang", true, DataSourceUpdateMode.Never);

            txtNam.DataBindings.Clear();
            txtNam.DataBindings.Add("Text", bindingSource, "Nam", true, DataSourceUpdateMode.Never);

            txtSoNgayCong.DataBindings.Clear();
            txtSoNgayCong.DataBindings.Add("Text", bindingSource, "SoNgayCong", true, DataSourceUpdateMode.Never);

            txtTongPhuCap.DataBindings.Clear();
            txtTongPhuCap.DataBindings.Add("Text", bindingSource, "TongPhuCap", true, DataSourceUpdateMode.Never);

            txtThucLinh.DataBindings.Clear();
            txtThucLinh.DataBindings.Add("Text", bindingSource, "ThucLinh", true, DataSourceUpdateMode.Never);

            // 5. Gán Source cho Grid
            dataGridView.DataSource = bindingSource;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa lương của nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value);
                BangLuong bl = context.BangLuong.Find(id);
                if (bl != null)
                {
                    context.BangLuong.Remove(bl);
                    context.SaveChanges();
                    MessageBox.Show("Xóa lương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                    frmBangLuong_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra đầu vào cơ bản
                if (cboNhanVien.SelectedValue == null || string.IsNullOrEmpty(txtThang.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên và thời gian!");
                    return;
                }

                // 2. Lấy ID nhân viên từ ComboBox (sử dụng ValueMember là "Id")
                int idNV = Convert.ToInt32(cboNhanVien.SelectedValue);
                decimal tongPhuCap = context.PhanCong
                .Where(pc => pc.NhanVienID == idNV)
                .Sum(pc => pc.PhuCap) ?? 0; // Nếu null thì bằng 0
                // 3. Tính toán Thực Lĩnh
                // Lấy Lương Cơ Bản từ database (giống logic hàm layLuongCoBan của bạn)
                var nv = context.NhanVien.Find(idNV);
                if (nv == null) return;

                decimal luongCoBan = nv.LuongCoBan;
                int soNgayCong = int.Parse(txtSoNgayCong.Text);


                // Công thức: ThucLinh = (LuongCoBan * SoNgayCong) + TongPhuCap
                decimal thucLinh = (luongCoBan * soNgayCong) + tongPhuCap;

                // Hiển thị lên giao diện
                txtThucLinh.Text = thucLinh.ToString();

                // 4. Thực hiện Lưu (Thêm mới hoặc Sửa)
                if (xulyThem) // Giả định bạn dùng biến flag này khi nhấn nút 'Thêm'
                {
                    BangLuong bl = new BangLuong
                    {
                        NhanVienID = idNV,
                        Thang = int.Parse(txtThang.Text),
                        Nam = int.Parse(txtNam.Text),
                        SoNgayCong = soNgayCong,
                        TongPhuCap = tongPhuCap,
                        ThucLinh = thucLinh
                    };
                    context.BangLuong.Add(bl);
                    MessageBox.Show("Thêm bảng lương thành công!");
                }
                else
                {
                    // Trường hợp Sửa: Tìm bản ghi hiện tại qua ID trên GridView
                    int idRecord = int.Parse(dataGridView.CurrentRow.Cells["Id"].Value.ToString());
                    var blEdit = context.BangLuong.Find(idRecord);
                    if (blEdit != null)
                    {
                        blEdit.NhanVienID = idNV;
                        blEdit.Thang = int.Parse(txtThang.Text);
                        blEdit.Nam = int.Parse(txtNam.Text);
                        blEdit.SoNgayCong = soNgayCong;
                        blEdit.TongPhuCap = tongPhuCap;
                        blEdit.ThucLinh = thucLinh;
                    }
                    MessageBox.Show("Cập nhật thành công!");
                }

                // 5. Cập nhật DB và làm mới bảng dữ liệu
                context.SaveChanges();
                frmBangLuong_Load(sender, e);
                // Hàm nạp lại dữ liệu lên DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmBangLuong_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
