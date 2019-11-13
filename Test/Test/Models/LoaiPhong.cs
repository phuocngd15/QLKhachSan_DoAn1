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

        [Display(Name = "Tên Loại Phòng")]
        public string TenLoaiPhong { get; set; }

        [Display(Name = "Mô Tả Loại Phòng")]
        public string MoTaLoaiPhong { get; set; }

        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
