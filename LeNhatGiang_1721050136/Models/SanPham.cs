using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeNhatGiang_1721050136.Models
{
    [Table("SanPham")]
    public class SanPham
    {
        [Key]
        [Display(Name = "Mã Sản Phẩm")]
        public int MaSanPham { get; set; }
        [Display(Name = "Tên Sản Phẩm")]
        public string TenSanPham { get; set; }
        [Display(Name = "Mã Nhà cung cấp")]
        public int Manhacungcap { get; set; }
        [ForeignKey("Manhacungcap")]
        public virtual NhaCungCap NhaCungCap { get; set; }

    }
}