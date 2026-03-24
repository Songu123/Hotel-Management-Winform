# Tóm Tắt Hệ Thống Quản Lý Khách Sạn

## 📋 Mục Lục
1. [Cấu Trúc Dự Án](#cấu-trúc-dự-án)
2. [Các Tính Năng Chính](#các-tính-năng-chính)
3. [Architecture](#architecture)
4. [Hướng Dẫn Sử Dụng](#hướng-dẫn-sử-dụng)

## 🏗️ Cấu Trúc Dự Án

```
QuanLyKhachSan/
├── Models/         # Các model/entity
│   ├── Room.cs     # Room, RoomType
│   ├── Customer.cs         # Customer
│   ├── Booking.cs        # Booking
│   ├── Invoice.cs    # Invoice, InvoiceDetail
│   ├── Service.cs  # Service
│   └── Enums.cs  # RoomStatus, BookingStatus, etc.
│
├── Data/ # Entity Framework
│   ├── HotelDbContext.cs           # DbContext
│   └── HotelDbContextFactory.cs    # Factory pattern
│
├── Repositories/      # Data Access Layer
│   ├── Interfaces/
│   │   ├── IRepository.cs          # Generic interface
│   │   ├── IRoomRepository.cs
│   │   ├── ICustomerRepository.cs
│   │   ├── IBookingRepository.cs
│   │   └── IInvoiceRepository.cs
│   └── Implementations/
│       ├── Repository.cs     # Generic implementation
│     ├── RoomRepository.cs
│       ├── CustomerRepository.cs
│       ├── BookingRepository.cs
│       └── InvoiceRepository.cs
│
├── Services/            # Business Logic Layer
│   ├── Interfaces/
│   │   ├── IRoomService.cs
│ │   ├── IBookingService.cs
│   │   ├── IInvoiceService.cs
│   │   └── IDashboardService.cs
│   └── Implementations/
│       ├── RoomService.cs
│       ├── BookingService.cs
│       ├── InvoiceService.cs
│       └── DashboardService.cs
│
├── UI/        # Presentation Layer
│   ├── MainForm.cs/Designer.cs     # Dashboard chính
│   ├── DashboardForm.cs/Designer.cs# Dashboard cũ
│   ├── RoomManagementForm.cs/Designer.cs
│   ├── BookingManagementForm.cs/Designer.cs
│   ├── CustomerManagementForm.cs/Designer.cs
│   ├── InvoiceManagementForm.cs/Designer.cs
│   ├── RoomDetailForm.cs/Designer.cs
│   └── Helpers/
│       └── DashboardUIHelper.cs    # UI utilities
│
├── Configuration/
│   └── ServiceCollectionExtensions.cs  # Dependency Injection
│
└── Program.cs# Entry point
```

## ✨ Các Tính Năng Chính

### 1. **Quản Lý Phòng (Room Management)**
- ✅ CRUD Operations (Create, Read, Update, Delete)
- ✅ Tìm kiếm phòng theo:
  - Số phòng
  - Loại phòng
  - Trạng thái (Trống, Đã đặt, Đang ở, Bảo trì, Không sử dụng)
- ✅ Lọc phòng theo tiêu chí
- ✅ Xem thông tin chi tiết phòng
- ✅ Cập nhật trạng thái phòng

**Trạng Thái Phòng:**
```
Available (0)  - Phòng trống
Reserved (1)       - Phòng đã đặt
Occupied (2)       - Phòng đang ở
Maintenance (3)    - Phòng bảo trì
OutOfService (4)   - Phòng tạm không sử dụng
```

### 2. **Quản Lý Đặt Phòng (Booking Management)**
- CRUD operations cho booking
- Xem booking sắp tới
- Quản lý check-in/check-out
- Hiển thị thông tin khách hàng
- Tính giá thuê phòng

### 3. **Quản Lý Khách Hàng (Customer Management)**
- CRUD operations
- Lọc theo loại khách (Cá nhân, Công ty, VIP)
- Lưu trữ thông tin: Tên, SĐT, Email, CCCD
- Theo dõi booking của khách

### 4. **Quản Lý Hóa Đơn (Invoice Management)**
- Tạo hóa đơn tự động từ booking
- CRUD operations
- Lọc hóa đơn theo trạng thái (Draft, Issued, Paid, Cancelled)
- Quản lý dịch vụ bổ sung
- Tính toán chiết khấu, điểm loyalty

### 5. **Dashboard Chính (MainForm)**
- Hiển thị 4 metric cards:
  - Today's Income (💰)
  - Revenue Per Room (💵)
  - Occupancy Rate (📊)
  - Number of Guests (👥)
- Quick Links: Reserve, Check-in, New Arrivals
- Room Status Distribution Chart
- Expected Today: Check-in, Check-out, Complaints
- Maintenance Overview
- Sidebar navigation

## 🏛️ Architecture

### Layers
```
┌─────────────────────────────────────────┐
│    Presentation Layer (UI Forms)  │
│  - MainForm, RoomManagementForm, etc.   │
└──────────────────┬──────────────────────┘
            │
┌──────────────────┴──────────────────────┐
│    Business Logic Layer (Services)      │
│  - RoomService, BookingService, etc. │
└──────────────────┬──────────────────────┘
           │
┌──────────────────┴──────────────────────┐
│    Data Access Layer (Repositories)     │
│  - RoomRepository, BookingRepository   │
└──────────────────┬──────────────────────┘
       │
┌──────────────────┴──────────────────────┐
│    Database Layer (Entity Framework)    │
│  - HotelDbContext       │
└──────────────────────────────────────────┘
```

### Design Patterns Sử Dụng

1. **Repository Pattern**
   - Generic base repository
   - Specialized repositories cho mỗi entity

2. **Service Pattern**
   - Business logic tách biệt khỏi UI

3. **Dependency Injection**
   - Microsoft.Extensions.DependencyInjection
   - Loose coupling giữa các components

4. **DTO Pattern**
   - DashboardData, OccupancyRateData, etc.

5. **Factory Pattern**
   - HotelDbContextFactory

## 📖 Hướng Dẫn Sử Dụng

### Thiết Lập Ban Đầu

1. **Clone/Download dự án**
   ```bash
   git clone <repository-url>
   cd QuanLyKhachSan
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Cập nhật database connection string**
   ```csharp
   // Program.cs
   string connectionString = "Server=YOUR_SERVER;Database=HotelManagement;...";
   ```

4. **Tạo database**
   ```bash
   dotnet ef database update
   ```

5. **Run ứng dụng**
   ```bash
   dotnet run
   ```

### Các Endpoint/Features

#### Room Management
```
URL: Sidebar → Rooms
Features:
- View all rooms
- Add new room
- Edit room details
- Delete room
- Search by room number
- Filter by status
- Filter by room type
```

#### Booking Management
```
URL: Sidebar → Booking (Not yet implemented)
Features:
- Create booking
- View bookings
- Update status
- Check-in/Check-out
```

#### Customer Management
```
URL: Sidebar → Contacts
Features:
- Add customer
- Edit profile
- View all customers
- Filter by type
```

#### Invoice Management
```
URL: Sidebar → Payments
Features:
- Create invoice
- View invoices
- Mark as paid
- Export to PDF (planned)
```

### Các Model Chính

#### Room
```csharp
public class Room
{
    public int RoomId { get; set; }
    public string RoomNumber { get; set; }
    public int RoomTypeId { get; set; }
    public RoomStatus Status { get; set; }
    public string Notes { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public RoomType RoomType { get; set; }
    public ICollection<Booking> Bookings { get; set; }
}
```

#### Booking
```csharp
public class Booking
{
    public int BookingId { get; set; }
    public int CustomerId { get; set; }
    public int RoomId { get; set; }
  public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public decimal RoomPricePerNight { get; set; }
    public BookingStatus Status { get; set; }
    public decimal DepositAmount { get; set; }
    // ... and more fields
}
```

## 🔧 Công Nghệ Sử Dụng

- **.NET 8** - Framework
- **C# 12** - Programming language
- **Entity Framework Core** - ORM
- **SQL Server** - Database
- **Windows Forms** - UI Framework
- **Dependency Injection** - IoC Container

## 📊 Database Schema

**Main Entities:**
- `RoomTypes` - Loại phòng
- `Rooms` - Phòng
- `Customers` - Khách hàng
- `Bookings` - Đặt phòng
- `Services` - Dịch vụ bổ sung
- `Invoices` - Hóa đơn
- `InvoiceDetails` - Chi tiết hóa đơn

**Relationships:**
```
RoomType ──1──→ M── Room
Room ──1──→ M── Booking
Customer ──1──→ M── Booking
Booking ──1──→ M── Invoice
Service ──1──→ M── InvoiceDetail
Invoice ──1──→ M── InvoiceDetail
```

## 🚀 Tính Năng Tiếp Theo (Roadmap)

- [ ] Thêm thực login/authentication
- [ ] Thêm role-based access control
- [ ] Export reports to PDF/Excel
- [ ] Email notifications
- [ ] SMS notifications
- [ ] Multi-language support
- [ ] Dark mode
- [ ] Mobile app integration
- [ ] Real-time availability updates
- [ ] Payment gateway integration

## 📝 Lưu Ý

1. **Connection String**: Cập nhật theo SQL Server của bạn
2. **Database**: Sử dụng `dotnet ef database update` sau khi thay đổi models
3. **Migrations**: Dùng `dotnet ef migrations add <name>` khi thêm fields
4. **Error Handling**: Luôn check exception messages trong MessageBox

## 📞 Support

Liên hệ: support@hotel.com

---

**Version:** 1.0
**Last Updated:** 2024
**Status:** In Development
