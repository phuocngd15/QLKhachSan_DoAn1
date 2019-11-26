using System.Collections.Generic;

namespace CaChepFinal2.Data
{
    public class LoaiDV
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<DichVu> dichVus { get; set; }
    }
}