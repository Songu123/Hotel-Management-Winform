# Hướng Dẫn Quản Lý Phòng - Hotel Management System

## Tính Năng Chính

### 1. **Xem Danh Sách Phòng**
- Hiển thị tất cả phòng trong khách sạn
- Bảng dữ liệu hiển thị các thông tin:
  - Số phòng
  - Loại phòng
  - Trạng thái hiện tại
  - Giá thuê/đêm
  - Sức chứa
  - Ghi chú

### 2. **Thêm Phòng Mới**
- Nhấn nút **"+ THÊM PHÒNG MỚI"** ở góc phải trên
- Nhập các thông tin:
  - **Số phòng**: Mã định danh duy nhất (VD: 101, 202)
  - **Loại phòng**: Chọn từ dropdown (Phòng Đơn, Phòng Đôi, Suite Deluxe)
  - **Trạng thái**: Mặc định là "Trống"
  - **Ghi chú**: Thêm bất kỳ ghi chú nào (tùy chọn)
- Nhấn **"Lưu"** để tạo phòng mới

### 3. **Sửa Thông Tin Phòng**
- Nhấn nút **"Sửa"** ở cột cuối cùng của hàng cần chỉnh sửa
- Cập nhật các thông tin cần thiết
- Nhấn **"Lưu"** để hoàn tất

### 4. **Xóa Phòng**
- Nhấn nút **"Xóa"** ở cột cuối cùng của hàng cần xóa
- Xác nhận lệnh xóa
- **Lưu ý**: Không thể xóa phòng có booking hoạt động

### 5. **Tìm Kiếm Phòng**
Sử dụng thanh tìm kiếm ở khu vực **"Tìm kiếm"**:
- Nhập số phòng (VD: 101) để tìm phòng cụ thể
- Nhập tên loại phòng (VD: Suite) để tìm theo loại
- Tìm kiếm **real-time** - kết quả cập nhật khi gõ

**Ví dụ:**
- Tìm "101" → hiển thị phòng số 101
- Tìm "Suite" → hiển thị tất cả phòng loại Suite

### 6. **Lọc Theo Trạng Thái**
Sử dụng dropdown **"Trạng thái"** để lọc phòng:

- **Tất cả**: Hiển thị tất cả phòng
- **Trống** (Available): Phòng sẵn sàng để thuê
- **Đã đặt** (Reserved): Phòng đã được đặt trước
- **Có người ở** (Occupied): Phòng đang có khách thuê
- **Bảo trì** (Maintenance): Phòng đang được sửa chữa/dọn dẹp
- **Không sử dụng** (OutOfService): Phòng tạm thời không sử dụng

### 7. **Lọc Theo Loại Phòng**
Sử dụng dropdown **"Loại phòng"** để lọc:
- **Tất cả loại phòng**: Hiển thị tất cả
- **Phòng Đơn**: Phòng ngủ cho 1 người (500,000đ/đêm)
- **Phòng Đôi**: Phòng ngủ cho 2 người (750,000đ/đêm)
- **Suite Deluxe**: Phòng cao cấp cho 4 người (1,500,000đ/đêm)

### 8. **Kết Hợp Tìm Kiếm và Lọc**
Bạn có thể kết hợp nhiều tiêu chí cùng lúc:
- Tìm số phòng + Lọc theo trạng thái
- Tìm loại phòng + Lọc theo trạng thái
- Lọc theo trạng thái + Lọc theo loại phòng
- **Ví dụ**: Tìm "Suite" + Lọc trạng thái "Trống" → hiển thị các phòng Suite đang trống

## Trạng Thái Phòng Chi Tiết

| Trạng Thái | Mô Tả | Có Thể Thực Hiện |
|-----------|-------|-----------------|
| **Trống** (Available) | Phòng sẵn sàng cho khách đặt | Tạo booking mới |
| **Đã đặt** (Reserved) | Khách đã đặt nhưng chưa check-in | Check-in |
| **Có người ở** (Occupied) | Khách đang ở phòng | Check-out, Dọn phòng |
| **Bảo trì** (Maintenance) | Phòng đang được bảo trì/dọn | Cập nhật trạng thái khi hoàn thành |
| **Không sử dụng** (OutOfService) | Phòng tạm thời không sử dụng | Kích hoạt lại khi sẵn sàng |

## Quy Trình Thông Thường

### 1. **Tạo Phòng Mới**
```
Thêm Phòng → Chọn Loại → Gán Trạng Thái = Trống → Lưu
```

### 2. **Chuẩn Bị Cho Khách**
```
Xem Phòng Trống → Cập Nhật Trạng Thái → Sẵn Sàng Cho Booking
```

### 3. **Sau Check-out**
```
Phòng Có Người Ở → Chuyển Thành Trống → Dọn Phòng Xong
```

### 4. **Bảo Trì Phòng**
```
Cập Nhật Trạng Thái = Bảo Trì → Hoàn Thành → Trở Thành Trống
```

## Lưu Ý Quan Trọng

1. **Không thể xóa phòng** nếu có booking hoạt động
2. **Số phòng phải duy nhất** - không được trùng lặp
3. **Loại phòng là bắt buộc** - phải chọn từ dropdown
4. Tìm kiếm **không phân biệt hoa/thường**
5. Mọi thay đổi được **lưu trực tiếp** vào cơ sở dữ liệu

## Ví Dụ Thực Tế

### Ví Dụ 1: Tìm Phòng Suite Có Sẵn
1. Nhập "Suite" trong ô tìm kiếm
2. Chọn "Trống" trong dropdown Trạng thái
3. Kết quả: Tất cả phòng Suite đang trống

### Ví Dụ 2: Kiểm Tra Phòng Đang Bảo Trì
1. Chọn "Bảo trì" trong dropdown Trạng thái
2. Kết quả: Tất cả phòng đang bảo trì (không cần tìm kiếm)

### Ví Dụ 3: Xóa Phòng Cũ
1. Tìm kiếm phòng cần xóa
2. Kiểm tra nó không có booking hoạt động
3. Nhấn nút "Xóa" và xác nhận
4. Phòng sẽ bị xóa khỏi hệ thống

## Hỗ Trợ Thêm

- Nếu gặp lỗi, hãy kiểm tra kết nối cơ sở dữ liệu
- Mọi thao tác được ghi log trong hệ thống
- Liên hệ bộ phận IT nếu cần hỗ trợ thêm
