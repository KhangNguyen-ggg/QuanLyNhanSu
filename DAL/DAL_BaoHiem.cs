using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_BaoHiem
    {
        //lấy ds
        public List<ET_BaoHiem> LayDanhSachBaoHiem()
        {
            QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext();
            var query = from bh in db.BaoHiemXaHois
                        select new ET_BaoHiem
                        {
                            MaNhanVien = bh.MaNhanVien,
                            SoSoBHXH = bh.SoSoBHXH,
                            NgayThamGia = bh.NgayThamGia,
                            NoiDangKyKhamBenh = bh.NoiDangKyKhamBenh,
                            MucDong = bh.MucDong,
                            TrangThai = bh.TrangThai,
                        };
            return query.ToList();

        }
    }
}
