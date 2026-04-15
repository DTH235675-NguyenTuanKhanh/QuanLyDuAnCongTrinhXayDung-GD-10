namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmNhatKyCongTrinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhatKyCongTrinh));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnNhap = new Button();
            dtpNgayGhi = new DateTimePicker();
            btnXuat = new Button();
            cboDuAn = new ComboBox();
            btnThoat = new Button();
            txtGhiChu = new TextBox();
            btnTimKiem = new Button();
            label5 = new Label();
            btnHuyBo = new Button();
            btnLuu = new Button();
            label6 = new Label();
            btnXoa = new Button();
            txtNoiDungCongViec = new TextBox();
            btnSua = new Button();
            label2 = new Label();
            btnThem = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            DuAn = new DataGridViewTextBoxColumn();
            NgayGhi = new DataGridViewTextBoxColumn();
            NoiDungCongViec = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            nhatKyCongTrinhBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nhatKyCongTrinhBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(dtpNgayGhi);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(cboDuAn);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(txtNoiDungCongViec);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1265, 249);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Nhật ký";
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
            btnNhap.Location = new Point(815, 145);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(145, 46);
            btnNhap.TabIndex = 41;
            btnNhap.Text = "Nhập Excel";
            btnNhap.TextAlign = ContentAlignment.MiddleRight;
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // dtpNgayGhi
            // 
            dtpNgayGhi.Location = new Point(148, 145);
            dtpNgayGhi.Name = "dtpNgayGhi";
            dtpNgayGhi.Size = new Size(250, 34);
            dtpNgayGhi.TabIndex = 25;
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
            btnXuat.Location = new Point(815, 189);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(145, 46);
            btnXuat.TabIndex = 40;
            btnXuat.Text = "Xuất Excel";
            btnXuat.TextAlign = ContentAlignment.MiddleRight;
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // cboDuAn
            // 
            cboDuAn.FormattingEnabled = true;
            cboDuAn.Location = new Point(152, 42);
            cboDuAn.Name = "cboDuAn";
            cboDuAn.Size = new Size(481, 36);
            cboDuAn.TabIndex = 24;
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
            btnThoat.Location = new Point(986, 166);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(99, 46);
            btnThoat.TabIndex = 39;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(759, 42);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(484, 34);
            txtGhiChu.TabIndex = 9;
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
            btnTimKiem.Location = new Point(666, 189);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(127, 46);
            btnTimKiem.TabIndex = 38;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(666, 42);
            label5.Name = "label5";
            label5.Size = new Size(87, 28);
            label5.TabIndex = 8;
            label5.Text = "Ghi chú: ";
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
            btnHuyBo.Location = new Point(666, 145);
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
            btnLuu.Location = new Point(553, 189);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 46);
            btnLuu.TabIndex = 36;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 144);
            label6.Name = "label6";
            label6.Size = new Size(101, 28);
            label6.TabIndex = 6;
            label6.Text = "Ngày ghi: ";
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
            btnXoa.Location = new Point(553, 145);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 46);
            btnXoa.TabIndex = 35;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtNoiDungCongViec
            // 
            txtNoiDungCongViec.Location = new Point(208, 94);
            txtNoiDungCongViec.Name = "txtNoiDungCongViec";
            txtNoiDungCongViec.Size = new Size(1035, 34);
            txtNoiDungCongViec.TabIndex = 3;
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
            btnSua.Location = new Point(426, 189);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(91, 46);
            btnSua.TabIndex = 34;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 94);
            label2.Name = "label2";
            label2.Size = new Size(192, 28);
            label2.TabIndex = 2;
            label2.Text = "Nội dung công việc: ";
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
            btnThem.Location = new Point(426, 145);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 46);
            btnThem.TabIndex = 33;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên Dự Án: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(873, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 267);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1265, 456);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhật ký";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, DuAn, NgayGhi, NoiDungCongViec, GhiChu });
            dataGridView.DataSource = nhatKyCongTrinhBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Location = new Point(6, 33);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView.Size = new Size(1253, 408);
            dataGridView.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // DuAn
            // 
            DuAn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DuAn.DataPropertyName = "DuAn";
            DuAn.HeaderText = "Dự Án";
            DuAn.MinimumWidth = 6;
            DuAn.Name = "DuAn";
            DuAn.Width = 400;
            // 
            // NgayGhi
            // 
            NgayGhi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NgayGhi.DataPropertyName = "NgayGhi";
            NgayGhi.HeaderText = "Ngày Ghi";
            NgayGhi.MinimumWidth = 6;
            NgayGhi.Name = "NgayGhi";
            NgayGhi.Width = 200;
            // 
            // NoiDungCongViec
            // 
            NoiDungCongViec.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NoiDungCongViec.DataPropertyName = "NoiDungCongViec";
            NoiDungCongViec.HeaderText = "Nội Dung Công Việc";
            NoiDungCongViec.MinimumWidth = 6;
            NoiDungCongViec.Name = "NoiDungCongViec";
            NoiDungCongViec.Width = 500;
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.HeaderText = "Ghi Chú";
            GhiChu.MinimumWidth = 6;
            GhiChu.Name = "GhiChu";
            // 
            // nhatKyCongTrinhBindingSource
            // 
            nhatKyCongTrinhBindingSource.DataSource = typeof(Data.NhatKyCongTrinh);
            // 
            // frmNhatKyCongTrinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 735);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhatKyCongTrinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhật Ký Công Trình";
            WindowState = FormWindowState.Maximized;
            Load += frmNhatKyCongTrinh_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)nhatKyCongTrinhBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboDuAn;
        private TextBox txtGhiChu;
        private Label label5;
        private Label label6;
        private TextBox txtNoiDungCongViec;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpNgayGhi;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private BindingSource nhatKyCongTrinhBindingSource;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn DuAn;
        private DataGridViewTextBoxColumn NgayGhi;
        private DataGridViewTextBoxColumn NoiDungCongViec;
        private DataGridViewTextBoxColumn GhiChu;
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