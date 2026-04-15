namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmNhaDauTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaDauTu));
            groupBox1 = new GroupBox();
            txtMaSoThue = new TextBox();
            label6 = new Label();
            txtSoDienThoai = new TextBox();
            label3 = new Label();
            txtDiaChi = new TextBox();
            label2 = new Label();
            txtTenNhaDauTu = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            TenNhaDauTu = new DataGridViewTextBoxColumn();
            MaSoThue = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            nhaDauTuBindingSource = new BindingSource(components);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nhaDauTuBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(txtMaSoThue);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(txtTenNhaDauTu);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1265, 250);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Nhà đầu tư";
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
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(818, 94);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(425, 34);
            txtSoDienThoai.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(683, 94);
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
            // txtTenNhaDauTu
            // 
            txtTenNhaDauTu.Location = new Point(176, 42);
            txtTenNhaDauTu.Name = "txtTenNhaDauTu";
            txtTenNhaDauTu.Size = new Size(457, 34);
            txtTenNhaDauTu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 42);
            label1.Name = "label1";
            label1.Size = new Size(158, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên Nhà Đầu Tư: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(955, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 268);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1265, 438);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Nhà đầu tư";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, TenNhaDauTu, MaSoThue, DiaChi, SoDienThoai });
            dataGridView.DataSource = nhaDauTuBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Location = new Point(0, 33);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView.Size = new Size(1259, 399);
            dataGridView.TabIndex = 0;
            // 
            // colID
            // 
            colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Width = 75;
            // 
            // TenNhaDauTu
            // 
            TenNhaDauTu.DataPropertyName = "TenNhaDauTu";
            TenNhaDauTu.FillWeight = 17.51825F;
            TenNhaDauTu.HeaderText = "Tên Nhà Đầu tư";
            TenNhaDauTu.MinimumWidth = 6;
            TenNhaDauTu.Name = "TenNhaDauTu";
            // 
            // MaSoThue
            // 
            MaSoThue.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MaSoThue.DataPropertyName = "MaSoThue";
            MaSoThue.FillWeight = 347.445251F;
            MaSoThue.HeaderText = "Mã Số Thuế";
            MaSoThue.MinimumWidth = 6;
            MaSoThue.Name = "MaSoThue";
            MaSoThue.Width = 150;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.FillWeight = 17.51825F;
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.FillWeight = 17.51825F;
            SoDienThoai.HeaderText = "Số Điện Thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // nhaDauTuBindingSource
            // 
            nhaDauTuBindingSource.DataSource = typeof(Data.NhaDauTu);
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
            btnNhap.Location = new Point(438, 144);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(145, 46);
            btnNhap.TabIndex = 32;
            btnNhap.Text = "Nhập Excel";
            btnNhap.TextAlign = ContentAlignment.MiddleRight;
            btnNhap.UseVisualStyleBackColor = false;
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
            btnXuat.Location = new Point(438, 188);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(145, 46);
            btnXuat.TabIndex = 31;
            btnXuat.Text = "Xuất Excel";
            btnXuat.TextAlign = ContentAlignment.MiddleRight;
            btnXuat.UseVisualStyleBackColor = false;
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
            btnThoat.Location = new Point(609, 165);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(99, 46);
            btnThoat.TabIndex = 30;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
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
            btnTimKiem.Location = new Point(289, 188);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(127, 46);
            btnTimKiem.TabIndex = 29;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = false;
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
            btnHuyBo.Location = new Point(289, 144);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(115, 46);
            btnHuyBo.TabIndex = 28;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.TextAlign = ContentAlignment.MiddleRight;
            btnHuyBo.UseVisualStyleBackColor = false;
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
            btnLuu.Location = new Point(176, 188);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 46);
            btnLuu.TabIndex = 27;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = false;
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
            btnXoa.Location = new Point(176, 144);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 46);
            btnXoa.TabIndex = 26;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
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
            btnSua.Location = new Point(49, 188);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(91, 46);
            btnSua.TabIndex = 25;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = false;
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
            btnThem.Location = new Point(49, 144);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 46);
            btnThem.TabIndex = 24;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            // 
            // frmNhaDauTu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 712);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhaDauTu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhà Đầu Tư";
            WindowState = FormWindowState.Maximized;
            Load += frmNhaDauTu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)nhaDauTuBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTimKiem;
        private Label label9;
        private TextBox txtNguoiDaiDien;
        private Label label5;
        private TextBox txtMaSoThue;
        private Label label6;
        private TextBox txtSoDienThoai;
        private Label label3;
        private TextBox txtDiaChi;
        private Label label2;
        private TextBox txtTenNhaDauTu;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private BindingSource nhaDauTuBindingSource;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn TenNhaDauTu;
        private DataGridViewTextBoxColumn MaSoThue;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SoDienThoai;
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