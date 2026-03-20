namespace QuanLyDuAnCongTrinhXayDung.Reports
{
    partial class frmThongKeVatTu
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
            btnLocKetQua = new Button();
            label1 = new Label();
            cboTenVatTu = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer.Location = new Point(1, 101);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(1003, 418);
            reportViewer.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLocKetQua);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboTenVatTu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 105);
            panel1.TabIndex = 1;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Anchor = AnchorStyles.Top;
            btnLocKetQua.Location = new Point(633, 33);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(129, 28);
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
            label1.Location = new Point(281, 33);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 1;
            label1.Text = "Tên vật tư:";
            // 
            // cboTenVatTu
            // 
            cboTenVatTu.Anchor = AnchorStyles.Top;
            cboTenVatTu.FormattingEnabled = true;
            cboTenVatTu.Location = new Point(388, 33);
            cboTenVatTu.Name = "cboTenVatTu";
            cboTenVatTu.Size = new Size(213, 28);
            cboTenVatTu.TabIndex = 0;
            // 
            // frmThongKeVatTu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 519);
            Controls.Add(panel1);
            Controls.Add(reportViewer);
            Name = "frmThongKeVatTu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh Sách Vật Tư";
            WindowState = FormWindowState.Maximized;
            Load += frmThongKeVatTu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Panel panel1;
        private Label label1;
        private ComboBox cboTenVatTu;
        private Button btnLocKetQua;
    }
}