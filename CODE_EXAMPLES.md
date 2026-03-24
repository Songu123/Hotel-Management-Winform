# Code Examples - Hệ Thống Quản Lý Khách Sạn

## 1. Sử Dụng RoomService

### Lấy tất cả phòng
```csharp
private readonly IRoomService _roomService;

// Trong event handler hoặc method
var allRooms = await _roomService.GetAllRoomsAsync();
foreach (var room in allRooms)
{
    Console.WriteLine($"Phòng {room.RoomNumber} - Trạng thái: {room.Status}");
}
```

### Thêm phòng mới
```csharp
var newRoom = new Room
{
    RoomNumber = "301",
    RoomTypeId = 1, // Suite
    Status = RoomStatus.Available,
    Notes = "Phòng mới đẹp lắm"
};

var createdRoom = await _roomService.CreateRoomAsync(newRoom);
MessageBox.Show($"Thêm phòng {createdRoom.RoomNumber} thành công!");
```

### Tìm kiếm và lọc phòng
```csharp
// Tìm phòng Suite đang trống
var availableSuites = await _roomService.SearchAndFilterRoomsAsync(
    searchTerm: "Suite",
    status: RoomStatus.Available,
    roomTypeId: null
);

// Cập nhật DataGridView
dgvRooms.Rows.Clear();
foreach (var room in availableSuites)
{
    dgvRooms.Rows.Add(room.RoomNumber, room.RoomType?.Name, room.Status);
}
```

### Cập nhật trạng thái phòng
```csharp
// Chuyển phòng sang trạng thái Đang ở
bool success = await _roomService.UpdateRoomStatusAsync(
    roomId: 1,
    newStatus: RoomStatus.Occupied
);

if (success)
    MessageBox.Show("Cập nhật trạng thái thành công!");
else
MessageBox.Show("Cập nhật thất bại!");
```

### Lấy thống kê phòng
```csharp
var statistics = await _roomService.GetRoomStatusStatisticsAsync();

foreach (var stat in statistics)
{
    Console.WriteLine($"{stat.Key}: {stat.Value} phòng");
}
// Output:
// Available: 15 phòng
// Occupied: 20 phòng
// Maintenance: 2 phòng
// Reserved: 8 phòng
```

## 2. Sử Dụng DashboardService

### Lấy dữ liệu dashboard toàn bộ
```csharp
private readonly IDashboardService _dashboardService;

private async void LoadDashboard()
{
    try
    {
        var dashboardData = await _dashboardService.GetDashboardDataAsync();
        
  // Cập nhật UI
   UpdateOccupancyCard(dashboardData.OccupancyRate);
    UpdateRevenueCard(dashboardData.Revenue);
     UpdateCheckInsCard(dashboardData.UpcomingCheckIns);
      UpdateRoomAvailabilityChart(dashboardData.RoomAvailability);
  }
    catch (Exception ex)
    {
        MessageBox.Show($"Lỗi: {ex.Message}");
    }
}
```

### Lấy tỷ lệ chiếm phòng
```csharp
var occupancyData = await _dashboardService.GetOccupancyRateAsync();

lblOccupancyRate.Text = $"{occupancyData.OccupancyPercentage}%";
lblOccupancyDescription.Text = occupancyData.Description;
// Output: "45 rooms occupied out of 100"
```

### Lấy doanh thu hôm nay
```csharp
var revenueData = await _dashboardService.GetDailyRevenueAsync();

lblTodayRevenue.Text = revenueData.FormattedDaily;   // $12,500.00
lblAverageRevenue.Text = revenueData.FormattedAverage; // $178.57
```

### Lấy danh sách booking gần đây
```csharp
var recentBookings = await _dashboardService.GetRecentBookingsAsync(daysAhead: 7);

dgvRecentBookings.Rows.Clear();
foreach (var booking in recentBookings)
{
    dgvRecentBookings.Rows.Add(
        booking.GuestName,
        booking.RoomNumber,
        booking.DateRange,
        booking.Status,
     booking.Amount
  );
}
```

## 3. Dependency Injection Setup

### Program.cs
```csharp
using Microsoft.Extensions.DependencyInjection;
using QuanLyKhachSan.Configuration;
using QuanLyKhachSan.UI;

namespace QuanLyKhachSan
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Cấu hình Dependency Injection
            var services = new ServiceCollection();
            
    string connectionString = "Server=.;Database=HotelManagement;Trusted_Connection=True;";
       services.AddHotelManagementServices(connectionString);
            services.AddScoped<MainForm>();
 services.AddScoped<RoomManagementForm>();
            
            var serviceProvider = services.BuildServiceProvider();
      
   // Khởi tạo database
            ServiceCollectionExtensions.InitializeDatabaseAsync(serviceProvider).Wait();
      
            // Start application
            ApplicationConfiguration.Initialize();
            var mainForm = ActivatorUtilities.CreateInstance<MainForm>(serviceProvider);
            Application.Run(mainForm);
        }
    }
}
```

## 4. Binding Data to DataGridView

### Bind Room Data
```csharp
private async void BindRoomData(DataGridView dgv)
{
    try
    {
        var rooms = await _roomService.GetAllRoomsAsync();
     dgv.Rows.Clear();
        
        foreach (var room in rooms)
        {
            dgv.Rows.Add(
room.RoomId,
      room.RoomNumber,
   room.RoomType?.Name ?? "N/A",
     GetStatusDisplay(room.Status),
 room.RoomType?.PricePerNight.ToString("N0") ?? "0",
    room.Notes
            );
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Lỗi: {ex.Message}");
    }
}

private string GetStatusDisplay(RoomStatus status)
{
    return status switch
    {
RoomStatus.Available => "Trống",
        RoomStatus.Occupied => "Đang ở",
        RoomStatus.Reserved => "Đã đặt",
      RoomStatus.Maintenance => "Bảo trì",
RoomStatus.OutOfService => "Không sử dụng",
   _ => "Không xác định"
  };
}
```

