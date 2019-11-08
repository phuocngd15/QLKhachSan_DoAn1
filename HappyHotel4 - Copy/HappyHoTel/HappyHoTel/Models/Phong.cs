using System.ComponentModel.DataAnnotations;

namespace HappyHoTel.Models
{
    public class Phong
    {
        [Key]
        public int PhongId { get; set; }

        public string TenPhong { get; set; }

        public int SoNguoiOToiDa { get; set; }

        public string MoTaPhong { get; set; }

        public decimal CachTinhTien { get; set; }

        public decimal PhuThu { get; set; }

        //0: Phong can clean, 1: phong San sang, 2: Phong co nguoi, 3: PhongDaDatCoc
        public string TinhTrangPhong { get; set; }

        public int LoaiPhongId { get; set; }
        public LoaiPhong LoaiPhongs { get; set; }
    }
}
