CREATE DATABASE QuanLyNhanSu;
GO

USE QuanLyNhanSu;
GO

-- =====================================================================
-- MODULE 1: DANH MỤC & CƠ CẤU TỔ CHỨC (Dùng cho Form Cài Đặt Danh Mục)
-- =====================================================================
CREATE TABLE ChiNhanh (
    MaChiNhanh VARCHAR(20) PRIMARY KEY,
    TenChiNhanh NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(255),
    Hotline VARCHAR(20),
    MaNguoiDungDau VARCHAR(20) 
);

CREATE TABLE ChucDanh (
    MaChucDanh VARCHAR(20) PRIMARY KEY,
    TenChucDanh NVARCHAR(100) NOT NULL,
    CapBac NVARCHAR(50) 
);

CREATE TABLE PhongBan (
    MaPhongBan VARCHAR(20) PRIMARY KEY,
    MaChiNhanh VARCHAR(20),
    TenPhongBan NVARCHAR(100) NOT NULL,
    MaPhongBanCha VARCHAR(20), 
    MaTruongPhong VARCHAR(20), 
    FOREIGN KEY (MaChiNhanh) REFERENCES ChiNhanh(MaChiNhanh)
);

CREATE TABLE CaLamViec (
    MaCa VARCHAR(20) PRIMARY KEY,
    TenCa NVARCHAR(100), 
    GioBatDau TIME,
    GioKetThuc TIME
);

CREATE TABLE HinhThucChamCong (
    MaHinhThuc VARCHAR(20) PRIMARY KEY,
    TenHinhThuc NVARCHAR(100) NOT NULL 
);

CREATE TABLE DanhMucPhuCap (
    MaPhuCap VARCHAR(20) PRIMARY KEY,
    TenPhuCap NVARCHAR(100), 
    MucTien DECIMAL(18,2)
);

-- =====================================================================
-- MODULE 2: QUẢN LÝ NHÂN SỰ LÕI (Dùng cho Form Hồ Sơ Nhân Viên)
-- =====================================================================
CREATE TABLE NhanVien (
    MaNhanVien VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    MaPhongBan VARCHAR(20),
    MaChucDanh VARCHAR(20),
    TrangThaiLamViec NVARCHAR(50) DEFAULT N'Đang làm việc',
    FOREIGN KEY (MaPhongBan) REFERENCES PhongBan(MaPhongBan),
    FOREIGN KEY (MaChucDanh) REFERENCES ChucDanh(MaChucDanh)
);

CREATE TABLE ChiTietNhanVien (
    MaNhanVien VARCHAR(20) PRIMARY KEY,
    SoDienThoai VARCHAR(15),
    EmailCaNhan VARCHAR(100),
    EmailCongTy VARCHAR(100) UNIQUE,
    DiaChiThuongTru NVARCHAR(255),
    SoCCCD VARCHAR(12) UNIQUE NOT NULL,
    NgayCapCCCD DATE,
    NoiCapCCCD NVARCHAR(100),
    MaSoThue VARCHAR(14) UNIQUE,
    SoTaiKhoan VARCHAR(20),
    TenNganHang NVARCHAR(100),
    -- ĐÃ BỔ SUNG CỘT HINHANH --
    HinhAnh VARBINARY(MAX),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien) ON DELETE CASCADE
);

-- ⭐ [BẢNG MỚI THÊM VÀO] ⭐ (Thuế / Giảm trừ)
CREATE TABLE GiamTruGiaCanh (
    MaGiamTru VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    HoTenNguoiPhuThuoc NVARCHAR(100),
    QuanHe NVARCHAR(50), 
    MaSoThue VARCHAR(14),
    NgayBatDau DATE,
    NgayKetThuc DATE,
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien) ON DELETE CASCADE
);

