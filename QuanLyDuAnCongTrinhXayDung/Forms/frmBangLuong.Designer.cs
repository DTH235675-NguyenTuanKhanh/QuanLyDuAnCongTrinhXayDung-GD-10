namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmBangLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangLuong));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtLuongCoBan = new TextBox();
            label7 = new Label();
            cboNhanVien = new ComboBox();
            txtSoNgayCong = new TextBox();
            label4 = new Label();
            btnNhap = new Button();
            btnXuat = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtThucLinh = new TextBox();
            label5 = new Label();
            txtTongPhuCap = new TextBox();
            label6 = new Label();
            txtNam = new TextBox();
            label3 = new Label();
            txtThang = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            bangLuongBindingSource = new BindingSource(components);
            colID = new DataGridViewTextBoxColumn();
            NhanVien = new DataGridViewTextBoxColumn();
            Thang = new DataGridViewTextBoxColumn();
            Nam = new DataGridViewTextBoxColumn();
            SoNgayCong = new DataGridViewTextBoxColumn();
            TongPhuCap = new DataGridViewTextBoxColumn();
            ThucLinh = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bangLuongBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AccessibleRole = AccessibleRole.None;
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(txtLuongCoBan);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(txtSoNgayCong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtThucLinh);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTongPhuCap);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNam);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtThang);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1187, 275);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Lương";
            // 
            // txtLuongCoBan
            // 
            txtLuongCoBan.Location = new Point(839, 91);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.Size = new Size(325, 34);
            txtLuongCoBan.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(687, 91);
            label7.Name = "label7";
            label7.Size = new Size(143, 28);
            label7.TabIndex = 31;
            label7.Text = "Lương Cơ Bản: ";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(169, 38);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(491, 36);
            cboNhanVien.TabIndex = 30;
            // 
            // txtSoNgayCong
            // 
            txtSoNgayCong.Location = new Point(468, 91);
            txtSoNgayCong.Name = "txtSoNgayCong";
            txtSoNgayCong.Size = new Size(192, 34);
            txtSoNgayCong.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 91);
            label4.Name = "label4";
            label4.Size = new Size(141, 28);
            label4.TabIndex = 28;
            label4.Text = "Số ngày công: ";
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
            btnNhap.Location = new Point(409, 179);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(145, 46);
            btnNhap.TabIndex = 23;
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
            btnXuat.Location = new Point(409, 223);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(145, 46);
            btnXuat.TabIndex = 22;
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
            btnThoat.Location = new Point(580, 200);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(99, 46);
            btnThoat.TabIndex = 21;
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
            btnTimKiem.Location = new Point(260, 223);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(127, 46);
            btnTimKiem.TabIndex = 20;
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
            btnHuyBo.Location = new Point(260, 179);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(115, 46);
            btnHuyBo.TabIndex = 19;
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
            btnLuu.Location = new Point(147, 223);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 46);
            btnLuu.TabIndex = 18;
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
            btnXoa.Location = new Point(147, 179);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 46);
            btnXoa.TabIndex = 17;
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
            btnSua.Location = new Point(20, 223);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(91, 46);
            btnSua.TabIndex = 16;
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
            btnThem.Location = new Point(20, 179);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 46);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtThucLinh
            // 
            txtThucLinh.Location = new Point(818, 46);
            txtThucLinh.Name = "txtThucLinh";
            txtThucLinh.Size = new Size(346, 34);
            txtThucLinh.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(695, 46);
            label5.Name = "label5";
            label5.Size = new Size(104, 28);
            label5.TabIndex = 8;
            label5.Text = "Thực Lĩnh: ";
            // 
            // txtTongPhuCap
            // 
            txtTongPhuCap.Location = new Point(468, 139);
            txtTongPhuCap.Name = "txtTongPhuCap";
            txtTongPhuCap.Size = new Size(192, 34);
            txtTongPhuCap.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(321, 145);
            label6.Name = "label6";
            label6.Size = new Size(141, 28);
            label6.TabIndex = 6;
            label6.Text = "Tổng phụ cấp: ";
            // 
            // txtNam
            // 
            txtNam.Location = new Point(101, 139);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(203, 34);
            txtNam.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 145);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 4;
            label3.Text = "Năm: ";
            label3.Click += label3_Click;
            // 
            // txtThang
            // 
            txtThang.Location = new Point(101, 91);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(203, 34);
            txtThang.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 91);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 2;
            label2.Text = "Tháng: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(143, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên Nhân viên: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(720, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 293);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1187, 552);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Lương";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, NhanVien, Thang, Nam, SoNgayCong, TongPhuCap, ThucLinh });
            dataGridView.DataSource = bangLuongBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.Location = new Point(6, 33);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView.Size = new Size(1175, 513);
            dataGridView.TabIndex = 0;
            // 
            // bangLuongBindingSource
            // 
            bangLuongBindingSource.DataSource = typeof(Data.BangLuong);
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
            // NhanVien
            // 
            NhanVien.DataPropertyName = "TenNhanVien";
            NhanVien.HeaderText = "Nhân Viên";
            NhanVien.MinimumWidth = 6;
            NhanVien.Name = "NhanVien";
            // 
            // Thang
            // 
            Thang.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Thang.DataPropertyName = "Thang";
            Thang.FillWeight = 54.2780762F;
            Thang.HeaderText = "Tháng";
            Thang.MinimumWidth = 6;
            Thang.Name = "Thang";
            Thang.Width = 125;
            // 
            // Nam
            // 
            Nam.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Nam.DataPropertyName = "Nam";
            Nam.FillWeight = 54.2780762F;
            Nam.HeaderText = "Năm";
            Nam.MinimumWidth = 6;
            Nam.Name = "Nam";
            Nam.Width = 125;
            // 
            // SoNgayCong
            // 
            SoNgayCong.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SoNgayCong.DataPropertyName = "SoNgayCong";
            SoNgayCong.FillWeight = 54.2780762F;
            SoNgayCong.HeaderText = "Số Ngày Công";
            SoNgayCong.MinimumWidth = 6;
            SoNgayCong.Name = "SoNgayCong";
            SoNgayCong.Width = 175;
            // 
            // TongPhuCap
            // 
            TongPhuCap.DataPropertyName = "TongPhuCap";
            dataGridViewCellStyle2.Format = "C0";
            TongPhuCap.DefaultCellStyle = dataGridViewCellStyle2;
            TongPhuCap.FillWeight = 54.2780762F;
            TongPhuCap.HeaderText = "Tổng Phụ Cấp";
            TongPhuCap.MinimumWidth = 6;
            TongPhuCap.Name = "TongPhuCap";
            // 
            // ThucLinh
            // 
            ThucLinh.DataPropertyName = "ThucLinh";
            dataGridViewCellStyle3.Format = "C0";
            ThucLinh.DefaultCellStyle = dataGridViewCellStyle3;
            ThucLinh.FillWeight = 54.2780762F;
            ThucLinh.HeaderText = "Thực Lĩnh";
            ThucLinh.MinimumWidth = 6;
            ThucLinh.Name = "ThucLinh";
            // 
            // frmBangLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 853);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmBangLuong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng Lương";
            WindowState = FormWindowState.Maximized;
            Load += frmBangLuong_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bangLuongBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtThucLinh;
        private Label label5;
        private TextBox txtTongPhuCap;
        private Label label6;
        private TextBox txtNam;
        private Label label3;
        private TextBox txtThang;
        private Label label2;
        private Label label1;
        private TextBox txtSoNgayCong;
        private Label label4;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private BindingSource bangLuongBindingSource;
        private ComboBox cboNhanVien;
        private TextBox txtLuongCoBan;
        private Label label7;
        private DataGridViewTextBoxColumn TenNhanVien;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn NhanVien;
        private DataGridViewTextBoxColumn Thang;
        private DataGridViewTextBoxColumn Nam;
        private DataGridViewTextBoxColumn SoNgayCong;
        private DataGridViewTextBoxColumn TongPhuCap;
        private DataGridViewTextBoxColumn ThucLinh;
    }
}