using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Services.Interfaces
{
    /// <summary>
    /// Service interface cho in phiếu thuê
    /// </summary>
    public interface IPrintService
    {
      /// <summary>
      /// In phiếu thuê dạng HTML
        /// </summary>
        Task<string> GenerateRentalDetailHtmlAsync(RentalDetail rentalDetail, List<RoomRentalDetail> roomDetails);

    /// <summary>
 /// In phiếu thuê (dùng PrintDialog)
        /// </summary>
        Task<bool> PrintRentalDetailAsync(RentalDetail rentalDetail, List<RoomRentalDetail> roomDetails);

        /// <summary>
        /// Lưu phiếu thuê dưới dạng PDF
        /// </summary>
        Task<bool> SaveRentalDetailAsPdfAsync(RentalDetail rentalDetail, List<RoomRentalDetail> roomDetails, string filePath);

   /// <summary>
        /// Tạo preview HTML cho phiếu thuê
      /// </summary>
        Task<string> PreviewRentalDetailAsync(RentalDetail rentalDetail, List<RoomRentalDetail> roomDetails);
    }
}
