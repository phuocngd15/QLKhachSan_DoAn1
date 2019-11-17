using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class PhieuDatPhong_Phong
    {
        [Key]
        public int PhongId { get; set; }
        [Display(Name = "Phòng")]

        public Phong Phongs { get; set; }

        public int PhieuDatPhongId { get; set; }
        public PhieuDatPhong PhieuDatPhongs { get; set; }
    }
}
