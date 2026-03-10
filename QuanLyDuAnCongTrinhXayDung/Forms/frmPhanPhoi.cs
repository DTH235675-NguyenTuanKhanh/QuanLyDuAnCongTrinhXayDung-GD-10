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
    public partial class frmPhanPhoi : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        int id;
        public frmPhanPhoi()
        {
            InitializeComponent();
        }

        private void frmPhanPhoi_Load(object sender, EventArgs e)
        {
            // Tắt tự động tạo cột để khớp với các cột bạn đã vẽ thủ công trên giao diện
            dataGridView.AutoGenerateColumns = false;

            // Khai báo List theo class phụ vừa tạo
            List<DanhSachPhanPhoi> ds = new List<DanhSachPhanPhoi>();

            // Truy vấn dữ liệu từ context
            ds = context.PhanPhoi.Select(r => new DanhSachPhanPhoi
            {
                ID = (int)r.ID,
                NgayLap = r.NgayLap,
                DuAnID = (int)r.DuAnID,
                TenDuAn = r.DuAn.TenDuAn, // Lấy tên dự án từ bảng liên kết
                GhiChu = r.GhiChu
            }).ToList();

            // Gán nguồn dữ liệu cho bảng
            dataGridView.DataSource = ds;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhanPhoiChiTiet f = new frmPhanPhoiChiTiet(0);
            f.ShowDialog();

            // Sau khi đóng form chi tiết, nạp lại danh sách ở form chính để thấy phiếu mới
            frmPhanPhoi_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                var cellValue = dataGridView.CurrentRow.Cells["colID"].Value;
                if (cellValue != null)
                {
                    id = Convert.ToInt32(cellValue);
                    // Mở form sửa và truyền ID vào
                     using (frmPhanPhoiChiTiet f = new frmPhanPhoiChiTiet(id)) { f.ShowDialog(); }
                    frmPhanPhoi_Load(sender, e); // Tải lại dữ liệu sau khi sửa
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa bản ghi phân phối này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value);
                    var pp = context.PhanPhoi.Find(id);
                    if (pp != null)
                    {
                        context.PhanPhoi.Remove(pp);
                        context.SaveChanges();
                        MessageBox.Show("Xóa thành công!");
                        frmPhanPhoi_Load(sender, e); // Tải lại dữ liệu sau khi xóa
                    }
                }
            }
        }
    }
}
