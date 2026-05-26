namespace QLNS
{
    partial class FormSuaNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing"></param>
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cboGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.cboPhongBan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblChucDanh = new System.Windows.Forms.Label();
            this.cboChucDanh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gbChiTiet = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNgayCap = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.txtNoiCap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.dptNgayCap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblEmailCt = new System.Windows.Forms.Label();
            this.lblEmailCN = new System.Windows.Forms.Label();
            this.txtEmailCT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmailCN = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMST = new System.Windows.Forms.Label();
            this.txtMST = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSTK = new System.Windows.Forms.Label();
            this.txtSTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNganHang = new System.Windows.Forms.Label();
            this.txtNganHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.gbChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblTitle.Location = new System.Drawing.Point(49, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(397, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM MỚI NHÂN VIÊN";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblMaNV.Location = new System.Drawing.Point(50, 78);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(155, 25);
            this.lblMaNV.TabIndex = 1;
            this.lblMaNV.Text = "Mã nhân viên (*)";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BorderRadius = 6;
            this.txtMaNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNhanVien.DefaultText = "";
            this.txtMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaNhanVien.Location = new System.Drawing.Point(220, 68);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.PlaceholderText = "Nhập mã NV...";
            this.txtMaNhanVien.SelectedText = "";
            this.txtMaNhanVien.Size = new System.Drawing.Size(350, 45);
            this.txtMaNhanVien.TabIndex = 2;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.Location = new System.Drawing.Point(50, 158);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(122, 25);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Họ và tên (*)";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderRadius = 6;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHoTen.Location = new System.Drawing.Point(220, 148);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PlaceholderText = "Nhập họ tên...";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(350, 45);
            this.txtHoTen.TabIndex = 4;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblGioiTinh.Location = new System.Drawing.Point(50, 238);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(112, 25);
            this.lblGioiTinh.TabIndex = 5;
            this.lblGioiTinh.Text = "Giới tính (*)";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cboGioiTinh.BorderRadius = 6;
            this.cboGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FocusedColor = System.Drawing.Color.Empty;
            this.cboGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboGioiTinh.ItemHeight = 39;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(220, 228);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(350, 45);
            this.cboGioiTinh.TabIndex = 6;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblNgaySinh.Location = new System.Drawing.Point(650, 78);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(124, 25);
            this.lblNgaySinh.TabIndex = 7;
            this.lblNgaySinh.Text = "Ngày sinh (*)";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpNgaySinh.BorderRadius = 6;
            this.dtpNgaySinh.BorderThickness = 1;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(800, 68);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(350, 45);
            this.dtpNgaySinh.TabIndex = 8;
            this.dtpNgaySinh.Value = new System.DateTime(2026, 5, 25, 0, 0, 0, 0);
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblPhongBan.Location = new System.Drawing.Point(650, 158);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(131, 25);
            this.lblPhongBan.TabIndex = 9;
            this.lblPhongBan.Text = "Phòng ban (*)";
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.cboPhongBan.BorderRadius = 6;
            this.cboPhongBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBan.FocusedColor = System.Drawing.Color.Empty;
            this.cboPhongBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPhongBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboPhongBan.ItemHeight = 39;
            this.cboPhongBan.Location = new System.Drawing.Point(800, 148);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(350, 45);
            this.cboPhongBan.TabIndex = 10;
            // 
            // lblChucDanh
            // 
            this.lblChucDanh.AutoSize = true;
            this.lblChucDanh.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblChucDanh.Location = new System.Drawing.Point(650, 238);
            this.lblChucDanh.Name = "lblChucDanh";
            this.lblChucDanh.Size = new System.Drawing.Size(130, 25);
            this.lblChucDanh.TabIndex = 11;
            this.lblChucDanh.Text = "Chức danh (*)";
            // 
            // cboChucDanh
            // 
            this.cboChucDanh.BackColor = System.Drawing.Color.Transparent;
            this.cboChucDanh.BorderRadius = 6;
            this.cboChucDanh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboChucDanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucDanh.FocusedColor = System.Drawing.Color.Empty;
            this.cboChucDanh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboChucDanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboChucDanh.ItemHeight = 39;
            this.cboChucDanh.Location = new System.Drawing.Point(800, 228);
            this.cboChucDanh.Name = "cboChucDanh";
            this.cboChucDanh.Size = new System.Drawing.Size(350, 45);
            this.cboChucDanh.TabIndex = 12;
            // 
            // gbChiTiet
            // 
            this.gbChiTiet.BorderRadius = 8;
            this.gbChiTiet.Controls.Add(this.label2);
            this.gbChiTiet.Controls.Add(this.lblNgayCap);
            this.gbChiTiet.Controls.Add(this.lblCCCD);
            this.gbChiTiet.Controls.Add(this.txtNoiCap);
            this.gbChiTiet.Controls.Add(this.txtCCCD);
            this.gbChiTiet.Controls.Add(this.lblSDT);
            this.gbChiTiet.Controls.Add(this.txtSDT);
            this.gbChiTiet.Controls.Add(this.dptNgayCap);
            this.gbChiTiet.Controls.Add(this.lblEmailCt);
            this.gbChiTiet.Controls.Add(this.lblEmailCN);
            this.gbChiTiet.Controls.Add(this.txtEmailCT);
            this.gbChiTiet.Controls.Add(this.txtEmailCN);
            this.gbChiTiet.Controls.Add(this.lblDiaChi);
            this.gbChiTiet.Controls.Add(this.txtDiaChi);
            this.gbChiTiet.Controls.Add(this.lblMST);
            this.gbChiTiet.Controls.Add(this.txtMST);
            this.gbChiTiet.Controls.Add(this.lblSTK);
            this.gbChiTiet.Controls.Add(this.txtSTK);
            this.gbChiTiet.Controls.Add(this.lblNganHang);
            this.gbChiTiet.Controls.Add(this.txtNganHang);
            this.gbChiTiet.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.gbChiTiet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gbChiTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbChiTiet.Location = new System.Drawing.Point(55, 300);
            this.gbChiTiet.Name = "gbChiTiet";
            this.gbChiTiet.Size = new System.Drawing.Size(1150, 453);
            this.gbChiTiet.TabIndex = 13;
            this.gbChiTiet.Text = "Thông tin liên lạc & Hồ sơ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nơi cấp";
            // 
            // lblNgayCap
            // 
            this.lblNgayCap.AutoSize = true;
            this.lblNgayCap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgayCap.ForeColor = System.Drawing.Color.Black;
            this.lblNgayCap.Location = new System.Drawing.Point(40, 150);
            this.lblNgayCap.Name = "lblNgayCap";
            this.lblNgayCap.Size = new System.Drawing.Size(82, 23);
            this.lblNgayCap.TabIndex = 0;
            this.lblNgayCap.Text = "Ngày cấp";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCCCD.ForeColor = System.Drawing.Color.Black;
            this.lblCCCD.Location = new System.Drawing.Point(40, 75);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(101, 23);
            this.lblCCCD.TabIndex = 0;
            this.lblCCCD.Text = "Số CCCD (*)";
            // 
            // txtNoiCap
            // 
            this.txtNoiCap.BorderRadius = 4;
            this.txtNoiCap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoiCap.DefaultText = "";
            this.txtNoiCap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNoiCap.Location = new System.Drawing.Point(180, 215);
            this.txtNoiCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoiCap.Name = "txtNoiCap";
            this.txtNoiCap.PlaceholderText = "";
            this.txtNoiCap.SelectedText = "";
            this.txtNoiCap.Size = new System.Drawing.Size(350, 45);
            this.txtNoiCap.TabIndex = 1;
            // 
            // txtCCCD
            // 
            this.txtCCCD.BorderRadius = 4;
            this.txtCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCCD.DefaultText = "";
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCCCD.Location = new System.Drawing.Point(180, 65);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.PlaceholderText = "";
            this.txtCCCD.SelectedText = "";
            this.txtCCCD.Size = new System.Drawing.Size(350, 45);
            this.txtCCCD.TabIndex = 1;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSDT.ForeColor = System.Drawing.Color.Black;
            this.lblSDT.Location = new System.Drawing.Point(600, 297);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(89, 23);
            this.lblSDT.TabIndex = 2;
            this.lblSDT.Text = "Điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.BorderRadius = 4;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSDT.Location = new System.Drawing.Point(750, 287);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(350, 45);
            this.txtSDT.TabIndex = 3;
            // 
            // dptNgayCap
            // 
            this.dptNgayCap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dptNgayCap.BorderRadius = 6;
            this.dptNgayCap.BorderThickness = 1;
            this.dptNgayCap.Checked = true;
            this.dptNgayCap.CustomFormat = "dd/MM/yyyy";
            this.dptNgayCap.FillColor = System.Drawing.Color.White;
            this.dptNgayCap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dptNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptNgayCap.Location = new System.Drawing.Point(180, 140);
            this.dptNgayCap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dptNgayCap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dptNgayCap.Name = "dptNgayCap";
            this.dptNgayCap.Size = new System.Drawing.Size(350, 45);
            this.dptNgayCap.TabIndex = 8;
            this.dptNgayCap.Value = new System.DateTime(2026, 5, 25, 0, 0, 0, 0);
            // 
            // lblEmailCt
            // 
            this.lblEmailCt.AutoSize = true;
            this.lblEmailCt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmailCt.ForeColor = System.Drawing.Color.Black;
            this.lblEmailCt.Location = new System.Drawing.Point(40, 369);
            this.lblEmailCt.Name = "lblEmailCt";
            this.lblEmailCt.Size = new System.Drawing.Size(116, 23);
            this.lblEmailCt.TabIndex = 4;
            this.lblEmailCt.Text = "Email Công ty";
            // 
            // lblEmailCN
            // 
            this.lblEmailCN.AutoSize = true;
            this.lblEmailCN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmailCN.ForeColor = System.Drawing.Color.Black;
            this.lblEmailCN.Location = new System.Drawing.Point(40, 297);
            this.lblEmailCN.Name = "lblEmailCN";
            this.lblEmailCN.Size = new System.Drawing.Size(117, 23);
            this.lblEmailCN.TabIndex = 4;
            this.lblEmailCN.Text = "Email cá nhân";
            // 
            // txtEmailCT
            // 
            this.txtEmailCT.BorderRadius = 4;
            this.txtEmailCT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailCT.DefaultText = "";
            this.txtEmailCT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmailCT.Location = new System.Drawing.Point(180, 359);
            this.txtEmailCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailCT.Name = "txtEmailCT";
            this.txtEmailCT.PlaceholderText = "";
            this.txtEmailCT.SelectedText = "";
            this.txtEmailCT.Size = new System.Drawing.Size(350, 45);
            this.txtEmailCT.TabIndex = 5;
            // 
            // txtEmailCN
            // 
            this.txtEmailCN.BorderRadius = 4;
            this.txtEmailCN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailCN.DefaultText = "";
            this.txtEmailCN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmailCN.Location = new System.Drawing.Point(180, 287);
            this.txtEmailCN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailCN.Name = "txtEmailCN";
            this.txtEmailCN.PlaceholderText = "";
            this.txtEmailCN.SelectedText = "";
            this.txtEmailCN.Size = new System.Drawing.Size(350, 45);
            this.txtEmailCN.TabIndex = 5;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lblDiaChi.Location = new System.Drawing.Point(600, 369);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(62, 23);
            this.lblDiaChi.TabIndex = 6;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderRadius = 4;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDiaChi.Location = new System.Drawing.Point(750, 359);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(350, 45);
            this.txtDiaChi.TabIndex = 7;
            // 
            // lblMST
            // 
            this.lblMST.AutoSize = true;
            this.lblMST.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMST.ForeColor = System.Drawing.Color.Black;
            this.lblMST.Location = new System.Drawing.Point(600, 75);
            this.lblMST.Name = "lblMST";
            this.lblMST.Size = new System.Drawing.Size(96, 23);
            this.lblMST.TabIndex = 8;
            this.lblMST.Text = "Mã số thuế";
            // 
            // txtMST
            // 
            this.txtMST.BorderRadius = 4;
            this.txtMST.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMST.DefaultText = "";
            this.txtMST.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMST.Location = new System.Drawing.Point(750, 65);
            this.txtMST.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMST.Name = "txtMST";
            this.txtMST.PlaceholderText = "";
            this.txtMST.SelectedText = "";
            this.txtMST.Size = new System.Drawing.Size(350, 45);
            this.txtMST.TabIndex = 9;
            // 
            // lblSTK
            // 
            this.lblSTK.AutoSize = true;
            this.lblSTK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSTK.ForeColor = System.Drawing.Color.Black;
            this.lblSTK.Location = new System.Drawing.Point(600, 150);
            this.lblSTK.Name = "lblSTK";
            this.lblSTK.Size = new System.Drawing.Size(105, 23);
            this.lblSTK.TabIndex = 10;
            this.lblSTK.Text = "Số tài khoản";
            // 
            // txtSTK
            // 
            this.txtSTK.BorderRadius = 4;
            this.txtSTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSTK.DefaultText = "";
            this.txtSTK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSTK.Location = new System.Drawing.Point(750, 140);
            this.txtSTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.PlaceholderText = "";
            this.txtSTK.SelectedText = "";
            this.txtSTK.Size = new System.Drawing.Size(350, 45);
            this.txtSTK.TabIndex = 11;
            // 
            // lblNganHang
            // 
            this.lblNganHang.AutoSize = true;
            this.lblNganHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNganHang.ForeColor = System.Drawing.Color.Black;
            this.lblNganHang.Location = new System.Drawing.Point(600, 225);
            this.lblNganHang.Name = "lblNganHang";
            this.lblNganHang.Size = new System.Drawing.Size(96, 23);
            this.lblNganHang.TabIndex = 12;
            this.lblNganHang.Text = "Ngân hàng";
            // 
            // txtNganHang
            // 
            this.txtNganHang.BorderRadius = 4;
            this.txtNganHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNganHang.DefaultText = "";
            this.txtNganHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNganHang.Location = new System.Drawing.Point(750, 215);
            this.txtNganHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNganHang.Name = "txtNganHang";
            this.txtNganHang.PlaceholderText = "";
            this.txtNganHang.SelectedText = "";
            this.txtNganHang.Size = new System.Drawing.Size(350, 45);
            this.txtNganHang.TabIndex = 13;
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 6;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(1070, 780);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(170, 55);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu hồ sơ";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 6;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHuy.Location = new System.Drawing.Point(870, 780);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(170, 55);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FormSuaNhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 853);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.gbChiTiet);
            this.Controls.Add(this.cboChucDanh);
            this.Controls.Add(this.lblChucDanh);
            this.Controls.Add(this.cboPhongBan);
            this.Controls.Add(this.lblPhongBan);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormSuaNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Nhân Viên";
            this.Load += new System.EventHandler(this.FormSuaNhanVien_Load);
            this.gbChiTiet.ResumeLayout(false);
            this.gbChiTiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaNV;
        public Guna.UI2.WinForms.Guna2TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblHoTen;
        public Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private System.Windows.Forms.Label lblGioiTinh;
        public Guna.UI2.WinForms.Guna2ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblPhongBan;
        public Guna.UI2.WinForms.Guna2ComboBox cboPhongBan;
        private System.Windows.Forms.Label lblChucDanh;
        public Guna.UI2.WinForms.Guna2ComboBox cboChucDanh;

        private Guna.UI2.WinForms.Guna2GroupBox gbChiTiet;
        private System.Windows.Forms.Label lblCCCD;
        public Guna.UI2.WinForms.Guna2TextBox txtCCCD;
        private System.Windows.Forms.Label lblSDT;
        public Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private System.Windows.Forms.Label lblEmailCN;
        public Guna.UI2.WinForms.Guna2TextBox txtEmailCN;
        private System.Windows.Forms.Label lblDiaChi;
        public Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private System.Windows.Forms.Label lblMST;
        public Guna.UI2.WinForms.Guna2TextBox txtMST;
        private System.Windows.Forms.Label lblSTK;
        public Guna.UI2.WinForms.Guna2TextBox txtSTK;
        private System.Windows.Forms.Label lblNganHang;
        public Guna.UI2.WinForms.Guna2TextBox txtNganHang;

        public Guna.UI2.WinForms.Guna2Button btnLuu;
        public Guna.UI2.WinForms.Guna2Button btnHuy;
        private System.Windows.Forms.Label lblEmailCt;
        public Guna.UI2.WinForms.Guna2TextBox txtEmailCT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNgayCap;
        public Guna.UI2.WinForms.Guna2TextBox txtNoiCap;
        public Guna.UI2.WinForms.Guna2DateTimePicker dptNgayCap;
    }
}