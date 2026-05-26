using BUS;
using System;
using ET;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class FormThemNhanVien : Form
    {
        public FormThemNhanVien()
        {
            InitializeComponent();
        }

        BUS_NhanVien busNV = new BUS_NhanVien();
        BUS_ChiTietNhanVien busCT = new BUS_ChiTietNhanVien();
        BUS_PhongBan busPhongBan = new BUS_PhongBan();
        BUS_ChucDanh busChucDanh = new BUS_ChucDanh();


        ET_NhanVien etNhanVien = new ET_NhanVien();
        ET_ChiTietNV etChiTiet = new ET_ChiTietNV();


        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            LoadCboPhongBan();
            LoadCboChucDanh();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu bắt buộc (Tránh lỗi vặt khi người dùng để trống)
            if (string.IsNullOrWhiteSpace(txtMaNhanVien.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã nhân viên và Họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return;
            }

            // 2. Gom dữ liệu Hành chính vào đối tượng ET_NhanVien
            
            etNhanVien.MaNhanVien = txtMaNhanVien.Text.Trim();
            etNhanVien.HoTen = txtHoTen.Text.Trim();
            etNhanVien.GioiTinh = cboGioiTinh.Text;
            etNhanVien.NgaySinh = dtpNgaySinh.Value;
            etNhanVien.MaPhongBan = cboPhongBan.SelectedValue?.ToString();
            etNhanVien.MaChucDanh = cboChucDanh.SelectedValue?.ToString();
            etNhanVien.TrangThaiLamViec = "Đang làm việc"; // Giá trị mặc định khi mới vào công ty

            // 3. Gom dữ liệu Hồ sơ vào đối tượng ET_ChiTietNV
            etChiTiet.MaNhanVien = txtMaNhanVien.Text.Trim(); // Bắt buộc phải giống mã NV ở trên để kết nối 2 bảng
            etChiTiet.SoDienThoai = txtSDT.Text.Trim();
            etChiTiet.SoCCCD = txtCCCD.Text.Trim();
            etChiTiet.EmailCaNhan = txtEmailCN.Text.Trim();
            etChiTiet.EmailCongTy = txtEmailCT.Text.Trim();
            etChiTiet.DiaChiThuongTru = txtDiaChi.Text.Trim();
            etChiTiet.MaSoThue = txtMST.Text.Trim();
            etChiTiet.TenNganHang = txtNganHang.Text.Trim();
            etChiTiet.SoTaiKhoan = txtSTK.Text.Trim();

            // (Nếu trên form có thêm 2 ô Ngày cấp, Nơi cấp CCCD thì bạn gán luôn ở đây)
            // etChiTiet.NgayCapCCCD = dtpNgayCapCCCD.Value;
            // etChiTiet.NoiCapCCCD = txtNoiCapCCCD.Text.Trim();

            // 4. Đẩy xuống tầng BUS xử lý theo đúng quy trình 2 bước
            if (busNV.ThemNhanVien(etNhanVien)) // Lưu bảng NhanVien trước
            {
                if (busCT.ThemChiTietNhanVien(etChiTiet)) // Nếu bảng cha lưu thành công, lưu tiếp bảng con
                {
                    MessageBox.Show("Thêm nhân viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form lại sau khi thêm xong
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thành công nhưng LƯU CHI TIẾT THẤT BẠI!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại! Có thể Mã nhân viên đã tồn tại.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ////nhân viên
            //txtMaNhanVien.Text = "";
            //txtHoTen.Text = "";
            //dtpNgaySinh.Value = DateTime.Now;
            //cboPhongBan.SelectedIndex = -1; 
            //cboChucDanh.SelectedIndex = -1;
            //cboGioiTinh.SelectedIndex = -1;

            ////chi tiết 
            //txtSDT.Text = "";
            //txtCCCD.Text = "";
            //txtEmailCN.Text = "";
            //txtEmailCT.Text = "";   
            //txtDiaChi.Text = "";
            //txtMST.Text = "";
            //txtNganHang.Text = "";
            //txtSTK.Text = "";
            this.Close();

        }
        //load cbo
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
    }
}
