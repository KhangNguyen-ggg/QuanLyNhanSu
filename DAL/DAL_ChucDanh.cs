using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChucDanh
    {
        QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext();

        public List<ChucDanh> LayDanhSachChucDanh()
        {
            return db.ChucDanhs.ToList();
        }
    }
}
