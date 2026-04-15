namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmDuAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDuAn));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnNKCT = new Button();
            btnXemNDT = new Button();
            btnThemLoai = new Button();
            btnNhap = new Button();
            dtpNgayKetThuc = new DateTimePicker();
            btnXuat = new Button();
            dtpNgayBatDau = new DateTimePicker();
            btnThoat = new Button();
            cboNhaDauTu = new ComboBox();
            btnTimKiem = new Button();
            cboKhachHang = new ComboBox();
            btnHuyBo = new Button();
            btnLuu = new Button();
            cboTenLoai = new ComboBox();
            btnXoa = new Button();
            label7 = new Label();
            btnSua = new Button();
            label8 = new Label();
            btnThem = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNganSach = new TextBox();
            label3 = new Label();
            txtDiaDiem = new TextBox();
            label2 = new Label();
            txtTenDuAn = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            duAnBindingSource = new BindingSource(components);
            colID = new DataGridViewTextBoxColumn();
            TenDuAn = new DataGridViewTextBoxColumn();
            colLoaiDuAn = new DataGridViewTextBoxColumn();
            colNhaDauTu = new DataGridViewTextBoxColumn();
            colKhachHang = new DataGridViewTextBoxColumn();
            DiaDiem = new DataGridViewTextBoxColumn();
            NgayBatDau = new DataGridViewTextBoxColumn();
            NgayKetThuc = new DataGridViewTextBoxColumn();
            NganSach = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)duAnBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(btnNKCT);
            groupBox1.Controls.Add(btnXemNDT);
            groupBox1.Controls.Add(btnThemLoai);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(dtpNgayKetThuc);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(dtpNgayBatDau);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(cboNhaDauTu);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(cboTenLoai);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNganSach);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDiaDiem);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTenDuAn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1317, 297);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Dự án";
            // 
            // btnNKCT
            // 
            btnNKCT.BackColor = Color.Transparent;
            btnNKCT.FlatAppearance.BorderSize = 0;
            btnNKCT.FlatAppearance.MouseOverBackColor = Color.SpringGreen;
            btnNKCT.FlatStyle = FlatStyle.Flat;
            btnNKCT.ForeColor = Color.Black;
            btnNKCT.Image = (Image)resources.GetObject("btnNKCT.Image");
            btnNKCT.ImageAlign = ContentAlignment.MiddleLeft;
            btnNKCT.Location = new Point(755, 235);
            btnNKCT.Name = "btnNKCT";
            btnNKCT.Size = new Size(148, 46);
            btnNKCT.TabIndex = 38;
            btnNKCT.Text = "Xem NKCT";
            btnNKCT.TextAlign = ContentAlignment.MiddleRight;
            btnNKCT.UseVisualStyleBackColor = false;
            btnNKCT.Click += btnNKCT_Click;
            // 
            // btnXemNDT
            // 
            btnXemNDT.BackColor = Color.Transparent;
            btnXemNDT.FlatAppearance.BorderSize = 0;
            btnXemNDT.FlatAppearance.MouseOverBackColor = Color.SpringGreen;
            btnXemNDT.FlatStyle = FlatStyle.Flat;
            btnXemNDT.ForeColor = Color.Black;
            btnXemNDT.Image = (Image)resources.GetObject("btnXemNDT.Image");
            btnXemNDT.ImageAlign = ContentAlignment.MiddleLeft;
            btnXemNDT.Location = new Point(598, 235);
            btnXemNDT.Name = "btnXemNDT";
            btnXemNDT.Size = new Size(136, 46);
            btnXemNDT.TabIndex = 37;
            btnXemNDT.Text = "Xem NĐT";
            btnXemNDT.TextAlign = ContentAlignment.MiddleRight;
            btnXemNDT.UseVisualStyleBackColor = false;
            btnXemNDT.Click += btnXemNDT_Click;
            // 
            // btnThemLoai
            // 
            btnThemLoai.BackColor = Color.Transparent;
            btnThemLoai.FlatAppearance.BorderSize = 0;
            btnThemLoai.FlatAppearance.MouseOverBackColor = Color.SpringGreen;
            btnThemLoai.FlatStyle = FlatStyle.Flat;
            btnThemLoai.ForeColor = Color.Black;
            btnThemLoai.Image = (Image)resources.GetObject("btnThemLoai.Image");
            btnThemLoai.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemLoai.Location = new Point(598, 191);
            btnThemLoai.Name = "btnThemLoai";
            btnThemLoai.Size = new Size(192, 46);
            btnThemLoai.TabIndex = 36;
            btnThemLoai.Text = "Thêm loại dự án";
            btnThemLoai.TextAlign = ContentAlignment.MiddleRight;
            btnThemLoai.UseVisualStyleBackColor = false;
            btnThemLoai.Click += btnThemLoai_Click;
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
            btnNhap.Location = new Point(422, 191);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(145, 46);
            btnNhap.TabIndex = 32;
            btnNhap.Text = "Nhập Excel";
            btnNhap.TextAlign = ContentAlignment.MiddleRight;
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Location = new Point(1021, 145);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(256, 34);
            dtpNgayKetThuc.TabIndex = 29;
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
            btnXuat.Location = new Point(422, 235);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(145, 46);
            btnXuat.TabIndex = 31;
            btnXuat.Text = "Xuất Excel";
            btnXuat.TextAlign = ContentAlignment.MiddleRight;
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Location = new Point(1017, 90);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(260, 34);
            dtpNgayBatDau.TabIndex = 28;
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
            btnThoat.Location = new Point(804, 191);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(99, 46);
            btnThoat.TabIndex = 30;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // cboNhaDauTu
            // 
            cboNhaDauTu.FormattingEnabled = true;
            cboNhaDauTu.Items.AddRange(new object[] { "Kỹ Sư", "Nhân Viên" });
            cboNhaDauTu.Location = new Point(564, 93);
            cboNhaDauTu.Name = "cboNhaDauTu";
            cboNhaDauTu.Size = new Size(301, 36);
            cboNhaDauTu.TabIndex = 27;
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
            btnTimKiem.Location = new Point(273, 235);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(127, 46);
            btnTimKiem.TabIndex = 29;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Items.AddRange(new object[] { "Kỹ Sư", "Nhân Viên" });
            cboKhachHang.Location = new Point(564, 42);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(301, 36);
            cboKhachHang.TabIndex = 26;
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
            btnHuyBo.Location = new Point(273, 191);
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
            btnLuu.Location = new Point(160, 235);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 46);
            btnLuu.TabIndex = 27;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // cboTenLoai
            // 
            cboTenLoai.FormattingEnabled = true;
            cboTenLoai.Items.AddRange(new object[] { "Kỹ Sư", "Nhân Viên" });
            cboTenLoai.Location = new Point(122, 93);
            cboTenLoai.Name = "cboTenLoai";
            cboTenLoai.Size = new Size(316, 36);
            cboTenLoai.TabIndex = 15;
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
            btnXoa.Location = new Point(160, 191);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 46);
            btnXoa.TabIndex = 26;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(880, 90);
            label7.Name = "label7";
            label7.Size = new Size(140, 28);
            label7.TabIndex = 14;
            label7.Text = "Ngày bắt đầu: ";
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
            btnSua.Location = new Point(33, 235);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(91, 46);
            btnSua.TabIndex = 25;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(880, 145);
            label8.Name = "label8";
            label8.Size = new Size(143, 28);
            label8.TabIndex = 12;
            label8.Text = "Ngày kết thúc: ";
            label8.Click += label8_Click;
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
            btnThem.Location = new Point(33, 191);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 46);
            btnThem.TabIndex = 24;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(446, 96);
            label4.Name = "label4";
            label4.Size = new Size(119, 28);
            label4.TabIndex = 10;
            label4.Text = "Nhà đầu tư: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(444, 42);
            label5.Name = "label5";
            label5.Size = new Size(123, 28);
            label5.TabIndex = 8;
            label5.Text = "Khách hàng: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 96);
            label6.Name = "label6";
            label6.Size = new Size(112, 28);
            label6.TabIndex = 6;
            label6.Text = "Loại dự án: ";
            // 
            // txtNganSach
            // 
            txtNganSach.Location = new Point(985, 44);
            txtNganSach.Name = "txtNganSach";
            txtNganSach.Size = new Size(292, 34);
            txtNganSach.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(876, 44);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 4;
            label3.Text = "Ngân sách: ";
            // 
            // txtDiaDiem
            // 
            txtDiaDiem.Location = new Point(122, 151);
            txtDiaDiem.Name = "txtDiaDiem";
            txtDiaDiem.Size = new Size(743, 34);
            txtDiaDiem.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 151);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 2;
            label2.Text = "Địa điểm: ";
            // 
            // txtTenDuAn
            // 
            txtTenDuAn.Location = new Point(122, 39);
            txtTenDuAn.Name = "txtTenDuAn";
            txtTenDuAn.Size = new Size(316, 34);
            txtTenDuAn.TabIndex = 1;
            txtTenDuAn.TextChanged += txtHoTen_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên dự án: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(909, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(402, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 315);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1317, 495);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Dự án";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeight = 29;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, TenDuAn, colLoaiDuAn, colNhaDauTu, colKhachHang, DiaDiem, NgayBatDau, NgayKetThuc, NganSach });
            dataGridView.DataSource = duAnBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.Location = new Point(6, 33);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView.Size = new Size(1305, 456);
            dataGridView.TabIndex = 0;
            // 
            // duAnBindingSource
            // 
            duAnBindingSource.DataSource = typeof(Data.DuAn);
            // 
            // colID
            // 
            colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Width = 50;
            // 
            // TenDuAn
            // 
            TenDuAn.DataPropertyName = "TenDuAn";
            TenDuAn.HeaderText = "Tên dự án";
            TenDuAn.MinimumWidth = 6;
            TenDuAn.Name = "TenDuAn";
            // 
            // colLoaiDuAn
            // 
            colLoaiDuAn.DataPropertyName = "TenLoai";
            colLoaiDuAn.HeaderText = "Loại dự án";
            colLoaiDuAn.MinimumWidth = 6;
            colLoaiDuAn.Name = "colLoaiDuAn";
            // 
            // colNhaDauTu
            // 
            colNhaDauTu.DataPropertyName = "TenNhaDauTu";
            colNhaDauTu.HeaderText = "Nhà đầu tư";
            colNhaDauTu.MinimumWidth = 6;
            colNhaDauTu.Name = "colNhaDauTu";
            // 
            // colKhachHang
            // 
            colKhachHang.DataPropertyName = "TenKhachHang";
            colKhachHang.HeaderText = "Khách hàng";
            colKhachHang.MinimumWidth = 6;
            colKhachHang.Name = "colKhachHang";
            // 
            // DiaDiem
            // 
            DiaDiem.DataPropertyName = "DiaDiem";
            DiaDiem.HeaderText = "Địa diểm";
            DiaDiem.MinimumWidth = 6;
            DiaDiem.Name = "DiaDiem";
            // 
            // NgayBatDau
            // 
            NgayBatDau.DataPropertyName = "NgayBatDau";
            NgayBatDau.HeaderText = "Ngày bắt đầu";
            NgayBatDau.MinimumWidth = 6;
            NgayBatDau.Name = "NgayBatDau";
            // 
            // NgayKetThuc
            // 
            NgayKetThuc.DataPropertyName = "NgayKetThuc";
            NgayKetThuc.HeaderText = "Ngày kết thúc";
            NgayKetThuc.MinimumWidth = 6;
            NgayKetThuc.Name = "NgayKetThuc";
            // 
            // NganSach
            // 
            NganSach.DataPropertyName = "NganSach";
            dataGridViewCellStyle2.Format = "C0";
            NganSach.DefaultCellStyle = dataGridViewCellStyle2;
            NganSach.HeaderText = "Ngân sách";
            NganSach.MinimumWidth = 6;
            NganSach.Name = "NganSach";
            // 
            // frmDuAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 822);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmDuAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dự Án";
            WindowState = FormWindowState.Maximized;
            Load += frmDuAn_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)duAnBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboTenLoai;
        private Label label7;
        private Label label8;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNganSach;
        private Label label3;
        private TextBox txtDiaDiem;
        private Label label2;
        private TextBox txtTenDuAn;
        private Label label1;
        private DateTimePicker dtpNgayBatDau;
        private ComboBox cboNhaDauTu;
        private ComboBox cboKhachHang;
        private DateTimePicker dtpNgayKetThuc;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private BindingSource duAnBindingSource;
        private DataGridViewTextBoxColumn LoaiDuAn;
        private DataGridViewTextBoxColumn KhachHang;
        private DataGridViewTextBoxColumn NhaDauTu;
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
        private Button btnXemNDT;
        private Button btnThemLoai;
        private Button btnNKCT;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn TenDuAn;
        private DataGridViewTextBoxColumn colLoaiDuAn;
        private DataGridViewTextBoxColumn colNhaDauTu;
        private DataGridViewTextBoxColumn colKhachHang;
        private DataGridViewTextBoxColumn DiaDiem;
        private DataGridViewTextBoxColumn NgayBatDau;
        private DataGridViewTextBoxColumn NgayKetThuc;
        private DataGridViewTextBoxColumn NganSach;
    }
}