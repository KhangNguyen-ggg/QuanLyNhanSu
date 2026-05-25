using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;

namespace BUS
{
    public class BUS_ChucDanh
    {
        DAL_ChucDanh dAL_ChucDanh = new DAL.DAL_ChucDanh();
        public List<ET_ChucDanh> LayDanhSachChucDanh()
        {
            var chucDanhs = dAL_ChucDanh.LayDanhSachChucDanh();
            return chucDanhs.Select(cd => new ET.ET_ChucDanh
            {
                MaChucDanh = cd.MaChucDanh,
                TenChucDanh = cd.TenChucDanh
            }).ToList();
        }
    }
}
