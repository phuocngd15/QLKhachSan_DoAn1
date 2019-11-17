using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class LoaiPhong
    {
        public LoaiPhong()
        {
            Phongs = new HashSet<Phong>();
        }

        [Key]
        public int LoaiPhongId { get; set; }

        [Display(Name = "Tên loại phòng")]
        public string TenLoaiPhong { get; set; }

        [Display(Name = "Mô tả loại phòng")]
        public string MoTaLoaiPhong { get; set; }

        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
