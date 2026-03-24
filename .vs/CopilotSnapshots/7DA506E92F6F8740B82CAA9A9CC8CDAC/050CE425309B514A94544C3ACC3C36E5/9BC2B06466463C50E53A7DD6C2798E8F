using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.Models
{
    [Table("CHITIETTIENICH")]
    public class RoomAmenity
    {
        [Key]
 [Column("maP")]
        [StringLength(20)]
       [ForeignKey("Room")]
       public string RoomId { get; set; }

        [Key]
    [Column("maTI")]
   [StringLength(20)]
    [ForeignKey("Amenity")]
public string AmenityId { get; set; }

  [Column("soLuong")]
    public int Quantity { get; set; }

        // Navigation properties
     public virtual Room Room { get; set; }
       public virtual Amenity Amenity { get; set; }
    }
}
