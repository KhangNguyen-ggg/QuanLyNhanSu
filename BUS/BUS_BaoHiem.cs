using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using DAL;
using System.Data;
namespace BUS
{
    public class BUS_BaoHiem
    {
        // Lấy ds
        public List<ET_BaoHiem> LayThongTinBaoHiem(string maNV)
        {
            DAL_BaoHiem dAL_BaoHiem = new DAL_BaoHiem();
            var query = dAL_BaoHiem.LayThongTinBaoHiem(maNV).Where(bh => bh.MaNhanVien == maNV);
            return query.Select(item => new ET_BaoHiem
            {
                MaNhanVien = item.MaNhanVien,
                SoSoBHXH = item.SoSoBHXH,
                NgayThamGia = item.NgayThamGia.GetValueOrDefault(),
                NoiDangKyKhamBenh = item.NoiDangKyKhamBenh,
                MucDong = item.MucDong,
                TrangThai = item.TrangThai
            }).ToList();
        }
        //cập nhật
        public bool CapNhatBaoHiem(ET_BaoHiem etBaoHiem)
        {
            DAL_BaoHiem dAL_BaoHiem = new DAL_BaoHiem();
            return dAL_BaoHiem.CapNhatBaoHiem(etBaoHiem);
        }
        
    }
}
