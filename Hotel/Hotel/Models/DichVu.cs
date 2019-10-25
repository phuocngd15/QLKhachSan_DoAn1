using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class DichVu
    {
        public int IdDichVu { get; set; }
        public string TenDichVu { get; set; }
        public decimal GiaBan { get; set; }
        public decimal GiaNhap { get; set; }

        public int IdLoaiDichVu { get; set; }
        public LoaiDichVu LoaiDichVu { get; set; }
    }
}
