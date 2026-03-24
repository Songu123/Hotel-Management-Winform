using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.Models
{
    [Table("KHACHHANG")]
    public class Customer
    {
        [Key]
        [Column("maKH")]
        [StringLength(20)]
    public string CustomerId { get; set; }

        [Column("tenKH")]
        [StringLength(50)]
    public string Name { get; set; }

        [Column("CMND")]
        [StringLength(20)]
        public string IdNumber { get; set; }

        [Column("gioiTinh")]
        public int Gender { get; set; }

        [Column("sDT")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Column("queQuan")]
        [StringLength(100)]
        public string Address { get; set; }

        [Column("quocTich")]
        [StringLength(100)]
        public string Nationality { get; set; }

        [Column("ngaySinh")]
    public DateTime DateOfBirth { get; set; }

        [Column("xuLy")]
        public int IsDeleted { get; set; } = 0;

        // Navigation properties
        public virtual ICollection<RentalDetail> RentalDetails { get; set; } = new List<RentalDetail>();
    }
}
