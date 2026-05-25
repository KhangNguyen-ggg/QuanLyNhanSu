using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ET;
namespace DAL
{

    public class DAL_NhanVien
    {

        //lấy ds
        public IQueryable<ET_NhanVienView> LayDanhSachLenGrid()
        {
            QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext();
            var query = from nv in db.NhanViens

                        join pb in db.PhongBans on nv.MaPhongBan equals pb.MaPhongBan into pbGroup
                        from pb in pbGroup.DefaultIfEmpty()

                        join cd in db.ChucDanhs on nv.MaChucDanh equals cd.MaChucDanh into cdGroup
                        from cd in cdGroup.DefaultIfEmpty()
                        select new ET_NhanVienView
                        {
                            MaNhanVien = nv.MaNhanVien,
                            HoTen = nv.HoTen,
                            ChucDanh = cd.TenChucDanh,
                            TrangThaiLamViec = nv.TrangThaiLamViec,
                            TenPhongBan = pb != null ? pb.TenPhongBan : "Không có phòng ban"
                        };
            return query;
        }

        // Lấy thông tin cơ bản 
        public IQueryable<NhanVien> LayThongTinCoBan()
        {
            QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext();
            return db.NhanViens;
        }



        //tìm
        public List<ET_NhanVienView> TimKiemNhanVien(string tuKhoa, string maPhongBan, bool isTimTheoPB)
        {
            using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
            {
                var query = from nv in db.NhanViens
                            join pb in db.PhongBans on nv.MaPhongBan equals pb.MaPhongBan into pbGroup
                            from pb in pbGroup.DefaultIfEmpty()

                            join cd in db.ChucDanhs on nv.MaChucDanh equals cd.MaChucDanh into cdGroup
                            from cd in cdGroup.DefaultIfEmpty()//sử dụng DefaultIfEmpty để tránh lỗi khi không có phòng ban hoặc chức danh tương ứng
                            select new { nv, pb, cd };

                if (isTimTheoPB && !string.IsNullOrEmpty(maPhongBan))
                {
                    query = query.Where(x => x.nv.MaPhongBan == maPhongBan);
                }

                // Tìm kiếm theo Mã NV hoặc Họ Tên, từ khóa có thể là một phần của Mã NV hoặc Họ Tên
                if (!string.IsNullOrEmpty(tuKhoa))
                {
                    query = query.Where(x => x.nv.MaNhanVien.Contains(tuKhoa) || x.nv.HoTen.Contains(tuKhoa));
                }


                var result = query.Select(x => new ET_NhanVienView
                {
                    MaNhanVien = x.nv.MaNhanVien,
                    HoTen = x.nv.HoTen,
                    TenPhongBan = x.pb != null ? x.pb.TenPhongBan : "Không có phòng ban",
                    // Khắc phục lỗi: Lấy trực tiếp tên hiển thị thay vì mã danh mục
                    ChucDanh = x.cd != null ? x.cd.TenChucDanh : "Chưa có chức danh",
                    TrangThaiLamViec = x.nv.TrangThaiLamViec
                }).ToList();

                return result;
            }
        }

        public bool ThemNhanVien(ET_NhanVien nv)
        {
            try
            {
                using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
                {
                    // Chuyển đổi gói dữ liệu ET thuần thành Entity được DB quản lý
                    NhanVien newNV = new NhanVien
                    {
                        MaNhanVien = nv.MaNhanVien,
                        HoTen = nv.HoTen,
                        GioiTinh = nv.GioiTinh,
                        NgaySinh = nv.NgaySinh,
                        MaPhongBan = nv.MaPhongBan,
                        MaChucDanh = nv.MaChucDanh,
                        TrangThaiLamViec = nv.TrangThaiLamViec
                    };

                    db.NhanViens.InsertOnSubmit(newNV);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //xóa
        public bool XoaNhanVien(string maNV)
        {
            try
            {
                using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
                {
                    var nv = db.NhanViens.FirstOrDefault(n => n.MaNhanVien == maNV);
                    if (nv != null)
                    {
                        db.NhanViens.DeleteOnSubmit(nv);
                        db.SubmitChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        // 4. HÀM CẬP NHẬT THÔNG TIN NHÂN VIÊN (Đã loại bỏ lệnh sửa Khóa chính)
        public bool SuaNhanVien(ET_NhanVien nv)
        {
            try
            {
                using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
                {
                    // Truy vấn thực thể đang tồn tại trong DB theo khóa chính
                    var existingNV = db.NhanViens.FirstOrDefault(n => n.MaNhanVien == nv.MaNhanVien);
                    if (existingNV != null)
                    {
                        // ĐÃ XÓA dòng sửa khóa chính existingNV.MaNhanVien để tránh lỗi crash hệ thống
                        existingNV.HoTen = nv.HoTen;
                        existingNV.GioiTinh = nv.GioiTinh;
                        existingNV.NgaySinh = nv.NgaySinh;
                        existingNV.MaPhongBan = nv.MaPhongBan;
                        existingNV.MaChucDanh = nv.MaChucDanh;
                        existingNV.TrangThaiLamViec = nv.TrangThaiLamViec;

                        db.SubmitChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
