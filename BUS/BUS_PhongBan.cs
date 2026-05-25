using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_PhongBan
    {
        DAL_PhongBan dAL_PhongBan = new DAL_PhongBan();

        // Lấy danh sách phòng ban
        public List<ET_PhongBan> LayDanhSachPhongBan()
        {
            var query = dAL_PhongBan.LayDanhSachPhongBan();
            //List<ET_PhongBan> listPhongBan = new List<ET_PhongBan>();
            //foreach (var item in query)
            //{
            //    ET_PhongBan et_PhongBan = new ET_PhongBan();
            //    et_PhongBan.MaPhongBan = item.MaPhongBan;
            //    et_PhongBan.MaChiNhanh = item.MaChiNhanh;
            //    et_PhongBan.TenPhongBan = item.TenPhongBan;
            //    et_PhongBan.MaPhongBanCha = item.MaPhongBanCha;
            //    et_PhongBan.MaTruongPhong = item.MaTruongPhong;
            //    listPhongBan.Add(et_PhongBan);
            //}
            //return listPhongBan;
            return query.Select(item => new ET_PhongBan
            {
                MaPhongBan = item.MaPhongBan,
                MaChiNhanh = item.MaChiNhanh,
                TenPhongBan = item.TenPhongBan,
                MaPhongBanCha = item.MaPhongBanCha,
                MaTruongPhong = item.MaTruongPhong
            }).ToList();
        }

    }
}
