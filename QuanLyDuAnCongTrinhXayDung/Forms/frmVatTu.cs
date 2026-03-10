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
    public partial class frmVatTu : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        bool xulyThem = false;
        int id;
        string hinhAnhTam = "";
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");
        public frmVatTu()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenVatTu.Enabled = giaTri;
            txtDonViTinh.Enabled = giaTri;
            numDonGia.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnDoiAnh.Enabled = giaTri; // Chỉ cho đổi ảnh khi đang Thêm/Sửa
        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;
            // Lấy danh sách vật tư từ DB
            var danhSach = context.VatTu.ToList();

            BindingSource bs = new BindingSource();
            bs.DataSource = danhSach;

            // Data Binding cho các controls
            txtTenVatTu.DataBindings.Clear();
            txtTenVatTu.DataBindings.Add("Text", bs, "TenVatTu", false, DataSourceUpdateMode.Never);

            txtDonViTinh.DataBindings.Clear();
            txtDonViTinh.DataBindings.Add("Text", bs, "DonViTinh", false, DataSourceUpdateMode.Never);

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", bs, "DonGia", false, DataSourceUpdateMode.Never);

            ptbHinhAnh.DataBindings.Clear();
            Binding bindingAnh = new Binding("ImageLocation", bs, "HinhAnh", true);
            bindingAnh.Format += (s, e) =>
            {
                if (e.Value != null) e.Value = Path.Combine(imagesFolder, e.Value.ToString());
            };
            ptbHinhAnh.DataBindings.Add(bindingAnh);

            dataGridView.DataSource = bs;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtTenVatTu.DataBindings.Clear();
            txtDonViTinh.DataBindings.Clear();
            numDonGia.DataBindings.Clear();
            ptbHinhAnh.DataBindings.Clear();
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
                // 1. Kiểm tra đầu vào (Validation)
                if (string.IsNullOrWhiteSpace(txtTenVatTu.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên vật tư!");
                    return;
                }

                decimal gia = 0;
                decimal.TryParse(numDonGia.Text, out gia);

                // 2. Thực hiện Lưu
                if (xulyThem) // Chế độ Thêm mới
                {
                    VatTu vt = new VatTu
                    {
                        TenVatTu = txtTenVatTu.Text,
                        DonGia = gia,
                        DonViTinh = txtDonViTinh.Text,
                        // HinhAnh = mảng byte của ảnh (nếu có)
                    };
                    context.VatTu.Add(vt);
                    MessageBox.Show("Thêm vật tư mới thành công!");
                }
                else // Chế độ Sửa
                {
                    // 'id' là biến toàn cục lưu ID dòng đang chọn khi nhấn nút 'Sửa'
                    var vtEdit = context.VatTu.Find(id);
                    if (vtEdit != null)
                    {
                        vtEdit.TenVatTu = txtTenVatTu.Text;
                        vtEdit.DonGia = gia;
                        vtEdit.DonViTinh = txtDonViTinh.Text;
                        // vtEdit.HinhAnh = ...
                    }
                    MessageBox.Show("Cập nhật vật tư thành công!");
                }

                // 3. Lưu thay đổi vào Database và tải lại Grid
                context.SaveChanges();
                frmVatTu_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy ID từ dòng đang chọn trên DataGridView
                if (dataGridView.CurrentRow == null) return;
                int idXoa = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

                // 2. Hỏi xác nhận
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa vật tư này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // 3. Tìm và xóa
                    var vtDelete = context.VatTu.Find(idXoa);
                    if (vtDelete != null)
                    {
                        context.VatTu.Remove(vtDelete);
                        context.SaveChanges();

                        MessageBox.Show("Xóa thành công!");
                        frmVatTu_Load(sender, e); // Tải lại dữ liệu sau khi xóa
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmVatTu_Load(sender, e); // Tải lại dữ liệu để hủy bỏ mọi thay đổi
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 1. Kiểm tra xem có đúng cột "HinhAnh" không (thay tên cột tương ứng của bạn)
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh" && e.Value != null)
            {
                try
                {
                    string path = e.Value.ToString();

                    // 2. Kiểm tra nếu file tồn tại thì mới convert sang Image
                    if (System.IO.File.Exists(path))
                    {
                        // Ép kiểu hiển thị sang Image để DataGridView không bị lỗi FormatException
                        e.Value = Image.FromFile(path);
                    }
                    else
                    {
                        // Nếu không có ảnh, có thể để một ảnh mặc định hoặc null
                        e.Value = null;
                    }
                }
                catch
                {
                    e.Value = null;
                }
            }
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Cập nhật hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                string fileSavePath = Path.Combine(imagesFolder, fileName + ext);
                File.Copy(openFileDialog.FileName, fileSavePath, true);
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value.ToString());
                VatTu sp = context.VatTu.Find(id); sp.HinhAnh = fileName + ext;
                context.VatTu.Update(sp);
                context.SaveChanges();
                frmVatTu_Load(sender, e);
            }
        }
    }
}
