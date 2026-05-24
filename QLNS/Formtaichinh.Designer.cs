namespace QLNS
{
    partial class Formtaichinh
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
            this.tabTaiChinh = new Guna.UI2.WinForms.Guna2TabControl();

            // TABS
            this.pageTamUng = new System.Windows.Forms.TabPage();
            this.pageKhenThuong = new System.Windows.Forms.TabPage();
            this.pagePhuCapNV = new System.Windows.Forms.TabPage();

            // ==========================================
            // 1. CONTROLS TẠM ỨNG
            // ==========================================
            this.pnInputTamUng = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMaTamUng = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboNhanVienTU = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSoTienTU = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLyDoTU = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuuTU = new Guna.UI2.WinForms.Guna2Button();
            this.btnDuyetTU = new Guna.UI2.WinForms.Guna2Button();
            this.dgvTamUng = new Guna.UI2.WinForms.Guna2DataGridView();

            // ==========================================
            // 2. CONTROLS KHEN THƯỞNG / KỶ LUẬT
            // ==========================================
            this.pnInputKTKL = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMaQD = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboNhanVienKT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboLoaiQD = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSoTienKT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLyDoKT = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuuKT = new Guna.UI2.WinForms.Guna2Button();
            this.dgvKhenThuong = new Guna.UI2.WinForms.Guna2DataGridView();

            // ==========================================
            // 3. CONTROLS CẤP PHỤ CẤP
            // ==========================================
            this.pnInputPC = new Guna.UI2.WinForms.Guna2Panel();
            this.cboNhanVienPC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboPhuCap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpNgayCap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtLyDoPC = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuuPC = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPhuCapNV = new Guna.UI2.WinForms.Guna2DataGridView();

            this.tabTaiChinh.SuspendLayout();

            this.pageTamUng.SuspendLayout();
            this.pnInputTamUng.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamUng)).BeginInit();

            this.pageKhenThuong.SuspendLayout();
            this.pnInputKTKL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenThuong)).BeginInit();

            this.pagePhuCapNV.SuspendLayout();
            this.pnInputPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuCapNV)).BeginInit();

            this.SuspendLayout();

            // 
            // tabTaiChinh
            // 
            this.tabTaiChinh.Controls.Add(this.pageTamUng);
            this.tabTaiChinh.Controls.Add(this.pageKhenThuong);
            this.tabTaiChinh.Controls.Add(this.pagePhuCapNV);
            this.tabTaiChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTaiChinh.ItemSize = new System.Drawing.Size(250, 50);
            this.tabTaiChinh.Location = new System.Drawing.Point(0, 0);
            this.tabTaiChinh.Name = "tabTaiChinh";
            this.tabTaiChinh.SelectedIndex = 0;
            this.tabTaiChinh.Size = new System.Drawing.Size(1200, 700);
            this.tabTaiChinh.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.tabTaiChinh.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabTaiChinh.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136)))));
            this.tabTaiChinh.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(160)))));
            this.tabTaiChinh.TabMenuBackColor = System.Drawing.Color.White;
            this.tabTaiChinh.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;

            // =========================================================================
            // TAB 1: TẠM ỨNG
            // =========================================================================
            this.pageTamUng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pageTamUng.Controls.Add(this.dgvTamUng);
            this.pageTamUng.Controls.Add(this.pnInputTamUng);
            this.pageTamUng.Location = new System.Drawing.Point(4, 54);
            this.pageTamUng.Name = "pageTamUng";
            this.pageTamUng.Padding = new System.Windows.Forms.Padding(20);
            this.pageTamUng.Size = new System.Drawing.Size(1192, 642);
            this.pageTamUng.Text = "Quản Lý Tạm Ứng";

            this.pnInputTamUng.BackColor = System.Drawing.Color.Transparent;
            this.pnInputTamUng.BorderRadius = 10;
            this.pnInputTamUng.Controls.Add(this.btnDuyetTU);
            this.pnInputTamUng.Controls.Add(this.btnLuuTU);
            this.pnInputTamUng.Controls.Add(this.txtLyDoTU);
            this.pnInputTamUng.Controls.Add(this.txtSoTienTU);
            this.pnInputTamUng.Controls.Add(this.cboNhanVienTU);
            this.pnInputTamUng.Controls.Add(this.txtMaTamUng);
            this.pnInputTamUng.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInputTamUng.FillColor = System.Drawing.Color.White;
            this.pnInputTamUng.Location = new System.Drawing.Point(20, 20);
            this.pnInputTamUng.Size = new System.Drawing.Size(1152, 120);

            this.txtMaTamUng.PlaceholderText = "Mã tạm ứng...";
            this.txtMaTamUng.Location = new System.Drawing.Point(30, 20);
            this.txtMaTamUng.Size = new System.Drawing.Size(150, 36);

            this.cboNhanVienTU.Location = new System.Drawing.Point(200, 20);
            this.cboNhanVienTU.Size = new System.Drawing.Size(300, 36);

            this.txtSoTienTU.PlaceholderText = "Số tiền (VNĐ)...";
            this.txtSoTienTU.Location = new System.Drawing.Point(520, 20);
            this.txtSoTienTU.Size = new System.Drawing.Size(200, 36);

            this.txtLyDoTU.PlaceholderText = "Lý do tạm ứng...";
            this.txtLyDoTU.Location = new System.Drawing.Point(30, 70);
            this.txtLyDoTU.Size = new System.Drawing.Size(690, 36);

            this.btnLuuTU.Text = "TẠO YÊU CẦU";
            this.btnLuuTU.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136)))));
            this.btnLuuTU.Location = new System.Drawing.Point(740, 20);
            this.btnLuuTU.Size = new System.Drawing.Size(150, 86);
            this.btnLuuTU.BorderRadius = 5;

            this.btnDuyetTU.Text = "✔ CHI TIỀN / DUYỆT";
            this.btnDuyetTU.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(160)))));
            this.btnDuyetTU.Location = new System.Drawing.Point(910, 20);
            this.btnDuyetTU.Size = new System.Drawing.Size(180, 86);
            this.btnDuyetTU.BorderRadius = 5;

            this.dgvTamUng.Location = new System.Drawing.Point(20, 160);
            this.dgvTamUng.Size = new System.Drawing.Size(1152, 460);
            this.dgvTamUng.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            // =========================================================================
            // TAB 2: KHEN THƯỞNG KỶ LUẬT
            // =========================================================================
            this.pageKhenThuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pageKhenThuong.Controls.Add(this.dgvKhenThuong);
            this.pageKhenThuong.Controls.Add(this.pnInputKTKL);
            this.pageKhenThuong.Location = new System.Drawing.Point(4, 54);
            this.pageKhenThuong.Name = "pageKhenThuong";
            this.pageKhenThuong.Padding = new System.Windows.Forms.Padding(20);
            this.pageKhenThuong.Size = new System.Drawing.Size(1192, 642);
            this.pageKhenThuong.Text = "Khen Thưởng / Kỷ Luật";

            this.pnInputKTKL.BackColor = System.Drawing.Color.Transparent;
            this.pnInputKTKL.BorderRadius = 10;
            this.pnInputKTKL.Controls.Add(this.btnLuuKT);
            this.pnInputKTKL.Controls.Add(this.txtLyDoKT);
            this.pnInputKTKL.Controls.Add(this.txtSoTienKT);
            this.pnInputKTKL.Controls.Add(this.cboLoaiQD);
            this.pnInputKTKL.Controls.Add(this.cboNhanVienKT);
            this.pnInputKTKL.Controls.Add(this.txtMaQD);
            this.pnInputKTKL.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInputKTKL.FillColor = System.Drawing.Color.White;
            this.pnInputKTKL.Location = new System.Drawing.Point(20, 20);
            this.pnInputKTKL.Size = new System.Drawing.Size(1152, 120);

            this.txtMaQD.PlaceholderText = "Mã quyết định...";
            this.txtMaQD.Location = new System.Drawing.Point(30, 20);
            this.txtMaQD.Size = new System.Drawing.Size(150, 36);

            this.cboNhanVienKT.Location = new System.Drawing.Point(200, 20);
            this.cboNhanVienKT.Size = new System.Drawing.Size(300, 36);

            this.cboLoaiQD.Location = new System.Drawing.Point(520, 20);
            this.cboLoaiQD.Size = new System.Drawing.Size(180, 36);
            // Có thể thêm sẵn: "Khen Thưởng", "Kỷ Luật" vào Items của cboLoaiQD trong file code C#

            this.txtSoTienKT.PlaceholderText = "Số tiền (VNĐ)...";
            this.txtSoTienKT.Location = new System.Drawing.Point(720, 20);
            this.txtSoTienKT.Size = new System.Drawing.Size(180, 36);

            this.txtLyDoKT.PlaceholderText = "Lý do khen thưởng/kỷ luật...";
            this.txtLyDoKT.Location = new System.Drawing.Point(30, 70);
            this.txtLyDoKT.Size = new System.Drawing.Size(870, 36);

            this.btnLuuKT.Text = "LƯU QUYẾT ĐỊNH";
            this.btnLuuKT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnLuuKT.Location = new System.Drawing.Point(920, 20);
            this.btnLuuKT.Size = new System.Drawing.Size(180, 86);
            this.btnLuuKT.BorderRadius = 5;

            this.dgvKhenThuong.Location = new System.Drawing.Point(20, 160);
            this.dgvKhenThuong.Size = new System.Drawing.Size(1152, 460);
            this.dgvKhenThuong.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            // =========================================================================
            // TAB 3: CẤP PHỤ CẤP
            // =========================================================================
            this.pagePhuCapNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pagePhuCapNV.Controls.Add(this.dgvPhuCapNV);
            this.pagePhuCapNV.Controls.Add(this.pnInputPC);
            this.pagePhuCapNV.Location = new System.Drawing.Point(4, 54);
            this.pagePhuCapNV.Name = "pagePhuCapNV";
            this.pagePhuCapNV.Padding = new System.Windows.Forms.Padding(20);
            this.pagePhuCapNV.Size = new System.Drawing.Size(1192, 642);
            this.pagePhuCapNV.Text = "Phụ Cấp Nhân Viên";

            this.pnInputPC.BackColor = System.Drawing.Color.Transparent;
            this.pnInputPC.BorderRadius = 10;
            this.pnInputPC.Controls.Add(this.btnLuuPC);
            this.pnInputPC.Controls.Add(this.txtLyDoPC);
            this.pnInputPC.Controls.Add(this.dtpNgayCap);
            this.pnInputPC.Controls.Add(this.cboPhuCap);
            this.pnInputPC.Controls.Add(this.cboNhanVienPC);
            this.pnInputPC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInputPC.FillColor = System.Drawing.Color.White;
            this.pnInputPC.Location = new System.Drawing.Point(20, 20);
            this.pnInputPC.Size = new System.Drawing.Size(1152, 100);

            this.cboNhanVienPC.Location = new System.Drawing.Point(30, 30);
            this.cboNhanVienPC.Size = new System.Drawing.Size(250, 36);

            this.cboPhuCap.Location = new System.Drawing.Point(300, 30);
            this.cboPhuCap.Size = new System.Drawing.Size(250, 36);

            this.dtpNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCap.FillColor = System.Drawing.Color.White;
            this.dtpNgayCap.Location = new System.Drawing.Point(570, 30);
            this.dtpNgayCap.Size = new System.Drawing.Size(150, 36);
            this.dtpNgayCap.BorderRadius = 5;

            this.txtLyDoPC.PlaceholderText = "Ghi chú cấp phát...";
            this.txtLyDoPC.Location = new System.Drawing.Point(740, 30);
            this.txtLyDoPC.Size = new System.Drawing.Size(220, 36);

            this.btnLuuPC.Text = "CẤP PHỤ CẤP";
            this.btnLuuPC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136)))));
            this.btnLuuPC.Location = new System.Drawing.Point(980, 30);
            this.btnLuuPC.Size = new System.Drawing.Size(140, 36);
            this.btnLuuPC.BorderRadius = 5;

            this.dgvPhuCapNV.Location = new System.Drawing.Point(20, 140);
            this.dgvPhuCapNV.Size = new System.Drawing.Size(1152, 480);
            this.dgvPhuCapNV.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            // 
            // FrmTaiChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabTaiChinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTaiChinh";
            this.Text = "Quản Lý Tài Chính & Lương";

            this.tabTaiChinh.ResumeLayout(false);

            this.pageTamUng.ResumeLayout(false);
            this.pnInputTamUng.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamUng)).EndInit();

            this.pageKhenThuong.ResumeLayout(false);
            this.pnInputKTKL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenThuong)).EndInit();

            this.pagePhuCapNV.ResumeLayout(false);
            this.pnInputPC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuCapNV)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        // Khai báo chung
        private Guna.UI2.WinForms.Guna2TabControl tabTaiChinh;
        private System.Windows.Forms.TabPage pageTamUng;
        private System.Windows.Forms.TabPage pageKhenThuong;
        private System.Windows.Forms.TabPage pagePhuCapNV;

        // 1. Tạm Ứng
        private Guna.UI2.WinForms.Guna2Panel pnInputTamUng;
        private Guna.UI2.WinForms.Guna2TextBox txtMaTamUng;
        private Guna.UI2.WinForms.Guna2ComboBox cboNhanVienTU;
        private Guna.UI2.WinForms.Guna2TextBox txtSoTienTU;
        private Guna.UI2.WinForms.Guna2TextBox txtLyDoTU;
        private Guna.UI2.WinForms.Guna2Button btnLuuTU;
        private Guna.UI2.WinForms.Guna2Button btnDuyetTU;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTamUng;

        // 2. Khen Thưởng Kỷ Luật
        private Guna.UI2.WinForms.Guna2Panel pnInputKTKL;
        private Guna.UI2.WinForms.Guna2TextBox txtMaQD;
        private Guna.UI2.WinForms.Guna2ComboBox cboNhanVienKT;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiQD;
        private Guna.UI2.WinForms.Guna2TextBox txtSoTienKT;
        private Guna.UI2.WinForms.Guna2TextBox txtLyDoKT;
        private Guna.UI2.WinForms.Guna2Button btnLuuKT;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKhenThuong;

        // 3. Phụ Cấp Nhân Viên
        private Guna.UI2.WinForms.Guna2Panel pnInputPC;
        private Guna.UI2.WinForms.Guna2ComboBox cboNhanVienPC;
        private Guna.UI2.WinForms.Guna2ComboBox cboPhuCap;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayCap;
        private Guna.UI2.WinForms.Guna2TextBox txtLyDoPC;
        private Guna.UI2.WinForms.Guna2Button btnLuuPC;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhuCapNV;
    }
}