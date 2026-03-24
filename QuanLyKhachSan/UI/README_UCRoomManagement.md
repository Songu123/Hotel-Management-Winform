# UCRoomManagement - Quản Lý Phòng

## Tổng Quan
`UCRoomManagement` là một User Control dùng để quản lý thông tin phòng trong hệ thống quản lý khách sạn. Nó cung cấp giao diện đầy đủ để xem, tìm kiếm, thêm, sửa và xóa thông tin phòng.

## Tính Năng Chính

### 1. **Hiển Thị Danh Sách Phòng**
- Hiển thị tất cả phòng trong bảng dữ liệu (DataGridView)
- Cột hiển thị: STT, Mã phòng, Tên phòng, Loại phòng, Giá phòng, Chi tiết loại phòng, Tình trạng, Hiện trạng

### 2. **Tìm Kiếm và Lọc**
Người dùng có thể lọc phòng theo các tiêu chí:
- **Mã phòng**: Tìm kiếm theo mã phòng (hỗ trợ tìm kiếm từng phần)
- **Tên phòng**: Tìm kiếm theo tên phòng (không phân biệt chữ hoa/thường)
- **Loại phòng**: Chọn loại phòng (Thường, VIP, Deluxe, Suite)
- **Chi tiết loại phòng**: Chọn từ danh sách (Phòng đơn, Phòng đôi, Phòng gia đình)
- **Giá phòng**: Lọc theo khoảng giá
  - Dưới 100,000 VND
  - 100,000 - 200,000 VND
  - 200,000 - 300,000 VND
  - Trên 300,000 VND
- **Tình trạng**: Chọn trạng thái phòng (Chưa dọn phòng, Trống, Đã đặt)
- **Hiện trạng**: Chọn tình trạng hiện tại (Mới, Tốt, Cần sửa chữa)

### 3. **Các Chức Năng CRUD**

#### **Thêm Phòng Mới** (Thêm phòng mới button)
- Click button để mở form thêm mới
- Nhập đầy đủ thông tin:
  - Mã phòng (bắt buộc)
  - Tên phòng (bắt buộc)
  - Loại phòng
  - Chi tiết loại phòng
  - Giá phòng (phải là số dương)
  - Tình trạng
  - Hiện trạng
- Click "Lưu" để lưu hoặc "Hủy" để hủy bỏ

#### **Chỉnh Sửa Phòng** (Sửa phòng button)
- Chọn phòng cần sửa từ bảng
- Click "Sửa phòng" để mở form chỉnh sửa
- Cập nhật thông tin cần thiết
- Click "Lưu" để lưu thay đổi

#### **Xóa Phòng** (Xem chi tiết button - hiện tại dùng để xóa)
- Chọn phòng cần xóa từ bảng
- Click button xóa
- Xác nhận thao tác xóa
- Phòng sẽ bị xóa khỏi hệ thống

#### **Làm Mới** (Làm mới button)
- Tải lại toàn bộ dữ liệu từ CSDL
- Xóa toàn bộ bộ lọc

### 4. **Cấu Trúc Giao Diện**
Giao diện được chia thành các phần:
1. **Header**: Tiêu đề "QUẢN LÝ PHÒNG" và mô tả chức năng
2. **Bộ lọc**: Các trường tìm kiếm và lọc
3. **Nút lệnh**: Thêm, sửa, xóa, làm mới
4. **Bảng dữ liệu**: Hiển thị danh sách phòng
5. **Form chỉnh sửa**: Hiển thị khi thêm/sửa (có thể ẩn/hiện)

## Cách Sử Dụng

### Khởi Tạo
```csharp
var roomService = serviceProvider.GetRequiredService<IRoomService>();
var ucRoomManagement = new UCRoomManagement(roomService);
parentContainer.Controls.Add(ucRoomManagement);
```

### Sự Kiện
- Tất cả thao tác tìm kiếm và lọc được thực hiện real-time khi người dùng thay đổi giá trị
- Form thêm/sửa hiển thị khi click các nút tương ứng

## Yêu Cầu
- IRoomService phải được inject vào constructor
- Model Room phải có đầy đủ các property: RoomId, Name, RoomType, RoomTypeDetails, Price, Status, CurrentCondition

## Ghi Chú
- Lọc được thực hiện trên dữ liệu trong bộ nhớ (in-memory), không gọi lại service
- Khi thêm/sửa thành công, dữ liệu sẽ được tải lại và hiển thị mới nhất
- Validation cơ bản cho form: mã phòng, tên phòng, giá phòng (phải > 0)
