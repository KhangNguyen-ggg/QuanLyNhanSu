CREATE DATABASE QuanLyNhanSu1;
GO

USE QuanLyNhanSu1;
GO

-- =====================================================================
-- NHÓM 1: CÁC BẢNG DANH MỤC GỐC (KHÔNG CHỨA KHÓA NGOẠI)
-- (Phải tạo đầu tiên để các bảng khác có thể tham chiếu đến)
-- =====================================================================

-- Bảng ChiNhanh: Lưu trữ thông tin về các cơ sở, chi nhánh của công ty.
CREATE TABLE ChiNhanh (
    MaChiNhanh VARCHAR(20) PRIMARY KEY,
    TenChiNhanh NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(255),
    Hotline VARCHAR(20),
    MaNguoiDungDau VARCHAR(20) 
);

-- Bảng ChucDanh: Danh mục các vị trí, chức danh và cấp bậc công việc (VD: Giám đốc, Trưởng phòng, Nhân viên...).
CREATE TABLE ChucDanh (
    MaChucDanh VARCHAR(20) PRIMARY KEY,
    TenChucDanh NVARCHAR(100) NOT NULL,
    CapBac NVARCHAR(50) 
);

-- Bảng CaLamViec: Quy định các khung giờ làm việc của công ty (VD: Ca hành chính, Ca sáng, Ca đêm...).
CREATE TABLE CaLamViec (
    MaCa VARCHAR(20) PRIMARY KEY,
    TenCa NVARCHAR(100), 
    GioBatDau TIME,
    GioKetThuc TIME
);

-- Bảng HinhThucChamCong: Các phương thức ghi nhận công (VD: Vân tay, Quẹt thẻ, Khuôn mặt...).
CREATE TABLE HinhThucChamCong (
    MaHinhThuc VARCHAR(20) PRIMARY KEY,
    TenHinhThuc NVARCHAR(100) NOT NULL 
);

-- Bảng DanhMucPhuCap: Danh sách các loại phụ cấp công ty hỗ trợ (VD: Ăn trưa, Xăng xe, Điện thoại...).
CREATE TABLE DanhMucPhuCap (
    MaPhuCap VARCHAR(20) PRIMARY KEY,
    TenPhuCap NVARCHAR(100), 
    MucTien DECIMAL(18,2)
);

-- Bảng NhomQuyen: Các nhóm quyền truy cập vào phần mềm (VD: Admin, Kế toán, Nhân sự, Nhân viên...).
CREATE TABLE NhomQuyen (
    MaNhomQuyen VARCHAR(20) PRIMARY KEY,
    TenNhomQuyen NVARCHAR(100) NOT NULL, 
    MoTa NVARCHAR(255)
);



-- =====================================================================
-- NHÓM 2: CÁC BẢNG CƠ SỞ CHÍNH
-- =====================================================================

-- Bảng PhongBan: Sơ đồ cơ cấu tổ chức các phòng ban. 
-- (Tạm thời chưa gán Khóa ngoại cho MaTruongPhong vì bảng Nhân viên chưa được tạo. Sẽ gán ở cuối)
CREATE TABLE PhongBan (
    MaPhongBan VARCHAR(20) PRIMARY KEY,
    MaChiNhanh VARCHAR(20),
    TenPhongBan NVARCHAR(100) NOT NULL,
    MaPhongBanCha VARCHAR(20), 
    MaTruongPhong VARCHAR(20),
    FOREIGN KEY (MaChiNhanh) REFERENCES ChiNhanh(MaChiNhanh)
);

-- Bảng ViTriTuyenDung: Các vị trí/Job đăng tuyển hiện tại của công ty, yêu cầu số lượng, hạn chót...
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

-- Bảng UngVien: Thông tin hồ sơ của những người ứng tuyển vào công ty.
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

-- Bảng NhanVien: BẢNG TRUNG TÂM. Lưu thông tin cơ bản của nhân viên chính thức trong công ty.
-- TẠO SAU KHI ĐÃ CÓ PHÒNG BAN VÀ CHỨC DANH
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

-- =====================================================================
-- NHÓM 3: CÁC BẢNG NGHIỆP VỤ (ĐÃ TỒN TẠI NHÂN VIÊN ĐỂ THAM CHIẾU)
-- =====================================================================

