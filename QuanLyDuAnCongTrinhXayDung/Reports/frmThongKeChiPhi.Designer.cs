namespace QuanLyDuAnCongTrinhXayDung.Reports
{
    partial class frmThongKeChiPhi
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
            panel1 = new Panel();
            btnHienTatCa = new Button();
            btnLocKetQua = new Button();
            dtpDenNgay = new DateTimePicker();
            label2 = new Label();
            dtpTuNgay = new DateTimePicker();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer.Location = new Point(1, 99);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(952, 425);
            reportViewer.TabIndex = 0;
            reportViewer.Load += frmThongKeChiPhi_Load;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHienTatCa);
            panel1.Controls.Add(btnLocKetQua);
            panel1.Controls.Add(dtpDenNgay);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpTuNgay);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 102);
            panel1.TabIndex = 1;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Anchor = AnchorStyles.Top;
            btnHienTatCa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHienTatCa.Location = new Point(779, 29);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(123, 38);
            btnHienTatCa.TabIndex = 5;
            btnHienTatCa.Text = "Hiện tất cả";
            btnHienTatCa.UseVisualStyleBackColor = true;
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Anchor = AnchorStyles.Top;
            btnLocKetQua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLocKetQua.Location = new Point(638, 30);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(123, 38);
            btnLocKetQua.TabIndex = 4;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Anchor = AnchorStyles.Top;
            dtpDenNgay.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDenNgay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(437, 34);
            dtpDenNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpDenNgay.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(154, 34);
            dtpDenNgay.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(332, 34);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 2;
            label2.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Anchor = AnchorStyles.Top;
            dtpTuNgay.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTuNgay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(146, 30);
            dtpTuNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpTuNgay.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(154, 34);
            dtpTuNgay.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 30);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày:";
            // 
            // frmThongKeChiPhi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 526);
            Controls.Add(panel1);
            Controls.Add(reportViewer);
            Name = "frmThongKeChiPhi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống Kê Chi Phí";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Panel panel1;
        private Label label1;
        private Button btnLocKetQua;
        private DateTimePicker dtpDenNgay;
        private Label label2;
        private DateTimePicker dtpTuNgay;
        private Button btnHienTatCa;
    }
}