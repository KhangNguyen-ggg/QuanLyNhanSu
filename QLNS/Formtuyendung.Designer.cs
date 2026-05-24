namespace QLNS
{
    partial class Formtuyendung
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
            this.tabTuyenDung = new Guna.UI2.WinForms.Guna2TabControl();

            // TABS
            this.pageViTri = new System.Windows.Forms.TabPage();
            this.pageUngVien = new System.Windows.Forms.TabPage();

            // ==========================================
            // 1. CONTROLS VỊ TRÍ TUYỂN DỤNG
            // ==========================================
            this.pnInputViTri = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMaTD = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboPhongBan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboChucDanh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpHanChot = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtMucLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboTrangThaiTD = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLuuViTri = new Guna.UI2.WinForms.Guna2Button();
            this.dgvViTri = new Guna.UI2.WinForms.Guna2DataGridView();

            // ==========================================
            // 2. CONTROLS HỒ SƠ ỨNG VIÊN
            // ==========================================
            this.pnInputUngVien = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMaUV = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboMaTD = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLinkCV = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboTrangThaiUV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLuuUngVien = new Guna.UI2.WinForms.Guna2Button();
            this.dgvUngVien = new Guna.UI2.WinForms.Guna2DataGridView();

            this.tabTuyenDung.SuspendLayout();

            this.pageViTri.SuspendLayout();
            this.pnInputViTri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViTri)).BeginInit();

            this.pageUngVien.SuspendLayout();
            this.pnInputUngVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUngVien)).BeginInit();

            this.SuspendLayout();

            // 
            // tabTuyenDung
            // 
            this.tabTuyenDung.Controls.Add(this.pageViTri);
            this.tabTuyenDung.Controls.Add(this.pageUngVien);
            this.tabTuyenDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTuyenDung.ItemSize = new System.Drawing.Size(250, 50);
            this.tabTuyenDung.Location = new System.Drawing.Point(0, 0);
            this.tabTuyenDung.Name = "tabTuyenDung";
            this.tabTuyenDung.SelectedIndex = 0;
            this.tabTuyenDung.Size = new System.Drawing.Size(1200, 700);
            this.tabTuyenDung.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.tabTuyenDung.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabTuyenDung.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136)))));
            this.tabTuyenDung.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(160)))));
            this.tabTuyenDung.TabMenuBackColor = System.Drawing.Color.White;
            this.tabTuyenDung.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;

            // =========================================================================
            // TAB 1: VỊ TRÍ TUYỂN DỤNG
            // =========================================================================
            this.pageViTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pageViTri.Controls.Add(this.dgvViTri);
            this.pageViTri.Controls.Add(this.pnInputViTri);
            this.pageViTri.Location = new System.Drawing.Point(4, 54);
            this.pageViTri.Name = "pageViTri";
            this.pageViTri.Padding = new System.Windows.Forms.Padding(20);
            this.pageViTri.Size = new System.Drawing.Size(1192, 642);
            this.pageViTri.Text = "Kế Hoạch Tuyển Dụng";

            this.pnInputViTri.BackColor = System.Drawing.Color.Transparent;
            this.pnInputViTri.BorderRadius = 10;
            this.pnInputViTri.Controls.Add(this.cboTrangThaiTD);
            this.pnInputViTri.Controls.Add(this.txtMucLuong);
            this.pnInputViTri.Controls.Add(this.dtpHanChot);
            this.pnInputViTri.Controls.Add(this.txtSoLuong);
            this.pnInputViTri.Controls.Add(this.cboChucDanh);
            this.pnInputViTri.Controls.Add(this.cboPhongBan);
            this.pnInputViTri.Controls.Add(this.btnLuuViTri);
            this.pnInputViTri.Controls.Add(this.txtMaTD);
            this.pnInputViTri.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInputViTri.FillColor = System.Drawing.Color.White;
            this.pnInputViTri.Location = new System.Drawing.Point(20, 20);
            this.pnInputViTri.Size = new System.Drawing.Size(1152, 140);

            // Dòng 1
            this.txtMaTD.PlaceholderText = "Mã đợt tuyển...";
            this.txtMaTD.Location = new System.Drawing.Point(30, 20);
            this.txtMaTD.Size = new System.Drawing.Size(150, 36);

            this.cboPhongBan.Location = new System.Drawing.Point(200, 20);
            this.cboPhongBan.Size = new System.Drawing.Size(250, 36);

            this.cboChucDanh.Location = new System.Drawing.Point(470, 20);
            this.cboChucDanh.Size = new System.Drawing.Size(250, 36);

            this.txtSoLuong.PlaceholderText = "SL Cần tuyển...";
            this.txtSoLuong.Location = new System.Drawing.Point(740, 20);
            this.txtSoLuong.Size = new System.Drawing.Size(150, 36);

            // Dòng 2
            this.dtpHanChot.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanChot.FillColor = System.Drawing.Color.White;
            this.dtpHanChot.Location = new System.Drawing.Point(30, 75);
            this.dtpHanChot.Size = new System.Drawing.Size(150, 36);
            this.dtpHanChot.BorderRadius = 5;

            this.txtMucLuong.PlaceholderText = "Mức lương dự kiến...";
            this.txtMucLuong.Location = new System.Drawing.Point(200, 75);
            this.txtMucLuong.Size = new System.Drawing.Size(250, 36);

            this.cboTrangThaiTD.Location = new System.Drawing.Point(470, 75);
            this.cboTrangThaiTD.Size = new System.Drawing.Size(250, 36);

            this.btnLuuViTri.Text = "MỞ ĐỢT TUYỂN";
            this.btnLuuViTri.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136)))));
            this.btnLuuViTri.Location = new System.Drawing.Point(920, 20);
            this.btnLuuViTri.Size = new System.Drawing.Size(180, 90);
            this.btnLuuViTri.BorderRadius = 5;

            // Grid Vị Trí
            this.dgvViTri.Location = new System.Drawing.Point(20, 180);
            this.dgvViTri.Size = new System.Drawing.Size(1152, 440);
            this.dgvViTri.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            // =========================================================================
            // TAB 2: HỒ SƠ ỨNG VIÊN
            // =========================================================================
            this.pageUngVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pageUngVien.Controls.Add(this.dgvUngVien);
            this.pageUngVien.Controls.Add(this.pnInputUngVien);
            this.pageUngVien.Location = new System.Drawing.Point(4, 54);
            this.pageUngVien.Name = "pageUngVien";
            this.pageUngVien.Padding = new System.Windows.Forms.Padding(20);
            this.pageUngVien.Size = new System.Drawing.Size(1192, 642);
            this.pageUngVien.Text = "Hồ Sơ Ứng Viên";

            this.pnInputUngVien.BackColor = System.Drawing.Color.Transparent;
            this.pnInputUngVien.BorderRadius = 10;
            this.pnInputUngVien.Controls.Add(this.btnLuuUngVien);
            this.pnInputUngVien.Controls.Add(this.cboTrangThaiUV);
            this.pnInputUngVien.Controls.Add(this.txtLinkCV);
            this.pnInputUngVien.Controls.Add(this.txtEmail);
            this.pnInputUngVien.Controls.Add(this.txtSDT);
            this.pnInputUngVien.Controls.Add(this.txtHoTen);
            this.pnInputUngVien.Controls.Add(this.cboMaTD);
            this.pnInputUngVien.Controls.Add(this.txtMaUV);
            this.pnInputUngVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInputUngVien.FillColor = System.Drawing.Color.White;
            this.pnInputUngVien.Location = new System.Drawing.Point(20, 20);
            this.pnInputUngVien.Size = new System.Drawing.Size(1152, 140);

            // Dòng 1
            this.txtMaUV.PlaceholderText = "Mã CV...";
            this.txtMaUV.Location = new System.Drawing.Point(30, 20);
            this.txtMaUV.Size = new System.Drawing.Size(150, 36);

            this.cboMaTD.Location = new System.Drawing.Point(200, 20);
            this.cboMaTD.Size = new System.Drawing.Size(250, 36);

            this.txtHoTen.PlaceholderText = "Họ tên ứng viên...";
            this.txtHoTen.Location = new System.Drawing.Point(470, 20);
            this.txtHoTen.Size = new System.Drawing.Size(250, 36);

            this.txtSDT.PlaceholderText = "Số điện thoại...";
            this.txtSDT.Location = new System.Drawing.Point(740, 20);
            this.txtSDT.Size = new System.Drawing.Size(150, 36);

            // Dòng 2
            this.txtEmail.PlaceholderText = "Email liên hệ...";
            this.txtEmail.Location = new System.Drawing.Point(30, 75);
            this.txtEmail.Size = new System.Drawing.Size(300, 36);

            this.txtLinkCV.PlaceholderText = "Link Drive/PDF CV...";
            this.txtLinkCV.Location = new System.Drawing.Point(350, 75);
            this.txtLinkCV.Size = new System.Drawing.Size(370, 36);

            this.cboTrangThaiUV.Location = new System.Drawing.Point(740, 75);
            this.cboTrangThaiUV.Size = new System.Drawing.Size(150, 36);

            this.btnLuuUngVien.Text = "LƯU HỒ SƠ";
            this.btnLuuUngVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(160)))));
            this.btnLuuUngVien.Location = new System.Drawing.Point(920, 20);
            this.btnLuuUngVien.Size = new System.Drawing.Size(180, 90);
            this.btnLuuUngVien.BorderRadius = 5;

            // Grid Ứng Viên
            this.dgvUngVien.Location = new System.Drawing.Point(20, 180);
            this.dgvUngVien.Size = new System.Drawing.Size(1152, 440);
            this.dgvUngVien.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            // 
            // FrmTuyenDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabTuyenDung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTuyenDung";
            this.Text = "Quản Lý Tuyển Dụng";

            this.tabTuyenDung.ResumeLayout(false);

            this.pageViTri.ResumeLayout(false);
            this.pnInputViTri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViTri)).EndInit();

            this.pageUngVien.ResumeLayout(false);
            this.pnInputUngVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUngVien)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabTuyenDung;

        // Tab Vị trí
        private System.Windows.Forms.TabPage pageViTri;
        private Guna.UI2.WinForms.Guna2Panel pnInputViTri;
        private Guna.UI2.WinForms.Guna2TextBox txtMaTD;
        private Guna.UI2.WinForms.Guna2ComboBox cboPhongBan;
        private Guna.UI2.WinForms.Guna2ComboBox cboChucDanh;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuong;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHanChot;
        private Guna.UI2.WinForms.Guna2TextBox txtMucLuong;
        private Guna.UI2.WinForms.Guna2ComboBox cboTrangThaiTD;
        private Guna.UI2.WinForms.Guna2Button btnLuuViTri;
        private Guna.UI2.WinForms.Guna2DataGridView dgvViTri;

        // Tab Ứng Viên
        private System.Windows.Forms.TabPage pageUngVien;
        private Guna.UI2.WinForms.Guna2Panel pnInputUngVien;
        private Guna.UI2.WinForms.Guna2TextBox txtMaUV;
        private Guna.UI2.WinForms.Guna2ComboBox cboMaTD;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtLinkCV;
        private Guna.UI2.WinForms.Guna2ComboBox cboTrangThaiUV;
        private Guna.UI2.WinForms.Guna2Button btnLuuUngVien;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUngVien;
    }
}