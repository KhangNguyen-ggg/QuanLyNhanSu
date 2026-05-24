namespace QLNS
{
    partial class Formchamcong
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
            this.tabChamCong = new Guna.UI2.WinForms.Guna2TabControl();

            // TABS
            this.pageDataChamCong = new System.Windows.Forms.TabPage();
            this.pageDonNghiPhep = new System.Windows.Forms.TabPage();

            // ==========================================
            // 1. CONTROLS DATA CHẤM CÔNG
            // ==========================================
            this.pnTopCC = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtTimNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLocCC = new Guna.UI2.WinForms.Guna2Button();
            this.btnImportExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuuCC = new Guna.UI2.WinForms.Guna2Button();
            this.dgvChamCong = new Guna.UI2.WinForms.Guna2DataGridView();

            // ==========================================
            // 2. CONTROLS DUYỆT ĐƠN NGHỈ PHÉP
            // ==========================================
            this.pnTopNP = new Guna.UI2.WinForms.Guna2Panel();
            this.cboTrangThaiDuyet = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLocNP = new Guna.UI2.WinForms.Guna2Button();
            this.btnDuyetDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnTuChoiDon = new Guna.UI2.WinForms.Guna2Button();
            this.dgvNghiPhep = new Guna.UI2.WinForms.Guna2DataGridView();

            this.tabChamCong.SuspendLayout();

            this.pageDataChamCong.SuspendLayout();
            this.pnTopCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();

            this.pageDonNghiPhep.SuspendLayout();
            this.pnTopNP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNghiPhep)).BeginInit();

            this.SuspendLayout();

            // 
            // tabChamCong
            // 
            this.tabChamCong.Controls.Add(this.pageDataChamCong);
            this.tabChamCong.Controls.Add(this.pageDonNghiPhep);
            this.tabChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabChamCong.ItemSize = new System.Drawing.Size(250, 50);
            this.tabChamCong.Location = new System.Drawing.Point(0, 0);
            this.tabChamCong.Name = "tabChamCong";
            this.tabChamCong.SelectedIndex = 0;
            this.tabChamCong.Size = new System.Drawing.Size(1250, 800);
            this.tabChamCong.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.tabChamCong.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabChamCong.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136)))));
            this.tabChamCong.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(160)))));
            this.tabChamCong.TabMenuBackColor = System.Drawing.Color.White;
            this.tabChamCong.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;

            // =========================================================================
            // TAB 1: DỮ LIỆU CHẤM CÔNG
            // =========================================================================
            this.pageDataChamCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pageDataChamCong.Controls.Add(this.dgvChamCong);
            this.pageDataChamCong.Controls.Add(this.pnTopCC);
            this.pageDataChamCong.Location = new System.Drawing.Point(4, 54);
            this.pageDataChamCong.Name = "pageDataChamCong";
            this.pageDataChamCong.Padding = new System.Windows.Forms.Padding(20);
            this.pageDataChamCong.Size = new System.Drawing.Size(1242, 742);
            this.pageDataChamCong.Text = "Bảng Dữ Liệu Chấm Công";

            // Panel Top Chấm Công
            this.pnTopCC.BackColor = System.Drawing.Color.Transparent;
            this.pnTopCC.BorderRadius = 10;
            this.pnTopCC.Controls.Add(this.btnLuuCC);
            this.pnTopCC.Controls.Add(this.btnImportExcel);
            this.pnTopCC.Controls.Add(this.btnLocCC);
            this.pnTopCC.Controls.Add(this.txtTimNV);
            this.pnTopCC.Controls.Add(this.dtpDenNgay);
            this.pnTopCC.Controls.Add(this.lblDenNgay);
            this.pnTopCC.Controls.Add(this.dtpTuNgay);
            this.pnTopCC.Controls.Add(this.lblTuNgay);
            this.pnTopCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopCC.FillColor = System.Drawing.Color.White;
            this.pnTopCC.Location = new System.Drawing.Point(20, 20);
            this.pnTopCC.Size = new System.Drawing.Size(1202, 100);

            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(30, 40);
            this.lblTuNgay.Text = "Từ ngày:";

            this.dtpTuNgay.BorderRadius = 5;
            this.dtpTuNgay.FillColor = System.Drawing.Color.White;
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(90, 30);
            this.dtpTuNgay.Size = new System.Drawing.Size(150, 36);

            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(260, 40);
            this.lblDenNgay.Text = "Đến ngày:";

            this.dtpDenNgay.BorderRadius = 5;
            this.dtpDenNgay.FillColor = System.Drawing.Color.White;
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(330, 30);
            this.dtpDenNgay.Size = new System.Drawing.Size(150, 36);

            this.txtTimNV.PlaceholderText = "Nhập mã hoặc tên NV...";
            this.txtTimNV.Location = new System.Drawing.Point(500, 30);
            this.txtTimNV.Size = new System.Drawing.Size(200, 36);

            this.btnLocCC.Text = "LỌC";
            this.btnLocCC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136)))));
            this.btnLocCC.Location = new System.Drawing.Point(720, 30);
            this.btnLocCC.Size = new System.Drawing.Size(100, 36);
            this.btnLocCC.BorderRadius = 5;

            this.btnImportExcel.Text = "IMPORT EXCEL";
            this.btnImportExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(160)))));
            this.btnImportExcel.Location = new System.Drawing.Point(840, 30);
            this.btnImportExcel.Size = new System.Drawing.Size(150, 36);
            this.btnImportExcel.BorderRadius = 5;

            this.btnLuuCC.Text = "LƯU ĐIỀU CHỈNH";
            this.btnLuuCC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnLuuCC.Location = new System.Drawing.Point(1010, 30);
            this.btnLuuCC.Size = new System.Drawing.Size(150, 36);
            this.btnLuuCC.BorderRadius = 5;

            // Grid Chấm Công
            this.dgvChamCong.Location = new System.Drawing.Point(20, 140);
            this.dgvChamCong.Size = new System.Drawing.Size(1202, 580);
            this.dgvChamCong.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            // =========================================================================
            // TAB 2: ĐƠN NGHỈ PHÉP
            // =========================================================================
            this.pageDonNghiPhep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pageDonNghiPhep.Controls.Add(this.dgvNghiPhep);
            this.pageDonNghiPhep.Controls.Add(this.pnTopNP);
            this.pageDonNghiPhep.Location = new System.Drawing.Point(4, 54);
            this.pageDonNghiPhep.Name = "pageDonNghiPhep";
            this.pageDonNghiPhep.Padding = new System.Windows.Forms.Padding(20);
            this.pageDonNghiPhep.Size = new System.Drawing.Size(1242, 742);
            this.pageDonNghiPhep.Text = "Duyệt Đơn Nghỉ Phép";

            // Panel Top Nghỉ Phép
            this.pnTopNP.BackColor = System.Drawing.Color.Transparent;
            this.pnTopNP.BorderRadius = 10;
            this.pnTopNP.Controls.Add(this.btnTuChoiDon);
            this.pnTopNP.Controls.Add(this.btnDuyetDon);
            this.pnTopNP.Controls.Add(this.btnLocNP);
            this.pnTopNP.Controls.Add(this.cboTrangThaiDuyet);
            this.pnTopNP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopNP.FillColor = System.Drawing.Color.White;
            this.pnTopNP.Location = new System.Drawing.Point(20, 20);
            this.pnTopNP.Size = new System.Drawing.Size(1202, 100);

            this.cboTrangThaiDuyet.Location = new System.Drawing.Point(30, 30);
            this.cboTrangThaiDuyet.Size = new System.Drawing.Size(250, 36);

            this.btnLocNP.Text = "LỌC ĐƠN";
            this.btnLocNP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136)))));
            this.btnLocNP.Location = new System.Drawing.Point(300, 30);
            this.btnLocNP.Size = new System.Drawing.Size(120, 36);
            this.btnLocNP.BorderRadius = 5;

            this.btnDuyetDon.Text = "✔ PHÊ DUYỆT ĐƠN";
            this.btnDuyetDon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(160)))));
            this.btnDuyetDon.Location = new System.Drawing.Point(850, 30);
            this.btnDuyetDon.Size = new System.Drawing.Size(170, 36);
            this.btnDuyetDon.BorderRadius = 5;

            this.btnTuChoiDon.Text = "✖ TỪ CHỐI";
            this.btnTuChoiDon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnTuChoiDon.Location = new System.Drawing.Point(1040, 30);
            this.btnTuChoiDon.Size = new System.Drawing.Size(130, 36);
            this.btnTuChoiDon.BorderRadius = 5;

            // Grid Nghỉ Phép
            this.dgvNghiPhep.Location = new System.Drawing.Point(20, 140);
            this.dgvNghiPhep.Size = new System.Drawing.Size(1202, 580);
            this.dgvNghiPhep.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            // 
            // FormChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 800);
            this.Controls.Add(this.tabChamCong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChamCong";
            this.Text = "Quản Lý Chấm Công & Nghỉ Phép";

            this.tabChamCong.ResumeLayout(false);

            this.pageDataChamCong.ResumeLayout(false);
            this.pnTopCC.ResumeLayout(false);
            this.pnTopCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();

            this.pageDonNghiPhep.ResumeLayout(false);
            this.pnTopNP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNghiPhep)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabChamCong;
        private System.Windows.Forms.TabPage pageDataChamCong;
        private System.Windows.Forms.TabPage pageDonNghiPhep;

        private Guna.UI2.WinForms.Guna2Panel pnTopCC;
        private System.Windows.Forms.Label lblTuNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDenNgay;
        private Guna.UI2.WinForms.Guna2TextBox txtTimNV;
        private Guna.UI2.WinForms.Guna2Button btnLocCC;
        private Guna.UI2.WinForms.Guna2Button btnImportExcel;
        private Guna.UI2.WinForms.Guna2Button btnLuuCC;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChamCong;

        private Guna.UI2.WinForms.Guna2Panel pnTopNP;
        private Guna.UI2.WinForms.Guna2ComboBox cboTrangThaiDuyet;
        private Guna.UI2.WinForms.Guna2Button btnLocNP;
        private Guna.UI2.WinForms.Guna2Button btnDuyetDon;
        private Guna.UI2.WinForms.Guna2Button btnTuChoiDon;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNghiPhep;
    }
}