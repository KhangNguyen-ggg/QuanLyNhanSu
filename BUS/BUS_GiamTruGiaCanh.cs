using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_GiamTruGiaCanh
    {
        //lấy ds
        public List<ET_GiamTruGiaCanh> LayDsTheoMa(string maNV)
        {
            DAL_GiamTruGiaCanh dalGiamTru = new DAL_GiamTruGiaCanh();
            var query = dalGiamTru.LayDsTheoMa(maNV);

            return query.Select(item => new ET_GiamTruGiaCanh
            {
                MaGiamTru = item.MaGiamTru,
                MaNhanVien = item.MaNhanVien,
                HoTenNguoiPhuThuoc = item.HoTenNguoiPhuThuoc,
                QuanHe = item.QuanHe,
                MaSoThue = item.MaSoThue,
                // Dùng GetValueOrDefault để tránh lỗi Cannot implicitly convert type 'DateTime?'
                NgayBatDau = item.NgayBatDau.GetValueOrDefault(),
                NgayKetThuc = item.NgayKetThuc
            }).ToList(); // <-- PHẢI DÙNG TOLIST()
        }   

        //thêm
        public bool ThemGiamTru(ET_GiamTruGiaCanh etGiamTru)
        {
            DAL_GiamTruGiaCanh dalGiamTru = new DAL_GiamTruGiaCanh();
            return dalGiamTru.ThemGiamTru(etGiamTru);
        }
        //sửa
        public bool SuaGiamTru(ET_GiamTruGiaCanh etGiamTru)
        {
            DAL_GiamTruGiaCanh dalGiamTru = new DAL_GiamTruGiaCanh();
            return dalGiamTru.SuaGiamTru(etGiamTru);
        }
        //xóa
        public bool XoaGiamTru(string maGiamTru)
        {
            DAL_GiamTruGiaCanh dalGiamTru = new DAL_GiamTruGiaCanh();
            return dalGiamTru.XoaGiamTru(maGiamTru);
        }
    }
}