-- =====================================================================
-- MODULE 3: QUẢN LÝ TUYỂN DỤNG & ĐÀO TẠO (Dùng cho Form Tuyển Dụng)
-- =====================================================================
CREATE TABLE ViTriTuyenDung (
    MaTuyenDung VARCHAR(20) PRIMARY KEY,
    MaPhongBan VARCHAR(20),
    MaChucDanh VARCHAR(20),
    SoLuongCanTuyen INT,
    HanChotNopHoSo DATE,
    MucLuongDuKien NVARCHAR(100),
    TrangThai NVARCHAR(50), 
    FOREIGN KEY (MaPhongBan) REFERENCES PhongBan(MaPhongBan),
    FOREIGN KEY (MaChucDanh) REFERENCES ChucDanh(MaChucDanh)
);

CREATE TABLE UngVien (
    MaUngVien VARCHAR(20) PRIMARY KEY,
    MaTuyenDung VARCHAR(20),
    HoTen NVARCHAR(100),
    SoDienThoai VARCHAR(15),
    Email VARCHAR(100),
    LinkCV VARCHAR(255),
    TrangThai NVARCHAR(50), 
    FOREIGN KEY (MaTuyenDung) REFERENCES ViTriTuyenDung(MaTuyenDung)
);

-- ⭐ [BẢNG MỚI THÊM VÀO] ⭐ (Lịch Phỏng vấn)
CREATE TABLE LichPhongVan (
    MaPhongVan VARCHAR(20) PRIMARY KEY,
    MaUngVien VARCHAR(20),
    MaNguoiPhongVan VARCHAR(20), 
    NgayGioPhongVan DATETIME,
    HinhThuc NVARCHAR(50), 
    KetQuaDanhGia NVARCHAR(MAX),
    FOREIGN KEY (MaUngVien) REFERENCES UngVien(MaUngVien),
    FOREIGN KEY (MaNguoiPhongVan) REFERENCES NhanVien(MaNhanVien)
);

-- ⭐ [BẢNG MỚI THÊM VÀO] ⭐ (Đào tạo nhân sự mới)
CREATE TABLE DaoTaoNghiepVu (
    MaDaoTao VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    TenKhoaDaoTao NVARCHAR(200) NOT NULL, 
    NguoiHuongDan VARCHAR(20), 
    NgayBatDau DATE,
    NgayKetThuc DATE,
    KetQuaDanhGia NVARCHAR(50),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (NguoiHuongDan) REFERENCES NhanVien(MaNhanVien)
);

-- =====================================================================
-- MODULE 4: HỢP ĐỒNG, BẢO HIỂM & PHỤ CẤP (Dùng cho Form Phúc Lợi)
-- =====================================================================
CREATE TABLE HopDongLaoDong (
    SoHopDong VARCHAR(50) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    LoaiHopDong NVARCHAR(100), 
    NgayKy DATE,
    NgayHieuLuc DATE,
    NgayHetHan DATE,
    LuongCung DECIMAL(18,2) NOT NULL, 
    TrangThai NVARCHAR(50), 
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien) ON DELETE CASCADE
);

-- ⭐ [BẢNG MỚI THÊM VÀO] ⭐ (Bảo hiểm xã hội)
CREATE TABLE BaoHiemXaHoi (
    SoSoBHXH VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    NgayThamGia DATE,
    NoiDangKyKhamBenh NVARCHAR(200),
    MucDong DECIMAL(18,2), 
    TrangThai NVARCHAR(50),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien) ON DELETE CASCADE
);

CREATE TABLE PhuCapNhanVien (
    MaNhanVien VARCHAR(20),
    MaPhuCap VARCHAR(20),
    NgayCapTien DATE,
    LyDoCap NVARCHAR(255),
    PRIMARY KEY (MaNhanVien, MaPhuCap, NgayCapTien),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien) ON DELETE CASCADE,
    FOREIGN KEY (MaPhuCap) REFERENCES DanhMucPhuCap(MaPhuCap)
);

