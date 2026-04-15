namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmVatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVatTu));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnDoiAnh = new Button();
            numDonGia = new NumericUpDown();
            btnNhap = new Button();
            label4 = new Label();
            btnXuat = new Button();
            ptbHinhAnh = new PictureBox();
            btnThoat = new Button();
            txtTenVatTu = new TextBox();
            btnTimKiem = new Button();
            txtDonViTinh = new TextBox();
            btnHuyBo = new Button();
            btnLuu = new Button();
            label3 = new Label();
            btnXoa = new Button();
            label2 = new Label();
            btnSua = new Button();
            label1 = new Label();
            btnThem = new Button();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenVatTu = new DataGridViewTextBoxColumn();
            colDonViTinh = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            danhSachVatTuBindingSource = new BindingSource(components);
            vatTuBindingSource = new BindingSource(components);
            phanPhoiChiTietBindingSource = new BindingSource(components);
            phanPhoiBindingSource = new BindingSource(components);
            chiTietPhanPhoiBindingSource = new BindingSource(components);
            phanPhoiBindingSource1 = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)danhSachVatTuBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vatTuBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiChiTietBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chiTietPhanPhoiBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(ptbHinhAnh);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(txtTenVatTu);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtDonViTinh);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1179, 298);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Vật tư";
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.BackColor = Color.Transparent;
            btnDoiAnh.FlatAppearance.BorderSize = 0;
            btnDoiAnh.FlatAppearance.MouseOverBackColor = Color.SpringGreen;
            btnDoiAnh.FlatStyle = FlatStyle.Flat;
            btnDoiAnh.ForeColor = Color.Black;
            btnDoiAnh.Image = (Image)resources.GetObject("btnDoiAnh.Image");
            btnDoiAnh.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoiAnh.Location = new Point(531, 100);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(122, 34);
            btnDoiAnh.TabIndex = 53;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.TextAlign = ContentAlignment.MiddleRight;
            btnDoiAnh.UseVisualStyleBackColor = false;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(132, 89);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(356, 34);
            numDonGia.TabIndex = 37;
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
            btnNhap.Location = new Point(415, 199);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(145, 34);
            btnNhap.TabIndex = 52;
            btnNhap.Text = "Nhập Excel";
            btnNhap.TextAlign = ContentAlignment.MiddleRight;
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(531, 39);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 35;
            label4.Text = "Hình ảnh: ";
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
            btnXuat.Location = new Point(415, 243);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(145, 34);
            btnXuat.TabIndex = 51;
            btnXuat.Text = "Xuất Excel";
            btnXuat.TextAlign = ContentAlignment.MiddleRight;
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // ptbHinhAnh
            // 
            ptbHinhAnh.Location = new Point(659, 39);
            ptbHinhAnh.Name = "ptbHinhAnh";
            ptbHinhAnh.Size = new Size(165, 140);
            ptbHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbHinhAnh.TabIndex = 34;
            ptbHinhAnh.TabStop = false;
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
            btnThoat.Location = new Point(585, 224);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(99, 34);
            btnThoat.TabIndex = 50;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtTenVatTu
            // 
            txtTenVatTu.Location = new Point(132, 39);
            txtTenVatTu.Name = "txtTenVatTu";
            txtTenVatTu.Size = new Size(356, 34);
            txtTenVatTu.TabIndex = 33;
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
            btnTimKiem.Location = new Point(266, 243);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(127, 34);
            btnTimKiem.TabIndex = 49;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Location = new Point(132, 145);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.Size = new Size(356, 34);
            txtDonViTinh.TabIndex = 5;
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
            btnHuyBo.Location = new Point(266, 199);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(115, 34);
            btnHuyBo.TabIndex = 48;
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
            btnLuu.Location = new Point(153, 243);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 34);
            btnLuu.TabIndex = 47;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 145);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 4;
            label3.Text = "Đơn vị tính: ";
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
            btnXoa.Location = new Point(153, 199);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 34);
            btnXoa.TabIndex = 46;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 91);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 2;
            label2.Text = "Đơn giá: ";
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
            btnSua.Location = new Point(26, 243);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(91, 34);
            btnSua.TabIndex = 45;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên Vật tư: ";
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
            btnThem.Location = new Point(26, 199);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 34);
            btnThem.TabIndex = 44;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(701, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(462, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 316);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1179, 398);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Vật tư";
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, colTenVatTu, colDonViTinh, colDonGia, HinhAnh });
            dataGridView.DataSource = danhSachVatTuBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.Location = new Point(6, 33);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView.Size = new Size(1167, 359);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // colID
            // 
            colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Width = 125;
            // 
            // colTenVatTu
            // 
            colTenVatTu.DataPropertyName = "TenVatTu";
            colTenVatTu.HeaderText = "Tên Vật tư";
            colTenVatTu.MinimumWidth = 6;
            colTenVatTu.Name = "colTenVatTu";
            // 
            // colDonViTinh
            // 
            colDonViTinh.DataPropertyName = "DonViTinh";
            colDonViTinh.HeaderText = "Đơn Vị Tính";
            colDonViTinh.MinimumWidth = 6;
            colDonViTinh.Name = "colDonViTinh";
            // 
            // colDonGia
            // 
            colDonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle2.Format = "C0";
            colDonGia.DefaultCellStyle = dataGridViewCellStyle2;
            colDonGia.HeaderText = "Đơn Giá";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            // 
            // HinhAnh
            // 
            HinhAnh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình Ảnh";
            HinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.Width = 223;
            // 
            // danhSachVatTuBindingSource
            // 
            danhSachVatTuBindingSource.DataSource = typeof(Data.DanhSachVatTu);
            // 
            // vatTuBindingSource
            // 
            vatTuBindingSource.DataSource = typeof(Data.VatTu);
            // 
            // phanPhoiChiTietBindingSource
            // 
            phanPhoiChiTietBindingSource.DataSource = typeof(Data.PhanPhoiChiTiet);
            // 
            // phanPhoiBindingSource
            // 
            phanPhoiBindingSource.DataSource = typeof(Data.PhanPhoi);
            // 
            // chiTietPhanPhoiBindingSource
            // 
            chiTietPhanPhoiBindingSource.DataMember = "ChiTietPhanPhoi";
            chiTietPhanPhoiBindingSource.DataSource = phanPhoiBindingSource;
            // 
            // phanPhoiBindingSource1
            // 
            phanPhoiBindingSource1.DataSource = typeof(Data.PhanPhoi);
            // 
            // frmVatTu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 774);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmVatTu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vật Tư";
            WindowState = FormWindowState.Maximized;
            Load += frmVatTu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)danhSachVatTuBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)vatTuBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiChiTietBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)chiTietPhanPhoiBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDonViTinh;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTenVatTu;
        private Label label4;
        private PictureBox ptbHinhAnh;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private BindingSource chiTietPhanPhoiBindingSource;
        private BindingSource phanPhoiBindingSource;
        private BindingSource phanPhoiChiTietBindingSource;
        private BindingSource vatTuBindingSource;
        private BindingSource phanPhoiBindingSource1;
        private NumericUpDown numDonGia;
        private BindingSource danhSachVatTuBindingSource;
        private PictureBox pictureBox1;
        private Button btnDoiAnh;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenVatTu;
        private DataGridViewTextBoxColumn colDonViTinh;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewImageColumn HinhAnh;
    }
}