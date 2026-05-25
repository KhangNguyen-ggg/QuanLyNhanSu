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

        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            LoadComboBoxPhongBan();
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
            string maNV = txtMaNhanVien2.Text.Trim();
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

            try
            {
                string maNV = dgvNhanVien1.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();

                // 1. TẢI THÔNG TIN CƠ BẢN
                var nvCoBan = busNhanVien.LayThongTinCoBan(maNV);
                if (nvCoBan != null)
                {
                    txtMaNhanVien2.Text = nvCoBan.MaNhanVien;
                    txtHoTen.Text = nvCoBan.HoTen;
                    txtGioiTinh.Text = nvCoBan.GioiTinh;
                    txtPhongBan.Text = nvCoBan.MaPhongBan;
                    txtChucDanh.Text = nvCoBan.MaChucDanh;

                    if (nvCoBan.NgaySinh.HasValue)
                        dtpNgaySinh.Value = nvCoBan.NgaySinh.Value;
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

                    // Gán trực tiếp ô đặc thù trên form của bạn
                    txtMaSoThue.Text = nvChiTiet.MaSoThue;
                    txtSoTK.Text = nvChiTiet.SoTaiKhoan;

                    if (nvChiTiet.NgayCapCCCD.HasValue)
                        dtpNgayCapCCCD.Value = nvChiTiet.NgayCapCCCD.Value;

                    // Giải mã mảng byte[] đổ ngược lại vào PictureBox hiển thị lên giao diện
                    if (nvChiTiet.AnhDaiDien != null)
                    {
                        using (MemoryStream ms = new MemoryStream(nvChiTiet.AnhDaiDien))
                        {
                            picAvatar.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picAvatar.Image = null;
                    }
                }
                else
                {
                    // Xóa trắng dữ liệu vùng chi tiết khi nhân viên chưa có hồ sơ
                    txtSoDienThoai.Clear();
                    txtDiaChi.Clear();
                    txtEmailCaNhan.Clear();
                    txtEmailCongTy.Clear();
                    txtCCCD.Clear();
                    txtNoiCapCCCD.Clear();
                    txtTenNganHang.Clear();
                    txtMaSoThue.Clear();
                    txtSoTK.Clear();
                    txtMaSoThue.Clear();
                    txtSoTK.Clear();
                    picAvatar.Image = null;
                    dtpNgayCapCCCD.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị dữ liệu dòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}