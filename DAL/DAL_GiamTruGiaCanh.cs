using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_GiamTruGiaCanh
    {
        public IQueryable<GiamTruGiaCanh> LayDsTheoMa(string maNV)
        {
            QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext();
            return db.GiamTruGiaCanhs.Where(nv => nv.MaNhanVien == maNV);
        }

        //thêm
        public bool ThemGiamTru(ET.ET_GiamTruGiaCanh etGiamTru)
        {
            try
            {
                using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
                {
                    GiamTruGiaCanh gtMoi = new GiamTruGiaCanh
                    {
                        MaGiamTru = etGiamTru.MaGiamTru,
                        MaNhanVien = etGiamTru.MaNhanVien,
                        HoTenNguoiPhuThuoc = etGiamTru.HoTenNguoiPhuThuoc,
                        QuanHe = etGiamTru.QuanHe,
                        MaSoThue = etGiamTru.MaSoThue,
                        NgayBatDau = etGiamTru.NgayBatDau,
                        NgayKetThuc = etGiamTru.NgayKetThuc
                    };
                    db.GiamTruGiaCanhs.InsertOnSubmit(gtMoi);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm giảm trừ gia cảnh: " + ex.Message);
                return false;
            }
        }
        //sửa
        public bool SuaGiamTru(ET.ET_GiamTruGiaCanh etGiamTru)
        {
            try
            {
                using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
                {
                    var gtSua = db.GiamTruGiaCanhs.FirstOrDefault(gt => gt.MaGiamTru == etGiamTru.MaGiamTru);
                    if (gtSua != null)
                    {
                        gtSua.MaNhanVien = etGiamTru.MaNhanVien;
                        gtSua.HoTenNguoiPhuThuoc = etGiamTru.HoTenNguoiPhuThuoc;
                        gtSua.QuanHe = etGiamTru.QuanHe;
                        gtSua.MaSoThue = etGiamTru.MaSoThue;
                        gtSua.NgayBatDau = etGiamTru.NgayBatDau;
                        gtSua.NgayKetThuc = etGiamTru.NgayKetThuc;
                        db.SubmitChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi sửa giảm trừ gia cảnh: " + ex.Message);
                return false;
            }
        }
        //xóa
        public bool XoaGiamTru(string maGiamTru)
        {
            try
            {
                using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
                {
                    var gtXoa = db.GiamTruGiaCanhs.FirstOrDefault(gt => gt.MaGiamTru == maGiamTru);
                    if (gtXoa != null)
                    {
                        db.GiamTruGiaCanhs.DeleteOnSubmit(gtXoa);
                        db.SubmitChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xóa giảm trừ gia cảnh: " + ex.Message);
                return false;
            }
        }

    }
}