-- Bảng HoiDongQuanTri: Quản lý danh sách thành viên cấp cao, tỷ lệ cổ phần, nhiệm kỳ.
CREATE TABLE HoiDongQuanTri (
    MaThanhVien VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    ChucVuHDQT NVARCHAR(100), 
    TyLeCoPhan DECIMAL(5,2), 
    NgayBoNhiem DATE,
    NhiemKy INT, 
    MaNhanVien VARCHAR(20) NULL,
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- Bảng LichPhongVan: Sắp xếp lịch hẹn phỏng vấn ứng viên và lưu lại kết quả đánh giá.
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

-- Bảng DaoTaoNghiepVu: Theo dõi quá trình học việc, hội nhập hoặc các khóa học nghiệp vụ của nhân viên.
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

-- Bảng ChiTietNhanVien: Lưu trữ các thông tin bảo mật, pháp lý cá nhân (CCCD, Thuế, Tài khoản ngân hàng).
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
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- Bảng HopDongLaoDong: Theo dõi các loại hợp đồng (thử việc, 1 năm, vô thời hạn) và mức lương cứng.
CREATE TABLE HopDongLaoDong (
    SoHopDong VARCHAR(50) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    LoaiHopDong NVARCHAR(100), 
    NgayKy DATE,
    NgayHieuLuc DATE,
    NgayHetHan DATE,
    LuongCung DECIMAL(18,2) NOT NULL, 
    TrangThai NVARCHAR(50), 
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- Bảng BaoHiemXaHoi: Cập nhật sổ BHXH, nơi khám chữa bệnh và mức đóng phí bảo hiểm hàng tháng.
CREATE TABLE BaoHiemXaHoi (
    SoSoBHXH VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    NgayThamGia DATE,
    NoiDangKyKhamBenh NVARCHAR(200),
    MucDong DECIMAL(18,2), 
    TrangThai NVARCHAR(50),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- Bảng GiamTruGiaCanh: Danh sách người phụ thuộc (con cái, cha mẹ già) để tính thuế Thu nhập cá nhân.
CREATE TABLE GiamTruGiaCanh (
    MaGiamTru VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    HoTenNguoiPhuThuoc NVARCHAR(100),
    QuanHe NVARCHAR(50), 
    MaSoThue VARCHAR(14),
    NgayBatDau DATE,
    NgayKetThuc DATE,
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- Bảng DataChamCong: Dữ liệu thô ghi nhận thời gian ra/vào mỗi ngày của từng nhân viên.
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
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (MaCa) REFERENCES CaLamViec(MaCa),
    FOREIGN KEY (MaHinhThuc) REFERENCES HinhThucChamCong(MaHinhThuc)
);

-- Bảng DonNghiPhep: Lưu lại các yêu cầu xin nghỉ phép, nghỉ ốm, thai sản... và trạng thái phê duyệt.
CREATE TABLE DonNghiPhep (
    MaDon VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    LoaiNghiPhep NVARCHAR(50), 
    TuNgay DATETIME,
    DenNgay DATETIME,
    LyDo NVARCHAR(255),
    TrangThaiDuyet NVARCHAR(50), 
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- Bảng DanhGiaKPI: Bảng đánh giá hiệu suất, điểm số và xếp loại công việc hàng tháng/năm.
CREATE TABLE DanhGiaKPI (
    MaDanhGia VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    ThangDanhGia INT,
    NamDanhGia INT,
    DiemSo DECIMAL(5,2), 
    XepLoai NVARCHAR(50), 
    NhanXet NVARCHAR(500),
    MaNguoiDanhGia VARCHAR(20), 
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (MaNguoiDanhGia) REFERENCES NhanVien(MaNhanVien)
);

-- Bảng KhenThuongKyLuat: Ghi chép lịch sử các quyết định thưởng tiền hoặc phạt vi phạm của nhân viên.
CREATE TABLE KhenThuongKyLuat (
    MaQuyetDinh VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    LoaiQuyetDinh NVARCHAR(50), 
    NgayQuyetDinh DATE,
    LyDo NVARCHAR(255),
    SoTien DECIMAL(18,2) DEFAULT 0,
    NguoiQuyetDinh VARCHAR(20),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- Bảng TaiSanCapPhat: Quản lý thiết bị công ty (Laptop, màn hình, đồng phục...) đã cấp cho ai.
CREATE TABLE TaiSanCapPhat (
    MaCapPhat VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    LoaiTaiSan NVARCHAR(100), 
    SoSeri VARCHAR(100),
    NgayCapPhat DATE,
    TinhTrang NVARCHAR(100), 
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- Bảng PhuCapNhanVien: Chi tiết gán từng loại phụ cấp cụ thể (từ bảng DanhMucPhuCap) cho từng nhân viên.
CREATE TABLE PhuCapNhanVien (
    MaNhanVien VARCHAR(20),
    MaPhuCap VARCHAR(20),
    NgayCapTien DATE,
    LyDoCap NVARCHAR(255),
    PRIMARY KEY (MaNhanVien, MaPhuCap, NgayCapTien),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (MaPhuCap) REFERENCES DanhMucPhuCap(MaPhuCap)
);

-- Bảng BangLuongThang: Bảng tổng hợp lương cuối cùng của kỳ, dùng để xuất phiếu lương (payslip).
CREATE TABLE BangLuongThang (
    MaBangLuong VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    Thang INT,
    Nam INT,
    SoNgayCongThucTe DECIMAL(4,1),
    LuongCoBan DECIMAL(18,2), 
    TongTienPhuCap DECIMAL(18,2),
    TongTienThuong DECIMAL(18,2),
    TongTienPhat DECIMAL(18,2),
    KhauTruBHXH DECIMAL(18,2),
    ThueTNCN DECIMAL(18,2),
    ThucLanh DECIMAL(18,2), 
    TrangThaiThanhToan NVARCHAR(50), 
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- Bảng TaiKhoan: Quản lý user/password để nhân viên đăng nhập vào hệ thống phần mềm HR.
CREATE TABLE TaiKhoan (
    TenDangNhap VARCHAR(50) PRIMARY KEY,
    MaNhanVien VARCHAR(20) UNIQUE NOT NULL, 
    MatKhau VARCHAR(255) NOT NULL, 
    MaNhomQuyen VARCHAR(20),
    TrangThaiHoatDong BIT DEFAULT 1, 
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (MaNhomQuyen) REFERENCES NhomQuyen(MaNhomQuyen)
);

-- Bảng NhatKyHoatDong: Ghi lại log các thao tác (thêm, sửa, xóa) của người dùng nhằm mục đích kiểm toán bảo mật.
CREATE TABLE NhatKyHoatDong (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap VARCHAR(50),
    ThoiGian DATETIME DEFAULT GETDATE(),
    HanhDong NVARCHAR(100), 
    ChiTiet NVARCHAR(MAX),  
    IPAddress VARCHAR(50),
    FOREIGN KEY (TenDangNhap) REFERENCES TaiKhoan(TenDangNhap)
);

-- Bảng QuyetDinhNghiViec: Lưu quyết định nghỉ việc, sa thải và theo dõi tiến độ bàn giao.
CREATE TABLE QuyetDinhNghiViec (
    MaQuyetDinh VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    NgayNopDon DATE,
    NgayNghiChinhThuc DATE,
    LyDoNghi NVARCHAR(500),
    TrangThaiBanGiao NVARCHAR(50), 
    NguoiDuyet VARCHAR(20),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- Bảng ChiTietBanGiao: Các đầu việc, hồ sơ, máy móc cần trả lại/bàn giao lại trước khi nhân viên out.
CREATE TABLE ChiTietBanGiao (
    MaBanGiao VARCHAR(20) PRIMARY KEY,
    MaQuyetDinh VARCHAR(20),
    HangMucBanGiao NVARCHAR(200), 
    NguoiNhanBanGiao VARCHAR(20), 
    TrangThai NVARCHAR(50), 
    GhiChu NVARCHAR(255),
    FOREIGN KEY (MaQuyetDinh) REFERENCES QuyetDinhNghiViec(MaQuyetDinh),
    FOREIGN KEY (NguoiNhanBanGiao) REFERENCES NhanVien(MaNhanVien)
);

-- Bảng HoSoCongTac: Quản lý các chuyến công tác, công lệnh và chi phí công tác phí dự kiến.
CREATE TABLE HoSoCongTac (
    MaCongTac VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    DiaDiem NVARCHAR(200),
    TuNgay DATE,
    DenNgay DATE,
    MucDich NVARCHAR(500),
    ChiPhiDuKien DECIMAL(18,2),
    TrangThaiDuyet NVARCHAR(50),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- Bảng TamUng: Quản lý các khoản tiền nhân viên xin tạm ứng và ghi nhận tháng/năm sẽ trừ vào lương.
CREATE TABLE TamUng (
    MaTamUng VARCHAR(20) PRIMARY KEY,
    MaNhanVien VARCHAR(20),
    NgayTamUng DATE,
    LyDo NVARCHAR(255),
    SoTien DECIMAL(18,2),
    TrangThaiHoanUng NVARCHAR(50), 
    ThangKhauTru INT, 
    NamKhauTru INT,
    NguoiDuyet VARCHAR(20),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- =====================================================================
-- BƯỚC CUỐI CÙNG: MỞ KẾT NỐI VÒNG (CIRCULAR REFERENCE)
-- =====================================================================
-- Cập nhật bảng Phòng Ban: Bảng Nhân Viên đã được tạo nên bây giờ ta có thể ép ràng buộc 
-- cột MaTruongPhong trong bảng PhongBan phải tham chiếu đến MaNhanVien của bảng NhanVien.
ALTER TABLE PhongBan
ADD CONSTRAINT FK_PhongBan_TruongPhong 
FOREIGN KEY (MaTruongPhong) REFERENCES NhanVien(MaNhanVien);