// ====================================================================
// BOOKING FORM - USAGE EXAMPLES AND TEST CASES
// ====================================================================

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.UI.BookingUI;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.Examples
{
    /// <summary>
    /// Ví dụ về cách sử dụng BookingForm
    /// </summary>
    public class BookingFormUsageExamples
    {
        private IRoomService _roomService;
    private IBookingService _bookingService;
        private ICustomerService _customerService;

        // ====================================================================
      // EXAMPLE 1: Basic Usage - Tạo phiếu thuê cơ bản
        // ====================================================================
      public void Example1_BasicBooking()
        {
 try
  {
             // Chuẩn bị dữ liệu
  var room = new Room
      {
RoomId = "P101",
 Name = "Phòng Đơn 101",
          Price = 150000,
                 Status = 0 // Available
     };

    var checkInDate = DateTime.Now.AddDays(1);
         var checkOutDate = DateTime.Now.AddDays(3);

           var customers = new List<Customer>
         {
       new Customer
          {
 CustomerId = "KH001",
               Name = "Nguyễn Văn A",
       PhoneNumber = "0901234567",
          IdNumber = "123456789",
           DateOfBirth = new DateTime(1990, 5, 15),
 Address = "123 Ngõ Giang, Phường Hàng Mã, Quận Hoàn Kiếm, Hà Nội",
          Nationality = "Việt Nam"
       }
    };

            // Tạo và hiển thị BookingForm
   var bookingForm = new BookingForm(room, checkInDate, checkOutDate, customers);
var result = bookingForm.ShowDialog();

       if (result == DialogResult.OK && bookingForm.IsConfirmed)
                {
         // Phiếu thuê đã được xác nhận
     var rentalDetail = bookingForm.GetRentalDetail();
      var selectedRooms = bookingForm.GetSelectedRooms();

        MessageBox.Show(
            $"Phiếu thuê được tạo thành công!\n\n" +
      $"Mã phiếu: {rentalDetail.RentalDetailId}\n" +
        $"Khách hàng: {rentalDetail.CustomerId}\n" +
              $"Số phòng: {selectedRooms.Count}",
           "Thành công",
    MessageBoxButtons.OK,
         MessageBoxIcon.Information);
           }
            }
    catch (Exception ex)
            {
 MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", 
     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ====================================================================
        // EXAMPLE 2: Multiple Room Booking - Đặt nhiều phòng
        // ====================================================================
        public void Example2_MultipleRoomBooking()
        {
            try
     {
   // Chuẩn bị multiple rooms
       var firstRoom = new Room
    {
    RoomId = "P101",
            Name = "Phòng Đơn 101",
 Price = 150000,
             Status = 0
        };

       var checkInDate = DateTime.Now.AddDays(1);
     var checkOutDate = DateTime.Now.AddDays(5);

           var customers = LoadCustomersFromService();

             // Tạo BookingForm cho phòng đầu tiên
         var bookingForm = new BookingForm(firstRoom, checkInDate, checkOutDate, customers);
    
                // Sau khi form được hiển thị, người dùng có thể click "Thêm phòng"
        // để thêm các phòng khác
            var result = bookingForm.ShowDialog();

     if (result == DialogResult.OK && bookingForm.IsConfirmed)
      {
         var selectedRooms = bookingForm.GetSelectedRooms();
               
 // Xử lý nhiều phòng đã chọn
            foreach (var roomDetail in selectedRooms)
         {
           Console.WriteLine($"Room: {roomDetail.RoomId}, " +
   $"Price: {roomDetail.RentalPrice}, " +
             $"Check-in: {roomDetail.RentalDate:dd/MM/yyyy}");
          }
                }
            }
            catch (Exception ex)
            {
  MessageBox.Show($"Lỗi: {ex.Message}");
 }
        }

   // ====================================================================
   // EXAMPLE 3: VIP Customer Booking - Đặt phòng cho khách VIP
        // ====================================================================
        public void Example3_VIPCustomerBooking()
        {
         try
{
    var vipRoom = new Room
  {
           RoomId = "P301",
 Name = "Phòng Suite 301",
     Price = 800000,
              Status = 0,
   RoomType = 4 // Suite room
                };

            var checkInDate = DateTime.Now.AddDays(7);
                var checkOutDate = DateTime.Now.AddDays(10);

        var vipCustomer = new List<Customer>
   {
            new Customer
              {
    CustomerId = "VIP001",
       Name = "Trần Quốc Tuấn",
    PhoneNumber = "+84912345678",
             IdNumber = "001234567890",
       Gender = 1,
      DateOfBirth = new DateTime(1985, 3, 20),
        Address = "Tòa nhà ABC, Đường Lê Duẩn, Quận 1, TP. Hồ Chí Minh",
       Nationality = "Việt Nam"
               }
              };

      var bookingForm = new BookingForm(vipRoom, checkInDate, checkOutDate, vipCustomer);
           var result = bookingForm.ShowDialog();

       if (result == DialogResult.OK && bookingForm.IsConfirmed)
         {
     var rentalDetail = bookingForm.GetRentalDetail();
          
        // Có thể thêm xử lý đặc biệt cho khách VIP
      if (rentalDetail.DepositAmount > 500000)
                    {
         MessageBox.Show("Khách VIP - Thanh toán cao, vui lòng xác nhận lại!");
    }
         }
 }
        catch (Exception ex)
         {
  MessageBox.Show($"Lỗi: {ex.Message}");
      }
      }

     // ====================================================================
        // EXAMPLE 4: Integration with UCBooking - Tích hợp với UCBooking
        // ====================================================================
        public void Example4_IntegrationWithUCBooking()
        {
   // Đây là cách tích hợp từ UCBooking.cs (OnBookRoom method)
            /*
     private async void OnBookRoom(object sender, Room room)
            {
       _selectedRoom = room;
                try
     {
  // Check if room is available
   if (room.Status != 0)
   {
      MessageBox.Show($"Phòng {room.Name} không sẵn sàng để đặt", "Thông báo",
          MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
       }

              // Validate booking dates
      if (dtpNgayThue.Value >= dtpNgayTra.Value)
        {
           MessageBox.Show("Ngày trả phải sau ngày thuê", "Cảnh báo",
         MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
      }

       // Load customers from database
     List<Customer> customers = new List<Customer>();
    try
                    {
       if (_roomService != null)
                {
        // Get service provider to access ICustomerService
           var serviceProvider = (IServiceProvider)Program.Services;
 var customerService = serviceProvider.GetService(typeof(ICustomerService)) as ICustomerService;

    if (customerService != null)
     {
             var allCustomers = await customerService.GetAllCustomersAsync();
          if (allCustomers != null)
      {
  customers = allCustomers.Where(c => c.IsDeleted == 0).ToList();
            }
           }
   }
         }
            catch (Exception ex)
  {
                System.Diagnostics.Debug.WriteLine($"Error loading customers: {ex.Message}");
          // Continue even if customer loading fails
   }

                // Show booking form
var bookingForm = new BookingForm(room, dtpNgayThue.Value, dtpNgayTra.Value, customers);
  var result = bookingForm.ShowDialog();

      if (result == DialogResult.OK && bookingForm.IsConfirmed)
   {
            // Calculate pricing
  var nights = (int)(dtpNgayTra.Value - dtpNgayThue.Value).TotalDays;
              decimal totalPrice = room.Price * nights;

        // Update room status in database
         room.Status = 1; // Occupied
   await _roomService.UpdateRoomAsync(room);

      // Update room status in UI
            _roomCardContainer.UpdateRoomStatus(room.RoomId, RoomStatusType.Occupied);

                  // Refresh room list
   await Task.Delay(500);
        LoadRoomsAsync();
             }
     }
         catch (Exception ex)
        {
      MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
   }
         }
 */
        }

        // ====================================================================
 // EXAMPLE 5: Data Validation - Kiểm tra dữ liệu đầu vào
        // ====================================================================
        public void Example5_DataValidation()
        {
      // BookingForm thực hiện các kiểm tra sau:
            
            // 1. Customer Validation
         var validations = new List<string>
      {
    "Mã khách hàng không được để trống",
    "Khách hàng phải tồn tại trong danh sách",
   "Số điện thoại phải hợp lệ",
         "CMND/CCCD phải hợp lệ"
    };

         // 2. Room Validation
            validations.Add("Phải chọn ít nhất một phòng");
            validations.Add("Phòng phải ở trạng thái 'Trống' (Available)");
 validations.Add("Không được chọn phòng trùng lặp");

         // 3. Date Validation
validations.Add("Ngày trả phải sau ngày thuê");
            validations.Add("Không thể đặt phòng cho ngày trong quá khứ");

    // 4. Financial Validation
       validations.Add("Tiền đặt cọc phải là số dương hoặc 0");
     validations.Add("Tiền đặt cọc không vượt quá tổng tiền phòng");

  // 5. Processing Status Validation
            validations.Add("Phải chọn tình trạng xử lý");
        }

        // ====================================================================
   // EXAMPLE 6: Error Handling - Xử lý lỗi
        // ====================================================================
        public void Example6_ErrorHandling()
{
try
        {
           // Scenario 1: Room không available
     var unavailableRoom = new Room
           {
        RoomId = "P201",
  Name = "Phòng 201",
        Price = 200000,
              Status = 1 // Occupied!
             };

                // Thường kiểm tra trước khi tạo BookingForm
                if (unavailableRoom.Status != 0)
      {
      MessageBox.Show("Phòng này không sẵn sàng để đặt", "Cảnh báo");
 return;
      }

                // Scenario 2: Invalid date range
                var checkInDate = DateTime.Now.AddDays(5);
          var checkOutDate = DateTime.Now.AddDays(3); // INVALID!

     if (checkInDate >= checkOutDate)
                {
        MessageBox.Show("Ngày trả phải sau ngày thuê", "Cảnh báo");
 return;
     }

          // Scenario 3: No customers available
     var emptyCustomerList = new List<Customer>();

  if (emptyCustomerList.Count == 0)
{
        MessageBox.Show("Không có khách hàng nào trong hệ thống. " +
              "Vui lòng tạo khách hàng trước!", "Cảnh báo");
   return;
       }

        // Scenario 4: Service not available
                var serviceProvider = (IServiceProvider)Program.Services;
  var customerService = serviceProvider.GetService(typeof(ICustomerService)) as ICustomerService;

       if (customerService == null)
                {
 MessageBox.Show("Không thể kết nối đến dịch vụ khách hàng", "Lỗi");
   return;
                }
            }
      catch (Exception ex)
     {
            MessageBox.Show($"Lỗi xảy ra: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ====================================================================
      // EXAMPLE 7: Deposit Calculation - Tính tiền đặt cọc
        // ====================================================================
  public void Example7_DepositCalculation()
        {
 var room = new Room { Price = 500000 }; // 500K per night
var nights = 3;
     var totalPrice = room.Price * nights; // 1,500,000

            // Common deposit scenarios:
      var scenarios = new Dictionary<string, int>
            {
                { "No deposit", 0 },
             { "50% deposit", (int)(totalPrice * 0.5) },      // 750,000
     { "100% pre-payment", (int)(totalPrice) },         // 1,500,000
  { "Fixed deposit", 500000 },  // Fixed amount
                { "VIP no deposit", 0 }   // VIP customer benefit
            };

          // In BookingForm, user can set deposit in txtTienDatCoc
    foreach (var scenario in scenarios)
  {
  Console.WriteLine($"{scenario.Key}: {scenario.Value:N0} VNĐ");
            }
        }

        // ====================================================================
        // EXAMPLE 8: Processing Status - Tình trạng xử lý phiếu
        // ====================================================================
 public void Example8_ProcessingStatus()
        {
      var statusValues = new Dictionary<int, string>
    {
             { 0, "Đang xử lý" },      // Processing
         { 1, "Đã xác nhận" },     // Confirmed
              { 2, "Đã hủy" }// Cancelled
};

      /*
 * Trong BookingForm, combobox cboTinhTrangXuLy chứa:
        * - Index 0: "Đang xử lý" (default)
       * - Index 1: "Đã xác nhận"
    * - Index 2: "Đã hủy"
             * 
             * Khi lưu phiếu, ProcessingStatus = cboTinhTrangXuLy.SelectedIndex
 */
        }

        // ====================================================================
  // EXAMPLE 9: Room Rental Detail Creation - Tạo chi tiết phòng thuê
        // ====================================================================
  public void Example9_RoomRentalDetailCreation()
        {
       var rentalDetail = new RoomRentalDetail
         {
                RentalDetailId = "CTT20240313145230",  // Auto-generated
     RoomId = "P101",
      RentalDate = DateTime.Now.AddDays(1),  // Check-in date
  ReturnDate = DateTime.Now.AddDays(3),  // Check-out date
                CheckoutDate = DateTime.Now.AddDays(3), // Actual checkout
     RentalType = 0,         // 0 = By day
     RentalPrice = 150000,   // Price per night
                Status = 0              // 0 = Active
  };

    /*
      * RentalType values:
             * 0 = Theo ngày (By day)
     * 1 = Theo giờ (By hour)
   * 2 = Theo tuần (By week)
      * 3 = Theo tháng (By month)
        */
 }

        // ====================================================================
        // EXAMPLE 10: Complete Workflow - Quy trình hoàn chỉnh
        // ====================================================================
        public void Example10_CompleteWorkflow()
        {
            /*
             * 1. UCBooking loads available rooms
             *    ↓
     * 2. User selects a room from the room card
  *    ↓
             * 3. OnBookRoom event is triggered
     *    ↓
  * 4. Validate:
  *    - Room is available
     *    - Check-in < Check-out
     *    ↓
         * 5. Load customers from database
             *    ↓
             * 6. Create and show BookingForm
      *    ↓
    * 7. User fills in:
           *    - Customer ID (auto-populate customer info)
             *    - Deposit amount
 *    - Processing status
   *    ↓
          * 8. User clicks "Lưu phiếu thuê"
        *    ↓
    * 9. Validate all data
        *    ↓
     * 10. If valid:
     *     - Create RentalDetail object
             *     - Add RoomRentalDetail objects
             *     - Set IsConfirmed = true
    *     - Show success message
 *     - Close form
    *    ↓
  * 11. Back in UCBooking:
   *     - Update room status to Occupied
 *     - Update room in database
             *     - Update UI with new status
           *     - Refresh room list
        */
        }

 // ====================================================================
        // Helper Methods
        // ====================================================================

        private List<Customer> LoadCustomersFromService()
      {
          // This would normally call the actual service
    return new List<Customer>
       {
       new Customer
{
     CustomerId = "KH001",
           Name = "Nguyễn Văn A",
       PhoneNumber = "0901234567",
 IdNumber = "123456789",
               DateOfBirth = new DateTime(1990, 5, 15),
       Address = "123 Hà Nội",
     Nationality = "Việt Nam",
               Gender = 1,
        IsDeleted = 0
          },
     new Customer
          {
    CustomerId = "KH002",
 Name = "Trần Thị B",
PhoneNumber = "0912345678",
      IdNumber = "987654321",
           DateOfBirth = new DateTime(1992, 8, 20),
       Address = "456 TP. Hồ Chí Minh",
   Nationality = "Việt Nam",
                Gender = 0,
       IsDeleted = 0
  }
            };
        }

        private int CalculateTotalPrice(Room room, DateTime checkIn, DateTime checkOut)
        {
 var nights = (int)(checkOut - checkIn).TotalDays;
      return room.Price * nights;
        }
    }
}

// ====================================================================
// UNIT TEST EXAMPLES
// ====================================================================

/*
[TestClass]
public class BookingFormTests
{
    [TestMethod]
    public void TestDateValidation()
    {
        // Arrange
        var checkIn = DateTime.Now.AddDays(1);
        var checkOut = DateTime.Now; // Invalid!
        
   // Act & Assert
        Assert.IsTrue(checkIn >= checkOut, "Should reject if check-in >= check-out");
}

 [TestMethod]
    public void TestPriceCalculation()
 {
        // Arrange
   var room = new Room { Price = 100000 };
        var checkIn = DateTime.Now;
        var checkOut = DateTime.Now.AddDays(5);
        var expectedPrice = 500000;
        
      // Act
        var nights = (int)(checkOut - checkIn).TotalDays;
        var actualPrice = room.Price * nights;
        
        // Assert
 Assert.AreEqual(expectedPrice, actualPrice);
    }

    [TestMethod]
    public void TestCustomerAutoPopulate()
    {
        // Arrange
    var customers = new List<Customer>
        {
  new Customer { CustomerId = "KH001", Name = "Test Customer" }
        };
        
        // Act
  var found = customers.FirstOrDefault(c => c.CustomerId == "KH001");
        
        // Assert
   Assert.IsNotNull(found);
        Assert.AreEqual("Test Customer", found.Name);
    }
}
*/
