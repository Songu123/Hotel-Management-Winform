/*
 * DEMO: Cách Sử Dụng Tính Năng Dọn Dẹp Phòng
 * 
 * Dòng chảy xử lý dọn dẹp phòng:
 */

// 1. Người dùng nhấp chuột phải vào phòng
// 2. Chọn "Dọn phòng" từ context menu
// 3. ModernRoomCard.cs gọi: OnCleanRoom_Click()
// 4. Điều này gọi: _roomCardContainer.OnCleaningClicked(room)
// 5. Kích hoạt: UCBooking.OnCleanRoom(sender, room)

// ===== BẮT ĐẦU XỬ LÝ =====

// Trong UCBooking.OnCleanRoom():
private async void OnCleanRoom(object sender, Room room)
{
    _selectedRoom = room;
    try
    {
   // 1️⃣ KIỂM TRA TRẠNG THÁI PHÒNG
        if (room.Status == 2) // Đang dọn
        {
 MessageBox.Show($"Phòng {room.Name} đang được dọn dẹp!");
      return;
        }

     if (room.Status == 3) // Bảo trì
  {
       MessageBox.Show($"Phòng {room.Name} đang bảo trì!");
      return;
      }

        // 2️⃣ MỞ FORM DỌN DẸP ĐƠN GIẢN
        var cleaningForm = new SimpleRoomCleaningForm(room);
        // Form này chứa:
        //   - Thông tin phòng
        //   - ComboBox chọn tình trạng (Tốt / Cần sửa / Cần vệ sinh)
        //- TextBox ghi chú
      //   - Nút "Dọn phòng" & "Hủy"

 var result = cleaningForm.ShowDialog();

        // 3️⃣ KIỂM TRA KẾT QUẢ
        if (result == DialogResult.OK)
        {
    // 4️⃣ CẬP NHẬT DỮ LIỆU PHÒNG
       room.Status = 0; // Chuyển về "Sẵn sàng"
         room.CurrentCondition = GetConditionValue(cleaningForm.GetCondition());
       // GetConditionValue(): Chuyển "Tốt" -> 0, "Cần sửa chữa" -> 1, v.v.

        // 5️⃣ LƯU VÀO DATABASE
 await _roomService.UpdateRoomAsync(room);
 // Gọi: IRoomService.UpdateRoomAsync(room)

      // 6️⃣ CẬP NHẬT GIAO DIỆN
            _roomCardContainer.UpdateRoomStatus(room.RoomId, RoomStatusType.Available);
     // Thay đổi màu thẻ phòng trên UI

            // 7️⃣ HIỂN THỊ THÔNG BÁO
  MessageBox.Show("✓ Dọn phòng thành công", "Thành công");

            // 8️⃣ TẢI LẠI DANH SÁCH PHÒNG
   await Task.Delay(500);
 LoadRoomsAsync(); // Làm mới dữ liệu từ database
        }
  }
    catch (Exception ex)
    {
     MessageBox.Show($"Lỗi: {ex.Message}");
    }
}

// ===== HELPER METHOD =====
private int GetConditionValue(string condition)
{
    return condition switch
    {
        "Tốt" => 0,
        "Cần sửa chữa" => 1,
    "Cần vệ sinh" => 2,
        _ => 0
    };
}

// ===== TIMELINE CỤ THỂ =====

/*
 * Ví dụ: Dọn phòng P101
 * 
 * 1. [TRƯỚC KHI DỌN]
 *    Room.Status = 0 (Sẵn sàng) hoặc 1 (Đang sử dụng)
 *    Room.CurrentCondition = ? (Bất kỳ)
 * 
 * 2. [NGƯỜI DÙNG CHỌN DỌN PHÒNG]
 *    SimpleRoomCleaningForm mở ra
 *    Hiển thị: Phòng P101, Giá: 150,000 VNĐ
 * 
 * 3. [NGƯỜI DÙNG ĐIỀN THÔNG TIN]
 *    Chọn: "Tốt"
 *Ghi chú: "Phòng sạch sẽ, mọi thứ OK"
 *    Nhấp: "Dọn phòng"
 * 
 * 4. [BACKEND XỬ LÝ]
 *    - room.Status = 0 (Sẵn sàng)
 *    - room.CurrentCondition = 0 (Tốt)
 *    - Gọi: await _roomService.UpdateRoomAsync(room)
 * 
 * 5. [DATABASE CẬP NHẬT]
 *    UPDATE PHONG SET tinhTrang=0, hienTrang=0 WHERE maP='P101'
 * 
 * 6. [GIAO DIỆN CẬP NHẬT]
 *    Thẻ phòng P101 đổi màu xanh (Available)
 * 
 * 7. [HIỂN THỊ THÔNG BÁO]
 *    "✓ Dọn phòng thành công"
 * 
 * 8. [TẢI LẠI DỮ LIỆU]
 *  LoadRoomsAsync() lấy lại danh sách từ database
 */

// ===== CÁC TRANG THÁI PHÒNG =====

/*
 * Status = 0: Sẵn sàng ✅
 *   - Có thể đặt phòng
 *   - Có thể dọn phòng (làm mới)
 * 
 * Status = 1: Đang sử dụng 👥
 *   - Khách đang ở phòng
 *   - Có thể dọn phòng (khi khách check out)
 * 
 * Status = 2: Đang dọn 🧹
 *   - Không thể dọn lại
 * - Không thể đặt phòng
 * 
 * Status = 3: Bảo trì 🔧
 *   - Không thể dọn
 *   - Không thể đặt phòng
 */

// ===== TÌNH TRẠNG PHÒNG (CurrentCondition) =====

/*
 * 0: Tốt 👍
 * 1: Cần sửa chữa 🔨
 * 2: Cần vệ sinh 🧽
 */

// ===== FILES LIÊN QUAN =====

/*
 * 1. QuanLyKhachSan/UI/BookingUI/SimpleRoomCleaningForm.cs
 *    ↳ Form dọn dẹp đơn giản
 * 
 * 2. QuanLyKhachSan/UI/BookingUI/UCBooking.cs
 *    ↳ Main UserControl, chứa OnCleanRoom() method
 * 
 * 3. QuanLyKhachSan/Models/Room.cs
 *    ↳ Chứa Status và CurrentCondition property
 * 
 * 4. QuanLyKhachSan/Services/Interfaces/IRoomService.cs
 *    ↳ Chứa UpdateRoomAsync() method
 * 
 * 5. QuanLyKhachSan/UI/ModernRoomCard.cs
 *    ↳ Thẻ phòng hiển thị, có context menu "Dọn phòng"
 */

// ===== CÓ THỂ MỞ RỘNG =====

/*
 * Nếu muốn thêm tính năng sau:
 * 
 * 1. Lưu lịch sử dọn phòng
 *    - Thêm tham số: employeeId (nhân viên dọn)
 *    - Thêm tham số: startTime, endTime (thời gian dọn)
 *    - Lưu vào bảng: ROOM_CLEANING_HISTORY
 * 
 * 2. Gán nhân viên dọn phòng
 *    - Thêm ComboBox chọn nhân viên vào form
 *    - Lưu thông tin nhân viên
 * 
 * 3. Báo cáo dọn phòng
 *    - Tính số phòng dọn/ngày
 *    - Hiệu suất dọn phòng
 *    - Báo cáo theo nhân viên
 * 
 * 4. Thông báo tự động
 *    - Khi phòng occupied, tự động nôi phòng cần dọn
 *    - Gửi notification cho nhân viên dọn
 */
