namespace QuanLyDuAnCongTrinhXayDung.Forms
{
    partial class frmPhanPhoi
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanPhoi));
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNgayLap = new DataGridViewTextBoxColumn();
            DuAn = new DataGridViewTextBoxColumn();
            colDuAnID = new DataGridViewTextBoxColumn();
            colTongChiPhi = new DataGridViewTextBoxColumn();
            colGhiChu = new DataGridViewTextBoxColumn();
            phanPhoiBindingSource = new BindingSource(components);
            btnCongViec = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(3, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1285, 462);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Phân Phối";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, colNgayLap, DuAn, colDuAnID, colTongChiPhi, colGhiChu });
            dataGridView.DataSource = phanPhoiBindingSource;
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
            dataGridView.Size = new Size(1273, 423);
            dataGridView.TabIndex = 0;
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
            // colNgayLap
            // 
            colNgayLap.DataPropertyName = "NgayLap";
            colNgayLap.HeaderText = "Ngày lập";
            colNgayLap.MinimumWidth = 6;
            colNgayLap.Name = "colNgayLap";
            // 
            // DuAn
            // 
            DuAn.DataPropertyName = "TenDuAn";
            DuAn.HeaderText = "Tên Dự Án";
            DuAn.MinimumWidth = 6;
            DuAn.Name = "DuAn";
            // 
            // colDuAnID
            // 
            colDuAnID.DataPropertyName = "DuAnID";
            colDuAnID.HeaderText = "DuAnID";
            colDuAnID.MinimumWidth = 6;
            colDuAnID.Name = "colDuAnID";
            colDuAnID.Visible = false;
            // 
            // colTongChiPhi
            // 
            colTongChiPhi.DataPropertyName = "TongChiPhi";
            dataGridViewCellStyle2.Format = "C0";
            colTongChiPhi.DefaultCellStyle = dataGridViewCellStyle2;
            colTongChiPhi.HeaderText = "Tổng chi phí";
            colTongChiPhi.MinimumWidth = 6;
            colTongChiPhi.Name = "colTongChiPhi";
            // 
            // colGhiChu
            // 
            colGhiChu.DataPropertyName = "GhiChu";
            colGhiChu.HeaderText = "Ghi Chú";
            colGhiChu.MinimumWidth = 6;
            colGhiChu.Name = "colGhiChu";
            // 
            // phanPhoiBindingSource
            // 
            phanPhoiBindingSource.DataSource = typeof(Data.PhanPhoi);
            // 
            // btnCongViec
            // 
            btnCongViec.Anchor = AnchorStyles.Bottom;
            btnCongViec.BackColor = Color.Transparent;
            btnCongViec.FlatAppearance.BorderSize = 0;
            btnCongViec.FlatAppearance.MouseOverBackColor = Color.SpringGreen;
            btnCongViec.FlatStyle = FlatStyle.Flat;
            btnCongViec.ForeColor = Color.Black;
            btnCongViec.Image = (Image)resources.GetObject("btnCongViec.Image");
            btnCongViec.ImageAlign = ContentAlignment.MiddleLeft;
            btnCongViec.Location = new Point(252, 488);
            btnCongViec.Name = "btnCongViec";
            btnCongViec.Size = new Size(134, 46);
            btnCongViec.TabIndex = 53;
            btnCongViec.Text = "In phân phối";
            btnCongViec.TextAlign = ContentAlignment.MiddleRight;
            btnCongViec.UseVisualStyleBackColor = false;
            btnCongViec.Click += btnInPhanPhoi_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.SpringGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(905, 488);
            button1.Name = "button1";
            button1.Size = new Size(125, 46);
            button1.TabIndex = 52;
            button1.Text = "Nhập Excel";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnNhap_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.SpringGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(1036, 488);
            button2.Name = "button2";
            button2.Size = new Size(116, 46);
            button2.TabIndex = 51;
            button2.Text = "Xuất Excel";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnXuat_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Black;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(780, 488);
            button3.Name = "button3";
            button3.Size = new Size(88, 46);
            button3.TabIndex = 50;
            button3.Text = "Thoát";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnThoat_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom;
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.Cyan;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Black;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(631, 488);
            button4.Name = "button4";
            button4.Size = new Size(111, 46);
            button4.TabIndex = 49;
            button4.Text = "Tìm Kiếm";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnTimKiem_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom;
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.Red;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Black;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(520, 488);
            button5.Name = "button5";
            button5.Size = new Size(76, 46);
            button5.TabIndex = 46;
            button5.Text = "Xóa";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnXoa_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom;
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Black;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(416, 488);
            button6.Name = "button6";
            button6.Size = new Size(77, 46);
            button6.TabIndex = 45;
            button6.Text = "Sửa";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = false;
            button6.Click += btnSua_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom;
            button7.BackColor = Color.Transparent;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.FlatAppearance.BorderColor = Color.Lime;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.Lime;
            button7.FlatAppearance.MouseOverBackColor = Color.Lime;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.Black;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(66, 488);
            button7.Name = "button7";
            button7.Size = new Size(161, 46);
            button7.TabIndex = 44;
            button7.Text = "Thêm phân phối";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = false;
            button7.Click += btnThem_Click;
            // 
            // frmPhanPhoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 546);
            Controls.Add(btnCongViec);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(button4);
            Name = "frmPhanPhoi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phân Phối";
            WindowState = FormWindowState.Maximized;
            Load += frmPhanPhoi_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)phanPhoiBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private BindingSource phanPhoiBindingSource;
        private DataGridViewTextBoxColumn colDuAn;
        private DataGridViewTextBoxColumn colTenDuAn;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNgayLap;
        private DataGridViewTextBoxColumn DuAn;
        private DataGridViewTextBoxColumn colDuAnID;
        private DataGridViewTextBoxColumn colTongChiPhi;
        private DataGridViewTextBoxColumn colGhiChu;
        private Button btnCongViec;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}