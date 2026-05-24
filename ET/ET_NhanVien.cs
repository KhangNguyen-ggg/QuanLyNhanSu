using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_NhanVien
    {
        
        //field
        private string maNhanVien;
        private string hoTen;
        private string gioiTinh;
        private DateTime? ngaySinh;
        private string maPhongBan;
        private string maChucDanh;
        private string trangThaiLamViec;

        //contructor
        public ET_NhanVien(string maNhanVien, string hoTen, string gioiTinh, DateTime ngaySinh, string maPhongBan, string maChucDanh, string trangThaiLamViec)
        {
            this.maNhanVien = maNhanVien;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.maPhongBan = maPhongBan;
            this.maChucDanh = maChucDanh;
            this.trangThaiLamViec = trangThaiLamViec;
        }

        public ET_NhanVien()
        {
        }

        //properties
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime? NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string MaPhongBan { get => maPhongBan; set => maPhongBan = value; }
        public string MaChucDanh { get => maChucDanh; set => maChucDanh = value; }
        public string TrangThaiLamViec { get => trangThaiLamViec; set => trangThaiLamViec = value; }

    }
}
