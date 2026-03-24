# Hướng Dẫn MainForm Dashboard - Hotel Management System

## Tổng Quan

MainForm là trang dashboard chính của hệ thống quản lý khách sạn, cung cấp cái nhìn tổng quan về các metrics, thống kê, và quick links để quản lý khách sạn.

## Cấu Trúc Giao Diện

### 1. **Sidebar (Bên Trái)**
- **Logo Section**: Hiển thị logo "🏨 HOTEL" ở đầu
- **Menu Items**: 9 mục menu chính
  - Front Desk
  - Progress
  - Request Handling
  - Maintenance
  - Service Usage
  - Contacts
  - Payments
  - Restaurant
  - Rooms
- **Bottom Panel**: Nút Help và Logout

### 2. **Header (Phía Trên)**
- Tiêu đề: "Hotel Management"
- Subtitle: "Dashboard Overview"
- Chiều cao cố định 70px

### 3. **Content Area (Phần Nội Dung Chính)**

#### **Row 1: Metric Cards** (Chiều cao: 140px)
Hiển thị 4 thẻ thông tin chính:

```
┌─────────────────────────────────────────────────────────┐
│ Today's Income  │ Revenue Per Room │ Occupancy Rate │ No. Of Guests │
│    💰 │      💵   │       📊   │      👥       │
│  4335.00        │    216.75        │     30.00      │10    │
└─────────────────────────────────────────────────────────┘
```

**Đặc điểm:**
- Mỗi card có 1 accent bar ở trên
- Icon emoji + tiêu đề + giá trị lớn
- Màu sắc khác nhau cho mỗi card

#### **Row 2: Quick Links, Charts, Expected Today** (Chiều cao: 280px)

**Phần A: Quick Links Panel**
- Reserve button: 39 đơn
- Check In button: 11 đơn
- New Arrivals: Individuals (20), Corporates (5)

**Phần B: Room Status Distribution Chart**
- Bar chart hiển thị phân phối trạng thái phòng
  - Clean: 4
  - Dirty: 3
  - Maintenance: 2
  - Occupied: 11

**Phần C: Expected Today Panel**
- Yet To Check In: 2
- Yet To Check Out: 2
- Complaints: Raised (9), Closed (3)

#### **Row 3: Maintenance Overview** (Chiều cao: 250px)
Hiển thị 3 trạng thái bảo trì:
- Pending: 5
- In Progress: 3
- Completed: 12

## Màu Sắc Sử Dụng

```csharp
// Background
Color.FromArgb(245, 247, 250)  // Xám nhạt

// Sidebar
Color.FromArgb(30, 40, 60)     // Xanh đậm
Color.FromArgb(20, 30, 50)     // Xanh đậm hơn (header sidebar)

// Card Colors
Color.FromArgb(70, 130, 180)   // Xanh biển (Income, Pending)
Color.FromArgb(200, 140, 80)   // Cam (Revenue)
Color.FromArgb(80, 180, 100)   // Xanh lá (Occupancy)
Color.FromArgb(200, 100, 100)  // Đỏ (Guests)

// Text
Color.FromArgb(30, 40, 60)   // Xám tối (tiêu đề)
Color.Gray    // Xám nhạt
Color.LightGray          // Xám rất nhạt
```

## Cách Sử Dụng Code

### Mở Form MainForm từ Program.cs
```csharp
// Program.cs
var mainForm = ActivatorUtilities.CreateInstance<MainForm>(serviceProvider);
Application.Run(mainForm);
```

### Cập Nhật Metric Cards Động
```csharp
// Tìm card và cập nhật giá trị
var incomeCard = contentPanel.Controls.OfType<Panel>()
    .FirstOrDefault(p => /* logic tìm card */);

if (incomeCard != null)
{
    var valueLabel = incomeCard.Controls.OfType<Label>()
        .FirstOrDefault(l => l.Font.Size == 32);
    valueLabel.Text = "5000.00";// Cập nhật giá trị mới
}
```

### Xử Lý Menu Click
```csharp
private void OnMenuItemClick(string menuItem)
{
    switch (menuItem)
    {
      case "Rooms":
            // Mở form quản lý phòng
            var roomForm = ActivatorUtilities.CreateInstance<RoomManagementForm>(_serviceProvider);
         roomForm.ShowDialog();
            break;
        // ... other cases
    }
}
```

## Tối Ưu Hóa & Cải Tiến

### 1. **Thêm Real-time Data**
```csharp
// Tải dữ liệu thực từ database
public class MainForm : Form
{
    private readonly IDashboardService _dashboardService;
    
private async void MainForm_Load(object sender, EventArgs e)
 {
        var data = await _dashboardService.GetDashboardDataAsync();
UpdateMetrics(data);
    }
}
```

### 2. **Thêm Charts Thực Tế**
Sử dụng thư viện như OxyPlot hoặc Chart.NET:
```csharp
dotnet add package OxyPlot.WindowsForms
```

### 3. **Thêm Refresh Timer**
```csharp
private Timer refreshTimer;

private void InitializeTimer()
{
    refreshTimer = new Timer();
    refreshTimer.Interval = 60000; // 1 phút
    refreshTimer.Tick += async (s, e) => await RefreshDashboard();
    refreshTimer.Start();
}
```

## Sự Kiện Nút

### Logout Button
```csharp
logoutBtn.Click += (s, e) => 
{
    Application.Exit();
};
```

### Help Button
```csharp
helpBtn.Click += (s, e) => 
{
    MessageBox.Show("Liên hệ: support@hotel.com", "Trợ Giúp");
};
```

## Responsive Design

Form sử dụng `WindowState = FormWindowState.Maximized` để tự động điều chỉnh kích thước.

**Lưu ý:** Nếu cần responsive hơn, sử dụng:
```csharp
this.Resize += (s, e) => 
{
    // Tính toán lại vị trí các control dựa trên kích thước form mới
};
```

## Troubleshooting

### Vấn đề: Không hiển thị gì
**Giải pháp:**
1. Kiểm tra `InitializeComponent()` được gọi trong constructor
2. Đảm bảo `CreateDashboardContent()` được gọi
3. Kiểm tra Dock properties của các Panel

### Vấn đề: Các control bị che khuất
**Giải pháp:**
1. Kiểm tra thứ tự `Controls.Add()`
2. Đảm bảo Dock properties hợp lý
3. Kiểm tra Location và Size

### Vấn đề: Sidebar không hiển thị
**Giải pháp:**
```csharp
// Thêm sidebar vào mainPanel TRƯỚC contentAreaPanel
mainPanel.Controls.Add(sidebarPanel);
mainPanel.Controls.Add(contentAreaPanel);
```

## File Liên Quan

- `MainForm.cs` - Logic và event handlers
- `MainForm.Designer.cs` - UI definition
- `MainForm.resx` - Resources
- `IDashboardService.cs` - Dashboard logic service
- `DashboardService.cs` - Dashboard service implementation

## Tính Năng Tiếp Theo

- [ ] Integrate real-time data dari database
- [ ] Thêm charts interactiveusing OxyPlot
- [ ] Thêm refresh button
- [ ] Thêm date range picker cho metrics
- [ ] Thêm export to PDF
- [ ] Thêm notifications/alerts
- [ ] Thêm user profile section
