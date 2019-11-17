using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class LoaiDichVu
    {
        public LoaiDichVu()
        {
            DichVus = new HashSet<DichVu>();
        }
        [Key]
        public int LoaiDichVuId { get; set; }

        [Display(Name = "Tên loại dịch vụ")]

        public string TenLoaiDichVu { get; set; }

        public ICollection<DichVu> DichVus { get; set; }
    }
}
