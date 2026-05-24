using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ChiTietNV
    {
        // fields
        private string maNhanVien;
        private string soDienThoai;
        private string emailCaNhan;
        private string emailCongTy;
        private string diaChiThuongTru;
        private string soCCCD;
        private DateTime? ngayCapCCCD;
        private string noiCapCCCD;
        private string maSoThue;
        private string soTaiKhoan;
        private string tenNganHang;

        private byte[] anhDaiDien;

        // properties
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string EmailCaNhan { get => emailCaNhan; set => emailCaNhan = value; }
        public string EmailCongTy { get => emailCongTy; set => emailCongTy = value; }
        public string DiaChiThuongTru { get => diaChiThuongTru; set => diaChiThuongTru = value; }
        public string SoCCCD { get => soCCCD; set => soCCCD = value; }
        public DateTime? NgayCapCCCD { get => ngayCapCCCD; set => ngayCapCCCD = value; }
        public string NoiCapCCCD { get => noiCapCCCD; set => noiCapCCCD = value; }
        public string MaSoThue { get => maSoThue; set => maSoThue = value; }
        public string SoTaiKhoan { get => soTaiKhoan; set => soTaiKhoan = value; }
        public string TenNganHang { get => tenNganHang; set => tenNganHang = value; }

        public byte[] AnhDaiDien { get => anhDaiDien; set => anhDaiDien = value; }

        public ET_ChiTietNV() { }

        public ET_ChiTietNV(string maNhanVien, string soDienThoai, string emailCaNhan, string emailCongTy, string diaChiThuongTru, string soCCCD, DateTime? ngayCapCCCD, string noiCapCCCD, string maSoThue, string soTaiKhoan, string tenNganHang, byte[] anhDaiDien)
        {
            this.MaNhanVien = maNhanVien;
            this.SoDienThoai = soDienThoai;
            this.EmailCaNhan = emailCaNhan;
            this.EmailCongTy = emailCongTy;
            this.DiaChiThuongTru = diaChiThuongTru;
            this.SoCCCD = soCCCD;
            this.NgayCapCCCD = ngayCapCCCD; 
            this.NoiCapCCCD = noiCapCCCD;
            this.MaSoThue = maSoThue;
            this.SoTaiKhoan = soTaiKhoan;
            this.TenNganHang = tenNganHang;

            // Gán giá trị cho ảnh
            this.AnhDaiDien = anhDaiDien;
        }
    }
}