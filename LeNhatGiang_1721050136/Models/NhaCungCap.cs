using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeNhatGiang_1721050136.Models
{

    [Table("NhaCungCap")]
    public class NhaCungCap
    {
        [Key]
        [Display(Name ="Mã Nhà Cung Cấp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaNhaCungCap { get; set; }
        [StringLength(50)]
        [Display(Name = "Tên Nhà Cung Cấp")]
        public string TenNhaCungCap { get; set; }
        public ICollection<SanPham> SanPhams { get; set; }


    }
}