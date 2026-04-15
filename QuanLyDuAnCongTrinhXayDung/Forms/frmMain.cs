using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuAnCongTrinhXayDung.Data;
using QuanLyDuAnCongTrinhXayDung.Reports;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    public partial class frmMain : Form
    {
        QLDACTXDDbContext context = new QLDACTXDDbContext();
        frmDuAn duAn = null;
        frmCongViec congViec = null;
        frmLoaiDuAn loaiDuAn = null;
        frmBangLuong bangLuong = null;
        frmNhatKyCongTrinh nhatKy = null;
        frmPhanCong phanCong = null;
        frmKhachHang khachHang = null;
        frmNhanVien nhanVien = null;
        frmNhaDauTu nhaDauTu = null;
        frmVatTu vatTu = null;
        frmPhanPhoi phanPhoi = null;
        frmDangNhap dangNhap = null;
        string hoVaTenNhanVien = "";
        string quyenHan = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuDuAn_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDuAn());
        }

        private void mnuCongViec_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCongViec());
        }

        private void mnuLoaiDuAn_Click(object sender, EventArgs e)
        {
            openChildForm(new frmLoaiDuAn());
        }

        private void mnuNhatKyCongTrinh_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhatKyCongTrinh());
        }

        private void mnuPhanCong_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhanCong());
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKhachHang());
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());
        }

        private void mnuNhaDauTu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhaDauTu());
        }

        private void mnuVatTu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVatTu());
        }

        private void mnuPhanPhoi_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhanPhoi());
        }

        private void mnuBangLuong_Click(object sender, EventArgs e)
        {
            openChildForm(new frmBangLuong());
        }
        private void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtTenDangNhap.Text;
                string matKhau = dangNhap.txtMatKhau.Text;
                if (tenDangNhap.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    var nhanVien = context.NhanVien.Where(r => r.TenDangNhap == tenDangNhap).SingleOrDefault();
                    if (nhanVien == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        if (BC.Verify(matKhau, nhanVien.MatKhau))
                        {
                            hoVaTenNhanVien = nhanVien.HoVaTen;
                            if (nhanVien.QuyenHan == true)
                                QuyenQuanLy();
                            else if (nhanVien.QuyenHan == false)
                                QuyenNhanVien();
                            else
                                ChuaDangNhap();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtMatKhau.Focus();
                            goto LamLai;
                        }
                    }
                }
            }
        }
        public void QuyenQuanLy()
        {
            mnuDuAn.Enabled = true;
            mnuCongViec.Enabled = true;
            mnuLoaiDuAn.Enabled = true;
            mnuNhatKyCongTrinh.Enabled = true;
            mnuPhanCong.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = true;
            mnuNhaDauTu.Enabled = true;
            mnuVatTu.Enabled = true;
            mnuPhanPhoi.Enabled = true;
            mnuBangLuong.Enabled = true;
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            btnDuAn.Enabled = true;
            btnNhanVien.Enabled = true;
            btnKhachHang.Enabled = true;
            btnVatTu.Enabled = true;
            btnPhanPhoi.Enabled = true;
            btnPhanCong.Enabled = true;


            lblTrangThai.Text = "Quản lý: " + hoVaTenNhanVien;
        }
        public void QuyenNhanVien()
        {
            mnuDuAn.Enabled = true;
            mnuCongViec.Enabled = true;
            mnuLoaiDuAn.Enabled = true;
            mnuNhatKyCongTrinh.Enabled = true;
            mnuPhanCong.Enabled = false;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = false;
            mnuNhaDauTu.Enabled = false;
            mnuVatTu.Enabled = false;
            mnuPhanPhoi.Enabled = false;
            mnuBangLuong.Enabled = false;
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            btnDuAn.Enabled = false;
            btnPhanCong.Enabled = false;
            btnPhanPhoi.Enabled = false;
            btnVatTu.Enabled = false;
            btnNhanVien.Enabled = false;
            btnKhachHang.Enabled = true;
            if (quyenHan == "Kế toán")
            {
                mnuNhanVien.Enabled = true;   
                mnuVatTu.Enabled = true;     
                mnuPhanPhoi.Enabled = true;   
                mnuBangLuong.Enabled = true;  

                btnVatTu.Enabled = true;
                btnPhanPhoi.Enabled = true;
            }
            else
            {
                mnuNhanVien.Enabled = false;
                mnuVatTu.Enabled = false;
                mnuPhanPhoi.Enabled = false;
                mnuBangLuong.Enabled = false;

                btnVatTu.Enabled = false;
                btnPhanPhoi.Enabled = false;
            }

            mnuPhanCong.Enabled = false;
            btnPhanCong.Enabled = false;

            lblTrangThai.Text = "Nhân viên (" + quyenHan + "): " + hoVaTenNhanVien;

        }
        public void ChuaDangNhap()
        {
            mnuDuAn.Enabled = false;
            mnuCongViec.Enabled = false;
            mnuLoaiDuAn.Enabled = false;
            mnuNhatKyCongTrinh.Enabled = false;
            mnuPhanCong.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuNhaDauTu.Enabled = false;
            mnuVatTu.Enabled = false;
            mnuPhanPhoi.Enabled = false;
            mnuBangLuong.Enabled = false;
            mnuDangXuat.Enabled = false;
            mnuDoiMatKhau.Enabled = false;
            btnDuAn.Enabled = false;
            btnNhanVien.Enabled = false;
            btnKhachHang.Enabled = false;
            btnVatTu.Enabled = false;
            btnPhanPhoi.Enabled = false;
            btnPhanCong.Enabled = false;
            mnuThongKeChiPhi.Enabled = false;
            mnuThongKeLuong.Enabled = false;
            mnuThongKeChiPhi.Enabled = false;
            lblTrangThai.Text = "Chưa đăng nhập.";
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
            CloseAllChildForms();
        }

        private void mnuThongKeVatTu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongKeVatTu());
        }

        private void mnuThongKeLuong_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongKeLuong());
        }

        private void mnuThongKeChiPhi_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongKeChiPhi());
        }

        private void mnuHuongDan_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }

        private void btnDuAn_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDuAn());
        }
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            // 1. Nếu đang có form con khác đang mở thì đóng nó lại cho nhẹ máy
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; // Nó sẽ tự Fill vào vùng trống còn lại của Panel

            panel1.Controls.Clear();
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();                       // Lệnh hiển thị
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKhachHang());
        }

        private void btnNhatKy_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhanCong());
        }

        private void btnVatTu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVatTu());
        }

        private void btnPhanPhoi_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhanPhoi());
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
            private void CloseChildForm(Form childForm)
        {
            // Kiểm tra xem trong Panel có Control nào không
            if (panel1.Controls.Count > 0)
            {
                // Lấy Control đầu tiên và ép kiểu về Form
                Form activeChild = panel1.Controls[0] as Form;

                if (activeChild != null)
                {
                    activeChild.Close();   // Đóng Form
                    activeChild.Dispose(); // Giải phóng bộ nhớ
                    panel1.Controls.Clear(); // Xóa khỏi danh sách quản lý của Panel
                }
            }
        }
        private void CloseAllChildForms()
        {
                CloseChildForm(new frmBangLuong());
                CloseChildForm(new frmCongViec());
                CloseChildForm(new frmDuAn());
                CloseChildForm(new frmKhachHang());
                CloseChildForm(new frmLoaiDuAn());
                CloseChildForm(new frmNhatKyCongTrinh());
                CloseChildForm(new frmNhanVien());
                CloseChildForm(new frmNhaDauTu());
                CloseChildForm(new frmPhanCong());
                CloseChildForm(new frmPhanPhoi());
                CloseChildForm(new frmVatTu());
        }
    }
}
