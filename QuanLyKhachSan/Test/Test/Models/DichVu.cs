using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class DichVu
    {
        [Key]
        public int DichVuId { get; set; }

        [Display(Name ="Tên dịch vụ")]
        public string TenDichVu { get; set; }

        [Display(Name = "Giá bán")]

        public decimal GiaBan { get; set; }

        [Display(Name = "Giá nhập")]

        public decimal GiaNhap { get; set; }


        public int LoaiDichVuId { get; set; }
        [Display(Name = "Loại dịch vụ")]

        public LoaiDichVu LoaiDichVu { get; set; }
    }
}
