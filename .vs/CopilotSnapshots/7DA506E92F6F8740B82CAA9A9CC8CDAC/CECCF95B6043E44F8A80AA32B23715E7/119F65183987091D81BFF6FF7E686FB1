using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.Models
{
    [Table("DICHVU")]
    public class Service
    {
        [Key]
        [Column("maDV")]
        [StringLength(20)]
        public string ServiceId { get; set; }

        [Column("tenDV")]
        [StringLength(100)]
        public string Name { get; set; }

        [Column("loaiDV")]
        [StringLength(128)]
        public string Type { get; set; }

        [Column("giaDV")]
        public int Price { get; set; }

        [Column("hinhAnh")]
        public string Image { get; set; }

        [Column("xuLy")]
        public int IsDeleted { get; set; } = 0;

        // Navigation properties
        public virtual ICollection<ServiceRentalDetail> ServiceRentalDetails { get; set; } = new List<ServiceRentalDetail>();
    }
}
