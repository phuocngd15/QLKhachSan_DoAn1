using System.Collections.Generic;

namespace CaChepFinal.Data
{
    public class LoaiPhong
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<Phong> phongs { get; set; }
    }
}
