namespace QLNS
{
    partial class Formdanhmuc
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
            this.tabDanhMuc = new Guna.UI2.WinForms.Guna2TabControl();

            // TABS
            this.pageChiNhanh = new System.Windows.Forms.TabPage();
            this.pagePhongBan = new System.Windows.Forms.TabPage();
            this.pageChucDanh = new System.Windows.Forms.TabPage();
            this.pageCaLamViec = new System.Windows.Forms.TabPage();
            this.pageHinhThucCC = new System.Windows.Forms.TabPage();
            this.pagePhuCap = new System.Windows.Forms.TabPage();

            // ==========================================
            // 1. CONTROLS CHI NHÁNH
            // ==========================================
            this.pnInputChiNhanh = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMaChiNhanh = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenChiNhanh = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHotline = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuuChiNhanh = new Guna.UI2.WinForms.Guna2Button();
            this.dgvChiNhanh = new Guna.UI2.WinForms.Guna2DataGridView();

            // ==========================================
            // 2. CONTROLS PHÒNG BAN
            // ==========================================
            this.pnInputPhongBan = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMaPhongBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenPhongBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboChiNhanh_PB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLuuPhongBan = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPhongBan = new Guna.UI2.WinForms.Guna2DataGridView();

            // ==========================================
            // 3. CONTROLS CHỨC DANH
            // ==========================================
            this.pnInputChucDanh = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMaChucDanh = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenChucDanh = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCapBac = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuuChucDanh = new Guna.UI2.WinForms.Guna2Button();
            this.dgvChucDanh = new Guna.UI2.WinForms.Guna2DataGridView();

            // ==========================================
            // 4. CONTROLS CA LÀM VIỆC
            // ==========================================
            this.pnInputCaLamViec = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMaCa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenCa = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnLuuCa = new Guna.UI2.WinForms.Guna2Button();
            this.dgvCaLamViec = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblGioBatDau = new System.Windows.Forms.Label();
            this.lblGioKetThuc = new System.Windows.Forms.Label();

            // ==========================================
            // 5. CONTROLS HÌNH THỨC CHẤM CÔNG
            // ==========================================
            this.pnInputHTCC = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMaHTCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenHTCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuuHTCC = new Guna.UI2.WinForms.Guna2Button();
            this.dgvHinhThucCC = new Guna.UI2.WinForms.Guna2DataGridView();

            // ==========================================
            // 6. CONTROLS PHỤ CẤP
            // ==========================================
            this.pnInputPhuCap = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMaPhuCap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenPhuCap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMucTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuuPhuCap = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPhuCap = new Guna.UI2.WinForms.Guna2DataGridView();