-- =====================================================================
-- MODULE 5: CHẤM CÔNG, NGHỈ PHÉP & KPI (Dùng cho Form Chấm Công)
-- =====================================================================
CREATE TABLE DataChamCong (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    NgayChamCong DATE,
    MaCa VARCHAR(20),
    GioVao TIME,
    GioRa TIME,
    SoGioOT DECIMAL(4,2), 
    MaHinhThuc VARCHAR(20),
    TrangThai NVARCHAR(50), 
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien) ON DELETE CASCADE,
    FOREIGN KEY (MaCa) REFERENCES CaLamViec(MaCa),
    FOREIGN KEY (MaHinhThuc) REFERENCES HinhThucChamCong(MaHinhThuc)
);

CREATE TABLE DonNghiPhep (
    MaDon VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    LoaiNghiPhep NVARCHAR(50), 
    TuNgay DATETIME,
    DenNgay DATETIME,
    LyDo NVARCHAR(255),
    TrangThaiDuyet NVARCHAR(50), 
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien) ON DELETE CASCADE
);

CREATE TABLE DanhGiaKPI (
    MaDanhGia VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    ThangDanhGia INT,
    NamDanhGia INT,
    DiemSo DECIMAL(5,2), 
    XepLoai NVARCHAR(50), 
    NhanXet NVARCHAR(500),
    MaNguoiDanhGia VARCHAR(20), 
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien) ON DELETE CASCADE,
    FOREIGN KEY (MaNguoiDanhGia) REFERENCES NhanVien(MaNhanVien)
);

CREATE TABLE KhenThuongKyLuat (
    MaQuyetDinh VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    LoaiQuyetDinh NVARCHAR(50), 
    NgayQuyetDinh DATE,
    LyDo NVARCHAR(255),
    SoTien DECIMAL(18,2) DEFAULT 0,
    NguoiQuyetDinh VARCHAR(20),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien) ON DELETE CASCADE
);

-- =====================================================================
-- MODULE 6: TÀI CHÍNH & VẬN HÀNH NỘI BỘ (Tạm ứng, Công tác, Tài sản)
-- =====================================================================
CREATE TABLE TamUng (
    MaTamUng VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20) NOT NULL,
    NgayTamUng DATE DEFAULT GETDATE(),
    SoTien DECIMAL(18,2) NOT NULL,
    LyDo NVARCHAR(255),
    TrangThai TINYINT DEFAULT 0, 
    ThangKhauTru INT,
    NamKhauTru INT,
    NguoiDuyet VARCHAR(20),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien) ON DELETE CASCADE,
    FOREIGN KEY (NguoiDuyet) REFERENCES NhanVien(MaNhanVien)
);

-- ⭐ [BẢNG MỚI THÊM VÀO] ⭐ (Quản lý hồ sơ công tác)
CREATE TABLE HoSoCongTac (
    MaCongTac VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    DiaDiem NVARCHAR(200),
    TuNgay DATE,
    DenNgay DATE,
    MucDich NVARCHAR(500),
    ChiPhiDuKien DECIMAL(18,2),
    TrangThaiDuyet NVARCHAR(50),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien) ON DELETE CASCADE
);

-- ⭐ [BẢNG MỚI THÊM VÀO] ⭐ (Quản lý thiết bị/tài sản công ty cấp)
CREATE TABLE TaiSanCapPhat (
    MaCapPhat VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    LoaiTaiSan NVARCHAR(100), 
    SoSeri VARCHAR(100),
    NgayCapPhat DATE,
    TinhTrang NVARCHAR(100), 
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien) ON DELETE CASCADE
);

-- =====================================================================
-- MODULE 7: QUẢN LÝ NGHỈ VIỆC & BÀN GIAO (Form Offboarding)
-- =====================================================================
CREATE TABLE QuyetDinhNghiViec (
    MaQuyetDinh VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    NgayNopDon DATE,
    NgayNghiChinhThuc DATE,
    LyDoNghi NVARCHAR(500),
    TrangThaiBanGiao NVARCHAR(50), 
    NguoiDuyet VARCHAR(20),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien) ON DELETE CASCADE
);

