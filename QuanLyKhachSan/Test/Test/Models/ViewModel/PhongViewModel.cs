using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models.ViewModel
{
    public class PhongViewModel
    {
        public Phong Phong { get; set; }
        public IEnumerable<LoaiPhong> LoaiPhongs { get; set; }
    }
}
