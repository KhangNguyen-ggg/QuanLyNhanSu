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
            return dAL_PhongBan.LayDanhSachPhongBan();
        }

    }
}
