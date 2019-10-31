using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class PhieuDatPhong_Phong
    {
        [Key]
        public int PhongId { get; set; }
        public Phong Phongs { get; set; }

        [Key]
        public int PhieuDatPhongId { get; set; }
        public PhieuDatPhong PhieuDatPhongs { get; set; }

    }
}
