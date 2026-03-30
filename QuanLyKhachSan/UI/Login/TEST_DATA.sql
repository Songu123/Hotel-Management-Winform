-- ===== SAMPLE LOGIN DATA FOR TESTING =====
-- Chạy script này để thêm dữ liệu test vào database

-- 1. Thêm nhân viên test
INSERT INTO NHANVIEN (maNV, tenNV, gioiTinh, soNgayPhep, chucVu, ngaySinh, ngayVaoLam, email, luong1Ngay, xuLy)
VALUES 
    ('NV001', 'Admin User', 1, 12, 1, '1990-01-01', '2023-01-01', 'admin@hotel.com', 500000, 0),
    ('NV002', 'Manager', 1, 12, 2, '1992-03-15', '2023-06-01', 'manager@hotel.com', 400000, 0),
    ('NV003', 'Staff', 0, 12, 3, '1995-07-20', '2024-01-01', 'staff@hotel.com', 300000, 0);

-- 2. Thêm quyền hạn test
INSERT INTO PHANQUYEN (maPQ, tenPQ)
VALUES 
    ('PQ001', 'Admin'),
    ('PQ002', 'Manager'),
    ('PQ003', 'Staff');
-- 3. Thêm tài khoản test
INSERT INTO TAIKHOAN (taiKhoan, maNV, matKhau, tinhTrang, maPQ, xuLy)
VALUES 
    ('admin', 'NV001', '123456', 0, 'PQ001', 0),
    ('manager', 'NV002', '123456', 0, 'PQ002', 0),
    ('staff', 'NV003', '123456', 0, 'PQ003', 0),
 ('disabled_user', 'NV003', '123456', 1, 'PQ003', 0),  -- Tài khoản bị vô hiệu hóa
    ('deleted_user', 'NV003', '123456', 0, 'PQ003', 1);   -- Tài khoản bị xóa mềm

-- ===== TEST CREDENTIALS =====
-- Username: admin     | Password: 123456 | Role: Admin    | Status: Active
-- Username: manager   | Password: 123456 | Role: Manager  | Status: Active
-- Username: staff     | Password: 123456 | Role: Staff    | Status: Active
-- Username: disabled_user  | Password: 123456 | Role: Staff | Status: Inactive (sẽ không thể đăng nhập)
-- Username: deleted_user   | Password: 123456 | Role: Staff | Status: Deleted (sẽ không thể đăng nhập)

-- ===== VERIFICATION =====
-- Kiểm tra dữ liệu nhân viên
SELECT * FROM NHANVIEN WHERE xuLy = 0 ORDER BY maNV;

-- Kiểm tra dữ liệu tài khoản
SELECT taiKhoan, maNV, matKhau, tinhTrang, maPQ, xuLy FROM TAIKHOAN;

-- Kiểm tra dữ liệu quyền hạn
SELECT * FROM PHANQUYEN;

-- ===== CLEANUP (Nếu muốn xóa dữ liệu test) =====
-- DELETE FROM TAIKHOAN WHERE taiKhoan IN ('admin', 'manager', 'staff', 'disabled_user', 'deleted_user');
-- DELETE FROM PHANQUYEN WHERE maPQ IN ('PQ001', 'PQ002', 'PQ003');
-- DELETE FROM NHANVIEN WHERE maNV IN ('NV001', 'NV002', 'NV003');
