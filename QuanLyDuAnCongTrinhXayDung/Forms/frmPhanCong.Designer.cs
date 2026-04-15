namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmPhanCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanCong));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnCongViec = new Button();
            btnNhap = new Button();
            dtpNgayKetThuc = new DateTimePicker();
            btnXuat = new Button();
            dtpNgayBatDau = new DateTimePicker();
            btnThoat = new Button();
            cboTenDuAn = new ComboBox();
            btnTimKiem = new Button();
            cboNhanVien = new ComboBox();
            btnHuyBo = new Button();
            btnLuu = new Button();
            cboTenCongViec = new ComboBox();
            btnXoa = new Button();
            label7 = new Label();
            btnSua = new Button();
            label8 = new Label();
            btnThem = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTienDo = new TextBox();
            label3 = new Label();
            txtPhuCap = new TextBox();
            label2 = new Label();
            txtVaiTro = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNhanVien = new DataGridViewTextBoxColumn();
            colDuAn = new DataGridViewTextBoxColumn();
            colCongViec = new DataGridViewTextBoxColumn();
            vaiTroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phuCapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngayBatDauDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngayKetThucDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phanTramHoanThanhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phanCongBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phanCongBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnCongViec);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(dtpNgayKetThuc);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(dtpNgayBatDau);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(cboTenDuAn);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(cboTenCongViec);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTienDo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPhuCap);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtVaiTro);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1309, 306);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Phân công";
            // 
            // btnCongViec
            // 
            btnCongViec.BackColor = Color.Transparent;
            btnCongViec.FlatAppearance.BorderSize = 0;
            btnCongViec.FlatAppearance.MouseOverBackColor = Color.SpringGreen;
            btnCongViec.FlatStyle = FlatStyle.Flat;
            btnCongViec.ForeColor = Color.Black;
            btnCongViec.Image = (Image)resources.GetObject("btnCongViec.Image");
            btnCongViec.ImageAlign = ContentAlignment.MiddleLeft;
            btnCongViec.Location = new Point(678, 250);
            btnCongViec.Name = "btnCongViec";
            btnCongViec.Size = new Size(192, 46);
            btnCongViec.TabIndex = 43;
            btnCongViec.Text = "Thêm công việc";
            btnCongViec.TextAlign = ContentAlignment.MiddleRight;
            btnCongViec.UseVisualStyleBackColor = false;
            btnCongViec.Click += btnCongViec_Click;
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
            btnNhap.Location = new Point(507, 206);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(145, 46);
            btnNhap.TabIndex = 41;
            btnNhap.Text = "Nhập Excel";
            btnNhap.TextAlign = ContentAlignment.MiddleRight;
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Location = new Point(1028, 117);
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
            btnXuat.Location = new Point(507, 250);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(145, 46);
            btnXuat.TabIndex = 40;
            btnXuat.Text = "Xuất Excel";
            btnXuat.TextAlign = ContentAlignment.MiddleRight;
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Location = new Point(1024, 62);
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
            btnThoat.Location = new Point(678, 206);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(99, 46);
            btnThoat.TabIndex = 39;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // cboTenDuAn
            // 
            cboTenDuAn.FormattingEnabled = true;
            cboTenDuAn.Items.AddRange(new object[] { "Kỹ Sư", "Nhân Viên" });
            cboTenDuAn.Location = new Point(122, 42);
            cboTenDuAn.Name = "cboTenDuAn";
            cboTenDuAn.Size = new Size(316, 36);
            cboTenDuAn.TabIndex = 27;
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
            btnTimKiem.Location = new Point(358, 250);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(127, 46);
            btnTimKiem.TabIndex = 38;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Items.AddRange(new object[] { "Kỹ Sư", "Nhân Viên" });
            cboNhanVien.Location = new Point(564, 42);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(301, 36);
            cboNhanVien.TabIndex = 26;
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
            btnHuyBo.Location = new Point(358, 206);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(115, 46);
            btnHuyBo.TabIndex = 37;
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
            btnLuu.Location = new Point(245, 250);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 46);
            btnLuu.TabIndex = 36;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // cboTenCongViec
            // 
            cboTenCongViec.FormattingEnabled = true;
            cboTenCongViec.Items.AddRange(new object[] { "Kỹ Sư", "Nhân Viên" });
            cboTenCongViec.Location = new Point(122, 93);
            cboTenCongViec.Name = "cboTenCongViec";
            cboTenCongViec.Size = new Size(316, 36);
            cboTenCongViec.TabIndex = 15;
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
            btnXoa.Location = new Point(245, 206);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 46);
            btnXoa.TabIndex = 35;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(887, 62);
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
            btnSua.Location = new Point(118, 250);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(91, 46);
            btnSua.TabIndex = 34;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(887, 117);
            label8.Name = "label8";
            label8.Size = new Size(143, 28);
            label8.TabIndex = 12;
            label8.Text = "Ngày kết thúc: ";
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
            btnThem.Location = new Point(118, 206);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 46);
            btnThem.TabIndex = 33;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(475, 93);
            label4.Name = "label4";
            label4.Size = new Size(78, 28);
            label4.TabIndex = 10;
            label4.Text = "Vai trò: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(444, 42);
            label5.Name = "label5";
            label5.Size = new Size(109, 28);
            label5.TabIndex = 8;
            label5.Text = "Nhân viên: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 96);
            label6.Name = "label6";
            label6.Size = new Size(107, 28);
            label6.TabIndex = 6;
            label6.Text = "Công việc: ";
            // 
            // txtTienDo
            // 
            txtTienDo.Location = new Point(564, 151);
            txtTienDo.Name = "txtTienDo";
            txtTienDo.Size = new Size(301, 34);
            txtTienDo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 151);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 4;
            label3.Text = "Tiến độ: ";
            // 
            // txtPhuCap
            // 
            txtPhuCap.Location = new Point(122, 151);
            txtPhuCap.Name = "txtPhuCap";
            txtPhuCap.Size = new Size(316, 34);
            txtPhuCap.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 151);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 2;
            label2.Text = "Phụ cấp: ";
            // 
            // txtVaiTro
            // 
            txtVaiTro.Location = new Point(564, 95);
            txtVaiTro.Name = "txtVaiTro";
            txtVaiTro.Size = new Size(301, 34);
            txtVaiTro.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 0;
            label1.Text = "Dự án: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(822, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(462, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(10, 324);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1309, 476);
            groupBox2.TabIndex = 5;
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, colNhanVien, colDuAn, colCongViec, vaiTroDataGridViewTextBoxColumn, phuCapDataGridViewTextBoxColumn, ngayBatDauDataGridViewTextBoxColumn, ngayKetThucDataGridViewTextBoxColumn, phanTramHoanThanhDataGridViewTextBoxColumn });
            dataGridView.DataSource = phanCongBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Location = new Point(6, 33);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1297, 437);
            dataGridView.TabIndex = 0;
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
            // colNhanVien
            // 
            colNhanVien.DataPropertyName = "TenNhanVien";
            colNhanVien.HeaderText = "Nhân viên";
            colNhanVien.MinimumWidth = 6;
            colNhanVien.Name = "colNhanVien";
            // 
            // colDuAn
            // 
            colDuAn.DataPropertyName = "TenDuAn";
            colDuAn.HeaderText = "Dự án";
            colDuAn.MinimumWidth = 6;
            colDuAn.Name = "colDuAn";
            // 
            // colCongViec
            // 
            colCongViec.DataPropertyName = "TenCongViec";
            colCongViec.HeaderText = "Công việc";
            colCongViec.MinimumWidth = 6;
            colCongViec.Name = "colCongViec";
            // 
            // vaiTroDataGridViewTextBoxColumn
            // 
            vaiTroDataGridViewTextBoxColumn.DataPropertyName = "VaiTro";
            vaiTroDataGridViewTextBoxColumn.HeaderText = "Vai trò";
            vaiTroDataGridViewTextBoxColumn.MinimumWidth = 6;
            vaiTroDataGridViewTextBoxColumn.Name = "vaiTroDataGridViewTextBoxColumn";
            // 
            // phuCapDataGridViewTextBoxColumn
            // 
            phuCapDataGridViewTextBoxColumn.DataPropertyName = "PhuCap";
            phuCapDataGridViewTextBoxColumn.HeaderText = "Phụ cấp";
            phuCapDataGridViewTextBoxColumn.MinimumWidth = 6;
            phuCapDataGridViewTextBoxColumn.Name = "phuCapDataGridViewTextBoxColumn";
            // 
            // ngayBatDauDataGridViewTextBoxColumn
            // 
            ngayBatDauDataGridViewTextBoxColumn.DataPropertyName = "NgayBatDau";
            ngayBatDauDataGridViewTextBoxColumn.HeaderText = "Ngày bắt đầu";
            ngayBatDauDataGridViewTextBoxColumn.MinimumWidth = 6;
            ngayBatDauDataGridViewTextBoxColumn.Name = "ngayBatDauDataGridViewTextBoxColumn";
            // 
            // ngayKetThucDataGridViewTextBoxColumn
            // 
            ngayKetThucDataGridViewTextBoxColumn.DataPropertyName = "NgayKetThuc";
            ngayKetThucDataGridViewTextBoxColumn.HeaderText = "Ngày kết thúc";
            ngayKetThucDataGridViewTextBoxColumn.MinimumWidth = 6;
            ngayKetThucDataGridViewTextBoxColumn.Name = "ngayKetThucDataGridViewTextBoxColumn";
            // 
            // phanTramHoanThanhDataGridViewTextBoxColumn
            // 
            phanTramHoanThanhDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            phanTramHoanThanhDataGridViewTextBoxColumn.DataPropertyName = "PhanTramHoanThanh";
            phanTramHoanThanhDataGridViewTextBoxColumn.HeaderText = "Tiến độ";
            phanTramHoanThanhDataGridViewTextBoxColumn.MinimumWidth = 6;
            phanTramHoanThanhDataGridViewTextBoxColumn.Name = "phanTramHoanThanhDataGridViewTextBoxColumn";
            phanTramHoanThanhDataGridViewTextBoxColumn.Width = 125;
            // 
            // phanCongBindingSource
            // 
            phanCongBindingSource.DataSource = typeof(Data.PhanCong);
            // 
            // frmPhanCong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 808);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmPhanCong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phân Công";
            WindowState = FormWindowState.Maximized;
            Load += frmPhanCong_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)phanCongBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpNgayKetThuc;
        private DateTimePicker dtpNgayBatDau;
        private ComboBox cboTenDuAn;
        private ComboBox cboNhanVien;
        private ComboBox cboTenCongViec;
        private Label label7;
        private Label label8;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTienDo;
        private Label label3;
        private TextBox txtPhuCap;
        private Label label2;
        private TextBox txtVaiTro;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private BindingSource phanCongBindingSource;
        private DataGridViewTextBoxColumn duAnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nhanVienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn congViecDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNhanVien;
        private DataGridViewTextBoxColumn colDuAn;
        private DataGridViewTextBoxColumn colCongViec;
        private DataGridViewTextBoxColumn vaiTroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phuCapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayBatDauDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayKetThucDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phanTramHoanThanhDataGridViewTextBoxColumn;
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
        private Button btnCongViec;
    }
}