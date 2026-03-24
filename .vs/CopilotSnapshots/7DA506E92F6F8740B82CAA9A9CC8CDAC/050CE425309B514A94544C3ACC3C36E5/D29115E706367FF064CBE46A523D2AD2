using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.Models
{
   [Table("CHITIETTHUEPHONG")]
    public class RoomRentalDetail
    {
 [Key]
  [Column("maCTT")]
    [StringLength(20)]
     [ForeignKey("RentalDetail")]
   public string RentalDetailId { get; set; }

        [Key]
 [Column("maP")]
        [StringLength(20)]
 [ForeignKey("Room")]
  public string RoomId { get; set; }

        [Key]
 [Column("ngayThue")]
    public DateTime RentalDate { get; set; }

[Column("ngayTra")]
  public DateTime ReturnDate { get; set; }

  [Column("ngayCheckOut")]
      public DateTime CheckoutDate { get; set; }

[Column("loaiHinhThue")]
   public int RentalType { get; set; }

[Column("giaThue")]
        public int RentalPrice { get; set; }

      [Column("tinhTrang")]
public int Status { get; set; }

    // Navigation properties
      public virtual RentalDetail RentalDetail { get; set; }
      public virtual Room Room { get; set; }
    }
}
