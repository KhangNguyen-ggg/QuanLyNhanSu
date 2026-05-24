using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using DAL;
namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dAL_NhanVien = new DAL_NhanVien();

        //lấy ds
        public List<ET_NhanVienView> LayDanhSachLenGrid()
        {
            return dAL_NhanVien.LayDanhSachLenGrid();
        }

        public List<ET_NhanVienView> TimKiemNhanVien(string tuKhoa, string maPhongBan, bool isTimTheoPB)
        {
            return dAL_NhanVien.TimKiemNhanVien(tuKhoa, maPhongBan, isTimTheoPB);
        }

        public ET_NhanVien LayThongTinCoBan(string maNV)
        {
            return dAL_NhanVien.LayThongTinCoBan(maNV);
        }

        //thêm
        public bool ThemNhanVien(NhanVien nv)
        {
            return dAL_NhanVien.ThemNhanVien(nv);
        }


    }
}
