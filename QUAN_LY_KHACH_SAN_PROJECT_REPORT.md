# 📊 BÁO CÁO PROJECT QUẢN LÝ KHÁCH SẠN
## Hệ Thống Quản Lý Khách Sạn - Windows Forms (.NET 8)

---

## 📋 MỤC LỤC
1. [Tổng Quan Project](#tổng-quan-project)
2. [Kiến Trúc Hệ Thống](#kiến-trúc-hệ-thống)
3. [Công Nghệ Sử Dụng](#công-nghệ-sử-dụng)
4. [Cơ Sở Dữ Liệu](#cơ-sở-dữ-liệu)
5. [Tính Năng Chính](#tính-năng-chính)
6. [Các Thành Phần Chính](#các-thành-phần-chính)
7. [Hệ Thống Xác Thực](#hệ-thống-xác-thực)
8. [Cấu Trúc Thư Mục](#cấu-trúc-thư-mục)
9. [Hướng Dẫn Sử Dụng](#hướng-dẫn-sử-dụng)
10. [Thông Tin Kết Luận](#thông-tin-kết-luận)

---

## 🎯 TỔNG QUAN PROJECT

### Tên Project
**Quản Lý Khách Sạn (Hotel Management System)**

### Mô Tả
Ứng dụng Windows Forms được xây dựng bằng C# và .NET 8, nhằm quản lý toàn bộ hoạt động của khách sạn từ quản lý phòng, khách hàng, booking, thanh toán đến dịch vụ phòng.

### Mục Tiêu
- Quản lý thông tin phòng và trạng thái phòng
- Quản lý khách hàng và booking
- Quản lý dịch vụ và hóa đơn
- Xác thực người dùng với database
- Tạo các báo cáo chi tiết
- Tích hợp các tính năng hiện đại như filter, tìm kiếm, in ấn

### Thông Tin Dự Án
| Thông Tin | Chi Tiết |
|-----------|----------|
| **Loại Dự Án** | Windows Forms Application |
| **Ngôn Ngữ Lập Trình** | C# 12.0 |
| **Framework** | .NET 8.0 |
| **Cơ Sở Dữ Liệu** | SQL Server |
| **ORM** | Entity Framework Core 8.0 |
| **Mẫu Thiết Kế** | Repository Pattern, Dependency Injection |
| **Ngày Bắt Đầu** | 2024 |
| **Trạng Thái** | Đang Phát Triển |

---

## 🏗️ KIẾN TRÚC HỆ THỐNG

### Sơ Đồ Kiến Trúc Tổng Thể

```
┌─────────────────────────────────────────────────────────────┐
│      WINDOWS FORMS (UI)        │
├─────────────────────────────────────────────────────────────┤
│  - MainForm (Main Application Window) │
│  - Login Form (Authentication)       │
│  - UC Rooms, Customers, Bookings, Invoices, Services │
└────────────────────┬────────────────────────────────────────┘
       │
┌─────────────────────┴────────────────────────────────────────┐
│          SERVICE LAYER (Business Logic)        │
├─────────────────────────────────────────────────────────────┤
│  - RoomService        - CustomerService     │
│  - BookingService - InvoiceService            │
│  - ServiceService       - AuthenticationService │
│  - EmployeeService      - PrintService  │
│  - RentalDetailService  - RoomRentalDetailService          │
└────────────────────┬────────────────────────────────────────┘
│
┌─────────────────────┴────────────────────────────────────────┐
│      REPOSITORY LAYER (Data Access)          │
├─────────────────────────────────────────────────────────────┤
│  - RoomRepository       - CustomerRepository                │
│  - BookingRepository    - InvoiceRepository              │
│  - ServiceRepository    - EmployeeRepository    │
│  - RentalDetailRepository  │
└────────────────────┬────────────────────────────────────────┘
      │
┌─────────────────────┴────────────────────────────────────────┐
│    ENTITY FRAMEWORK CORE (ORM Layer)           │
├─────────────────────────────────────────────────────────────┤
│  - HotelDbContext     │
│  - DbSet<T> for each Entity │
│  - Migrations Support       │
└────────────────────┬────────────────────────────────────────┘
     │
┌─────────────────────┴────────────────────────────────────────┐
│       DATABASE (SQL SERVER)       │
├─────────────────────────────────────────────────────────────┤
│  HotelManagement Database with 14 Tables            │
└─────────────────────────────────────────────────────────────┘
```

### Mẫu Kiến Trúc
- **N-Tier Architecture**: Tách biệt rõ ràng giữa UI, Business Logic và Data Access
- **Repository Pattern**: Trừu tượng hóa truy cập dữ liệu
- **Dependency Injection**: Quản lý dependencies tập trung thông qua DI Container
- **Factory Pattern**: Khởi tạo các đối tượng dịch vụ

---

## 💻 CÔNG NGHỆ SỬ DỤNG

### Nền Tảng & Runtime
| Công Nghệ | Phiên Bản | Mục Đích |
|-----------|----------|---------|
| **.NET** | 8.0 | Runtime Framework |
| **C#** | 12.0 | Ngôn ngữ lập trình |
| **Windows Forms** | .NET 8 | UI Framework |
| **Entity Framework Core** | 8.0 | ORM - Truy cập database |

### Thư Viện & Packages
```xml
<!-- Dependencies -->
<ItemGroup>
  <!-- Database & ORM -->
  <PackageReference Include="Microsoft.EntityFrameworkCore" Version="8.0.0" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="8.0.0" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="8.0.0" />
  
  <!-- Dependency Injection -->
  <PackageReference Include="Microsoft.Extensions.DependencyInjection" Version="8.0.0" />
  <PackageReference Include="Microsoft.Extensions.Configuration" Version="8.0.0" />
  
  <!-- Other Utilities -->
  <PackageReference Include="QuestPDF" Version="2024.12.0" /> (for PDF generation)
</ItemGroup>
```

### Cơ Sở Dữ Liệu
- **DBMS**: Microsoft SQL Server
- **Connection String**: `Server=.;Database=HotelManagement;Trusted_Connection=True;`
- **Authentication**: Windows Authentication

---

## 🗄️ CƠ SỞ DỮ LIỆU

### Sơ Đồ ER (Entity-Relationship Diagram)

```
NHANVIEN (Nhân Viên)
├── maNV (PK)
├── tenNV, gioiTinh, ngaySinh, ngayVaoLam
├── email, luong1Ngay, soNgayPhep
└── chucVu, xuLy

PHANQUYEN (Phân Quyền)
├── maPQ (PK)
├── tenPQ
└── CHITIETCHUCNANG (FK)

TAIKHOAN (Tài Khoản)
├── taiKhoan (PK)
├── maNV (FK) → NHANVIEN
├── maPQ (FK) → PHANQUYEN
├── matKhau, tinhTrang
└── xuLy

KHACHHANG (Khách Hàng)
├── maKH (PK)
├── tenKH, CMND, gioiTinh
├── sDT, queQuan, quocTich
├── ngaySinh
└── xuLy

PHONG (Phòng)
├── maP (PK)
├── tenP, loaiP, giaP, chiTietLoaiP
├── tinhTrang, hienTrang
├── CHITIETTIENICH (FK) → TIENICH
└── xuLy

TIENICH (Tiện Ích)
├── maTI (PK)
├── tenTI
└── xuLy

DICHVU (Dịch Vụ)
├── maDV (PK)
├── tenDV, loaiDV, giaDV
├── hinhAnh
└── xuLy

CHITIETTHUE (Chi Tiết Thuê)
├── maCTT (PK)
├── maKH (FK) → KHACHHANG
├── maNV (FK) → NHANVIEN
├── ngayLapPhieu, tienDatCoc
├── tinhTrangXuLy
├── CHITIETTHUEPHONG (FK)
├── CHITIETTHUEDICHVU (FK)
├── HOADON (FK)
└── xuLy

CHITIETTHUEPHONG (Chi Tiết Thuê Phòng)
├── maCTT (FK) → CHITIETTHUE
├── maP (FK) → PHONG
├── ngayThue, ngayTra, ngayCheckOut
├── loaiHinhThue, giaThue, tinhTrang
└── (Composite Key: maCTT, maP, ngayThue)

CHITIETTHUEDICHVU (Chi Tiết Thuê Dịch Vụ)
├── maCTT (FK) → CHITIETTHUE
├── maDV (FK) → DICHVU
├── ngaySuDung, SoLuong, giaDV
└── (Composite Key: maCTT, maDV, ngaySuDung)

HOADON (Hóa Đơn)
├── maHD (PK)
├── maCTT (FK) → CHITIETTHUE
├── giamGia, phuThu, ngayThanhToan
├── phuongThucThanhToan
└── xuLy

CHITIETTIENICH (Chi Tiết Tiện Ích)
├── maP (FK) → PHONG
├── maTI (FK) → TIENICH
├── soLuong
└── (Composite Key: maP, maTI)

CHITIETCHUCNANG (Chi Tiết Chức Năng)
├── maPQ (FK) → PHANQUYEN
├── maChucNang (FK) → CHUCNANG
└── (Composite Key: maPQ, maChucNang)

CHUCNANG (Chức Năng)
├── maChucNang (PK)
└── tenChucNang
```

### Danh Sách 14 Bảng Chính

| # | Bảng | Tên Tiếng Việt | Mô Tả |
|---|------|-----------------|--------|
| 1 | NHANVIEN | Nhân Viên | Lưu trữ thông tin nhân viên khách sạn |
| 2 | PHANQUYEN | Phân Quyền | Quản lý các vai trò người dùng |
| 3 | TAIKHOAN | Tài Khoản | Lưu trữ tài khoản đăng nhập của nhân viên |
| 4 | CHUCNANG | Chức Năng | Danh sách các chức năng hệ thống |
| 5 | CHITIETCHUCNANG | Chi Tiết Chức Năng | Gán chức năng cho từng quyền hạn |
| 6 | KHACHHANG | Khách Hàng | Lưu trữ thông tin khách hàng |
| 7 | PHONG | Phòng | Danh sách phòng của khách sạn |
| 8 | TIENICH | Tiện Ích | Danh sách tiện ích trong phòng |
| 9 | CHITIETTIENICH | Chi Tiết Tiện Ích | Gán tiện ích cho từng phòng |
| 10 | DICHVU | Dịch Vụ | Danh sách dịch vụ khách sạn |
| 11 | CHITIETTHUE | Chi Tiết Thuê | Thông tin booking/thuê phòng |
| 12 | CHITIETTHUEPHONG | Chi Tiết Thuê Phòng | Chi tiết phòng được thuê trong một booking |
| 13 | CHITIETTHUEDICHVU | Chi Tiết Thuê Dịch Vụ | Chi tiết dịch vụ sử dụng trong một booking |
| 14 | HOADON | Hóa Đơn | Hóa đơn thanh toán |

---

## ✨ TÍNH NĂNG CHÍNH

### 1. 🔐 Xác Thực & Bảo Mật

#### Login Form (Đăng Nhập)
- ✅ Giao diện hiện đại với thiết kế 2 cột (Brand + Form)
- ✅ Xác thực từ database SQL Server
- ✅ Hiển thị/ẩn mật khẩu bằng nút toggle
- ✅ Checkbox "Ghi nhớ tôi" lưu username vào Registry
- ✅ Hỗ trợ phím Enter để đăng nhập
- ✅ Phím Escape để thoát ứng dụng
- ✅ Validation đầu vào (3 ký tự username, 6 ký tự password)
- ✅ Thông báo lỗi thân thiện
- ✅ Fallback mode (test: admin/123456)

**Chi Tiết Đăng Nhập:**
```
┌─────────────────────────────────────────┐
│  🏨 QUẢN LÝ KHÁCH SẠN        │
│  ────────────────────────────────────   │
│  ✓ Quản lý phòng     │
│  ✓ Đặt phòng           │
│  ✓ Hóa đơn               │
│  ✓ Báo cáo  │
│            │
│     Chào mừng!        │
│     Đăng nhập vào hệ thống   │
│        │
│  👤 Tên đăng nhập: [________]        │
│     🔒 Mật khẩu: [__________] [👁️]    │
│     💾 ☐ Ghi nhớ tôi      │
│       │
│     [✅ Đăng Nhập] [❌ Hủy]      │
└─────────────────────────────────────────┘
```

### 2. 🛏️ Quản Lý Phòng

**Tính Năng:**
- ✅ Xem danh sách tất cả phòng
- ✅ Hiển thị trạng thái phòng (Trống, Đã đặt, Đang sử dụng, Bảo trì)
- ✅ Thêm phòng mới
- ✅ Chỉnh sửa thông tin phòng
- ✅ Xóa phòng (soft delete)
- ✅ Quản lý tiện ích trong phòng
- ✅ Lọc theo loại phòng
- ✅ Tìm kiếm phòng
- ✅ Hiển thị sơ đồ tầng

**Thông Tin Phòng:**
- Mã phòng, tên phòng
- Loại phòng (VIP, Thường, Tiết Kiệm)
- Giá thuê, tình trạng, điều kiện hiện tại
- Danh sách tiện ích

### 3. 👥 Quản Lý Khách Hàng

**Tính Năng:**
- ✅ Xem danh sách khách hàng
- ✅ Thêm khách hàng mới
- ✅ Chỉnh sửa thông tin khách
- ✅ Tìm kiếm khách hàng
- ✅ Lọc theo điều kiện
- ✅ Xóa khách hàng (soft delete)
- ✅ Xem lịch sử booking của khách

**Thông Tin Khách Hàng:**
- Tên, CMND, giới tính
- Số điện thoại, địa chỉ, quốc tịch
- Ngày sinh
- Lịch sử các lần thuê phòng

### 4. 🗓️ Quản Lý Booking (Đặt Phòng)

**Tính Năng:**
- ✅ Tạo booking mới
- ✅ Chọn phòng từ sơ đồ tầng
- ✅ Thiết lập ngày nhận/trả phòng
- ✅ Thêm dịch vụ vào booking
- ✅ Xem danh sách booking
- ✅ Chỉnh sửa booking
- ✅ Hủy booking
- ✅ Check-in/Check-out phòng
- ✅ Quản lý trạng thái phòng trong booking

**Loại Booking:**
- Theo giờ
- Theo đêm
- Theo ngày

### 5. 💳 Quản Lý Thanh Toán & Hóa Đơn

**Tính Năng:**
- ✅ Tạo hóa đơn từ booking
- ✅ Tính toán tự động:
  - Tiền thuê phòng
  - Tiền dịch vụ
  - Giảm giá
  - Phụ thu
- ✅ Hiển thị chi tiết hóa đơn
- ✅ Thanh toán hóa đơn
- ✅ Hỗ trợ 4 phương thức thanh toán:
  - Tiền mặt
  - Thẻ tín dụng
  - Ví điện tử
  - Chuyển khoản ngân hàng
- ✅ In hóa đơn (PDF)
- ✅ Lịch sử thanh toán

### 6. 🛎️ Quản Lý Dịch Vụ

**Tính Năng:**
- ✅ Xem danh sách dịch vụ
- ✅ Thêm dịch vụ mới
- ✅ Chỉnh sửa dịch vụ
- ✅ Xóa dịch vụ
- ✅ Phân loại dịch vụ:
  - Room Service
  - Giặt ủi
  - SPA/Massage
  - Đưa đón sân bay
  - Khác
- ✅ Quản lý giá dịch vụ
- ✅ Hình ảnh dịch vụ
- ✅ Tìm kiếm dịch vụ

### 7. 📊 Dashboard

**Tính Năng:**
- ✅ Thống kê tổng quát
- ✅ Số phòng trống/đang sử dụng
- ✅ Tổng doanh thu
- ✅ Số khách hôm nay
- ✅ Biểu đồ thống kê
- ✅ Thông tin nhanh

### 8. 📋 Báo Cáo

**Tính Năng:**
- ✅ Báo cáo doanh thu
- ✅ Báo cáo phòng
- ✅ Báo cáo khách hàng
- ✅ Báo cáo dịch vụ
- ✅ Xuất báo cáo (Excel, PDF)

---

## 📦 CÁC THÀNH PHẦN CHÍNH

### 1. Models (Entities)

```
Models/
├── Account.cs// Tài khoản đăng nhập
├── Employee.cs      // Nhân viên
├── Customer.cs       // Khách hàng
├── Room.cs         // Phòng
├── Booking.cs / RentalDetail.cs    // Booking
├── RoomRentalDetail.cs     // Chi tiết phòng trong booking
├── Service.cs        // Dịch vụ
├── ServiceRentalDetail.cs  // Chi tiết dịch vụ trong booking
├── Invoice.cs              // Hóa đơn
├── Role.cs// Vai trò/Quyền
├── Function.cs             // Chức năng hệ thống
├── RoleFunction.cs         // Gán chức năng cho role
├── Amenity.cs   // Tiện ích
├── RoomAmenity.cs          // Gán tiện ích cho phòng
├── Floor.cs       // Tầng (nếu có)
└── Enums.cs      // Enumerations (RoomStatus, BookingStatus, etc)
```

### 2. Repositories (Data Access)

```
Repositories/
├── Interfaces/
│   ├── IRepository.cs
│   ├── IRoomRepository.cs
│   ├── ICustomerRepository.cs
│   ├── IBookingRepository.cs
│   ├── IInvoiceRepository.cs
│   └── ... (các interfaces khác)
└── Implementations/
 ├── Repository.cs (Base class)
    ├── RoomRepository.cs
    ├── CustomerRepository.cs
    ├── BookingRepository.cs
    ├── InvoiceRepository.cs
    └── ... (các implementations khác)
```

### 3. Services (Business Logic)

```
Services/
├── Interfaces/
│   ├── IRoomService.cs
│   ├── ICustomerService.cs
│   ├── IBookingService.cs
│   ├── IInvoiceService.cs
│   ├── IServiceService.cs
│   ├── IAuthenticationService.cs
│   ├── IEmployeeService.cs
│   ├── IPrintService.cs
│   └── ... (các interfaces khác)
└── Implementations/
    ├── RoomService.cs
    ├── CustomerService.cs
    ├── BookingService.cs
    ├── InvoiceService.cs
    ├── ServiceService.cs
    ├── AuthenticationService.cs
    ├── EmployeeService.cs
    ├── PrintService.cs
    └── ... (các implementations khác)
```

### 4. UI (User Interface)

```
UI/
├── MainForm.cs / MainForm.Designer.cs
├── UCDashboard.cs          // Dashboard
├── Login/
│   ├── LoginForm.cs
│ └── LoginForm.Designer.cs
├── RoomServiceUI/
│   ├── UCRoom.cs
│   └── AddRoomForm.cs
├── CustomerUI/
│   ├── UCCustomer.cs
│   └── AddCustomerForm.cs
├── BookingUI/
│   ├── UCBooking.cs
│   ├── BookingDetailForm.cs
│   ├── PaymentForm.cs
│   └── ... (các forms liên quan booking)
├── InvoiceUI/
│   ├── UCInvoiceManagement.cs
│└── ProfessionalInvoiceForm.cs
├── Service/
│   ├── UCServiceManagement.cs
│   ├── AddServiceForm.cs
│   └── EditServiceForm.cs
└── ... (các UI components khác)
```

### 5. Data & Database

```
Data/
├── HotelDbContext.cs      // DbContext chính
├── HotelDbContextFactory.cs   // Factory pattern
└── HotelDbSeeder.cs           // Seed dữ liệu ban đầu

Migrations/
├── 20260328091200_Create-Database.cs
└── HotelDbContextModelSnapshot.cs
```

### 6. Configuration

```
Configuration/
├── ServiceCollectionExtensions.cs  // Dependency Injection setup
└── Database initialization
```

---

## 🔐 HỆ THỐNG XÁC THỰC

### Authentication Service

**Interface:**
```csharp
public interface IAuthenticationService
{
    // Xác thực username/password
    Task<Account?> AuthenticateAsync(string username, string password);
    
    // Lấy thông tin tài khoản
    Task<Account?> GetAccountAsync(string username);
    
    // Kiểm tra tài khoản hoạt động
    Task<bool> IsAccountActiveAsync(string username);
    
    // Lấy chi tiết tài khoản (Account + Employee + Role)
    Task<(Account? account, Employee? employee, Role? role)> GetAccountDetailsAsync(string username);
}
```

### Xác Thực Cơ Sở Dữ Liệu

**Các Bước Xác Thực:**
1. Người dùng nhập tên đăng nhập và mật khẩu
2. Tìm kiếm trong bảng `TAIKHOAN`
3. Kiểm tra:
   - Username có tồn tại?
   - Mật khẩu có khớp?
   - Tài khoản có hoạt động? (Status = 0)
   - Tài khoản có bị xóa? (IsDeleted = 0)
4. Nếu hợp lệ: Đăng nhập thành công
5. Nếu không hợp lệ: Hiển thị lỗi

### Bảo Mật

**Hiện Tại:**
- ✅ Password masking khi nhập
- ✅ Validation đầu vào
- ✅ Soft delete (xuLy flag)
- ✅ Status check
- ✅ Generic error messages

**Cần Cải Thiện:**
- ⏳ Password hashing (BCrypt/Argon2)
- ⏳ Login attempt counter
- ⏳ Account lockout
- ⏳ Audit logging
- ⏳ Two-factor authentication

---

## 📁 CẤU TRÚC THƯ MỤC

```
QuanLyKhachSan/
│
├── QuanLyKhachSan.csproj          // Project file
├── Program.cs       // Entry point
│
├── Models/     // Entities
│   ├── Account.cs
│   ├── Employee.cs
│   ├── Customer.cs
│   ├── Room.cs
│   ├── RentalDetail.cs (Booking)
│   ├── Service.cs
│   ├── Invoice.cs
│   ├── Role.cs
│   ├── Enums.cs
│   └── ... (13+ models)
│
├── Data/       // Database Context
│   ├── HotelDbContext.cs
│   ├── HotelDbContextFactory.cs
│   ├── HotelDbSeeder.cs
│   └── Migrations/
│       ├── 20260328091200_Create-Database.cs
│       └── HotelDbContextModelSnapshot.cs
│
├── Repositories/   // Data Access Layer
│   ├── Interfaces/
│   │   ├── IRepository.cs
│   │   ├── IRoomRepository.cs
│   │   ├── ICustomerRepository.cs
│   │   ├── IBookingRepository.cs
│   │   ├── IInvoiceRepository.cs
│   │   └── ... (8+ interfaces)
│   └── Implementations/
│       ├── Repository.cs (Base)
│     ├── RoomRepository.cs
│       ├── CustomerRepository.cs
│       ├── BookingRepository.cs
│       └── ... (12+ implementations)
│
├── Services/    // Business Logic Layer
│   ├── Interfaces/
│   │   ├── IRoomService.cs
│   │   ├── ICustomerService.cs
│   │   ├── IBookingService.cs
│   │   ├── IInvoiceService.cs
│   │├── IServiceService.cs
│   │   ├── IAuthenticationService.cs
│   │   └── ... (10+ interfaces)
│   ├── Implementations/
│   │   ├── RoomService.cs
│   │   ├── CustomerService.cs
│   │   ├── BookingService.cs
│   │   ├── InvoiceService.cs
│   │   ├── ServiceService.cs
│   │   ├── AuthenticationService.cs
│   │   └── ... (10+ implementations)
│   └── RequestHandlers/        // Request/Response Pattern
│       ├── Interfaces/
│       ├── CustomerCreateRequestHandler.cs
│   ├── RefreshCustomerListRequestHandler.cs
│       └── ... (3+ handlers)
│
├── UI/   // User Interface Layer
│   ├── MainForm.cs / MainForm.Designer.cs
│   ├── MainForm.resx
│   ├── UCDashboard.cs
│   ├── UCReports.cs
│   │
│   ├── Login/
│   │   ├── LoginForm.cs
│   │   ├── LoginForm.Designer.cs
│   │   ├── LOGIN_GUIDE.md
│   │   ├── LOGIN_QUICK_START.md
│   │   ├── DATABASE_LOGIN_GUIDE.md
│   │   └── AUTHENTICATION_SERVICE_USAGE.md
│   │
│   ├── RoomServiceUI/
│   │   ├── UCRoom.cs
│   │   ├── UCRoom.Designer.cs
│   │   ├── AddRoomForm.cs
│   │   └── RoomDetailForm.cs
│   │
│   ├── CustomerUI/
│   │   ├── UCCustomer.cs
│   │   ├── UCCustomer.Designer.cs
│   │   ├── AddCustomerForm.cs
│ │   └── UpdateCustomerForm.cs
│   │
│   ├── BookingUI/
│   │   ├── UCBooking.cs
│   │   ├── UCBookingModern.cs
│   │   ├── BookingDetailForm.cs
│   │   ├── BookingForm.cs
│   │   ├── BookingNewForm.cs
│   │   ├── PaymentForm.cs
│   │   ├── PaymentDetailForm.cs
│   │   ├── RoomAllocationDialog.cs
│   │   ├── SelectRentalForm.cs
│   │   ├── RoomStatusManagementForm.cs
│   │   └── ... (10+ files)
│   │
│   ├── InvoiceUI/
│   │   ├── UCInvoiceManagement.cs
│   │   └── ProfessionalInvoiceForm.cs
│   │
│   ├── Service/
│   │   ├── UCServiceManagement.cs
│   │   ├── UCServiceManagement.Designer.cs
│   │   ├── AddServiceForm.cs
│   │   ├── EditServiceForm.cs
│   │   ├── UCServices.cs
│   │   ├── SERVICE_MANAGEMENT_README.md
│   │   ├── QUICK_START.md
│   │   └── INTEGRATION_GUIDE.md
│   │
│   └── ... (other UI components)
│
├── Configuration/
│   └── ServiceCollectionExtensions.cs
│
├── Tests/
│   └── Services/
│       └── CustomerCreateRequestHandlerTests.cs
│
├── Properties/
│   └── Resources.Designer.cs
│
└── bin/, obj/            // Build outputs
```

---

## 📖 HƯỚNG DẪN SỬ DỤNG

### 1. Chuẩn Bị Môi Trường

**Yêu Cầu:**
- Visual Studio 2022 hoặc mới hơn
- .NET 8.0 SDK
- SQL Server (Local hoặc Remote)
- Git

**Cài Đặt:**
```bash
# Clone project
git clone https://github.com/Songu123/Hotel-Management-Winform.git
cd QuanLyKhachSan

# Restore packages
dotnet restore

# Update database (migrations)
dotnet ef database update

# Build
dotnet build
```

### 2. Cấu Hình Kết Nối Database

**File:** `Program.cs`

```csharp
string connectionString = "Server=.;Database=HotelManagement;Trusted_Connection=True;TrustServerCertificate=True;";
```

**Điều Chỉnh:**
- `Server=.` → Thay bằng tên server của bạn
- `Database=HotelManagement` → Tên database
- `Trusted_Connection=True` → Windows Authentication

### 3. Chạy Ứng Dụng

```bash
# Debug mode
dotnet run

# Hoặc từ Visual Studio
F5 hoặc Ctrl + F5
```

### 4. Đăng Nhập

**Tài Khoản Mặc Định (Test Mode):**
- Username: `admin`
- Password: `123456`

**Tài Khoản Từ Database:**
- Truy vấn bảng `TAIKHOAN` (Account)
- Kiểm tra Status = 0 (Active)
- IsDeleted = 0 (Not deleted)

### 5. Sử Dụng Các Tính Năng

#### Quản Lý Phòng
1. Click **🛏️ Phòng** trên menu
2. Xem danh sách phòng
3. Click **Thêm** để thêm phòng mới
4. Nhập thông tin:
 - Mã phòng, tên phòng
   - Loại (VIP, Thường, Tiết Kiệm)
   - Giá thuê
   - Chọn tiện ích
5. Click **Lưu**

#### Quản Lý Khách Hàng
1. Click **👥 Khách Hàng**
2. Xem danh sách khách
3. Click **Thêm** để thêm khách mới
4. Nhập thông tin cơ bản
5. Click **Lưu**

#### Tạo Booking
1. Click **🗓️ Booking**
2. Click **Booking Mới**
3. Chọn khách hàng
4. Chọn phòng từ sơ đồ tầng
5. Chọn ngày nhận/trả phòng
6. Thêm dịch vụ (nếu cần)
7. Click **Lưu Booking**

#### Thanh Toán
1. Click **💳 Thanh Toán**
2. Chọn booking cần thanh toán
3. Kiểm tra chi tiết hóa đơn
4. Chọn phương thức thanh toán
5. Click **Thanh Toán**
6. In hóa đơn (PDF)

### 6. Thoát Ứng Dụng
- Click nút **❌ Thoát** hoặc Close window
- Hoặc nhấn **Escape** từ Login Form

---

## 📊 ENUMERATIONS (Enums)

### RoomStatus (Trạng Thái Phòng)
```csharp
public enum RoomStatus
{
    Available = 0,      // Trống
    Reserved = 1,       // Đã đặt
    Occupied = 2,       // Đang sử dụng
    Maintenance = 3,    // Bảo trì
    OutOfService = 4    // Tạm đóng
}
```

### BookingStatus (Trạng Thái Booking)
```csharp
public enum BookingStatus
{
Pending = 0,        // Chờ xác nhận
    Confirmed = 1,      // Đã xác nhận
    CheckedIn = 2,  // Check-in
    CheckedOut = 3,     // Check-out
    Cancelled = 4       // Hủy
}
```

### PaymentMethod (Phương Thức Thanh Toán)
```csharp
public enum PaymentMethod
{
    Cash = 0,           // Tiền mặt
    Card = 1,        // Thẻ
    EWallet = 2,      // Ví điện tử
    BankTransfer = 3    // Chuyển khoản
}
```

### ServiceType (Loại Dịch Vụ)
```csharp
public enum ServiceType
{
    RoomService = 0,    // Phục vụ phòng
    Laundry = 1,     // Giặt ủi
    Spa = 2,      // SPA/Massage
    AirportTransfer = 3,// Đưa đón sân bay
    Other = 4    // Khác
}
```

---

## 🔧 CẤP HÌNH HỆ THỐNG

### Dependency Injection Setup

**File:** `Configuration/ServiceCollectionExtensions.cs`

```csharp
public static IServiceCollection AddHotelManagementServices(
    this IServiceCollection services, 
    string connectionString)
{
    // DbContext
  services.AddDbContext<HotelDbContext>(options =>
        options.UseSqlServer(connectionString));
    
    // Repositories
    services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
    services.AddScoped<IRoomRepository, RoomRepository>();
    services.AddScoped<ICustomerRepository, CustomerRepository>();
    // ... (other repositories)
    
    // Services
    services.AddScoped<IRoomService, RoomService>();
    services.AddScoped<ICustomerService, CustomerService>();
    services.AddScoped<IAuthenticationService, AuthenticationService>();
    // ... (other services)
    
// Request Handlers
    services.AddScoped<ICustomerCreateRequestHandler, CustomerCreateRequestHandler>();
    // ... (other handlers)
    
    return services;
}
```

---

## 📈 THỐNG KÊ PROJECT

| Thông Tin | Số Lượng |
|-----------|----------|
| **Models/Entities** | 15+ |
| **Repository Classes** | 12+ |
| **Service Classes** | 12+ |
| **UI Forms/Controls** | 30+ |
| **Database Tables** | 14 |
| **Tính Năng Chính** | 8+ |
| **Phương Thức Thanh Toán** | 4 |
| **Loại Dịch Vụ** | 5 |
| **Dòng Code (approx)** | 15,000+ |

---

## ✅ KIỂM TRA CHẤT LƯỢNG

### Chuẩn Mã

| Chuẩn | Trạng Thái |
|------|-----------|
| Naming Convention | ✅ PascalCase, camelCase |
| XML Documentation | ✅ Có |
| Error Handling | ✅ Try-catch blocks |
| Null Safety | ✅ ? operator, null checks |
| Async/Await | ✅ Async operations |
| SOLID Principles | ✅ Dependency Injection |
| DRY Principle | ✅ Base classes, reusable |
| Code Comments | ✅ Chi tiết |

### Testing

| Loại Test | Trạng Thái |
|-----------|-----------|
| Unit Tests | ⏳ Cơ bản |
| Integration Tests | ⏳ Cần thêm |
| UI Tests | ⏳ Manual |

---

## 🐛 KNOWN ISSUES & LIMITATIONS

### Vấn Đề Hiện Tại

1. **Password Hashing**: Mật khẩu chưa được hash, cần cải thiện bảo mật
2. **Login Attempts**: Chưa có cơ chế khóa tài khoản sau failed attempts
3. **Audit Logging**: Chưa có ghi lại lịch sử đăng nhập
4. **PDF Generation**: In hóa đơn cần tối ưu hóa

### Giới Hạn

- Ứng dụng là desktop, không có web version
- Không hỗ trợ multi-user concurrent updates (cần locking mechanism)
- Không có backup/restore tự động

---

## 📝 TƯƠNG LAI PHÁT TRIỂN

### Phase 2 (Planned)
- [ ] Improve password security (BCrypt hashing)
- [ ] Add login attempt counter & account lockout
- [ ] Implement audit logging
- [ ] Add two-factor authentication
- [ ] Mobile app support
- [ ] Real-time notifications
- [ ] Advanced reporting & analytics
- [ ] Multi-language support
- [ ] Cloud database migration
- [ ] REST API for mobile/web

### Phase 3 (Proposed)
- [ ] Web version (ASP.NET Core)
- [ ] Mobile app (iOS/Android)
- [ ] Business Intelligence Dashboard
- [ ] AI-powered recommendations
- [ ] Chatbot support
- [ ] IoT integration (smart rooms)

---

## 📚 TÀI LIỆU THAM KHẢO

### Internal Documentation
- `UI/Login/LOGIN_GUIDE.md` - Hướng dẫn Login
- `UI/Login/DATABASE_LOGIN_GUIDE.md` - Database authentication
- `UI/Service/SERVICE_MANAGEMENT_README.md` - Quản lý dịch vụ
- `UI/Service/INTEGRATION_GUIDE.md` - Tích hợp dịch vụ
- `UI/Login/TEST_DATA.sql` - Test data script

### External Resources
- [.NET 8 Documentation](https://learn.microsoft.com/en-us/dotnet/)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/)
- [Windows Forms](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/)
- [C# Programming Guide](https://learn.microsoft.com/en-us/dotnet/csharp/)

---

## 🤝 ĐÓNG GÓP

### Cách Đóng Góp
1. Fork project
2. Tạo feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to branch (`git push origin feature/AmazingFeature`)
5. Open Pull Request

### Code Guidelines
- Tuân thủ C# naming conventions
- Thêm XML documentation cho public methods
- Viết unit tests cho các tính năng mới
- Cập nhật documentation khi cần thiết

---

## 📄 LICENSE

Project này được cấp phép dưới license MIT. Xem file LICENSE để chi tiết.

---

## 📞 LIÊN HỆ & HỖ TRỢ

### Repository
- GitHub: [Hotel-Management-Winform](https://github.com/Songu123/Hotel-Management-Winform)
- Branch chính: `feature/checkout`

### Issues & Support
- Báo cáo lỗi: GitHub Issues
- Thảo luận: GitHub Discussions
- Email: (Liên hệ qua GitHub)

---

## 📋 NGÔN NGỮ

- 🇻🇳 Tiếng Việt: Giao diện & Database
- 🇬🇧 Tiếng Anh: Code comments & Documentation

---

## 🏆 THÀNH TỰU & MỤC TIÊU

### Đã Hoàn Thành
✅ UI hiện đại cho Login
✅ Database Authentication
✅ CRUD operations cho tất cả entities
✅ Dependency Injection setup
✅ Repository Pattern implementation
✅ Service layer architecture
✅ Quản lý phòng, khách, booking, thanh toán
✅ Invoice generation & printing
✅ Role-based access (planning)

### Đang Tiến Hành
⏳ Password hashing & security improvements
⏳ Audit logging
⏳ Advanced reporting
⏳ Performance optimization

### Mục Tiêu Tương Lai
🎯 Enterprise-grade hotel management system
🎯 Mobile & Web versions
🎯IA & Machine learning integration
🎯 Multi-property support
🎯 International market expansion

---

## 📅 LỊCH SỬ PHIÊN BẢN

| Phiên Bản | Ngày | Thay Đổi |
|-----------|------|---------|
| 1.0.0 | 2024 | Initial release |
| 1.1.0 | 2024 | Added Login system |
| 1.2.0 | 2024 | Database authentication |
| 1.3.0 | 2024 | Service management |
| (Developing) | 2025 | Security improvements |

---

## ✨ KẾT LUẬN

Hệ thống **Quản Lý Khách Sạn** là một ứng dụng Windows Forms toàn diện, được xây dựng với các best practices của C# và .NET 8. Project này cung cấp:

✅ **Kiến trúc bền vững**: N-Tier architecture với clear separation of concerns
✅ **Công nghệ hiện đại**: .NET 8, Entity Framework Core, Dependency Injection
✅ **Tính năng đầy đủ**: Quản lý phòng, khách, booking, thanh toán, dịch vụ
✅ **Bảo mật cơ bản**: Authentication, validation, error handling
✅ **Mở rộng dễ dàng**: Repository & Service patterns cho việc bổ sung tính năng

Project này phù hợp để:
- 🎓 Học tập lập trình C# & .NET
- 💼 Cơ sở cho hệ thống quản lý thực tế
- 📚 Tham khảo kiến trúc dự án
- 🚀 Khởi động cho startup khách sạn

**Tình trạng hiện tại**: Đang phát triển tích cực, ready for beta testing.

---

**Tài Liệu Này Được Tạo Lúc**: 2024  
**Cập Nhật Cuối Cùng**: 2024  
**Phiên Bản**: 1.3.0  

**Made with ❤️ for Hotel Management Systems**

---