            this.tabDanhMuc.SuspendLayout();
            this.pageChiNhanh.SuspendLayout();
            this.pnInputChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNhanh)).BeginInit();

            this.pagePhongBan.SuspendLayout();
            this.pnInputPhongBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();

            this.pageChucDanh.SuspendLayout();
            this.pnInputChucDanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucDanh)).BeginInit();

            this.pageCaLamViec.SuspendLayout();
            this.pnInputCaLamViec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaLamViec)).BeginInit();

            this.pageHinhThucCC.SuspendLayout();
            this.pnInputHTCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHinhThucCC)).BeginInit();

            this.pagePhuCap.SuspendLayout();
            this.pnInputPhuCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuCap)).BeginInit();
            this.SuspendLayout();

            // 
            // tabDanhMuc
            // 
            this.tabDanhMuc.Controls.Add(this.pageChiNhanh);
            this.tabDanhMuc.Controls.Add(this.pagePhongBan);
            this.tabDanhMuc.Controls.Add(this.pageChucDanh);
            this.tabDanhMuc.Controls.Add(this.pageCaLamViec);
            this.tabDanhMuc.Controls.Add(this.pageHinhThucCC);
            this.tabDanhMuc.Controls.Add(this.pagePhuCap);
            this.tabDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDanhMuc.ItemSize = new System.Drawing.Size(190, 50);
            this.tabDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.tabDanhMuc.Name = "tabDanhMuc";
            this.tabDanhMuc.SelectedIndex = 0;
            this.tabDanhMuc.Size = new System.Drawing.Size(1200, 700);
            this.tabDanhMuc.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.tabDanhMuc.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabDanhMuc.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136)))));
            this.tabDanhMuc.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(160)))));
            this.tabDanhMuc.TabMenuBackColor = System.Drawing.Color.White;
            this.tabDanhMuc.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;

            // =========================================================================
            // TAB 1: CHI NHÁNH
            // =========================================================================
            this.pageChiNhanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pageChiNhanh.Controls.Add(this.dgvChiNhanh);
            this.pageChiNhanh.Controls.Add(this.pnInputChiNhanh);
            this.pageChiNhanh.Location = new System.Drawing.Point(4, 54);
            this.pageChiNhanh.Name = "pageChiNhanh";
            this.pageChiNhanh.Padding = new System.Windows.Forms.Padding(20);
            this.pageChiNhanh.Size = new System.Drawing.Size(1192, 642);
            this.pageChiNhanh.Text = "Cơ sở / Chi nhánh";

            this.pnInputChiNhanh.BackColor = System.Drawing.Color.Transparent;
            this.pnInputChiNhanh.BorderRadius = 10;
            this.pnInputChiNhanh.Controls.Add(this.btnLuuChiNhanh);
            this.pnInputChiNhanh.Controls.Add(this.txtHotline);
            this.pnInputChiNhanh.Controls.Add(this.txtDiaChi);
            this.pnInputChiNhanh.Controls.Add(this.txtTenChiNhanh);
            this.pnInputChiNhanh.Controls.Add(this.txtMaChiNhanh);
            this.pnInputChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInputChiNhanh.FillColor = System.Drawing.Color.White;
            this.pnInputChiNhanh.Location = new System.Drawing.Point(20, 20);
            this.pnInputChiNhanh.Size = new System.Drawing.Size(1152, 120);

            this.txtMaChiNhanh.PlaceholderText = "Mã chi nhánh...";
            this.txtMaChiNhanh.Location = new System.Drawing.Point(30, 25);
            this.txtMaChiNhanh.Size = new System.Drawing.Size(200, 36);

            this.txtTenChiNhanh.PlaceholderText = "Tên chi nhánh...";
            this.txtTenChiNhanh.Location = new System.Drawing.Point(250, 25);
            this.txtTenChiNhanh.Size = new System.Drawing.Size(350, 36);

            this.txtHotline.PlaceholderText = "Hotline...";
            this.txtHotline.Location = new System.Drawing.Point(620, 25);
            this.txtHotline.Size = new System.Drawing.Size(200, 36);

            this.txtDiaChi.PlaceholderText = "Địa chỉ...";
            this.txtDiaChi.Location = new System.Drawing.Point(30, 70);
            this.txtDiaChi.Size = new System.Drawing.Size(790, 36);

            this.btnLuuChiNhanh.Text = "LƯU DỮ LIỆU";
            this.btnLuuChiNhanh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136)))));
            this.btnLuuChiNhanh.Location = new System.Drawing.Point(840, 25);
            this.btnLuuChiNhanh.Size = new System.Drawing.Size(150, 80);
            this.btnLuuChiNhanh.BorderRadius = 5;

            this.dgvChiNhanh.Location = new System.Drawing.Point(20, 160);
            this.dgvChiNhanh.Size = new System.Drawing.Size(1152, 460);
            this.dgvChiNhanh.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            // =========================================================================
            // TAB 2: PHÒNG BAN
            // =========================================================================
            this.pagePhongBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pagePhongBan.Controls.Add(this.dgvPhongBan);
            this.pagePhongBan.Controls.Add(this.pnInputPhongBan);
            this.pagePhongBan.Location = new System.Drawing.Point(4, 54);
            this.pagePhongBan.Name = "pagePhongBan";
            this.pagePhongBan.Padding = new System.Windows.Forms.Padding(20);
            this.pagePhongBan.Size = new System.Drawing.Size(1192, 642);
            this.pagePhongBan.Text = "Cơ cấu Phòng Ban";

            this.pnInputPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.pnInputPhongBan.BorderRadius = 10;
            this.pnInputPhongBan.Controls.Add(this.btnLuuPhongBan);
            this.pnInputPhongBan.Controls.Add(this.cboChiNhanh_PB);
            this.pnInputPhongBan.Controls.Add(this.txtTenPhongBan);
            this.pnInputPhongBan.Controls.Add(this.txtMaPhongBan);
            this.pnInputPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInputPhongBan.FillColor = System.Drawing.Color.White;
            this.pnInputPhongBan.Location = new System.Drawing.Point(20, 20);
            this.pnInputPhongBan.Size = new System.Drawing.Size(1152, 100);

            this.txtMaPhongBan.PlaceholderText = "Mã phòng ban...";
            this.txtMaPhongBan.Location = new System.Drawing.Point(30, 30);
            this.txtMaPhongBan.Size = new System.Drawing.Size(200, 36);

            this.txtTenPhongBan.PlaceholderText = "Tên phòng ban...";
            this.txtTenPhongBan.Location = new System.Drawing.Point(250, 30);
            this.txtTenPhongBan.Size = new System.Drawing.Size(350, 36);

            this.cboChiNhanh_PB.Location = new System.Drawing.Point(620, 30);
            this.cboChiNhanh_PB.Size = new System.Drawing.Size(250, 36);

            this.btnLuuPhongBan.Text = "LƯU PHÒNG BAN";
            this.btnLuuPhongBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136)))));
            this.btnLuuPhongBan.Location = new System.Drawing.Point(890, 30);
            this.btnLuuPhongBan.Size = new System.Drawing.Size(150, 36);
            this.btnLuuPhongBan.BorderRadius = 5;

            this.dgvPhongBan.Location = new System.Drawing.Point(20, 140);
            this.dgvPhongBan.Size = new System.Drawing.Size(1152, 480);
            this.dgvPhongBan.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            // =========================================================================
            // TAB 3: CHỨC DANH
            // =========================================================================
            this.pageChucDanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pageChucDanh.Controls.Add(this.dgvChucDanh);
            this.pageChucDanh.Controls.Add(this.pnInputChucDanh);
            this.pageChucDanh.Location = new System.Drawing.Point(4, 54);
            this.pageChucDanh.Name = "pageChucDanh";
            this.pageChucDanh.Padding = new System.Windows.Forms.Padding(20);
            this.pageChucDanh.Size = new System.Drawing.Size(1192, 642);
            this.pageChucDanh.Text = "Chức Danh";

            this.pnInputChucDanh.BackColor = System.Drawing.Color.Transparent;
            this.pnInputChucDanh.BorderRadius = 10;
            this.pnInputChucDanh.Controls.Add(this.btnLuuChucDanh);
            this.pnInputChucDanh.Controls.Add(this.txtCapBac);
            this.pnInputChucDanh.Controls.Add(this.txtTenChucDanh);
            this.pnInputChucDanh.Controls.Add(this.txtMaChucDanh);
            this.pnInputChucDanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInputChucDanh.FillColor = System.Drawing.Color.White;
            this.pnInputChucDanh.Location = new System.Drawing.Point(20, 20);
            this.pnInputChucDanh.Size = new System.Drawing.Size(1152, 100);

            this.txtMaChucDanh.PlaceholderText = "Mã chức danh...";
            this.txtMaChucDanh.Location = new System.Drawing.Point(30, 30);
            this.txtMaChucDanh.Size = new System.Drawing.Size(200, 36);

            this.txtTenChucDanh.PlaceholderText = "Tên chức danh...";
            this.txtTenChucDanh.Location = new System.Drawing.Point(250, 30);
            this.txtTenChucDanh.Size = new System.Drawing.Size(350, 36);

            this.txtCapBac.PlaceholderText = "Cấp bậc (vd: Quản lý, Nhân viên)...";
            this.txtCapBac.Location = new System.Drawing.Point(620, 30);
            this.txtCapBac.Size = new System.Drawing.Size(250, 36);

            this.btnLuuChucDanh.Text = "LƯU CHỨC DANH";
            this.btnLuuChucDanh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136)))));
            this.btnLuuChucDanh.Location = new System.Drawing.Point(890, 30);
            this.btnLuuChucDanh.Size = new System.Drawing.Size(150, 36);
            this.btnLuuChucDanh.BorderRadius = 5;

            this.dgvChucDanh.Location = new System.Drawing.Point(20, 140);
            this.dgvChucDanh.Size = new System.Drawing.Size(1152, 480);
            this.dgvChucDanh.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            // =========================================================================
            // TAB 4: CA LÀM VIỆC
            // =========================================================================
            this.pageCaLamViec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pageCaLamViec.Controls.Add(this.dgvCaLamViec);
            this.pageCaLamViec.Controls.Add(this.pnInputCaLamViec);
            this.pageCaLamViec.Location = new System.Drawing.Point(4, 54);
            this.pageCaLamViec.Name = "pageCaLamViec";
            this.pageCaLamViec.Padding = new System.Windows.Forms.Padding(20);
            this.pageCaLamViec.Size = new System.Drawing.Size(1192, 642);
            this.pageCaLamViec.Text = "Ca Làm Việc";

            this.pnInputCaLamViec.BackColor = System.Drawing.Color.Transparent;
            this.pnInputCaLamViec.BorderRadius = 10;
            this.pnInputCaLamViec.Controls.Add(this.lblGioKetThuc);
            this.pnInputCaLamViec.Controls.Add(this.lblGioBatDau);
            this.pnInputCaLamViec.Controls.Add(this.btnLuuCa);
            this.pnInputCaLamViec.Controls.Add(this.dtpGioKetThuc);
            this.pnInputCaLamViec.Controls.Add(this.dtpGioBatDau);
            this.pnInputCaLamViec.Controls.Add(this.txtTenCa);
            this.pnInputCaLamViec.Controls.Add(this.txtMaCa);
            this.pnInputCaLamViec.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInputCaLamViec.FillColor = System.Drawing.Color.White;
            this.pnInputCaLamViec.Location = new System.Drawing.Point(20, 20);
            this.pnInputCaLamViec.Size = new System.Drawing.Size(1152, 100);

            this.txtMaCa.PlaceholderText = "Mã ca...";
            this.txtMaCa.Location = new System.Drawing.Point(30, 30);
            this.txtMaCa.Size = new System.Drawing.Size(150, 36);

            this.txtTenCa.PlaceholderText = "Tên ca (vd: Ca Sáng)...";
            this.txtTenCa.Location = new System.Drawing.Point(200, 30);
            this.txtTenCa.Size = new System.Drawing.Size(250, 36);

            this.lblGioBatDau.AutoSize = true;
            this.lblGioBatDau.Location = new System.Drawing.Point(470, 40);
            this.lblGioBatDau.Text = "Bắt đầu:";

            this.dtpGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioBatDau.ShowUpDown = true;
            this.dtpGioBatDau.Location = new System.Drawing.Point(530, 35);
            this.dtpGioBatDau.Size = new System.Drawing.Size(100, 25);

            this.lblGioKetThuc.AutoSize = true;
            this.lblGioKetThuc.Location = new System.Drawing.Point(650, 40);
            this.lblGioKetThuc.Text = "Kết thúc:";

            this.dtpGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioKetThuc.ShowUpDown = true;
            this.dtpGioKetThuc.Location = new System.Drawing.Point(710, 35);
            this.dtpGioKetThuc.Size = new System.Drawing.Size(100, 25);

            this.btnLuuCa.Text = "LƯU CA LÀM";
            this.btnLuuCa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136)))));
            this.btnLuuCa.Location = new System.Drawing.Point(850, 30);
            this.btnLuuCa.Size = new System.Drawing.Size(150, 36);
            this.btnLuuCa.BorderRadius = 5;

            this.dgvCaLamViec.Location = new System.Drawing.Point(20, 140);
            this.dgvCaLamViec.Size = new System.Drawing.Size(1152, 480);
            this.dgvCaLamViec.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            // =========================================================================
            // TAB 5: HÌNH THỨC CHẤM CÔNG
            // =========================================================================
            this.pageHinhThucCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pageHinhThucCC.Controls.Add(this.dgvHinhThucCC);
            this.pageHinhThucCC.Controls.Add(this.pnInputHTCC);
            this.pageHinhThucCC.Location = new System.Drawing.Point(4, 54);
            this.pageHinhThucCC.Name = "pageHinhThucCC";
            this.pageHinhThucCC.Padding = new System.Windows.Forms.Padding(20);
            this.pageHinhThucCC.Size = new System.Drawing.Size(1192, 642);
            this.pageHinhThucCC.Text = "Loại Chấm Công";

            this.pnInputHTCC.BackColor = System.Drawing.Color.Transparent;
            this.pnInputHTCC.BorderRadius = 10;
            this.pnInputHTCC.Controls.Add(this.btnLuuHTCC);
            this.pnInputHTCC.Controls.Add(this.txtTenHTCC);
            this.pnInputHTCC.Controls.Add(this.txtMaHTCC);
            this.pnInputHTCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInputHTCC.FillColor = System.Drawing.Color.White;
            this.pnInputHTCC.Location = new System.Drawing.Point(20, 20);
            this.pnInputHTCC.Size = new System.Drawing.Size(1152, 100);

            this.txtMaHTCC.PlaceholderText = "Mã hình thức...";
            this.txtMaHTCC.Location = new System.Drawing.Point(30, 30);
            this.txtMaHTCC.Size = new System.Drawing.Size(200, 36);

            this.txtTenHTCC.PlaceholderText = "Tên (vd: Vân tay, Khuôn mặt, Bù giờ)...";
            this.txtTenHTCC.Location = new System.Drawing.Point(250, 30);
            this.txtTenHTCC.Size = new System.Drawing.Size(400, 36);

            this.btnLuuHTCC.Text = "LƯU HÌNH THỨC";
            this.btnLuuHTCC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136)))));
            this.btnLuuHTCC.Location = new System.Drawing.Point(670, 30);
            this.btnLuuHTCC.Size = new System.Drawing.Size(150, 36);
            this.btnLuuHTCC.BorderRadius = 5;

            this.dgvHinhThucCC.Location = new System.Drawing.Point(20, 140);
            this.dgvHinhThucCC.Size = new System.Drawing.Size(1152, 480);
            this.dgvHinhThucCC.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            // =========================================================================
            // TAB 6: PHỤ CẤP
            // =========================================================================
            this.pagePhuCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pagePhuCap.Controls.Add(this.dgvPhuCap);
            this.pagePhuCap.Controls.Add(this.pnInputPhuCap);
            this.pagePhuCap.Location = new System.Drawing.Point(4, 54);
            this.pagePhuCap.Name = "pagePhuCap";
            this.pagePhuCap.Padding = new System.Windows.Forms.Padding(20);
            this.pagePhuCap.Size = new System.Drawing.Size(1192, 642);
            this.pagePhuCap.Text = "Danh Mục Phụ Cấp";

            this.pnInputPhuCap.BackColor = System.Drawing.Color.Transparent;
            this.pnInputPhuCap.BorderRadius = 10;
            this.pnInputPhuCap.Controls.Add(this.btnLuuPhuCap);
            this.pnInputPhuCap.Controls.Add(this.txtMucTien);
            this.pnInputPhuCap.Controls.Add(this.txtTenPhuCap);
            this.pnInputPhuCap.Controls.Add(this.txtMaPhuCap);
            this.pnInputPhuCap.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInputPhuCap.FillColor = System.Drawing.Color.White;
            this.pnInputPhuCap.Location = new System.Drawing.Point(20, 20);
            this.pnInputPhuCap.Size = new System.Drawing.Size(1152, 100);

            this.txtMaPhuCap.PlaceholderText = "Mã phụ cấp...";
            this.txtMaPhuCap.Location = new System.Drawing.Point(30, 30);
            this.txtMaPhuCap.Size = new System.Drawing.Size(200, 36);

            this.txtTenPhuCap.PlaceholderText = "Tên phụ cấp (vd: Xăng xe, Ăn trưa)...";
            this.txtTenPhuCap.Location = new System.Drawing.Point(250, 30);
            this.txtTenPhuCap.Size = new System.Drawing.Size(350, 36);

            this.txtMucTien.PlaceholderText = "Mức tiền (VNĐ)...";
            this.txtMucTien.Location = new System.Drawing.Point(620, 30);
            this.txtMucTien.Size = new System.Drawing.Size(250, 36);

            this.btnLuuPhuCap.Text = "LƯU PHỤ CẤP";
            this.btnLuuPhuCap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(136)))));
            this.btnLuuPhuCap.Location = new System.Drawing.Point(890, 30);
            this.btnLuuPhuCap.Size = new System.Drawing.Size(150, 36);
            this.btnLuuPhuCap.BorderRadius = 5;

            this.dgvPhuCap.Location = new System.Drawing.Point(20, 140);
            this.dgvPhuCap.Size = new System.Drawing.Size(1152, 480);
            this.dgvPhuCap.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabDanhMuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDanhMuc";
            this.Text = "Thiết Lập Danh Mục";

            this.tabDanhMuc.ResumeLayout(false);

            this.pageChiNhanh.ResumeLayout(false);
            this.pnInputChiNhanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNhanh)).EndInit();

            this.pagePhongBan.ResumeLayout(false);
            this.pnInputPhongBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();

            this.pageChucDanh.ResumeLayout(false);
            this.pnInputChucDanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucDanh)).EndInit();

            this.pageCaLamViec.ResumeLayout(false);
            this.pnInputCaLamViec.ResumeLayout(false);
            this.pnInputCaLamViec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaLamViec)).EndInit();

            this.pageHinhThucCC.ResumeLayout(false);
            this.pnInputHTCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHinhThucCC)).EndInit();

            this.pagePhuCap.ResumeLayout(false);
            this.pnInputPhuCap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuCap)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        // Khai báo chung
        private Guna.UI2.WinForms.Guna2TabControl tabDanhMuc;

        // Tab Pages
        private System.Windows.Forms.TabPage pageChiNhanh;
        private System.Windows.Forms.TabPage pagePhongBan;
        private System.Windows.Forms.TabPage pageChucDanh;
        private System.Windows.Forms.TabPage pageCaLamViec;
        private System.Windows.Forms.TabPage pageHinhThucCC;
        private System.Windows.Forms.TabPage pagePhuCap;

        // 1. Chi Nhánh
        private Guna.UI2.WinForms.Guna2Panel pnInputChiNhanh;
        private Guna.UI2.WinForms.Guna2TextBox txtMaChiNhanh;
        private Guna.UI2.WinForms.Guna2TextBox txtTenChiNhanh;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtHotline;
        private Guna.UI2.WinForms.Guna2Button btnLuuChiNhanh;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChiNhanh;

        // 2. Phòng Ban
        private Guna.UI2.WinForms.Guna2Panel pnInputPhongBan;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhongBan;
        private Guna.UI2.WinForms.Guna2TextBox txtTenPhongBan;
        private Guna.UI2.WinForms.Guna2ComboBox cboChiNhanh_PB;
        private Guna.UI2.WinForms.Guna2Button btnLuuPhongBan;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhongBan;

        // 3. Chức Danh
        private Guna.UI2.WinForms.Guna2Panel pnInputChucDanh;
        private Guna.UI2.WinForms.Guna2TextBox txtMaChucDanh;
        private Guna.UI2.WinForms.Guna2TextBox txtTenChucDanh;
        private Guna.UI2.WinForms.Guna2TextBox txtCapBac;
        private Guna.UI2.WinForms.Guna2Button btnLuuChucDanh;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChucDanh;

        // 4. Ca Làm Việc
        private Guna.UI2.WinForms.Guna2Panel pnInputCaLamViec;
        private Guna.UI2.WinForms.Guna2TextBox txtMaCa;
        private Guna.UI2.WinForms.Guna2TextBox txtTenCa;
        private System.Windows.Forms.Label lblGioBatDau;
        private System.Windows.Forms.DateTimePicker dtpGioBatDau;
        private System.Windows.Forms.Label lblGioKetThuc;
        private System.Windows.Forms.DateTimePicker dtpGioKetThuc;
        private Guna.UI2.WinForms.Guna2Button btnLuuCa;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCaLamViec;

        // 5. Hình Thức Chấm Công
        private Guna.UI2.WinForms.Guna2Panel pnInputHTCC;
        private Guna.UI2.WinForms.Guna2TextBox txtMaHTCC;
        private Guna.UI2.WinForms.Guna2TextBox txtTenHTCC;
        private Guna.UI2.WinForms.Guna2Button btnLuuHTCC;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHinhThucCC;

        // 6. Phụ Cấp
        private Guna.UI2.WinForms.Guna2Panel pnInputPhuCap;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhuCap;
        private Guna.UI2.WinForms.Guna2TextBox txtTenPhuCap;
        private Guna.UI2.WinForms.Guna2TextBox txtMucTien;
        private Guna.UI2.WinForms.Guna2Button btnLuuPhuCap;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhuCap;
    }
}