using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Phong
    {
        [Key]
        public int IdPhong { get; set; }

        public string TenPhong { get; set; }

        public int SoNguoiOToiDa { get; set; }

        public string MoTaPhong { get; set; }

        public decimal CachTinhTien { get; set; }

        public decimal PhuThu { get; set; }

        //0: Phong can clean, 1: phong San sang, 2: Phong co nguoi, 3: PhongDaDatCoc
        public int TinhTrangPhong { get; set; }

        public int IdLoaiPhong { get; set; }
        public LoaiPhong LoaiPhongs { get; set; }


        /
        public ICollection<PhieuDatPhong> PhieuDatPhongs { get; set; }
    }
}
