using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class PhongPhieuDatPhong
    {
        public int PhongId { get; set; }
        public Phong phong { get; set; }

        public int PhieuDatPhongId { get; set; }
        public PhieuDatPhong phieuDatPhong { get; set; }


    
    }
}
