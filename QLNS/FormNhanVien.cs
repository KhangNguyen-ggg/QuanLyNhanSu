using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using BUS;
using ET;

namespace QLNS
{
    public partial class FormNhanVien : Form
    {
        private BUS_NhanVien busNhanVien = new BUS_NhanVien();
        private BUS_ChiTietNhanVien busChiTietNhanVien = new BUS_ChiTietNhanVien();
        private BUS_PhongBan busPhongBan = new BUS_PhongBan();
        private BUS_ChucDanh busChucDanh = new BUS_ChucDanh();
        private BUS_BaoHiem busBaoHiem = new BUS_BaoHiem();
        private BUS_GiamTruGiaCanh busGiamTru = new BUS_GiamTruGiaCanh();
        private BUS_TaiSanCapPhat busTaiSanCapPhat = new BUS_TaiSanCapPhat();
        private string currentMaNV = "";

        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataForCurrentTab();
            LoadComboBoxPhongBan();
            LoadComboBoxTrangThaiBH();
            LoadNhanVien();
            LoadComboBoxChucDanh();

        }

        public void LoadNhanVien()
        {
            try
            {
                dgvNhanVien1.DataSource = busNhanVien.LayDanhSachLenGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadComboBoxPhongBan()
        {
            cboPhongBan.DataSource = busPhongBan.LayDanhSachPhongBan();
            cboPhongBan.DisplayMember = "TenPhongBan";
            cboPhongBan.ValueMember = "MaPhongBan";
        }

        public void LoadComboBoxChucDanh()
        {
            cboChucDanh.DataSource = busChucDanh.LayDanhSachChucDanh();
            cboChucDanh.DisplayMember = "TenChucDanh";
            cboChucDanh.ValueMember = "MaChucDanh";
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                openFile.Title = "Chọn ảnh đại diện nhân viên";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    picAvatar.Image = Image.FromFile(openFile.FileName);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text.Trim();
            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng chọn nhân viên từ bảng trước khi lưu ảnh!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                byte[] imgBytes = null;
                if (picAvatar.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        // Khắc phục triệt để lỗi Generic GDI+ bằng cách ép định dạng Jpeg khi lưu vào bộ nhớ tạm
                        picAvatar.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imgBytes = ms.ToArray();
                    }
                }

                if (busChiTietNhanVien.CapNhatHinhAnh(maNV, imgBytes))
                {
                    MessageBox.Show("Lưu ảnh đại diện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nhân viên này chưa có hồ sơ chi tiết để lưu ảnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu ảnh: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            bool isTimTheoPB = chkChonPB.Checked;
            string maPhongBan = cboPhongBan.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(tuKhoa) && !isTimTheoPB)
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm hoặc tích chọn Phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTimKiem.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                // Chặn toàn bộ ký tự đặc biệt độc hại độc quyền bằng Regex chữ Việt, chữ số, dấu cách
                if (Regex.IsMatch(tuKhoa, @"[^a-zA-Z0-9\s\p{L}]"))
                {
                    MessageBox.Show("Từ khóa không được chứa ký tự đặc biệt!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTimKiem.Focus();
                    return;
                }
            }

            var ketQua = busNhanVien.TimKiemNhanVien(tuKhoa, maPhongBan, isTimTheoPB);
            dgvNhanVien1.DataSource = ketQua;

            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả nào phù hợp!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvNhanVien1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Chỉ lưu lại mã nhân viên đang click
            currentMaNV = dgvNhanVien1.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();

            // Gọi hàm tổng để tự động load đúng cái tab đang hiển thị
            LoadDataForCurrentTab();
        }

        private void chkChonPB_CheckedChanged(object sender, EventArgs e)
        {
            cboPhongBan.Enabled = chkChonPB.Checked;
        }

        private void pageChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                FormThemNhanVien formThem = new FormThemNhanVien();
                formThem.ShowDialog();
                LoadNhanVien();

            }
            catch (Exception ex)
            {
            }

        }

