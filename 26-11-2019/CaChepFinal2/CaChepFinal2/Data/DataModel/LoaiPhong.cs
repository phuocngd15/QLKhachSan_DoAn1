using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CaChepFinal2.Data
{
    public class LoaiPhong
    {
        public int Id { get; set; }
        [Display(Name="Tên loại phòng")]
        public string Name { get; set; }

        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        public string ImageUrl { get; set; }
        public IEnumerable<Phong> phongs { get; set; }
    }
}
