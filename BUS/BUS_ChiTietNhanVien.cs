using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using ET;
namespace BUS
{
    public class BUS_ChiTietNhanVien
    {
        DAL_ChiTietNhanVien dAL_ChiTietNhanVien = new DAL_ChiTietNhanVien();
            
        // Lấy chi tiết nhân viên
        public IQueryable LayChiTietNhanVien(string maNV)
        {
            return dAL_ChiTietNhanVien.LayChiTietNhanVien(maNV);
        }

        public ET_ChiTietNV LayThongTinChiTiet(string maNV)
        {
            return dAL_ChiTietNhanVien.LayThongTinChiTiet(maNV);
        }

        public bool CapNhatHinhAnh(string maNV, byte[] hinhAnh)
        {
            return dAL_ChiTietNhanVien.CapNhatHinhAnh(maNV, hinhAnh);
        }

        //thêm
        public bool ThemChiTietNhanVien(ET_ChiTietNV ct)
        {
            return dAL_ChiTietNhanVien.ThemChiTiet(ct);
        }
        // Sửa
        public bool SuaChiTietNhanVien(ET_ChiTietNV ct)
        {
            return dAL_ChiTietNhanVien.SuaChiTiet(ct);
        }
    }
}
