using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HappyHoTel.Models
{
    public class LoaiDichVu
    {
        public LoaiDichVu()
        {
            DichVus = new HashSet<DichVu>();
        }
        [Key]
        public int LoaiDichVuId { get; set; }
        public string TenLoaiDichVu { get; set; }

        public ICollection<DichVu> DichVus { get; set; }
    }
}
