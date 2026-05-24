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
        QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext();
        
        //lấy ds
        public List<ET_NhanVienView> LayDanhSachLenGrid()
        {
            // Dùng using để đảm bảo dữ liệu luôn được lấy mới nhất từ SQL
            using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
            {
                var ds = from nv in db.NhanViens
                         join pb in db.PhongBans on nv.MaPhongBan equals pb.MaPhongBan into pbGroup
                         from pb in pbGroup.DefaultIfEmpty()
                         select new ET_NhanVienView
                         {
                             MaNhanVien = nv.MaNhanVien,
                             HoTen = nv.HoTen,
                             TenPhongBan = pb.TenPhongBan,
                             TrangThaiLamViec = nv.TrangThaiLamViec
                         };

                return ds.ToList(); 
            }
        }

        // Lấy thông tin cơ bản 
        public ET_NhanVien LayThongTinCoBan(string maNV)
        {
            using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
            {
                var nv = db.NhanViens.FirstOrDefault(n => n.MaNhanVien == maNV);
                if (nv != null)
                {
                    // Dùng constructor của ET_NhanVien bạn đã tạo
                    return new ET_NhanVien(
                        nv.MaNhanVien,
                        nv.HoTen,
                        nv.GioiTinh,
                        nv.NgaySinh.GetValueOrDefault(),
                        nv.MaPhongBan,
                        nv.MaChucDanh,
                        nv.TrangThaiLamViec
                    );
                }
                return null;
            }
        }



        //tìm
        public List<ET_NhanVienView> TimKiemNhanVien(string tuKhoa, string maPhongBan, bool isTimTheoPB)
        {
            using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
            {
                var query = from nv in db.NhanViens
                            join pb in db.PhongBans on nv.MaPhongBan equals pb.MaPhongBan into pbGroup
                            from pb in pbGroup.DefaultIfEmpty()
                            select new { nv, pb };

                if (isTimTheoPB && !string.IsNullOrEmpty(maPhongBan))
                {
                    query = query.Where(x => x.nv.MaPhongBan == maPhongBan);
                }

                if (!string.IsNullOrEmpty(tuKhoa))
                {
                    query = query.Where(x => x.nv.MaNhanVien.Contains(tuKhoa) || x.nv.HoTen.Contains(tuKhoa));
                }

                var result = query.Select(x => new ET_NhanVienView
                {
                    MaNhanVien = x.nv.MaNhanVien,
                    HoTen = x.nv.HoTen,
                    TenPhongBan = x.pb.TenPhongBan,
                    TrangThaiLamViec = x.nv.TrangThaiLamViec
                }).ToList();

                return result;
            }
        }

        //thêm
        public bool ThemNhanVien(NhanVien nv)
        {
            try
            {
                db.NhanViens.InsertOnSubmit(nv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //xóa
        public bool XoaNhanVien(string maNV)
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
        //sửa
        public bool SuaNhanVien(NhanVien nv)
        {
            using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
            {
                var existingNV = db.NhanViens.FirstOrDefault(n => n.MaNhanVien == nv.MaNhanVien);
                if (existingNV != null)
                {
                    existingNV.MaNhanVien = nv.MaNhanVien;
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

        
    }
}