-- ⭐ [BẢNG MỚI THÊM VÀO] ⭐ (Chi tiết bàn giao khi nghỉ việc)
CREATE TABLE ChiTietBanGiao (
    MaBanGiao VARCHAR(20) PRIMARY KEY,
    MaQuyetDinh VARCHAR(20),
    HangMucBanGiao NVARCHAR(200), 
    NguoiNhanBanGiao VARCHAR(20), 
    TrangThai NVARCHAR(50), 
    GhiChu NVARCHAR(255),
    FOREIGN KEY (MaQuyetDinh) REFERENCES QuyetDinhNghiViec(MaQuyetDinh) ON DELETE CASCADE,
    FOREIGN KEY (NguoiNhanBanGiao) REFERENCES NhanVien(MaNhanVien)
);

-- =====================================================================
-- MODULE 8: HỆ THỐNG & BẢO MẬT (Dùng cho Formhethong)
-- =====================================================================
CREATE TABLE NhomQuyen (
    MaNhomQuyen VARCHAR(20) PRIMARY KEY,
    TenNhomQuyen NVARCHAR(100) NOT NULL, 
    MoTa NVARCHAR(255)
);

CREATE TABLE TaiKhoan (
    TenDangNhap VARCHAR(50) PRIMARY KEY,
    MaNhanVien VARCHAR(20) UNIQUE NOT NULL, 
    MatKhau VARCHAR(255) NOT NULL, 
    MaNhomQuyen VARCHAR(20),
    TrangThaiHoatDong BIT DEFAULT 1, 
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien) ON DELETE CASCADE,
    FOREIGN KEY (MaNhomQuyen) REFERENCES NhomQuyen(MaNhomQuyen)
);

-- ⭐ [BẢNG MỚI THÊM VÀO] ⭐ (Log lưu lịch sử thao tác phần mềm)
CREATE TABLE NhatKyHoatDong (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap VARCHAR(50),
    ThoiGian DATETIME DEFAULT GETDATE(),
    HanhDong NVARCHAR(100), 
    ChiTiet NVARCHAR(MAX),  
    IPAddress VARCHAR(50),
    FOREIGN KEY (TenDangNhap) REFERENCES TaiKhoan(TenDangNhap) ON DELETE CASCADE
);

-- =====================================================================
-- BƯỚC CUỐI: CẬP NHẬT RÀNG BUỘC THAM CHIẾU VÒNG 
-- =====================================================================
ALTER TABLE PhongBan
ADD CONSTRAINT FK_PhongBan_TruongPhong 
FOREIGN KEY (MaTruongPhong) REFERENCES NhanVien(MaNhanVien);
GO

-- 1. Thêm Chi nhánh (Cần thiết cho Phòng ban)
INSERT INTO ChiNhanh (MaChiNhanh, TenChiNhanh) 
VALUES ('CN_HQ', N'Trụ sở chính');

-- 2. Thêm Phòng ban (Cần thiết cho Nhân viên)
INSERT INTO PhongBan (MaPhongBan, MaChiNhanh, TenPhongBan) 
VALUES ('PB_IT', 'CN_HQ', N'Phòng Công Nghệ Thông Tin');

-- 3. Thêm Chức danh (Cần thiết cho Nhân viên)
INSERT INTO ChucDanh (MaChucDanh, TenChucDanh, CapBac) 
VALUES ('CD_ADMIN', N'Quản trị viên', N'Quản lý');

-- 4. Thêm Nhân viên Admin (Để liên kết với Tài khoản)
INSERT INTO NhanVien (MaNhanVien, HoTen, MaPhongBan, MaChucDanh) 
VALUES ('NV_ADMIN', N'Quản Trị Viên Hệ Thống', 'PB_IT', 'CD_ADMIN');

-- 5. Thêm Nhóm quyền Admin
INSERT INTO NhomQuyen (MaNhomQuyen, TenNhomQuyen, MoTa) 
VALUES ('NQ_ADMIN', N'Administrator', N'Toàn quyền hệ thống');
-- 6. Tạo Tài khoản Admin
INSERT INTO TaiKhoan (TenDangNhap, MaNhanVien, MatKhau, MaNhomQuyen, TrangThaiHoatDong) 
VALUES ('admin', 'NV_ADMIN', '123456', 'NQ_ADMIN', 1);