using System.ComponentModel.DataAnnotations;

namespace HappyHoTel.Models
{
    public class DichVu
    {
        [Key]
        public int DichVuId { get; set; }
        public string TenDichVu { get; set; }
        public decimal GiaBan { get; set; }
        public decimal GiaNhap { get; set; }

        public int LoaiDichVuId { get; set; }
        public LoaiDichVu LoaiDichVu { get; set; }
    }
}
