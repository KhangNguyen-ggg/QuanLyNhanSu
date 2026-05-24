USE QuanLyNhanSu;
GO

-- 1. Thêm Chi nhánh
INSERT INTO ChiNhanh (MaChiNhanh, TenChiNhanh, DiaChi, Hotline, MaNguoiDungDau)
VALUES 
('CN01', N'Trụ sở chính HCM', N'Quận 1, TP.HCM', '0901234567', NULL),
('CN02', N'Chi nhánh Hà Nội', N'Cầu Giấy, Hà Nội', '0909876543', NULL);

-- 2. Thêm Chức danh
INSERT INTO ChucDanh (MaChucDanh, TenChucDanh, CapBac)
VALUES 
('CD01', N'Giám đốc', N'Quản lý cấp cao'),
('CD02', N'Trưởng phòng', N'Quản lý'),
('CD03', N'Nhân viên', N'Nhân viên'),
('CD04', N'Thực tập sinh', N'Thực tập sinh');

-- 3. Thêm Phòng ban (Tạm để MaTruongPhong = NULL)
INSERT INTO PhongBan (MaPhongBan, MaChiNhanh, TenPhongBan, MaPhongBanCha, MaTruongPhong)
VALUES 
('PB01', 'CN01', N'Phòng Nhân sự', NULL, NULL),
('PB02', 'CN01', N'Phòng IT', NULL, NULL),
('PB03', 'CN02', N'Phòng Kế toán', NULL, NULL);

-- 4. Thêm 10 Nhân viên
INSERT INTO NhanVien (MaNhanVien, HoTen, GioiTinh, NgaySinh, MaPhongBan, MaChucDanh, TrangThaiLamViec)
VALUES 
('NV001', N'Nguyễn Văn An', N'Nam', '1990-05-15', 'PB01', 'CD02', N'Đang làm việc'),
('NV002', N'Trần Thị Bích', N'Nữ', '1995-08-20', 'PB01', 'CD03', N'Đang làm việc'),
('NV003', N'Lê Hoàng Cường', N'Nam', '1992-12-10', 'PB02', 'CD02', N'Đang làm việc'),
('NV004', N'Phạm Thị Dung', N'Nữ', '1998-03-25', 'PB02', 'CD03', N'Đang làm việc'),
('NV005', N'Hoàng Văn Em', N'Nam', '1997-07-30', 'PB02', 'CD03', N'Đang làm việc'),
('NV006', N'Đặng Thị Phương', N'Nữ', '1993-11-05', 'PB03', 'CD02', N'Đang làm việc'),
('NV007', N'Bùi Xuân Hinh', N'Nam', '1985-02-14', 'PB01', 'CD01', N'Đang làm việc'),
('NV008', N'Ngô Thanh Hải', N'Nam', '2000-09-09', 'PB02', 'CD04', N'Đang làm việc'),
('NV009', N'Vũ Thị Lan', N'Nữ', '1996-06-18', 'PB03', 'CD03', N'Đang làm việc'),
('NV010', N'Đỗ Minh Trí', N'Nam', '1994-04-22', 'PB01', 'CD03', N'Đang làm việc');

-- 5. (Tùy chọn) Cập nhật lại Trưởng phòng cho Phòng ban
UPDATE PhongBan SET MaTruongPhong = 'NV001' WHERE MaPhongBan = 'PB01';
UPDATE PhongBan SET MaTruongPhong = 'NV003' WHERE MaPhongBan = 'PB02';
UPDATE PhongBan SET MaTruongPhong = 'NV006' WHERE MaPhongBan = 'PB03';
GO