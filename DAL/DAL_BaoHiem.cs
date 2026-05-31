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
        public IQueryable<BaoHiemXaHoi> LayThongTinBaoHiem(string maNV)
        {
            QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext();
            return db.BaoHiemXaHois;
        }
        //cập nhật bảo hiểm
        public bool CapNhatBaoHiem(ET_BaoHiem etBaoHiem)
        {
            try
            {
                using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
                {
                    var baoHiem = db.BaoHiemXaHois.FirstOrDefault(bh => bh.MaNhanVien == etBaoHiem.MaNhanVien);

                    if (baoHiem != null)
                    {
                        baoHiem.SoSoBHXH = etBaoHiem.SoSoBHXH;
                        baoHiem.NgayThamGia = etBaoHiem.NgayThamGia;
                        baoHiem.NoiDangKyKhamBenh = etBaoHiem.NoiDangKyKhamBenh;
                        baoHiem.MucDong = etBaoHiem.MucDong;
                        baoHiem.TrangThai = etBaoHiem.TrangThai;
                    }
                    else
                    {
                        BaoHiemXaHoi bhMoi = new BaoHiemXaHoi
                        {
                            MaNhanVien = etBaoHiem.MaNhanVien,
                            SoSoBHXH = etBaoHiem.SoSoBHXH,
                            NgayThamGia = etBaoHiem.NgayThamGia,
                            NoiDangKyKhamBenh = etBaoHiem.NoiDangKyKhamBenh,
                            MucDong = etBaoHiem.MucDong,
                            TrangThai = etBaoHiem.TrangThai
                        };
                        db.BaoHiemXaHois.InsertOnSubmit(bhMoi);
                    }

                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi cập nhật bảo hiểm: " + ex.Message);
                return false;
            }
        }
       
    }
}
