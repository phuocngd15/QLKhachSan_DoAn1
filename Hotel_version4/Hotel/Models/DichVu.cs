using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Hotel.Models
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
