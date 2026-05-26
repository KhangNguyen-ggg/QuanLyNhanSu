using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class FormXoaNhanVien : Form
    {
        public FormXoaNhanVien()
        {
            InitializeComponent();
        }
        BUS_NhanVien busNhanVien = new BUS_NhanVien();

        private void FromXoaNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        //load nhân viên lên dgv
        public void LoadNhanVien()
        {
            try
            {
                dgvNhanVien.DataSource = busNhanVien.LayDanhSachLenGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtMaNV.Text.Trim();
            bool isTimTheoPB = false;
            string maPhongBan = "";

            if (string.IsNullOrEmpty(tuKhoa) && !isTimTheoPB)
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm hoặc tích chọn Phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                // Chặn toàn bộ ký tự đặc biệt độc hại độc quyền bằng Regex chữ Việt, chữ số, dấu cách
                if (Regex.IsMatch(tuKhoa, @"[^a-zA-Z0-9\s\p{L}]"))
                {
                    MessageBox.Show("Từ khóa không được chứa ký tự đặc biệt!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaNV.Focus();
                    return;
                }
            }

            var ketQua = busNhanVien.TimKiemNhanVien(tuKhoa, maPhongBan, isTimTheoPB);
            dgvNhanVien.DataSource = ketQua;

            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả nào phù hợp!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                busNhanVien.XoaNhanVien(txtMaNV.Text.Trim());
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            LoadNhanVien();

        }
    }
}
