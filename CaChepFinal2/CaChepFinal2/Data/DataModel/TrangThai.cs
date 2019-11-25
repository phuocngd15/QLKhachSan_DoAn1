using System.Collections.Generic;

namespace CaChepFinal2.Data
{
    public class TrangThai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<DatPhong> datPhongs { get; set; }

    }
}
