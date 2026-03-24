namespace QuanLyKhachSan.Models
{
    /// <summary>
    /// Trạng thái phòng trong hệ thống
    /// </summary>
    public enum RoomStatus
    {
        /// <summary>Phòng trống, sẵn sàng cho thuê</summary>
        Available = 0,

        /// <summary>Phòng đã được đặt trước nhưng khách chưa check-in</summary>
        Reserved = 1,

        /// <summary>Phòng đang được khách thuê</summary>
 Occupied = 2,

        /// <summary>Phòng đang bảo trì/dọn dẹp</summary>
    Maintenance = 3,

        /// <summary>Phòng tạm thời không sử dụng</summary>
        OutOfService = 4
    }

    /// <summary>
    /// Trạng thái booking
    /// </summary>
    public enum BookingStatus
    {
        /// <summary>Booking mới, chưa xác nhận</summary>
    Pending = 0,

        /// <summary>Booking đã xác nhận</summary>
      Confirmed = 1,

        /// <summary>Khách đã check-in</summary>
      CheckedIn = 2,

        /// <summary>Khách đã check-out</summary>
        CheckedOut = 3,

   /// <summary>Booking bị hủy</summary>
        Cancelled = 4
    }

    /// <summary>
    /// Loại khách hàng
    /// </summary>
    public enum CustomerType
    {
        /// <summary>Khách lẻ</summary>
        Individual = 0,

        /// <summary>Khách đặt theo nhóm/công ty</summary>
  Corporate = 1,

        /// <summary>Khách VIP/thân thiết</summary>
        VIP = 2
    }

    /// <summary>
    /// Phương thức thanh toán
    /// </summary>
    public enum PaymentMethod
    {
        /// <summary>Thanh toán bằng tiền mặt</summary>
        Cash = 0,

        /// <summary>Thanh toán bằng thẻ tín dụng/ghi nợ</summary>
        Card = 1,

        /// <summary>Thanh toán qua ví điện tử</summary>
      EWallet = 2,

        /// <summary>Thanh toán qua chuyển khoản ngân hàng</summary>
        BankTransfer = 3
    }

    /// <summary>
    /// Trạng thái hóa đơn
    /// </summary>
    public enum InvoiceStatus
    {
        /// <summary>Hóa đơn nháp, chưa hoàn tất</summary>
        Draft = 0,

        /// <summary>Hóa đơn chính thức đã phát hành</summary>
 Issued = 1,

        /// <summary>Hóa đơn đã thanh toán đủ</summary>
  Paid = 2,

        /// <summary>Hóa đơn bị hủy</summary>
        Cancelled = 3
    }

    /// <summary>
    /// Loại dịch vụ
    /// </summary>
    public enum ServiceType
    {
        /// <summary>Dịch vụ phòng (ăn uống, nước uống...)</summary>
        RoomService = 0,

/// <summary>Dịch vụ giặt ủi</summary>
        Laundry = 1,

        /// <summary>Dịch vụ SPA/massage</summary>
        Spa = 2,

        /// <summary>Dịch vụ đưa đón sân bay</summary>
AirportTransfer = 3,

      /// <summary>Dịch vụ khác</summary>
        Other = 4
    }
}
