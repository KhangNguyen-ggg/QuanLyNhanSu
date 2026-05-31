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
            txtMaNhanVien2.Text = currentMaNV; 

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


        private void btnLuuBaoHiem_Click(object sender, EventArgs e)
        {
                
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
            // (Sau này bạn thêm các else if cho pageGiaCanh, pageDaoTao... vào đây)
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
                // Tầng BUS của bạn đang trả về List, ta dùng FirstOrDefault để lấy ra người duy nhất
                var dsBaoHiem = busBaoHiem.LayThongTinBaoHiem(maNV);
                var baoHiemInfo = dsBaoHiem.FirstOrDefault();

                if (baoHiemInfo != null)
                {
                    // NẾU ĐÃ CÓ BẢO HIỂM: Đổ dữ liệu lên UI
                    txtSoSoBHXH.Text = baoHiemInfo.SoSoBHXH;
                    dtpNgayThamGia.Value = baoHiemInfo.NgayThamGia ?? DateTime.Now;
                    txtNoiDK.Text = baoHiemInfo.NoiDangKyKhamBenh;
                    txtMucDong.Text = baoHiemInfo.MucDong?.ToString("N0") ?? ""; // Format hiển thị số tiền có dấu phẩy
                    cboTrangThaiBH.Text = baoHiemInfo.TrangThai;
                }
                else
                {
                    // NẾU CHƯA CÓ: Làm sạch giao diện để chuẩn bị thêm mới
                    txtSoSoBHXH.Clear();
                    dtpNgayThamGia.Value = DateTime.Now;
                    txtNoiDK.Clear();
                    txtMucDong.Clear();
                    cboTrangThaiBH.Text = "Chưa tham gia"; // Trạng thái mặc định thực tế
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

        private void btnLuuBaoHiem_Click_1(object sender, EventArgs e)
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

    }
}