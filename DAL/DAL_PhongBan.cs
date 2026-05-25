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

        public IQueryable<PhongBan> LayDanhSachPhongBan()
        {
            QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext();
            var query = from pb in db.PhongBans
                        select pb;
            return query;
        }

    }
}
