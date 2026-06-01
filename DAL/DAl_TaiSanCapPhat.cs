using System;
using System.Collections.Generic;
using System.Linq;
using ET;

namespace DAL
{
    public class DAL_TaiSanCapPhat
    {
        public IQueryable<TaiSanCapPhat> LayDsTheoMa(string maNV)
        {
            QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext();
            return db.TaiSanCapPhats.Where(ts => ts.MaNhanVien == maNV);
        }

        // Thêm
        public bool ThemTaiSan(ET_TaiSanCapPhat etTaiSan)
        {
            try
            {
                using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
                {
                    TaiSanCapPhat tsMoi = new TaiSanCapPhat
                    {
                        MaCapPhat = etTaiSan.MaCapPhat,
                        MaNhanVien = etTaiSan.MaNhanVien,
                        LoaiTaiSan = etTaiSan.LoaiTaiSan,
                        SoSeri = etTaiSan.SoSeri,
                        NgayCapPhat = etTaiSan.NgayCapPhat,
                        TinhTrang = etTaiSan.TinhTrang
                    };
                    db.TaiSanCapPhats.InsertOnSubmit(tsMoi);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm cấp phát: " + ex.Message);
                return false;
            }
        }

        // Sửa
        public bool SuaTaiSan(ET_TaiSanCapPhat etTaiSan)
        {
            try
            {
                using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
                {
                    var tsSua = db.TaiSanCapPhats.FirstOrDefault(ts => ts.MaCapPhat == etTaiSan.MaCapPhat);
                    if (tsSua != null)
                    {
                        tsSua.LoaiTaiSan = etTaiSan.LoaiTaiSan;
                        tsSua.SoSeri = etTaiSan.SoSeri;
                        tsSua.NgayCapPhat = etTaiSan.NgayCapPhat;
                        tsSua.TinhTrang = etTaiSan.TinhTrang;

                        db.SubmitChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi sửa cấp phát: " + ex.Message);
                return false;
            }
        }

        // Xóa
        public bool XoaTaiSan(string maCapPhat)
        {
            try
            {
                using (QuanLyNhanSuDataContext db = new QuanLyNhanSuDataContext())
                {
                    var tsXoa = db.TaiSanCapPhats.FirstOrDefault(ts => ts.MaCapPhat == maCapPhat);
                    if (tsXoa != null)
                    {
                        db.TaiSanCapPhats.DeleteOnSubmit(tsXoa);
                        db.SubmitChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xóa cấp phát: " + ex.Message);
                return false;
            }
        }
    }
}