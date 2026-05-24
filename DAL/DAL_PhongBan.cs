using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhongBan
    {

        public List<ET_PhongBan> LayDanhSachPhongBan()
        {
            using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
            {
                return db.PhongBans.Select(pb => new ET_PhongBan
                {
                    MaPhongBan = pb.MaPhongBan,
                    TenPhongBan = pb.TenPhongBan
                }).ToList();
            }
        }
    }
}
