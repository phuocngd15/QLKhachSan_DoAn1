using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
