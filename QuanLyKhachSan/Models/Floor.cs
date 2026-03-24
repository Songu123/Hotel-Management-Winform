namespace QuanLyKhachSan.Models
{
    /// <summary>
    /// Đại diện cho một tầng trong khách sạn
    /// </summary>
    public class Floor
  {
        /// <summary>
        /// ID duy nhất của tầng
        /// </summary>
        public int FloorId { get; set; }

        /// <summary>
        /// Số tầng (1, 2, 3, ...)
        /// </summary>
        public int FloorNumber { get; set; }

    /// <summary>
        /// Tên tầng (VD: "Tầng 1", "Tầng Trệt", ...)
     /// </summary>
        public string FloorName { get; set; } = string.Empty;

        /// <summary>
  /// Mô tả tầng
    /// </summary>
        public string Description { get; set; } = string.Empty;

   /// <summary>
        /// Số phòng tối đa trên tầng này
    /// </summary>
        public int MaxRooms { get; set; }

        /// <summary>
        /// Ghi chú về tầng
        /// </summary>
 public string Notes { get; set; } = string.Empty;

        /// <summary>
        /// Ngày tạo bản ghi
        /// </summary>
      public DateTime CreatedDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Ngày cập nhật lần cuối
    /// </summary>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Navigation property: Danh sách phòng trên tầng này
        /// </summary>
        public ICollection<Room>? Rooms { get; set; } = new List<Room>();
    }
}
