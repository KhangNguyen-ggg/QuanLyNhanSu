using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using DAL;
namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dAL_NhanVien = new DAL_NhanVien();

        //lấy ds
        public List<ET_NhanVienView> LayDanhSachLenGrid()
        {
            var data = dAL_NhanVien.LayDanhSachLenGrid();
            return data.ToList();
        }

        public List<ET_NhanVienView> TimKiemNhanVien(string tuKhoa, string maPhongBan, bool isTimTheoPB)
        {
            return dAL_NhanVien.TimKiemNhanVien(tuKhoa, maPhongBan, isTimTheoPB);
        }

        // ĐỔI KIỂU TRẢ VỀ TỪ List<ET_NhanVien> THÀNH ET_NhanVien
        public ET_NhanVien LayThongTinCoBan(string maNV)
        {
            var data = dAL_NhanVien.LayThongTinCoBan();

            // Thay vì ToList(), ta dùng FirstOrDefault() để lấy ra 1 người duy nhất
            var result = data.Where(nv => nv.MaNhanVien == maNV)
                             .Select(nv => new ET_NhanVien
                             {
                                 MaNhanVien = nv.MaNhanVien,
                                 HoTen = nv.HoTen,
                                 GioiTinh = nv.GioiTinh,
                                 NgaySinh = nv.NgaySinh.GetValueOrDefault(),
                                 MaPhongBan = nv.MaPhongBan,
                                 MaChucDanh = nv.MaChucDanh,
                                 TrangThaiLamViec = nv.TrangThaiLamViec
                             }).FirstOrDefault(); // SỬA Ở ĐÂY

            return result;
        }

        //thêm
        public bool ThemNhanVien(ET_NhanVien nv)
        {
            return dAL_NhanVien.ThemNhanVien(nv);
        }
        //xóa
        public bool XoaNhanVien(string maNV)
        {
            return dAL_NhanVien.XoaNhanVien(maNV);
        }
        //sửa
        public bool SuaNhanVien(ET_NhanVien nv)
        {
            return dAL_NhanVien.SuaNhanVien(nv);


        }
    }
}
