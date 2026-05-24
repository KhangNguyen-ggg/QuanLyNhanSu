using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietNhanVien
    {
        QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext();

        // Lấy chi tiết nhân viên theo Mã NV
        public IQueryable LayChiTietNhanVien(string maNV)
        {
            var chiTiet = from ct in db.ChiTietNhanViens
                          where ct.MaNhanVien == maNV
                          select new
                          {
                              ct.MaNhanVien,
                              ct.SoDienThoai,
                              ct.EmailCaNhan,
                              ct.EmailCongTy,
                              ct.DiaChiThuongTru,
                              ct.SoCCCD,
                              ct.NgayCapCCCD,
                              ct.NoiCapCCCD,
                              ct.MaSoThue,
                              ct.SoTaiKhoan,
                              ct.TenNganHang
                          };
            return chiTiet;
        }

        // Xóa chữ List<>
        public ET_ChiTietNV LayThongTinChiTiet(string maNV)
        {
            using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
            {
                return db.ChiTietNhanViens
                         .Where(ct => ct.MaNhanVien == maNV)
                         .Select(ct => new ET_ChiTietNV
                         {
                             MaNhanVien = ct.MaNhanVien,
                             SoDienThoai = ct.SoDienThoai,
                             EmailCaNhan = ct.EmailCaNhan,
                             EmailCongTy = ct.EmailCongTy,
                             DiaChiThuongTru = ct.DiaChiThuongTru,
                             SoCCCD = ct.SoCCCD,
                             NgayCapCCCD = ct.NgayCapCCCD,
                             NoiCapCCCD = ct.NoiCapCCCD,
                             MaSoThue = ct.MaSoThue,
                             SoTaiKhoan = ct.SoTaiKhoan,
                             TenNganHang = ct.TenNganHang,
                             AnhDaiDien = ct.HinhAnh != null ? ct.HinhAnh.ToArray() : null
                         }).FirstOrDefault(); // <--- Đổi .ToList() thành .FirstOrDefault()
            }
        }

        public bool CapNhatHinhAnh(string maNV, byte[] hinhAnh)
        {
            using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
            {
                // 1. Tìm chi tiết nhân viên cần sửa
                var ct = db.ChiTietNhanViens.FirstOrDefault(x => x.MaNhanVien == maNV);

                if (ct != null)
                {
                    // 2. Chuyển từ byte[] sang Binary của LINQ to SQL
                    if (hinhAnh != null)
                    {
                        ct.HinhAnh = new System.Data.Linq.Binary(hinhAnh);
                    }
                    else
                    {
                        ct.HinhAnh = null; // Trường hợp muốn xóa ảnh
                    }

                    // 3. Lưu xuống Database
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
        }
    }
}
