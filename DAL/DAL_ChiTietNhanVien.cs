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

        // 
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
        public bool ThemChiTiet(ET_ChiTietNV ct)
        {
            try
            {
                using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
                {
                    ChiTietNhanVien chiTiet = new ChiTietNhanVien
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
                        TenNganHang = ct.TenNganHang
                    };
                    db.ChiTietNhanViens.InsertOnSubmit(chiTiet);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        //sửa chi tiết
        // CẬP NHẬT THÔNG TIN CHI TIẾT NHÂN VIÊN
        public bool SuaChiTiet(ET_ChiTietNV ct)
        {
            try
            {
                using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
                {
                    // Tìm xem nhân viên này đã có hồ sơ chi tiết trong SQL chưa
                    var existingCT = db.ChiTietNhanViens.FirstOrDefault(x => x.MaNhanVien == ct.MaNhanVien);

                    if (existingCT != null)
                    {
                        // NẾU ĐÃ CÓ: Tiến hành ghi đè dữ liệu mới (Update)
                        existingCT.SoDienThoai = ct.SoDienThoai;
                        existingCT.SoCCCD = ct.SoCCCD;
                        existingCT.EmailCaNhan = ct.EmailCaNhan;
                        existingCT.EmailCongTy = ct.EmailCongTy;
                        existingCT.DiaChiThuongTru = ct.DiaChiThuongTru;
                        existingCT.MaSoThue = ct.MaSoThue;
                        existingCT.TenNganHang = ct.TenNganHang;
                        existingCT.SoTaiKhoan = ct.SoTaiKhoan;

                        // Nếu bạn có dùng 2 ô Ngày cấp và Nơi cấp trên Form thì mở comment 2 dòng này ra:
                        // existingCT.NgayCapCCCD = ct.NgayCapCCCD;
                        // existingCT.NoiCapCCCD = ct.NoiCapCCCD;
                    }
                    else
                    {
                        // NẾU CHƯA CÓ (Do lúc thêm mới bị lỗi mạng hoặc ai đó lỡ tay xóa DB):
                        // Tiến hành tạo mới (Insert) để tự động sửa lỗi thiếu dữ liệu
                        ChiTietNhanVien newCT = new ChiTietNhanVien
                        {
                            MaNhanVien = ct.MaNhanVien,
                            SoDienThoai = ct.SoDienThoai,
                            SoCCCD = ct.SoCCCD,
                            EmailCaNhan = ct.EmailCaNhan,
                            EmailCongTy = ct.EmailCongTy,
                            DiaChiThuongTru = ct.DiaChiThuongTru,
                            MaSoThue = ct.MaSoThue,
                            TenNganHang = ct.TenNganHang,
                            SoTaiKhoan = ct.SoTaiKhoan
                            // NgayCapCCCD = ct.NgayCapCCCD,
                            // NoiCapCCCD = ct.NoiCapCCCD
                        };
                        db.ChiTietNhanViens.InsertOnSubmit(newCT);
                    }

                    db.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
