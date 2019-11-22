using System.Collections.Generic;

namespace CaChepFinal.Models.DataModels
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
