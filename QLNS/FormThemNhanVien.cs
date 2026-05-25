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
            // (Ví dụ logic gọi trên Form)
            if (busNV.ThemNhanVien(etNhanVien)) // Lưu bảng NhanVien trước
            {
                // Nếu bảng cha lưu thành công, lưu tiếp bảng con
                if (busCT.ThemChiTietNhanVien(etChiTiet))
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                }
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
