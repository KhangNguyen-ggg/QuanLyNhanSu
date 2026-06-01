using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using ET;

namespace BUS
{
    public class BUS_TaiSanCapPhat
    {
        private DAL_TaiSanCapPhat dalTaiSan = new DAL_TaiSanCapPhat();

        // Hiển thị (Trả về List để đổ lên DataGridView)
        public List<ET_TaiSanCapPhat> LayDsTheoMa(string maNV)
        {
            var query = dalTaiSan.LayDsTheoMa(maNV);
            return query.Select(item => new ET_TaiSanCapPhat
            {
                MaCapPhat = item.MaCapPhat,
                MaNhanVien = item.MaNhanVien,
                LoaiTaiSan = item.LoaiTaiSan,
                SoSeri = item.SoSeri,
                NgayCapPhat = item.NgayCapPhat,
                TinhTrang = item.TinhTrang
            }).ToList();
        }

        // Thêm
        public bool ThemTaiSan(ET_TaiSanCapPhat etTaiSan)
        {
            return dalTaiSan.ThemTaiSan(etTaiSan);
        }

        // Sửa
        public bool SuaTaiSan(ET_TaiSanCapPhat etTaiSan)
        {
            return dalTaiSan.SuaTaiSan(etTaiSan);
        }

        // Xóa
        public bool XoaTaiSan(string maCapPhat)
        {
            return dalTaiSan.XoaTaiSan(maCapPhat);
        }
    }
}