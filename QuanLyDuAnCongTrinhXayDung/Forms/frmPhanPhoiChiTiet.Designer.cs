namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmPhanPhoiChiTiet
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanPhoiChiTiet));
            groupBox1 = new GroupBox();
            txtGhiChu = new TextBox();
            label6 = new Label();
            cboDuAn = new ComboBox();
            label5 = new Label();
            cboVatTu = new ComboBox();
            numSoLuong = new NumericUpDown();
            txtTongChiPhi = new TextBox();
            label4 = new Label();
            numDonGia = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            danhSachPhanPhoiChiTietBindingSource2 = new BindingSource(components);
            danhSachPhanPhoiChiTietBindingSource1 = new BindingSource(components);
            danhSachPhanPhoiChiTietBindingSource = new BindingSource(components);
            phanPhoiChiTietBindingSource1 = new BindingSource(components);
            phanPhoiChiTietBindingSource = new BindingSource(components);
            cSDLBindingSource = new BindingSource(components);
            colID = new DataGridViewTextBoxColumn();
            colVatTuID = new DataGridViewTextBoxColumn();
            colDuAnID = new DataGridViewTextBoxColumn();
            colTenVatTu = new DataGridViewTextBoxColumn();
            colTenDuAn = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colTongChiPhi = new DataGridViewTextBoxColumn();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)danhSachPhanPhoiChiTietBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)danhSachPhanPhoiChiTietBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)danhSachPhanPhoiChiTietBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiChiTietBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiChiTietBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cSDLBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cboDuAn);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboVatTu);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(txtTongChiPhi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1004, 264);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Phân phối";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(145, 220);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(851, 34);
            txtGhiChu.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 223);
            label6.Name = "label6";
            label6.Size = new Size(90, 28);
            label6.TabIndex = 45;
            label6.Text = "Ghi Chú: ";
            // 
            // cboDuAn
            // 
            cboDuAn.FormattingEnabled = true;
            cboDuAn.Location = new Point(608, 101);
            cboDuAn.Name = "cboDuAn";
            cboDuAn.Size = new Size(344, 36);
            cboDuAn.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(500, 104);
            label5.Name = "label5";
            label5.Size = new Size(107, 28);
            label5.TabIndex = 43;
            label5.Text = "Tên Dự án: ";
            // 
            // cboVatTu
            // 
            cboVatTu.FormattingEnabled = true;
            cboVatTu.Location = new Point(132, 39);
            cboVatTu.Name = "cboVatTu";
            cboVatTu.Size = new Size(356, 36);
            cboVatTu.TabIndex = 42;
            cboVatTu.SelectedIndexChanged += cboVatTu_SelectedIndexChanged;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(132, 100);
            numSoLuong.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(356, 34);
            numSoLuong.TabIndex = 41;
            numSoLuong.ValueChanged += numSoLuong_ValueChanged;
            // 
            // txtTongChiPhi
            // 
            txtTongChiPhi.Location = new Point(145, 164);
            txtTongChiPhi.Name = "txtTongChiPhi";
            txtTongChiPhi.Size = new Size(445, 34);
            txtTongChiPhi.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 167);
            label4.Name = "label4";
            label4.Size = new Size(129, 28);
            label4.TabIndex = 39;
            label4.Text = "Tổng chi phí: ";
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(596, 40);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(356, 34);
            numDonGia.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 100);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 4;
            label3.Text = "Số lượng: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(500, 41);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 2;
            label2.Text = "Đơn giá: ";
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
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(669, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 232);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 282);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1004, 436);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách chi tiết";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, colVatTuID, colDuAnID, colTenVatTu, colTenDuAn, colSoLuong, colDonGia, colTongChiPhi });
            dataGridView.DataSource = danhSachPhanPhoiChiTietBindingSource2;
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
            dataGridView.Size = new Size(990, 397);
            dataGridView.TabIndex = 0;
            // 
            // danhSachPhanPhoiChiTietBindingSource2
            // 
            danhSachPhanPhoiChiTietBindingSource2.DataSource = typeof(Data.DanhSachPhanPhoiChiTiet);
            // 
            // danhSachPhanPhoiChiTietBindingSource1
            // 
            danhSachPhanPhoiChiTietBindingSource1.DataSource = typeof(Data.DanhSachPhanPhoiChiTiet);
            // 
            // danhSachPhanPhoiChiTietBindingSource
            // 
            danhSachPhanPhoiChiTietBindingSource.DataSource = typeof(Data.DanhSachPhanPhoiChiTiet);
            // 
            // phanPhoiChiTietBindingSource1
            // 
            phanPhoiChiTietBindingSource1.DataSource = typeof(Data.PhanPhoiChiTiet);
            // 
            // phanPhoiChiTietBindingSource
            // 
            phanPhoiChiTietBindingSource.DataSource = typeof(Data.PhanPhoiChiTiet);
            // 
            // cSDLBindingSource
            // 
            cSDLBindingSource.DataSource = typeof(Migrations.CSDL);
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
            // colVatTuID
            // 
            colVatTuID.DataPropertyName = "VatTuID";
            colVatTuID.HeaderText = "VatTuID";
            colVatTuID.MinimumWidth = 6;
            colVatTuID.Name = "colVatTuID";
            colVatTuID.Visible = false;
            // 
            // colDuAnID
            // 
            colDuAnID.DataPropertyName = "DuAnID";
            colDuAnID.HeaderText = "DuAnID";
            colDuAnID.MinimumWidth = 6;
            colDuAnID.Name = "colDuAnID";
            colDuAnID.Visible = false;
            // 
            // colTenVatTu
            // 
            colTenVatTu.DataPropertyName = "TenVatTu";
            colTenVatTu.HeaderText = "Tên Vật Tư";
            colTenVatTu.MinimumWidth = 6;
            colTenVatTu.Name = "colTenVatTu";
            // 
            // colTenDuAn
            // 
            colTenDuAn.DataPropertyName = "TenDuAn";
            colTenDuAn.HeaderText = "Tên Dự Án";
            colTenDuAn.MinimumWidth = 6;
            colTenDuAn.Name = "colTenDuAn";
            // 
            // colSoLuong
            // 
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.HeaderText = "Số Lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
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
            // colTongChiPhi
            // 
            colTongChiPhi.DataPropertyName = "TongChiPhi";
            dataGridViewCellStyle3.Format = "C0";
            colTongChiPhi.DefaultCellStyle = dataGridViewCellStyle3;
            colTongChiPhi.HeaderText = "Tổng Chi Phí";
            colTongChiPhi.MinimumWidth = 6;
            colTongChiPhi.Name = "colTongChiPhi";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Bottom;
            btnThoat.BackColor = Color.Transparent;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatAppearance.MouseOverBackColor = Color.Red;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.Black;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(620, 724);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(87, 46);
            btnThoat.TabIndex = 51;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Bottom;
            btnHuyBo.BackColor = Color.Transparent;
            btnHuyBo.FlatAppearance.BorderSize = 0;
            btnHuyBo.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.ForeColor = Color.Black;
            btnHuyBo.Image = (Image)resources.GetObject("btnHuyBo.Image");
            btnHuyBo.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyBo.Location = new Point(474, 724);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(103, 46);
            btnHuyBo.TabIndex = 50;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.TextAlign = ContentAlignment.MiddleRight;
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Bottom;
            btnLuu.BackColor = Color.Transparent;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.Black;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(353, 724);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(74, 46);
            btnLuu.TabIndex = 49;
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
            btnXoa.Location = new Point(806, 158);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 46);
            btnXoa.TabIndex = 48;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
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
            btnThem.Location = new Point(652, 158);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 46);
            btnThem.TabIndex = 47;
            btnThem.Text = "Xác nhận";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnXacNhan_Click;
            // 
            // frmPhanPhoiChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 782);
            Controls.Add(btnThoat);
            Controls.Add(groupBox2);
            Controls.Add(btnHuyBo);
            Controls.Add(btnLuu);
            Controls.Add(groupBox1);
            Name = "frmPhanPhoiChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phân Phối Chi Tiết";
            WindowState = FormWindowState.Maximized;
            Load += frmPhanPhoiChiTiet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)danhSachPhanPhoiChiTietBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)danhSachPhanPhoiChiTietBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)danhSachPhanPhoiChiTietBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiChiTietBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiChiTietBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cSDLBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numDonGia;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private BindingSource phanPhoiChiTietBindingSource;
        private BindingSource phanPhoiChiTietBindingSource1;
        private BindingSource danhSachPhanPhoiChiTietBindingSource;
        private NumericUpDown numSoLuong;
        private TextBox txtTongChiPhi;
        private Label label4;
        private ComboBox cboVatTu;
        private PictureBox pictureBox1;
        private BindingSource danhSachPhanPhoiChiTietBindingSource1;
        private BindingSource cSDLBindingSource;
        private ComboBox cboDuAn;
        private Label label5;
        private DataGridView dataGridView;
        private BindingSource danhSachPhanPhoiChiTietBindingSource2;
        private TextBox txtGhiChu;
        private Label label6;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colVatTuID;
        private DataGridViewTextBoxColumn colDuAnID;
        private DataGridViewTextBoxColumn colTenVatTu;
        private DataGridViewTextBoxColumn colTenDuAn;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colTongChiPhi;
        private Button btnXoa;
        private Button btnThem;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
    }
}