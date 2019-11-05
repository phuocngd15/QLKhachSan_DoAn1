using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HappyHoTel.Models
{
    public class LoaiPhong
    {
        public LoaiPhong()
        {
            Phongs = new HashSet<Phong>();
        }

        [Key]
        public int LoaiPhongId { get; set; }

        [Required]
        public string TenLoaiPhong { get; set; }

        public string MoTaLoaiPhong { get; set; }

        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
