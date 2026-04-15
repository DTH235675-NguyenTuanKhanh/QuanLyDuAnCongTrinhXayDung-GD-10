namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmKhachHang
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            groupBox1 = new GroupBox();
            txtTimKiem = new TextBox();
            label9 = new Label();
            txtNguoiDaiDien = new TextBox();
            label5 = new Label();
            txtMaSoThue = new TextBox();
            label6 = new Label();
            txtDienThoai = new TextBox();
            label3 = new Label();
            txtDiaChi = new TextBox();
            label2 = new Label();
            txtTenCongTy = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            dgvKhachHang = new DataGridView();
            Idcol = new DataGridViewTextBoxColumn();
            TenCongTy = new DataGridViewTextBoxColumn();
            MaSothue = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            NguoiDaiDien = new DataGridViewTextBoxColumn();
            khachHangBindingSource = new BindingSource(components);
            khoiTaoMoiBindingSource = new BindingSource(components);
            btnNhap = new Button();
            btnXuat = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)khachHangBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)khoiTaoMoiBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(txtNguoiDaiDien);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(txtMaSoThue);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTenCongTy);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1265, 287);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Khách Hàng";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(818, 148);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(425, 34);
            txtTimKiem.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(688, 148);
            label9.Name = "label9";
            label9.Size = new Size(102, 28);
            label9.TabIndex = 26;
            label9.Text = "Tìm Kiếm: ";
            // 
            // txtNguoiDaiDien
            // 
            txtNguoiDaiDien.Location = new Point(818, 91);
            txtNguoiDaiDien.Name = "txtNguoiDaiDien";
            txtNguoiDaiDien.Size = new Size(425, 34);
            txtNguoiDaiDien.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(666, 91);
            label5.Name = "label5";
            label5.Size = new Size(156, 28);
            label5.TabIndex = 8;
            label5.Text = "Người Đại Diện: ";
            // 
            // txtMaSoThue
            // 
            txtMaSoThue.Location = new Point(818, 39);
            txtMaSoThue.Name = "txtMaSoThue";
            txtMaSoThue.Size = new Size(425, 34);
            txtMaSoThue.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(666, 39);
            label6.Name = "label6";
            label6.Size = new Size(124, 28);
            label6.TabIndex = 6;
            label6.Text = "Mã Số Thuế: ";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(148, 148);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(485, 34);
            txtDienThoai.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 148);
            label3.Name = "label3";
            label3.Size = new Size(114, 28);
            label3.TabIndex = 4;
            label3.Text = "Điện Thoại: ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(148, 94);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(485, 34);
            txtDiaChi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 94);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 2;
            label2.Text = "Địa Chỉ: ";
            // 
            // txtTenCongTy
            // 
            txtTenCongTy.Location = new Point(148, 42);
            txtTenCongTy.Name = "txtTenCongTy";
            txtTenCongTy.Size = new Size(485, 34);
            txtTenCongTy.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên Công Ty: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(818, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(439, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dgvKhachHang);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(10, 305);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1265, 436);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Khách Hàng";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKhachHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKhachHang.ColumnHeadersHeight = 29;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { Idcol, TenCongTy, MaSothue, DiaChi, SoDienThoai, NguoiDaiDien });
            dgvKhachHang.DataSource = khachHangBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvKhachHang.Location = new Point(6, 33);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvKhachHang.Size = new Size(1253, 397);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.CellContentClick += dgvKhachHang_CellContentClick;
            // 
            // Idcol
            // 
            Idcol.DataPropertyName = "ID";
            Idcol.FillWeight = 64.17112F;
            Idcol.HeaderText = "ID";
            Idcol.MinimumWidth = 6;
            Idcol.Name = "Idcol";
            // 
            // TenCongTy
            // 
            TenCongTy.DataPropertyName = "TenCongTy";
            TenCongTy.FillWeight = 107.165771F;
            TenCongTy.HeaderText = "Tên Công Ty";
            TenCongTy.MinimumWidth = 6;
            TenCongTy.Name = "TenCongTy";
            // 
            // MaSothue
            // 
            MaSothue.DataPropertyName = "MaSoThue";
            MaSothue.FillWeight = 107.165771F;
            MaSothue.HeaderText = "Mã Số Thuế";
            MaSothue.MinimumWidth = 6;
            MaSothue.Name = "MaSothue";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.FillWeight = 107.165771F;
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.FillWeight = 107.165771F;
            SoDienThoai.HeaderText = "Số Điện Thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // NguoiDaiDien
            // 
            NguoiDaiDien.DataPropertyName = "NguoiDaiDien";
            NguoiDaiDien.FillWeight = 107.165771F;
            NguoiDaiDien.HeaderText = "Người Đại Diện";
            NguoiDaiDien.MinimumWidth = 6;
            NguoiDaiDien.Name = "NguoiDaiDien";
            // 
            // khachHangBindingSource
            // 
            khachHangBindingSource.DataSource = typeof(Data.KhachHang);
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.Transparent;
            btnNhap.FlatAppearance.BorderSize = 0;
            btnNhap.FlatAppearance.MouseOverBackColor = Color.SpringGreen;
            btnNhap.FlatStyle = FlatStyle.Flat;
            btnNhap.ForeColor = Color.Black;
            btnNhap.Image = (Image)resources.GetObject("btnNhap.Image");
            btnNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhap.Location = new Point(450, 188);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(145, 46);
            btnNhap.TabIndex = 32;
            btnNhap.Text = "Nhập Excel";
            btnNhap.TextAlign = ContentAlignment.MiddleRight;
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.Transparent;
            btnXuat.FlatAppearance.BorderSize = 0;
            btnXuat.FlatAppearance.MouseOverBackColor = Color.SpringGreen;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.ForeColor = Color.Black;
            btnXuat.Image = (Image)resources.GetObject("btnXuat.Image");
            btnXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuat.Location = new Point(450, 232);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(145, 46);
            btnXuat.TabIndex = 31;
            btnXuat.Text = "Xuất Excel";
            btnXuat.TextAlign = ContentAlignment.MiddleRight;
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Transparent;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatAppearance.MouseOverBackColor = Color.Red;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.Black;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(621, 209);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(99, 46);
            btnThoat.TabIndex = 30;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Transparent;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(301, 232);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(127, 46);
            btnTimKiem.TabIndex = 29;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.Transparent;
            btnHuyBo.FlatAppearance.BorderSize = 0;
            btnHuyBo.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.ForeColor = Color.Black;
            btnHuyBo.Image = (Image)resources.GetObject("btnHuyBo.Image");
            btnHuyBo.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyBo.Location = new Point(301, 188);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(115, 46);
            btnHuyBo.TabIndex = 28;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.TextAlign = ContentAlignment.MiddleRight;
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Transparent;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.Black;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(188, 232);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 46);
            btnLuu.TabIndex = 27;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Transparent;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatAppearance.MouseOverBackColor = Color.Red;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.Black;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(188, 188);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 46);
            btnXoa.TabIndex = 26;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Transparent;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.Black;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(61, 232);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(91, 46);
            btnSua.TabIndex = 25;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Transparent;
            btnThem.BackgroundImageLayout = ImageLayout.Zoom;
            btnThem.FlatAppearance.BorderColor = Color.Lime;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnThem.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.Black;
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(61, 188);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 46);
            btnThem.TabIndex = 24;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 753);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KHÁCH HÀNG";
            WindowState = FormWindowState.Maximized;
            Load += frmKhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)khachHangBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)khoiTaoMoiBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNguoiDaiDien;
        private Label label5;
        private TextBox txtMaSoThue;
        private Label label6;
        private TextBox txtDienThoai;
        private Label label3;
        private TextBox txtDiaChi;
        private Label label2;
        private TextBox txtTenCongTy;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvKhachHang;
        private BindingSource khachHangBindingSource;
        private BindingSource khoiTaoMoiBindingSource;
        private TextBox txtTimKiem;
        private Label label9;
        private DataGridViewTextBoxColumn Idcol;
        private DataGridViewTextBoxColumn TenCongTy;
        private DataGridViewTextBoxColumn MaSothue;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn NguoiDaiDien;
        private PictureBox pictureBox1;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}