### Bind với Filter
```csharp
private async void FilterAndBindData(string searchTerm, RoomStatus? status)
{
    try
    {
    var filteredRooms = await _roomService.SearchAndFilterRoomsAsync(
 searchTerm,
            status,
   roomTypeId: null
        );
     
        dgvRooms.Rows.Clear();
        foreach (var room in filteredRooms)
        {
            // Thêm vào grid
            dgvRooms.Rows.Add(room.RoomId, room.RoomNumber, ...);
        }
     
        lblResultCount.Text = $"Tìm thấy {filteredRooms.Count()} kết quả";
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Lỗi: {ex.Message}");
    }
}
```

## 5. Event Handlers

### TextBox Search Changed
```csharp
private async void tbSearch_TextChanged(object sender, EventArgs e)
{
    string searchTerm = tbSearch.Text;
    RoomStatus? status = GetSelectedStatus();
    
    await FilterAndBindData(searchTerm, status);
}

private RoomStatus? GetSelectedStatus()
{
  string selectedStatus = cbStatus.SelectedItem?.ToString();
    return selectedStatus switch
    {
 "Trống" => RoomStatus.Available,
    "Đang ở" => RoomStatus.Occupied,
        "Đã đặt" => RoomStatus.Reserved,
        "Bảo trì" => RoomStatus.Maintenance,
        _ => null
    };
}
```

### Button Click - Add Room
```csharp
private void btnAddRoom_Click(object sender, EventArgs e)
{
    var addForm = new RoomDetailForm(null, _roomTypes);
    
if (addForm.ShowDialog() == DialogResult.OK)
    {
      try
        {
     var newRoom = addForm.GetRoom();
  var created = await _roomService.CreateRoomAsync(newRoom);
          
            MessageBox.Show("Thêm phòng thành công!");
            await BindRoomData(dgvRooms); // Refresh data
        }
     catch (Exception ex)
        {
            MessageBox.Show($"Lỗi: {ex.Message}");
        }
    }
}
```

### DataGridView Cell Click - Edit/Delete
```csharp
private async void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
{
    if (e.RowIndex < 0) return;
    
    int roomId = (int)dgvRooms.Rows[e.RowIndex].Cells[0].Value;
  int columnIndex = e.ColumnIndex;

    // Edit button (column 7)
    if (columnIndex == 7)
 {
   await EditRoom(roomId);
    }
    // Delete button (column 8)
    else if (columnIndex == 8)
    {
        if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", 
       MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
    await DeleteRoom(roomId);
        }
    }
}

private async Task EditRoom(int roomId)
{
  var room = await _roomService.GetRoomAsync(roomId);
    if (room == null)
    {
        MessageBox.Show("Không tìm thấy phòng!");
        return;
    }
    
    var editForm = new RoomDetailForm(room, _roomTypes);
    if (editForm.ShowDialog() == DialogResult.OK)
    {
        var updated = editForm.GetRoom();
        await _roomService.UpdateRoomAsync(updated);
 
        MessageBox.Show("Cập nhật thành công!");
        await BindRoomData(dgvRooms);
    }
}

private async Task DeleteRoom(int roomId)
{
    bool success = await _roomService.DeleteRoomAsync(roomId);
    
    if (success)
    {
   MessageBox.Show("Xóa phòng thành công!");
        await BindRoomData(dgvRooms);
    }
    else
  {
        MessageBox.Show("Không thể xóa phòng có booking hoạt động!");
    }
}
```

## 6. Async/Await Pattern

### Best Practice
```csharp
// ❌ BAD - Synchronous in UI thread
private void LoadData()
{
    var rooms = _roomService.GetAllRoomsAsync().Result; // Blocks UI!
}

// ✅ GOOD - Asynchronous
private async void LoadData()
{
    var rooms = await _roomService.GetAllRoomsAsync(); // Non-blocking
}

// ✅ BETTER - With error handling
private async void LoadData()
{
    try
    {
        var rooms = await _roomService.GetAllRoomsAsync();
        BindDataToGrid(rooms);
    }
catch (Exception ex)
    {
        MessageBox.Show($"Error: {ex.Message}");
      // Log error
    }
}
```

## 7. Custom Dialog Forms

### RoomDetailForm Usage
```csharp
// Thêm phòng mới
var addForm = new RoomDetailForm(null, _roomTypes.ToList());
if (addForm.ShowDialog() == DialogResult.OK)
{
    var room = addForm.GetRoom();
    await _roomService.CreateRoomAsync(room);
}

// Sửa phòng
var room = await _roomService.GetRoomAsync(roomId);
var editForm = new RoomDetailForm(room, _roomTypes.ToList());
if (editForm.ShowDialog() == DialogResult.OK)
{
    var updated = editForm.GetRoom();
    await _roomService.UpdateRoomAsync(updated);
}
```

## 8. Error Handling

### Try-Catch Best Practice
```csharp
try
{
    var rooms = await _roomService.GetAllRoomsAsync();
    BindRoomData(rooms);
}
catch (ArgumentException argEx)
{
    MessageBox.Show($"Invalid argument: {argEx.Message}", "Error");
}
catch (InvalidOperationException opEx)
{
    MessageBox.Show($"Operation error: {opEx.Message}", "Error");
}
catch (Exception ex)
{
    MessageBox.Show($"Unexpected error: {ex.Message}", "Error");
    // Log to file or database
}
finally
{
    // Cleanup resources
}
```

---

**Note:** Tất cả examples này sử dụng async/await pattern và follow best practices cho .NET 8 WinForms applications.
