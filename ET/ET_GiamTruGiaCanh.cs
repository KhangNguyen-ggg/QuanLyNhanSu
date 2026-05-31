using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_GiamTruGiaCanh
    {
        private string maGiamTru;
        private string maNhanVien;
        private string hoTenNguoiPhuThuoc;
        private string quanHe;
        private string maSoThue;
        private DateTime? ngayBatDau;
        private DateTime? ngayKetThuc;

        public string MaGiamTru { get => maGiamTru; set => maGiamTru = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HoTenNguoiPhuThuoc { get => hoTenNguoiPhuThuoc; set => hoTenNguoiPhuThuoc = value; }
        public string QuanHe { get => quanHe; set => quanHe = value; }
        public string MaSoThue { get => maSoThue; set => maSoThue = value; }
        public DateTime? NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime? NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }


        public ET_GiamTruGiaCanh() { }
        public ET_GiamTruGiaCanh(string maGiamTru, string maNhanVien, string hoTenNguoiPhuThuoc, string quanHe, string maSoThue, DateTime? ngayBatDau, DateTime? ngayKetThuc)
        {
            this.maGiamTru = maGiamTru;
            this.maNhanVien = maNhanVien;
            this.hoTenNguoiPhuThuoc = hoTenNguoiPhuThuoc;
            this.quanHe = quanHe;
            this.maSoThue = maSoThue;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
        }
    }
}
