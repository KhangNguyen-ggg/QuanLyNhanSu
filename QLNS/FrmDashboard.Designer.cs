namespace QLNS
{
    partial class FrmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();

            // 4 THẺ THỐNG KÊ (CARDS) - Bóp width còn 240px
            this.cardTongNhanSu = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTongNhanSu_Title = new System.Windows.Forms.Label();
            this.lblTongNhanSu_Value = new System.Windows.Forms.Label();

            this.cardNhanVienMoi = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNhanVienMoi_Title = new System.Windows.Forms.Label();
            this.lblNhanVienMoi_Value = new System.Windows.Forms.Label();

            this.cardDonNghiPhep = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDonNghiPhep_Title = new System.Windows.Forms.Label();
            this.lblDonNghiPhep_Value = new System.Windows.Forms.Label();

            this.cardTuyenDung = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTuyenDung_Title = new System.Windows.Forms.Label();
            this.lblTuyenDung_Value = new System.Windows.Forms.Label();

            // 2 BIỂU ĐỒ (CHARTS)
            this.chartNhanSuPhongBan = new Guna.Charts.WinForms.GunaChart();
            this.datasetBarChart = new Guna.Charts.WinForms.GunaBarDataset();

            this.chartGioiTinh = new Guna.Charts.WinForms.GunaChart();
            this.datasetDoughnutChart = new Guna.Charts.WinForms.GunaDoughnutDataset();

            this.lblChart1 = new System.Windows.Forms.Label();
            this.lblChart2 = new System.Windows.Forms.Label();

            this.pnMain.SuspendLayout();
            this.cardTongNhanSu.SuspendLayout();
            this.cardNhanVienMoi.SuspendLayout();
            this.cardDonNghiPhep.SuspendLayout();
            this.cardTuyenDung.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnMain 
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnMain.Controls.Add(this.lblChart2);
            this.pnMain.Controls.Add(this.lblChart1);
            this.pnMain.Controls.Add(this.chartGioiTinh);
            this.pnMain.Controls.Add(this.chartNhanSuPhongBan);
            this.pnMain.Controls.Add(this.cardTuyenDung);
            this.pnMain.Controls.Add(this.cardDonNghiPhep);
            this.pnMain.Controls.Add(this.cardNhanVienMoi);
            this.pnMain.Controls.Add(this.cardTongNhanSu);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1250, 800); // Size chuẩn lọt lòng Main 1280

            // ==========================================
            // CARDS (Căn lại Location cho màn 1280)
            // Kích thước Card: 280 x 120, Khoảng cách: 30px
            // ==========================================
            // CARD 1
            this.cardTongNhanSu.BorderRadius = 15;
            this.cardTongNhanSu.FillColor = System.Drawing.Color.White;
            this.cardTongNhanSu.Location = new System.Drawing.Point(30, 20);
            this.cardTongNhanSu.Size = new System.Drawing.Size(275, 120);

            this.lblTongNhanSu_Title.AutoSize = true;
            this.lblTongNhanSu_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongNhanSu_Title.ForeColor = System.Drawing.Color.DimGray;
            this.lblTongNhanSu_Title.Location = new System.Drawing.Point(15, 20);
            this.lblTongNhanSu_Title.Text = "TỔNG NHÂN SỰ";
            this.cardTongNhanSu.Controls.Add(this.lblTongNhanSu_Title);

            this.lblTongNhanSu_Value.AutoSize = true;
            this.lblTongNhanSu_Value.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTongNhanSu_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136)))));
            this.lblTongNhanSu_Value.Location = new System.Drawing.Point(10, 50);
            this.lblTongNhanSu_Value.Text = "156";
            this.cardTongNhanSu.Controls.Add(this.lblTongNhanSu_Value);

            // CARD 2
            this.cardNhanVienMoi.BorderRadius = 15;
            this.cardNhanVienMoi.FillColor = System.Drawing.Color.White;
            this.cardNhanVienMoi.Location = new System.Drawing.Point(335, 20); // 30 + 275 + 30
            this.cardNhanVienMoi.Size = new System.Drawing.Size(275, 120);

            this.lblNhanVienMoi_Title.AutoSize = true;
            this.lblNhanVienMoi_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNhanVienMoi_Title.ForeColor = System.Drawing.Color.DimGray;
            this.lblNhanVienMoi_Title.Location = new System.Drawing.Point(15, 20);
            this.lblNhanVienMoi_Title.Text = "NHÂN VIÊN MỚI";
            this.cardNhanVienMoi.Controls.Add(this.lblNhanVienMoi_Title);

            this.lblNhanVienMoi_Value.AutoSize = true;
            this.lblNhanVienMoi_Value.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblNhanVienMoi_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(160)))));
            this.lblNhanVienMoi_Value.Location = new System.Drawing.Point(10, 50);
            this.lblNhanVienMoi_Value.Text = "+12";
            this.cardNhanVienMoi.Controls.Add(this.lblNhanVienMoi_Value);

            // CARD 3
            this.cardDonNghiPhep.BorderRadius = 15;
            this.cardDonNghiPhep.FillColor = System.Drawing.Color.White;
            this.cardDonNghiPhep.Location = new System.Drawing.Point(640, 20); // 335 + 275 + 30
            this.cardDonNghiPhep.Size = new System.Drawing.Size(275, 120);

            this.lblDonNghiPhep_Title.AutoSize = true;
            this.lblDonNghiPhep_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDonNghiPhep_Title.ForeColor = System.Drawing.Color.DimGray;
            this.lblDonNghiPhep_Title.Location = new System.Drawing.Point(15, 20);
            this.lblDonNghiPhep_Title.Text = "ĐƠN CHỜ DUYỆT";
            this.cardDonNghiPhep.Controls.Add(this.lblDonNghiPhep_Title);

            this.lblDonNghiPhep_Value.AutoSize = true;
            this.lblDonNghiPhep_Value.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblDonNghiPhep_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.lblDonNghiPhep_Value.Location = new System.Drawing.Point(10, 50);
            this.lblDonNghiPhep_Value.Text = "05";
            this.cardDonNghiPhep.Controls.Add(this.lblDonNghiPhep_Value);

            // CARD 4
            this.cardTuyenDung.BorderRadius = 15;
            this.cardTuyenDung.FillColor = System.Drawing.Color.White;
            this.cardTuyenDung.Location = new System.Drawing.Point(945, 20); // 640 + 275 + 30
            this.cardTuyenDung.Size = new System.Drawing.Size(275, 120);

            this.lblTuyenDung_Title.AutoSize = true;
            this.lblTuyenDung_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTuyenDung_Title.ForeColor = System.Drawing.Color.DimGray;
            this.lblTuyenDung_Title.Location = new System.Drawing.Point(15, 20);
            this.lblTuyenDung_Title.Text = "CV ỨNG VIÊN";
            this.cardTuyenDung.Controls.Add(this.lblTuyenDung_Title);

            this.lblTuyenDung_Value.AutoSize = true;
            this.lblTuyenDung_Value.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTuyenDung_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.lblTuyenDung_Value.Location = new System.Drawing.Point(10, 50);
            this.lblTuyenDung_Value.Text = "24";
            this.cardTuyenDung.Controls.Add(this.lblTuyenDung_Value);

            // ==========================================
            // CHARTS (Kéo dài Height xuống 600px)
            // ==========================================
            this.lblChart1.AutoSize = true;
            this.lblChart1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136)))));
            this.lblChart1.Location = new System.Drawing.Point(30, 170);
            this.lblChart1.Text = "Thống Kê Nhân Sự Theo Phòng Ban";

            this.chartNhanSuPhongBan.BackColor = System.Drawing.Color.White;
            this.chartNhanSuPhongBan.Datasets.AddRange(new Guna.Charts.Interfaces.IGunaDataset[] { this.datasetBarChart });
            this.chartNhanSuPhongBan.Location = new System.Drawing.Point(30, 210);
            this.chartNhanSuPhongBan.Size = new System.Drawing.Size(730, 560); // Kéo dài để tận dụng màn 1024
            this.chartNhanSuPhongBan.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);

            this.chartNhanSuPhongBan.Title.Display = false;
            this.chartNhanSuPhongBan.Legend.Position = Guna.Charts.WinForms.LegendPosition.Bottom;

            this.datasetBarChart.Label = "Số lượng nhân sự";
            this.datasetBarChart.FillColors.AddRange(new System.Drawing.Color[] { System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136))))) });

            this.datasetBarChart.DataPoints.Add("Phòng IT", 45);
            this.datasetBarChart.DataPoints.Add("Kế Toán", 15);
            this.datasetBarChart.DataPoints.Add("Marketing", 25);
            this.datasetBarChart.DataPoints.Add("Nhân Sự", 10);
            this.datasetBarChart.DataPoints.Add("Kinh Doanh", 61);

            // CHART 2
            this.lblChart2.AutoSize = true;
            this.lblChart2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblChart2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136)))));
            this.lblChart2.Location = new System.Drawing.Point(790, 170);
            this.lblChart2.Text = "Tỷ Lệ Giới Tính";

            this.chartGioiTinh.BackColor = System.Drawing.Color.White;
            this.chartGioiTinh.Datasets.AddRange(new Guna.Charts.Interfaces.IGunaDataset[] { this.datasetDoughnutChart });
            this.chartGioiTinh.Location = new System.Drawing.Point(790, 210);
            this.chartGioiTinh.Size = new System.Drawing.Size(430, 560); // Kéo dài tương xứng
            this.chartGioiTinh.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            this.chartGioiTinh.Title.Display = false;
            this.chartGioiTinh.Legend.Position = Guna.Charts.WinForms.LegendPosition.Bottom;

            this.datasetDoughnutChart.Label = "Giới tính";
            this.datasetDoughnutChart.FillColors.AddRange(new System.Drawing.Color[] {
                System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136))))),
                System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(160)))))
            });

            this.datasetDoughnutChart.DataPoints.Add("Nam", 95);
            this.datasetDoughnutChart.DataPoints.Add("Nữ", 61);

            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 800);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";

            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.cardTongNhanSu.ResumeLayout(false);
            this.cardNhanVienMoi.ResumeLayout(false);
            this.cardDonNghiPhep.ResumeLayout(false);
            this.cardTuyenDung.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private Guna.UI2.WinForms.Guna2Panel cardTongNhanSu;
        private System.Windows.Forms.Label lblTongNhanSu_Title;
        private System.Windows.Forms.Label lblTongNhanSu_Value;
        private Guna.UI2.WinForms.Guna2Panel cardNhanVienMoi;
        private System.Windows.Forms.Label lblNhanVienMoi_Title;
        private System.Windows.Forms.Label lblNhanVienMoi_Value;
        private Guna.UI2.WinForms.Guna2Panel cardDonNghiPhep;
        private System.Windows.Forms.Label lblDonNghiPhep_Title;
        private System.Windows.Forms.Label lblDonNghiPhep_Value;
        private Guna.UI2.WinForms.Guna2Panel cardTuyenDung;
        private System.Windows.Forms.Label lblTuyenDung_Title;
        private System.Windows.Forms.Label lblTuyenDung_Value;
        private System.Windows.Forms.Label lblChart1;
        private Guna.Charts.WinForms.GunaChart chartNhanSuPhongBan;
        private Guna.Charts.WinForms.GunaBarDataset datasetBarChart;
        private System.Windows.Forms.Label lblChart2;
        private Guna.Charts.WinForms.GunaChart chartGioiTinh;
        private Guna.Charts.WinForms.GunaDoughnutDataset datasetDoughnutChart;
    }
}