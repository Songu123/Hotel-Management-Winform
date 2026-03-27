using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.Models
{
    /// <summary>
    /// Ghi lại lịch sử dọn dẹp phòng
    /// </summary>
    [Table("DONPHONG")]
    public class RoomCleaning
    {
        [Key]
        [Column("maDonPhong")]
        [StringLength(50)]
        public string CleaningId { get; set; } = string.Empty;

        [Column("maP")]
        [StringLength(20)]
        [ForeignKey("Room")]
 public string RoomId { get; set; } = string.Empty;

     [Column("maNV")]
        [StringLength(20)]
  [ForeignKey("Employee")]
        public string EmployeeId { get; set; } = string.Empty;

      [Column("ngayBatDau")]
        public DateTime StartTime { get; set; }

        [Column("ngayKetThuc")]
     public DateTime? EndTime { get; set; }

      [Column("tinhTrangPhong")]
        public int RoomConditionBefore { get; set; } // 0: Tốt, 1: Cần sửa chữa, 2: Cần vệ sinh

    [Column("tinhTrangPhongSau")]
        public int RoomConditionAfter { get; set; }

   [Column("ghiChu")]
        [StringLength(500)]
    public string Notes { get; set; } = string.Empty;

    [Column("trangThaiDon")]
        public int Status { get; set; } = 0; // 0: Đang thực hiện, 1: Hoàn thành, 2: Hủy

        [Column("xuLy")]
   public int IsDeleted { get; set; } = 0;

        // Navigation properties
        public virtual Room? Room { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}
