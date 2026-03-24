namespace QuanLyKhachSan.Models
{
    /// <summary>
    /// Đại diện cho một booking/đơn đặt phòng
    /// </summary>
    public class Booking
    {
        /// <summary>
 /// ID duy nhất của booking
      /// </summary>
        public int BookingId { get; set; }

        /// <summary>
   /// ID khách hàng
 /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// ID phòng
 /// </summary>
     public int RoomId { get; set; }

      /// <summary>
        /// Ngày nhận phòng (check-in)
   /// </summary>
        public DateTime CheckInDate { get; set; }

        /// <summary>
    /// Ngày trả phòng (check-out)
     /// </summary>
        public DateTime CheckOutDate { get; set; }

    /// <summary>
        /// Số lượng khách sẽ lưu trú
        /// </summary>
      public int NumberOfGuests { get; set; }

        /// <summary>
      /// Trạng thái booking
        /// </summary>
        public BookingStatus Status { get; set; } = BookingStatus.Pending;

        /// <summary>
        /// Giá phòng theo đêm (lưu lại giá tại thời điểm booking)
        /// </summary>
        public decimal RoomPricePerNight { get; set; }

     /// <summary>
     /// Tổng tiền đặt cọc trước (nếu có)
 /// </summary>
        public decimal DepositAmount { get; set; } = 0;

   /// <summary>
        /// Ghi chú đặc biệt từ khách hàng
     /// </summary>
   public string Notes { get; set; } = string.Empty;

        /// <summary>
        /// Ngày tạo booking
        /// </summary>
     public DateTime CreatedDate { get; set; } = DateTime.Now;

   /// <summary>
      /// Ngày cập nhật lần cuối
     /// </summary>
 public DateTime? UpdatedDate { get; set; }

     /// <summary>
        /// Navigation property: Thông tin khách hàng
    /// </summary>
        public Customer? Customer { get; set; }

    /// <summary>
        /// Navigation property: Thông tin phòng
        /// </summary>
        public Room? Room { get; set; }

        /// <summary>
        /// Navigation property: Danh sách hóa đơn liên quan đến booking này
  /// </summary>
       public ICollection<Invoice>? Invoices { get; set; } = new List<Invoice>();
    }
}
