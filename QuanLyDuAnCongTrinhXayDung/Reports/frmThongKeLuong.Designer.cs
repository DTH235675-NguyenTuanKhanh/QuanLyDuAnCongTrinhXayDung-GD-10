namespace QuanLyDuAnCongTrinhXayDung.Reports
{
    partial class frmThongKeLuong
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
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            btnLocKetQua = new Button();
            label1 = new Label();
            cboTenNhanVien = new ComboBox();
            panel1 = new Panel();
            label3 = new Label();
            cboNam = new ComboBox();
            label2 = new Label();
            cboThang = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer.Location = new Point(1, 110);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(965, 405);
            reportViewer.TabIndex = 0;
            reportViewer.Load += frmThongKeLuong_Load;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Anchor = AnchorStyles.Top;
            btnLocKetQua.Location = new Point(812, 38);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(94, 28);
            btnLocKetQua.TabIndex = 2;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 38);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 1;
            label1.Text = "Tên Nhân viên:";
            // 
            // cboTenNhanVien
            // 
            cboTenNhanVien.Anchor = AnchorStyles.Top;
            cboTenNhanVien.FormattingEnabled = true;
            cboTenNhanVien.Location = new Point(162, 38);
            cboTenNhanVien.Name = "cboTenNhanVien";
            cboTenNhanVien.Size = new Size(231, 28);
            cboTenNhanVien.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cboNam);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboThang);
            panel1.Controls.Add(btnLocKetQua);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboTenNhanVien);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 113);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(615, 38);
            label3.Name = "label3";
            label3.Size = new Size(58, 28);
            label3.TabIndex = 6;
            label3.Text = "Năm:";
            // 
            // cboNam
            // 
            cboNam.Anchor = AnchorStyles.Top;
            cboNam.FormattingEnabled = true;
            cboNam.Location = new Point(679, 37);
            cboNam.Name = "cboNam";
            cboNam.Size = new Size(108, 28);
            cboNam.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(415, 38);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 4;
            label2.Text = "Tháng:";
            // 
            // cboThang
            // 
            cboThang.Anchor = AnchorStyles.Top;
            cboThang.FormattingEnabled = true;
            cboThang.Location = new Point(491, 38);
            cboThang.Name = "cboThang";
            cboThang.Size = new Size(108, 28);
            cboThang.TabIndex = 3;
            // 
            // frmThongKeLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 519);
            Controls.Add(panel1);
            Controls.Add(reportViewer);
            Name = "frmThongKeLuong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THỐNG KÊ LƯƠNG";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Button btnLocKetQua;
        private Label label1;
        private ComboBox cboTenNhanVien;
        private Panel panel1;
        private Label label3;
        private ComboBox cboNam;
        private Label label2;
        private ComboBox cboThang;
    }
}