using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.Models
{
   [Table("NHANVIEN")]
    public class Employee
    {
        [Key]
     [Column("maNV")]
        [StringLength(20)]
        public string EmployeeId { get; set; }

   [Column("tenNV")]
   [StringLength(50)]
        public string Name { get; set; }

      [Column("gioiTinh")]
     public int Gender { get; set; }

      [Column("soNgayPhep")]
     public int DaysOff { get; set; }

   [Column("chucVu")]
public int Position { get; set; }

     [Column("ngaySinh")]
        public DateTime DateOfBirth { get; set; }

        [Column("ngayVaoLam")]
        public DateTime StartDate { get; set; }

  [Column("email")]
[StringLength(100)]
        public string Email { get; set; }

        [Column("luong1Ngay")]
   public int DailySalary { get; set; }

        [Column("xuLy")]
        public int IsDeleted { get; set; } = 0;

        // Navigation properties
   public virtual ICollection<RentalDetail> RentalDetails { get; set; } = new List<RentalDetail>();
      public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
    }
}
