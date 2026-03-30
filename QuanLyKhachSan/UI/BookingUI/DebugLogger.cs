using System;
using System.Diagnostics;
using System.IO;

namespace QuanLyKhachSan.UI.BookingUI
{
/// <summary>
    /// 🔍 Debug Logger - Ghi lại tất cả hoạt động để debug
    /// </summary>
    public static class DebugLogger
    {
        private static string _logFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
       "BookingDebug.log"
        );

static DebugLogger()
        {
   // Tạo log file khi khởi động
      try
            {
       File.WriteAllText(_logFilePath, $"=== BOOKING DEBUG LOG - {DateTime.Now:yyyy-MM-dd HH:mm:ss} ===\n");
}
            catch { }
      }

      /// <summary>
        /// Log thông tin chung
        /// </summary>
public static void Info(string message)
        {
            string msg = $"[INFO] {DateTime.Now:HH:mm:ss.fff} - {message}";
       Debug.WriteLine(msg);
            WriteToFile(msg);
        }

        /// <summary>
        /// Log thành công
        /// </summary>
        public static void Success(string message)
        {
  string msg = $"[✓ SUCCESS] {DateTime.Now:HH:mm:ss.fff} - {message}";
    Debug.WriteLine(msg);
            WriteToFile(msg);
        }

        /// <summary>
    /// Log lỗi
        /// </summary>
   public static void Error(string message, Exception ex = null)
     {
        string msg = $"[✗ ERROR] {DateTime.Now:HH:mm:ss.fff} - {message}";
 if (ex != null)
    {
         msg += $"\n  Exception: {ex.GetType().Name}";
       msg += $"\n  Message: {ex.Message}";
   msg += $"\n  StackTrace: {ex.StackTrace}";
            }
Debug.WriteLine(msg);
    WriteToFile(msg);
        }

/// <summary>
        /// Log warning
     /// </summary>
        public static void Warning(string message)
        {
       string msg = $"[⚠ WARNING] {DateTime.Now:HH:mm:ss.fff} - {message}";
            Debug.WriteLine(msg);
  WriteToFile(msg);
        }

      /// <summary>
   /// Log khi thêm phòng
        /// </summary>
     public static void LogAddRoom(string rentalDetailId, string roomId, DateTime rentalDate, 
            DateTime returnDate, int price)
    {
            Info($"➕ ADD ROOM EVENT:");
       Info($"  - RentalDetailId: {rentalDetailId}");
         Info($"  - RoomId: {roomId}");
      Info($"  - RentalDate: {rentalDate:dd/MM/yyyy HH:mm}");
          Info($"  - ReturnDate: {returnDate:dd/MM/yyyy HH:mm}");
            Info($"  - RentalPrice: {price:N0}");

int nights = Math.Max(1, (int)(returnDate.Date - rentalDate.Date).TotalDays);
            int total = price * nights;
            Info($"- Nights: {nights}");
     Info($"  - Total: {total:N0}");
        }

        /// <summary>
        /// Log khi thêm dịch vụ
     /// </summary>
        public static void LogAddService(string rentalDetailId, string serviceId, 
            int quantity, int price, DateTime usageDate)
        {
            Info($"🍔 ADD SERVICE EVENT:");
          Info($"  - RentalDetailId: {rentalDetailId}");
            Info($"  - ServiceId: {serviceId}");
        Info($"  - Quantity: {quantity}");
   Info($"  - ServicePrice: {price:N0}");
            Info($"  - UsageDate: {usageDate:dd/MM/yyyy}");
            Info($"  - Total: {(price * quantity):N0}");
        }

        /// <summary>
        /// Log khi checkout
        /// </summary>
      public static void LogCheckout(string rentalDetailId, int roomCount, int serviceCount, 
          int roomTotal, int serviceTotal, int grandTotal)
     {
      Info($"✓ CHECKOUT EVENT:");
  Info($"  - RentalDetailId: {rentalDetailId}");
            Info($"  - Rooms Count: {roomCount}");
            Info($"  - Services Count: {serviceCount}");
      Info($"  - Room Total: {roomTotal:N0}");
 Info($"  - Service Total: {serviceTotal:N0}");
        Info($"  - Grand Total: {grandTotal:N0}");
        }

 /// <summary>
        /// Log state hiện tại
   /// </summary>
   public static void LogState(int roomCount, int serviceCount, int totalRoomCost, 
            int totalServiceCost, int grandTotal)
        {
          Info($"📊 CURRENT STATE:");
  Info($"  - Rooms: {roomCount}");
    Info($"  - Services: {serviceCount}");
            Info($"  - Room Cost: {totalRoomCost:N0}");
            Info($"  - Service Cost: {totalServiceCost:N0}");
    Info($"  - Total: {grandTotal:N0}");
   }

 /// <summary>
        /// Log từng row trong grid
        /// </summary>
        public static void LogGridRows(string gridName, int count)
        {
            Info($"🔢 {gridName} ROWS: {count}");
        }

        /// <summary>
        /// Ghi vào file log
        /// </summary>
        private static void WriteToFile(string message)
        {
            try
            {
 File.AppendAllText(_logFilePath, message + "\n");
         }
      catch { }
        }

      /// <summary>
        /// Mở file log
        /// </summary>
    public static void OpenLogFile()
        {
            try
            {
      if (File.Exists(_logFilePath))
      {
        Process.Start(new ProcessStartInfo(_logFilePath) { UseShellExecute = true });
}
            }
            catch { }
        }

     /// <summary>
        /// Xóa log file
        /// </summary>
  public static void ClearLog()
        {
      try
            {
    File.Delete(_logFilePath);
            File.WriteAllText(_logFilePath, $"=== BOOKING DEBUG LOG - {DateTime.Now:yyyy-MM-dd HH:mm:ss} ===\n");
 }
            catch { }
        }

     /// <summary>
        /// Get đường dẫn log file
        /// </summary>
        public static string GetLogFilePath()
      {
            return _logFilePath;
        }
    }
}
