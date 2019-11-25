using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaChepFinal2.Data;

namespace CaChepFinal2.Areas.Admin.Models
{
    public class DatPhongDetails
    {
        public DatPhong GetDatPhong { get; set; }

        public List<ChiTietPhongDatPhong> ChiTietPhongDatPhongs { get; set; }
        public List<ChiTietDichVuDatPhong> ChiTietDichVuDatPhongs { get; set; }
        //public DatPhong DatPhong { get; set; }
        //public decimal  { get; set; }

    }
}
