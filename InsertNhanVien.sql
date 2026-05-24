USE QuanLyNhanSu;
GO

-- =====================================================================
-- BƯỚC 1: THÊM DỮ LIỆU DANH MỤC (BẮT BUỘC ĐỂ TRÁNH LỖI KHÓA NGOẠI)
-- =====================================================================

-- Thêm chi nhánh
IF NOT EXISTS (SELECT 1 FROM ChiNhanh WHERE MaChiNhanh = 'CN01')
    INSERT INTO ChiNhanh (MaChiNhanh, TenChiNhanh, DiaChi) 
    VALUES ('CN01', N'Trụ sở chính TDC', N'Thủ Đức, TP.HCM');

-- Thêm phòng ban
IF NOT EXISTS (SELECT 1 FROM PhongBan WHERE MaPhongBan = 'PB01')
BEGIN
    INSERT INTO PhongBan (MaPhongBan, MaChiNhanh, TenPhongBan) VALUES ('PB01', 'CN01', N'Phòng Kỹ thuật phần mềm');
    INSERT INTO PhongBan (MaPhongBan, MaChiNhanh, TenPhongBan) VALUES ('PB02', 'CN01', N'Phòng Nhân sự');
END

-- Thêm chức danh
IF NOT EXISTS (SELECT 1 FROM ChucDanh WHERE MaChucDanh = 'CD01')
BEGIN
    INSERT INTO ChucDanh (MaChucDanh, TenChucDanh, CapBac) VALUES ('CD01', N'Thực tập sinh', N'Nhân viên');
    INSERT INTO ChucDanh (MaChucDanh, TenChucDanh, CapBac) VALUES ('CD02', N'Lập trình viên', N'Nhân viên');
    INSERT INTO ChucDanh (MaChucDanh, TenChucDanh, CapBac) VALUES ('CD03', N'Trưởng phòng', N'Quản lý');
END

-- =====================================================================
-- BƯỚC 2: TẠO 100 NHÂN VIÊN BẰNG VÒNG LẶP WHILE
-- =====================================================================
DECLARE @i INT = 1;
DECLARE @MaNV VARCHAR(20);
DECLARE @HoTen NVARCHAR(100);
DECLARE @GioiTinh NVARCHAR(10);
DECLARE @NgaySinh DATE;
DECLARE @MaPB VARCHAR(20);
DECLARE @MaCD VARCHAR(20);

-- Xóa dữ liệu cũ nếu muốn chạy lại nhiều lần (Tùy chọn)
-- DELETE FROM NhanVien WHERE MaNhanVien LIKE 'NV%';

WHILE @i <= 100
BEGIN
    -- 1. Định dạng mã nhân viên: NV001, NV002,... đến NV100
    SET @MaNV = 'NV' + RIGHT('000' + CAST(@i AS VARCHAR(3)), 3);

    -- 2. Đặt tên nhân viên có đánh số để dễ phân biệt khi test
    SET @HoTen = N'Nhân viên Test số ' + CAST(@i AS NVARCHAR(10));

    -- 3. Đan xen giới tính
    SET @GioiTinh = CASE WHEN @i % 2 = 0 THEN N'Nam' ELSE N'Nữ' END;

    -- 4. Random ngày sinh (Tuổi dao động từ khoảng 20 - 30)
    SET @NgaySinh = DATEADD(DAY, - (ROUND(RAND(CHECKSUM(NEWID())) * (3650), 0) + 7300), GETDATE());

    -- 5. Phân bổ phòng ban và chức danh xen kẽ
    SET @MaPB = CASE WHEN @i % 3 = 0 THEN 'PB02' ELSE 'PB01' END;
    SET @MaCD = CASE 
                    WHEN @i % 10 = 0 THEN 'CD03' -- Cứ 10 người thì có 1 Trưởng phòng
                    WHEN @i % 2 = 0 THEN 'CD02'  -- Lập trình viên
                    ELSE 'CD01'                  -- Thực tập sinh
                END;

    -- Kiểm tra xem nhân viên đã tồn tại chưa để tránh lỗi Primary Key
    IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaNhanVien = @MaNV)
    BEGIN
        -- Insert vào bảng NhanVien với trạng thái mặc định
        INSERT INTO NhanVien (MaNhanVien, HoTen, GioiTinh, NgaySinh, MaPhongBan, MaChucDanh, TrangThaiLamViec)
        VALUES (@MaNV, @HoTen, @GioiTinh, @NgaySinh, @MaPB, @MaCD, N'Đang làm việc');
    END

    SET @i = @i + 1;
END;

PRINT N'Đã chèn xong 100 nhân viên vào CSDL!';
GO