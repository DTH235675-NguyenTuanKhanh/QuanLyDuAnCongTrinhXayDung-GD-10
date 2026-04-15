namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuThoat = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuDuAn = new ToolStripMenuItem();
            mnuCongViec = new ToolStripMenuItem();
            mnuLoaiDuAn = new ToolStripMenuItem();
            mnuNhatKyCongTrinh = new ToolStripMenuItem();
            mnuBangLuong = new ToolStripMenuItem();
            mnuPhanCong = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mnuKhachHang = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuNhaDauTu = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mnuVatTu = new ToolStripMenuItem();
            mnuPhanPhoi = new ToolStripMenuItem();
            mnuBaoCaoThongKe = new ToolStripMenuItem();
            mnuThongKeVatTu = new ToolStripMenuItem();
            mnuThongKeChiPhi = new ToolStripMenuItem();
            mnuThongKeLuong = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuHuongDan = new ToolStripMenuItem();
            mnuThongTin = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            helpProvider1 = new HelpProvider();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            btnDuAn = new Button();
            btnNhanVien = new Button();
            btnKhachHang = new Button();
            btnPhanCong = new Button();
            btnVatTu = new Button();
            btnPhanPhoi = new Button();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gainsboro;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuBaoCaoThongKe, mnuTroGiup });
            menuStrip1.Location = new Point(202, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(864, 41);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, toolStripSeparator1, mnuThoat });
            mnuHeThong.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(137, 37);
            mnuHeThong.Text = "Hệ Thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(264, 38);
            mnuDangNhap.Text = "Đăng Nhập";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(264, 38);
            mnuDangXuat.Text = "Đăng Xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(264, 38);
            mnuDoiMatKhau.Text = "Đổi Mật Khẩu";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(261, 6);
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(264, 38);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuDuAn, mnuCongViec, mnuLoaiDuAn, mnuNhatKyCongTrinh, mnuBangLuong, mnuPhanCong, toolStripSeparator2, mnuKhachHang, mnuNhanVien, mnuNhaDauTu, toolStripSeparator3, mnuVatTu, mnuPhanPhoi });
            mnuQuanLy.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(126, 37);
            mnuQuanLy.Text = "Quản Lý";
            // 
            // mnuDuAn
            // 
            mnuDuAn.Name = "mnuDuAn";
            mnuDuAn.Size = new Size(331, 38);
            mnuDuAn.Text = "Dự Án";
            mnuDuAn.Click += mnuDuAn_Click;
            // 
            // mnuCongViec
            // 
            mnuCongViec.Name = "mnuCongViec";
            mnuCongViec.Size = new Size(331, 38);
            mnuCongViec.Text = "Công Việc";
            mnuCongViec.Click += mnuCongViec_Click;
            // 
            // mnuLoaiDuAn
            // 
            mnuLoaiDuAn.Name = "mnuLoaiDuAn";
            mnuLoaiDuAn.Size = new Size(331, 38);
            mnuLoaiDuAn.Text = "Loại Dự Án";
            mnuLoaiDuAn.Click += mnuLoaiDuAn_Click;
            // 
            // mnuNhatKyCongTrinh
            // 
            mnuNhatKyCongTrinh.Name = "mnuNhatKyCongTrinh";
            mnuNhatKyCongTrinh.Size = new Size(331, 38);
            mnuNhatKyCongTrinh.Text = "Nhật Ký Công Trình";
            mnuNhatKyCongTrinh.Click += mnuNhatKyCongTrinh_Click;
            // 
            // mnuBangLuong
            // 
            mnuBangLuong.Name = "mnuBangLuong";
            mnuBangLuong.Size = new Size(331, 38);
            mnuBangLuong.Text = "Bảng Lương";
            mnuBangLuong.Click += mnuBangLuong_Click;
            // 
            // mnuPhanCong
            // 
            mnuPhanCong.Name = "mnuPhanCong";
            mnuPhanCong.Size = new Size(331, 38);
            mnuPhanCong.Text = "Phân Công";
            mnuPhanCong.Click += mnuPhanCong_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(328, 6);
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(331, 38);
            mnuKhachHang.Text = "Khách Hàng";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(331, 38);
            mnuNhanVien.Text = "Nhân Viên";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuNhaDauTu
            // 
            mnuNhaDauTu.Name = "mnuNhaDauTu";
            mnuNhaDauTu.Size = new Size(331, 38);
            mnuNhaDauTu.Text = "Nhà Đầu Tư";
            mnuNhaDauTu.Click += mnuNhaDauTu_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(328, 6);
            // 
            // mnuVatTu
            // 
            mnuVatTu.Name = "mnuVatTu";
            mnuVatTu.Size = new Size(331, 38);
            mnuVatTu.Text = "Vật Tư";
            mnuVatTu.Click += mnuVatTu_Click;
            // 
            // mnuPhanPhoi
            // 
            mnuPhanPhoi.Name = "mnuPhanPhoi";
            mnuPhanPhoi.Size = new Size(331, 38);
            mnuPhanPhoi.Text = "Phân Phối";
            mnuPhanPhoi.Click += mnuPhanPhoi_Click;
            // 
            // mnuBaoCaoThongKe
            // 
            mnuBaoCaoThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeVatTu, mnuThongKeChiPhi, mnuThongKeLuong });
            mnuBaoCaoThongKe.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            mnuBaoCaoThongKe.Size = new Size(257, 37);
            mnuBaoCaoThongKe.Text = "Báo Cáo - Thống Kê";
            // 
            // mnuThongKeVatTu
            // 
            mnuThongKeVatTu.Name = "mnuThongKeVatTu";
            mnuThongKeVatTu.Size = new Size(306, 38);
            mnuThongKeVatTu.Text = "Thống Kê Vật Tư";
            mnuThongKeVatTu.Click += mnuThongKeVatTu_Click;
            // 
            // mnuThongKeChiPhi
            // 
            mnuThongKeChiPhi.Name = "mnuThongKeChiPhi";
            mnuThongKeChiPhi.Size = new Size(306, 38);
            mnuThongKeChiPhi.Text = "Thống Kê Chi Phí";
            mnuThongKeChiPhi.Click += mnuThongKeChiPhi_Click;
            // 
            // mnuThongKeLuong
            // 
            mnuThongKeLuong.Name = "mnuThongKeLuong";
            mnuThongKeLuong.Size = new Size(306, 38);
            mnuThongKeLuong.Text = "Thống Kê Lương";
            mnuThongKeLuong.Click += mnuThongKeLuong_Click;
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuHuongDan, mnuThongTin });
            mnuTroGiup.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(130, 37);
            mnuTroGiup.Text = "Trợ Giúp";
            // 
            // mnuHuongDan
            // 
            mnuHuongDan.Name = "mnuHuongDan";
            mnuHuongDan.Size = new Size(332, 38);
            mnuHuongDan.Text = "Hướng dẫn sử dụng";
            mnuHuongDan.Click += mnuHuongDan_Click;
            // 
            // mnuThongTin
            // 
            mnuThongTin.Name = "mnuThongTin";
            mnuThongTin.Size = new Size(332, 38);
            mnuThongTin.Text = "Thông tin phần mềm";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, lblLienKet });
            statusStrip1.Location = new Point(0, 522);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1066, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(123, 20);
            lblTrangThai.Text = "Chưa Đăng Nhập";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(847, 20);
            toolStripStatusLabel1.Spring = true;
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(81, 20);
            lblLienKet.Text = "© 2024 FIT";
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://dth235675-nguyentuankhanh.github.io/DTH235675-NguyenTuanKhanh-HuongDan/";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Gainsboro;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(btnDuAn);
            flowLayoutPanel1.Controls.Add(btnNhanVien);
            flowLayoutPanel1.Controls.Add(btnKhachHang);
            flowLayoutPanel1.Controls.Add(btnPhanCong);
            flowLayoutPanel1.Controls.Add(btnVatTu);
            flowLayoutPanel1.Controls.Add(btnPhanPhoi);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(202, 522);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnDuAn
            // 
            btnDuAn.BackColor = Color.Gainsboro;
            btnDuAn.BackgroundImageLayout = ImageLayout.None;
            btnDuAn.FlatAppearance.BorderColor = Color.Navy;
            btnDuAn.FlatAppearance.BorderSize = 0;
            btnDuAn.FlatStyle = FlatStyle.Flat;
            btnDuAn.Font = new Font("Times New Roman", 13.8F);
            btnDuAn.ForeColor = SystemColors.ControlText;
            btnDuAn.Image = (Image)resources.GetObject("btnDuAn.Image");
            btnDuAn.Location = new Point(0, 91);
            btnDuAn.Margin = new Padding(0);
            btnDuAn.Name = "btnDuAn";
            btnDuAn.Size = new Size(202, 65);
            btnDuAn.TabIndex = 1;
            btnDuAn.Text = "Dự Án";
            btnDuAn.TextAlign = ContentAlignment.BottomCenter;
            btnDuAn.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDuAn.UseVisualStyleBackColor = false;
            btnDuAn.Click += btnDuAn_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.Gainsboro;
            btnNhanVien.FlatAppearance.BorderColor = Color.Navy;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Times New Roman", 13.8F);
            btnNhanVien.ForeColor = SystemColors.ControlText;
            btnNhanVien.Image = (Image)resources.GetObject("btnNhanVien.Image");
            btnNhanVien.Location = new Point(0, 156);
            btnNhanVien.Margin = new Padding(0);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(202, 65);
            btnNhanVien.TabIndex = 2;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.TextAlign = ContentAlignment.BottomCenter;
            btnNhanVien.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.Gainsboro;
            btnKhachHang.FlatAppearance.BorderColor = Color.Navy;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Times New Roman", 13.8F);
            btnKhachHang.ForeColor = SystemColors.ControlText;
            btnKhachHang.Image = (Image)resources.GetObject("btnKhachHang.Image");
            btnKhachHang.Location = new Point(0, 221);
            btnKhachHang.Margin = new Padding(0);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(202, 65);
            btnKhachHang.TabIndex = 3;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.TextAlign = ContentAlignment.BottomCenter;
            btnKhachHang.TextImageRelation = TextImageRelation.ImageAboveText;
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnPhanCong
            // 
            btnPhanCong.BackColor = Color.Gainsboro;
            btnPhanCong.FlatAppearance.BorderColor = Color.Navy;
            btnPhanCong.FlatAppearance.BorderSize = 0;
            btnPhanCong.FlatStyle = FlatStyle.Flat;
            btnPhanCong.Font = new Font("Times New Roman", 13.8F);
            btnPhanCong.ForeColor = SystemColors.ControlText;
            btnPhanCong.Image = (Image)resources.GetObject("btnPhanCong.Image");
            btnPhanCong.Location = new Point(0, 286);
            btnPhanCong.Margin = new Padding(0);
            btnPhanCong.Name = "btnPhanCong";
            btnPhanCong.Size = new Size(202, 65);
            btnPhanCong.TabIndex = 4;
            btnPhanCong.Text = "Phân Công";
            btnPhanCong.TextAlign = ContentAlignment.BottomCenter;
            btnPhanCong.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPhanCong.UseVisualStyleBackColor = false;
            btnPhanCong.Click += btnNhatKy_Click;
            // 
            // btnVatTu
            // 
            btnVatTu.BackColor = Color.Gainsboro;
            btnVatTu.FlatAppearance.BorderColor = Color.Navy;
            btnVatTu.FlatAppearance.BorderSize = 0;
            btnVatTu.FlatStyle = FlatStyle.Flat;
            btnVatTu.Font = new Font("Times New Roman", 13.8F);
            btnVatTu.ForeColor = SystemColors.ControlText;
            btnVatTu.Image = (Image)resources.GetObject("btnVatTu.Image");
            btnVatTu.Location = new Point(0, 351);
            btnVatTu.Margin = new Padding(0);
            btnVatTu.Name = "btnVatTu";
            btnVatTu.Size = new Size(202, 65);
            btnVatTu.TabIndex = 5;
            btnVatTu.Text = "Vật Tư";
            btnVatTu.TextAlign = ContentAlignment.BottomCenter;
            btnVatTu.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVatTu.UseVisualStyleBackColor = false;
            btnVatTu.Click += btnVatTu_Click;
            // 
            // btnPhanPhoi
            // 
            btnPhanPhoi.BackColor = Color.Gainsboro;
            btnPhanPhoi.FlatAppearance.BorderColor = Color.Navy;
            btnPhanPhoi.FlatAppearance.BorderSize = 0;
            btnPhanPhoi.FlatStyle = FlatStyle.Flat;
            btnPhanPhoi.Font = new Font("Times New Roman", 13.8F);
            btnPhanPhoi.ForeColor = SystemColors.ControlText;
            btnPhanPhoi.Image = (Image)resources.GetObject("btnPhanPhoi.Image");
            btnPhanPhoi.Location = new Point(0, 416);
            btnPhanPhoi.Margin = new Padding(0);
            btnPhanPhoi.Name = "btnPhanPhoi";
            btnPhanPhoi.Size = new Size(202, 65);
            btnPhanPhoi.TabIndex = 6;
            btnPhanPhoi.Text = "Phân Phối";
            btnPhanPhoi.TextAlign = ContentAlignment.BottomCenter;
            btnPhanPhoi.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPhanPhoi.UseVisualStyleBackColor = false;
            btnPhanPhoi.Click += btnPhanPhoi_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(202, 41);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 481);
            panel1.TabIndex = 6;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1066, 548);
            Controls.Add(menuStrip1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            helpProvider1.SetHelpNavigator(this, HelpNavigator.Topic);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            helpProvider1.SetShowHelp(this, true);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Dự Án Công Trình Xây Dựng";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuDangNhap;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuDuAn;
        private ToolStripMenuItem mnuCongViec;
        private ToolStripMenuItem mnuLoaiDuAn;
        private ToolStripMenuItem mnuNhatKyCongTrinh;
        private ToolStripMenuItem mnuPhanCong;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuNhaDauTu;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mnuVatTu;
        private ToolStripMenuItem mnuPhanPhoi;
        private ToolStripMenuItem mnuBaoCaoThongKe;
        private ToolStripMenuItem mnuThongKeVatTu;
        private ToolStripMenuItem mnuThongKeChiPhi;
        private ToolStripMenuItem mnuThongKeLuong;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuHuongDan;
        private ToolStripMenuItem mnuThongTin;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblLienKet;
        private ToolStripMenuItem mnuBangLuong;
        private HelpProvider helpProvider1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Button btnDuAn;
        private Button btnNhanVien;
        private Button btnKhachHang;
        private Button btnPhanCong;
        private Button btnVatTu;
        private Panel panel1;
        private Button btnPhanPhoi;
    }
}