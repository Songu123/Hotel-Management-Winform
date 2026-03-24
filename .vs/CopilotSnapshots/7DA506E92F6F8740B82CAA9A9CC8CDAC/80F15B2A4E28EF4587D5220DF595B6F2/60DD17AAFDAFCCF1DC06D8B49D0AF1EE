using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.Models
{
    [Table("CHITIETCHUCNANG")]
    public class RoleFunction
    {
        [Key]
        [Column("maPQ")]
        [StringLength(20)]
        [ForeignKey("Role")]
   public string RoleId { get; set; } = string.Empty;

        [Key]
    [Column("maChucNang")]
        [StringLength(20)]
        [ForeignKey("Function")]
        public string FunctionId { get; set; } = string.Empty;

        // Navigation properties
  public virtual Role? Role { get; set; }
        public virtual Function? Function { get; set; }
    }
}
