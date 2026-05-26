using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ET;

namespace QLNS
{
    public partial class FormSuaNhanVien : Form
    {
        // 1. Khai báo các lớp BUS
        BUS_NhanVien busNV = new BUS_NhanVien();
        BUS_ChiTietNhanVien busCT = new BUS_ChiTietNhanVien();
        BUS_PhongBan busPhongBan = new BUS_PhongBan();
        BUS_ChucDanh busChucDanh = new BUS_ChucDanh();

        // 2. Biến toàn cục để lưu Mã nhân viên đang cần sửa
        private string maNhanVienCanSua;

        // 3. SỬA HÀM KHỞI TẠO: Thêm tham số truyền vào là maNV
        public FormSuaNhanVien(string maNV)
        {
            InitializeComponent();
            this.maNhanVienCanSua = maNV; // Hứng mã nhân viên từ Form chính truyền qua
        }

        private void FormSuaNhanVien_Load(object sender, EventArgs e)
        {
            // Bước 1: Nạp danh mục cho ComboBox
            LoadCboPhongBan();
            LoadCboChucDanh();

            // Bước 2: Tự động tải dữ liệu của nhân viên lên các ô Textbox
            LoadDuLieuNhanVienCu();
        }

        public void LoadCboPhongBan()
        {
            cboPhongBan.DataSource = busPhongBan.LayDanhSachPhongBan();
            cboPhongBan.DisplayMember = "TenPhongBan";
            cboPhongBan.ValueMember = "MaPhongBan";
        }

        public void LoadCboChucDanh()
        {
            cboChucDanh.DataSource = busChucDanh.LayDanhSachChucDanh();
            cboChucDanh.DisplayMember = "TenChucDanh";
            cboChucDanh.ValueMember = "MaChucDanh";
        }

        private void LoadDuLieuNhanVienCu()
        {
            try
            {
                // A. Tải thông tin hành chính cơ bản
                ET_NhanVien nvCoBan = busNV.LayThongTinCoBan(maNhanVienCanSua);
                if (nvCoBan != null)
                {
                    txtMaNhanVien.Text = nvCoBan.MaNhanVien;
                    txtHoTen.Text = nvCoBan.HoTen;
                    cboGioiTinh.Text = nvCoBan.GioiTinh;
                    dtpNgaySinh.Value = nvCoBan.NgaySinh ?? DateTime.Now;
                    cboPhongBan.SelectedValue = nvCoBan.MaPhongBan;
                    cboChucDanh.SelectedValue = nvCoBan.MaChucDanh;

                    // BẮT BUỘC: Khóa ô Mã Nhân Viên không cho người dùng sửa khóa chính
                    txtMaNhanVien.Enabled = false;
                }

                // B. Tải thông tin hồ sơ chi tiết
                ET_ChiTietNV nvChiTiet = busCT.LayThongTinChiTiet(maNhanVienCanSua);
                if (nvChiTiet != null)
                {
                    txtSDT.Text = nvChiTiet.SoDienThoai;
                    txtCCCD.Text = nvChiTiet.SoCCCD;
                    txtEmailCN.Text = nvChiTiet.EmailCaNhan;
                    txtEmailCT.Text = nvChiTiet.EmailCongTy;
                    txtDiaChi.Text = nvChiTiet.DiaChiThuongTru;
                    txtMST.Text = nvChiTiet.MaSoThue;
                    txtNganHang.Text = nvChiTiet.TenNganHang;
                    txtSTK.Text = nvChiTiet.SoTaiKhoan;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu cũ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi bấm nút Lưu Cập Nhật
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng không để trống Họ tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Đóng gói dữ liệu ET Hành chính
            ET_NhanVien etNhanVien = new ET_NhanVien
            {
                MaNhanVien = txtMaNhanVien.Text.Trim(), // Vẫn lấy từ ô text (dù đã bị khóa mờ)
                HoTen = txtHoTen.Text.Trim(),
                GioiTinh = cboGioiTinh.Text,
                NgaySinh = dtpNgaySinh.Value,
                MaPhongBan = cboPhongBan.SelectedValue?.ToString(),
                MaChucDanh = cboChucDanh.SelectedValue?.ToString(),
                TrangThaiLamViec = "Đang làm việc" // Hoặc lấy từ 1 combobox trạng thái nếu bạn có
            };

            // Đóng gói dữ liệu ET Chi tiết
            ET_ChiTietNV etChiTiet = new ET_ChiTietNV
            {
                MaNhanVien = txtMaNhanVien.Text.Trim(),
                SoDienThoai = txtSDT.Text.Trim(),
                SoCCCD = txtCCCD.Text.Trim(),
                EmailCaNhan = txtEmailCN.Text.Trim(),
                EmailCongTy = txtEmailCT.Text.Trim(),
                DiaChiThuongTru = txtDiaChi.Text.Trim(),
                MaSoThue = txtMST.Text.Trim(),
                TenNganHang = txtNganHang.Text.Trim(),
                SoTaiKhoan = txtSTK.Text.Trim()
            };

            // Gọi BUS để Cập nhật
            if (busNV.SuaNhanVien(etNhanVien)) // Sửa bảng cha trước
            {
                // LƯU Ý: Bạn cần đảm bảo đã viết hàm SuaChiTietNhanVien trong BUS_ChiTietNhanVien
                if (busCT.SuaChiTietNhanVien(etChiTiet)) // Sửa bảng con
                {
                    MessageBox.Show("Cập nhật hồ sơ nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Sửa xong thì tự động đóng Form
                }
                else
                {
                    MessageBox.Show("Cập nhật Hành chính thành công nhưng thông tin Chi tiết bị lỗi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Cập nhật nhân viên thất bại!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi bấm nút Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close(); // Hủy thì chỉ cần đóng form, không cần clear text
        }
    }
}