        private void gbChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                FormXoaNhanVien formXoa = new FormXoaNhanVien();
                formXoa.ShowDialog();
                LoadNhanVien();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien1.CurrentRow != null)
            {
                string maNV = dgvNhanVien1.CurrentRow.Cells["MaNhanVien"].Value.ToString();

                // Gọi Form Sửa và truyền mã vào
                FormSuaNhanVien frmSua = new FormSuaNhanVien(maNV);
                frmSua.ShowDialog();

                LoadNhanVien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên để sửa!");
            }
        }

        private void btnHuyBaoHiem_Click(object sender, EventArgs e)
        {
            //chuyển sang page chi tiết
            tabRight.SelectedTab = pageChiTiet;
        }

        // --- HÀM TỔNG QUẢN: KIỂM TRA ĐANG Ở TAB NÀO THÌ LOAD TAB ĐÓ ---
        private void LoadDataForCurrentTab()
        {
            // Nếu chưa click chọn ai thì không làm gì cả
            if (string.IsNullOrEmpty(currentMaNV)) return;

            // Kiểm tra Tab nào đang hiển thị trên màn hình
            if (tabRight.SelectedTab == pageChiTiet)
            {
                LoadTabChiTiet(currentMaNV);
            }
            else if (tabRight.SelectedTab == pageBaoHiem)
            {
                LoadTabBaoHiem(currentMaNV);
            }
            else if (tabRight.SelectedTab == pageGiamTruGC)
            {
                LoadTabGiamTru();
            }
            else if (tabRight.SelectedTab == pageTaiSan)
            {
                LoadTabTaiSan(currentMaNV);
            }

        }

        // --- HÀM LOAD TAB CHI TIẾT 
        private void LoadTabChiTiet(string maNV)
        {
            try
            {
                // 1. TẢI THÔNG TIN CƠ BẢN
                var nvCoBan = busNhanVien.LayThongTinCoBan(maNV);
                if (nvCoBan != null)
                {
                    txtMaNhanVien.Text = nvCoBan.MaNhanVien;
                    txtHoTen.Text = nvCoBan.HoTen;
                    txtGioiTinh.Text = nvCoBan.GioiTinh;
                    txtPhongBan.Text = nvCoBan.MaPhongBan;
                    cboChucDanh.SelectedValue = nvCoBan.MaChucDanh;

                    if (nvCoBan.NgaySinh.HasValue)// Phòng trường hợp ngày sinh bị null để tránh lỗi
                        dtpNgaySinh.Value = nvCoBan.NgaySinh.Value;
                }
                else
                {
                    MessageBox.Show("");
                }

                // 2. TẢI HỒ SƠ CHI TIẾT VÀ ẢNH ĐẠI DIỆN
                var nvChiTiet = busChiTietNhanVien.LayThongTinChiTiet(maNV);
                if (nvChiTiet != null)
                {
                    txtSoDienThoai.Text = nvChiTiet.SoDienThoai;
                    txtDiaChi.Text = nvChiTiet.DiaChiThuongTru;
                    txtEmailCaNhan.Text = nvChiTiet.EmailCaNhan;
                    txtEmailCongTy.Text = nvChiTiet.EmailCongTy;
                    txtCCCD.Text = nvChiTiet.SoCCCD;
                    txtNoiCapCCCD.Text = nvChiTiet.NoiCapCCCD;
                    txtTenNganHang.Text = nvChiTiet.TenNganHang;
                    txtMaSoThue.Text = nvChiTiet.MaSoThue;
                    txtSoTK.Text = nvChiTiet.SoTaiKhoan;

                    if (nvChiTiet.NgayCapCCCD.HasValue)
                        dtpNgayCapCCCD.Value = nvChiTiet.NgayCapCCCD.Value;

                    if (nvChiTiet.AnhDaiDien != null)
                    {
                        using (MemoryStream ms = new MemoryStream(nvChiTiet.AnhDaiDien))
                        {
                            picAvatar.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picAvatar.Image = null; // Cập nhật hình mặc định nếu cần
                    }
                }
                else
                {
                    // Xóa trắng các ô TextBox nếu chưa có chi tiết 
                    {
                        txtSoDienThoai.Clear();
                        txtDiaChi.Clear();
                        txtEmailCaNhan.Clear();
                        txtEmailCongTy.Clear();
                        txtCCCD.Clear();
                        txtNoiCapCCCD.Clear();
                        txtTenNganHang.Clear();
                        txtMaSoThue.Clear();
                        txtSoTK.Clear();
                        picAvatar.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chi tiết: " + ex.Message);
            }
        }

        // --- HÀM LOAD TAB BẢO HIỂM ---
        private void LoadTabBaoHiem(string maNV)
        {
            try
            {
                var dsBaoHiem = busBaoHiem.LayThongTinBaoHiem(maNV);

                // Phải kiểm tra Count > 0 để chắc chắn danh sách không bị rỗng
                if (dsBaoHiem != null && dsBaoHiem.Count > 0)
                {
                    var baoHiemInfo = dsBaoHiem[0];
                    txtSoSoBHXH.Text = baoHiemInfo.SoSoBHXH;
                    dtpNgayThamGia.Value = baoHiemInfo.NgayThamGia ?? DateTime.Now;
                    txtNoiDK.Text = baoHiemInfo.NoiDangKyKhamBenh;
                    txtMucDong.Text = baoHiemInfo.MucDong?.ToString("N0") ?? "";
                    cboTrangThaiBH.Text = baoHiemInfo.TrangThai;
                }
                else
                {
                    // NẾU CHƯA CÓ: Làm sạch giao diện
                    txtSoSoBHXH.Clear();
                    dtpNgayThamGia.Value = DateTime.Now;
                    txtNoiDK.Clear();
                    txtMucDong.Clear();
                    cboTrangThaiBH.Text = "Chưa tham gia";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị bảo hiểm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataForCurrentTab();
        }

        private void btnLuuBaoHiem_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã click chọn nhân viên nào trên lưới chưa
            if (string.IsNullOrEmpty(currentMaNV))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên từ danh sách bên trái trước khi lưu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Ép kiểu Mức đóng an toàn (Loại bỏ dấu phẩy do format "N0" tạo ra)
                decimal mucDongAnToan = 0;
                decimal.TryParse(txtMucDong.Text.Replace(",", "").Replace(".", ""), out mucDongAnToan);

                // 3. Đóng gói dữ liệu
                ET_BaoHiem BaoHiem = new ET_BaoHiem
                {
                    MaNhanVien = currentMaNV,
                    SoSoBHXH = txtSoSoBHXH.Text.Trim(),
                    NgayThamGia = dtpNgayThamGia.Value,
                    NoiDangKyKhamBenh = txtNoiDK.Text.Trim(),
                    MucDong = mucDongAnToan,
                    TrangThai = cboTrangThaiBH.Text //Cbo đang gắn cứng
                };

                // 4. Lưu xuống DB
                if (busBaoHiem.CapNhatBaoHiem(BaoHiem))
                {
                    MessageBox.Show("Cập nhật hồ sơ bảo hiểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại. Vui lòng kiểm tra lại thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật bảo hiểm: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Đưa danh sách các trạng thái chuẩn vào ComboBox
        private void LoadComboBoxTrangThaiBH()
        {
            cboTrangThaiBH.Items.Clear();
            cboTrangThaiBH.Items.Add("Chưa tham gia");
            cboTrangThaiBH.Items.Add("Đang tham gia");
            cboTrangThaiBH.Items.Add("Báo giảm (Tạm dừng)");
            cboTrangThaiBH.Items.Add("Đã chốt sổ");

            // Chọn sẵn "Chưa tham gia" làm giá trị mặc định cho người mới
            cboTrangThaiBH.SelectedIndex = 0;

        }

        //giảm trừ gia cảnh
        //load 
        private void LoadTabGiamTru()
        {
            try
            {
                var giamTruInfo = busGiamTru.LayDsTheoMa(currentMaNV);
                dgvGiamTru.DataSource = giamTruInfo;

                // 3. Kiểm tra: Nếu danh sách có dữ liệu (lớn hơn 0 người)
                if (giamTruInfo.Count > 0)
                {
                    var nguoiDauTien = giamTruInfo[0];

                    txtMaNVGiamTru.Text = nguoiDauTien.MaNhanVien;
                    txtMaGT.Text = nguoiDauTien.MaGiamTru;
                    txtHoTenNPT.Text = nguoiDauTien.HoTenNguoiPhuThuoc;
                    cboQuanHe.Text = nguoiDauTien.QuanHe;
                    txtMaSoThueNPT.Text = nguoiDauTien.MaSoThue;
                    dtpNgayBatDauGT.Value = nguoiDauTien.NgayBatDau ?? DateTime.Now;

                    // Xử lý CheckBox và Ngày kết thúc
                    if (nguoiDauTien.NgayKetThuc.HasValue)
                    {
                        dtpNgayKetThucGT.Value = nguoiDauTien.NgayKetThuc.Value;
                    }
                    else
                    {
                        dtpNgayKetThucGT.Value = DateTime.Now;
                    }

                }
                else
                {
                    txtMaGT.Clear();
                    txtHoTenNPT.Clear();
                    cboQuanHe.SelectedIndex = -1;
                    txtMaSoThueNPT.Clear();
                    dtpNgayBatDauGT.Value = DateTime.Now;
                    dtpNgayKetThucGT.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi tải thông tin gia cảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyGiamTru_Click(object sender, EventArgs e)
        {
            //chuyển sang page chi tiết
            tabRight.SelectedTab = pageChiTiet;
        }

        private void btnThemGiamTru_Click(object sender, EventArgs e)
        {
            // 1. Validate: Kiểm tra đã chọn Nhân viên và nhập đủ Tên chưa
            if (string.IsNullOrEmpty(currentMaNV))
            {
                MessageBox.Show("Vui lòng chọn nhân viên ở danh sách bên trái!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHoTenNPT.Text) || string.IsNullOrWhiteSpace(cboQuanHe.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Quan hệ người phụ thuộc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenNPT.Focus();
                return;
            }

            try
            {
                // Tự động sinh mã tránh trùng lặp tuyệt đối (VD: GT2605311530)
                string maTuDong = "GT" + DateTime.Now.ToString("yyMMddHHmmss");

                ET_GiamTruGiaCanh gc = new ET_GiamTruGiaCanh
                {
                    MaGiamTru = maTuDong,
                    MaNhanVien = currentMaNV,
                    HoTenNguoiPhuThuoc = txtHoTenNPT.Text.Trim(),
                    QuanHe = cboQuanHe.Text,
                    MaSoThue = txtMaSoThueNPT.Text.Trim(),
                    NgayBatDau = dtpNgayBatDauGT.Value,
                    NgayKetThuc = dtpNgayKetThucGT.Value
                };

                if (busGiamTru.ThemGiamTru(gc))
                {
                    MessageBox.Show("Thêm người phụ thuộc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTabGiamTru();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLuuGiamTru_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaGT.Text))
            {
                MessageBox.Show("Vui lòng click chọn một người phụ thuộc trên lưới để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ET_GiamTruGiaCanh gc = new ET_GiamTruGiaCanh
                {
                    MaGiamTru = txtMaGT.Text.Trim(),
                    MaNhanVien = currentMaNV,
                    HoTenNguoiPhuThuoc = txtHoTenNPT.Text.Trim(),
                    QuanHe = cboQuanHe.Text,
                    MaSoThue = txtMaSoThueNPT.Text.Trim(),
                    NgayBatDau = dtpNgayBatDauGT.Value,
                    NgayKetThuc = dtpNgayKetThucGT.Value
                };

                if (busGiamTru.SuaGiamTru(gc))
                {
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTabGiamTru();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnXoaGiamTru_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaGT.Text))
            {
                MessageBox.Show("Vui lòng click chọn một người phụ thuộc trên lưới để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận trước khi xóa
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa người phụ thuộc '{txtHoTenNPT.Text}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (busGiamTru.XoaGiamTru(txtMaGT.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTabGiamTru();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dgvGiamTru_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvGiamTru.Rows[e.RowIndex];

                // Dùng dấu ? (Null-conditional) để tránh văng phần mềm nếu ô đó trong CSDL bị rỗng
                txtMaGT.Text = row.Cells["MaGiamTru"].Value?.ToString() ?? "";
                txtHoTenNPT.Text = row.Cells["HoTenNguoiPhuThuoc"].Value?.ToString() ?? "";
                cboQuanHe.Text = row.Cells["QuanHe"].Value?.ToString() ?? "";
                txtMaSoThueNPT.Text = row.Cells["MaSoThue"].Value?.ToString() ?? "";

                if (row.Cells["NgayBatDau"].Value != null)
                {
                    dtpNgayBatDauGT.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value);
                }

                if (row.Cells["NgayKetThuc"].Value != null)
                {
                    dtpNgayKetThucGT.Value = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value);
                }
                else
                {
                    dtpNgayKetThucGT.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị chi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //========================= TAB TÀI SẢN CẤP PHÁT =========================
        private void LoadTabTaiSan(string maNV)
        {
            try
            {
                var dsTaiSan = busTaiSanCapPhat.LayDsTheoMa(maNV);
                dgvTaiSan.DataSource = dsTaiSan;

                if (dsTaiSan != null && dsTaiSan.Count > 0)
                {
                    var ts = dsTaiSan[0];
                    txtMaCapPhat.Text = ts.MaCapPhat;
                    txtMaNVCapPhat.Text = ts.MaNhanVien;
                    cboLoai.Text = ts.LoaiTaiSan;
                    txtSoSeri.Text = ts.SoSeri;
                    dtpNgayCapPhat.Value = ts.NgayCapPhat ?? DateTime.Now;
                    txtTinhTrangCapPhat.Text = ts.TinhTrang;
                }
                else
                {
                    txtMaCapPhat.Clear();
                    txtMaNVCapPhat.Clear();
                    cboLoai.SelectedIndex = -1;
                    txtSoSeri.Clear();
                    dtpNgayCapPhat.Value = DateTime.Now;
                    txtTinhTrangCapPhat.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải tài sản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTaiSan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bỏ qua nếu click nhầm vào tiêu đề cột
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvTaiSan.Rows[e.RowIndex];

                // Đổ dữ liệu an toàn bằng toán tử ? để chống lỗi Null
                txtMaCapPhat.Text = row.Cells["MaCapPhat"].Value?.ToString() ?? "";
                txtMaNVCapPhat.Text = row.Cells["MaNhanVien"].Value?.ToString() ?? "";
                cboLoai.Text = row.Cells["LoaiTaiSan"].Value?.ToString() ?? "";
                txtSoSeri.Text = row.Cells["SoSeri"].Value?.ToString() ?? "";
                txtTinhTrangCapPhat.Text = row.Cells["TinhTrang"].Value?.ToString() ?? "";

                // Xử lý ngày cấp phát
                if (row.Cells["NgayCapPhat"].Value != null)
                {
                    dtpNgayCapPhat.Value = Convert.ToDateTime(row.Cells["NgayCapPhat"].Value);
                }
                else
                {
                    dtpNgayCapPhat.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị chi tiết tài sản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemCP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentMaNV))
            {
                MessageBox.Show("Vui lòng chọn nhân viên ở danh sách bên trái!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cboLoai.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Loại tài sản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoai.Focus();
                return;
            }

            try
            {
                // Tự động sinh mã tài sản không bao giờ trùng (VD: TS260531102030)
                string maTuDong = "TS" + DateTime.Now.ToString("yyMMddHHmmss");

                ET_TaiSanCapPhat ts = new ET_TaiSanCapPhat
                {
                    MaCapPhat = maTuDong,
                    MaNhanVien = currentMaNV,
                    LoaiTaiSan = cboLoai.Text.Trim(),
                    SoSeri = txtSoSeri.Text.Trim(),
                    NgayCapPhat = dtpNgayCapPhat.Value,
                    TinhTrang = txtTinhTrangCapPhat.Text.Trim()
                };

                if (busTaiSanCapPhat.ThemTaiSan(ts))
                {
                    MessageBox.Show("Cấp phát tài sản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTabTaiSan(currentMaNV); // Load lại lưới ngay lập tức
                }
                else
                {
                    MessageBox.Show("Thêm thất bại. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuCP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaCapPhat.Text))
            {
                MessageBox.Show("Vui lòng click chọn một tài sản trên lưới để cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ET_TaiSanCapPhat ts = new ET_TaiSanCapPhat
                {
                    MaCapPhat = txtMaCapPhat.Text.Trim(), // Lấy mã hiện tại để SQL biết cập nhật dòng nào
                    MaNhanVien = currentMaNV,
                    LoaiTaiSan = cboLoai.Text.Trim(),
                    SoSeri = txtSoSeri.Text.Trim(),
                    NgayCapPhat = dtpNgayCapPhat.Value,
                    TinhTrang = txtTinhTrangCapPhat.Text.Trim()
                };

                if (busTaiSanCapPhat.SuaTaiSan(ts))
                {
                    MessageBox.Show("Cập nhật tài sản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTabTaiSan(currentMaNV);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaCp_Click(object sender, EventArgs e)
        {
            string maCapPhat = txtMaCapPhat.Text.Trim();
            if (string.IsNullOrEmpty(maCapPhat))
            {
                MessageBox.Show("Vui lòng click chọn một tài sản trên lưới để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài sản '{cboLoai.Text}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (busTaiSanCapPhat.XoaTaiSan(maCapPhat))
                    {
                        MessageBox.Show("Thu hồi / Xóa tài sản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTabTaiSan(currentMaNV);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuyCP_Click(object sender, EventArgs e)
        {
            tabRight.SelectedTab = pageChiTiet;
        }
    }

}
