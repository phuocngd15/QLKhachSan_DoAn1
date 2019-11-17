using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class Phong
    {
        [Key]
        public int PhongId { get; set; }


        [Display(Name ="Tên phòng")]
        public string TenPhong { get; set; }

        [Display(Name ="Số người ở tối đa")]
        public int SoNguoiOToiDa { get; set; }
        public string Image { get; set; }

        [Display(Name ="Mô tả phòng")]
        public string MoTaPhong { get; set; }


        [Display(Name ="Cách tính tiền")]
        public decimal CachTinhTien { get; set; }


        [Display(Name ="Phụ thu")]
        public decimal PhuThu { get; set; }

        //0: Phong can clean, 1: phong San sang, 2: Phong co nguoi, 3: PhongDaDatCoc
        [Display(Name="Tình trạng phòng")]
        public string TinhTrangPhong { get; set; }

        public int LoaiPhongId { get; set; }

        [Display(Name = "Loại phòng")]
        public virtual LoaiPhong LoaiPhongs { get; set; }
    }
}
