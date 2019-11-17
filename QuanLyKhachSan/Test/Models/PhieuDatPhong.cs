using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class PhieuDatPhong
    {
        [Key]
        public int PhieuDatPhongId { get; set; }

        // tinh trang = 0: chua nhan,,,,,, Tinh trang = 1: da nhan phong
        [Display(Name = "Tình trạng")]

        public bool TinhTrang { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Ngày nhận dự tính")]

        public DateTime NgayNhanDuTinh { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Ngày trả dự tính")]

        public DateTime NgayTraDuTinh { get; set; }

        [DefaultValue(0)]
        public int UserId { get; set; }
        public Account Account { get; set; }
    }
}
