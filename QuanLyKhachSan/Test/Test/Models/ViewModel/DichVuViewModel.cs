using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models.ViewModel
{
    public class DichVuViewModel
    {
        public DichVu DichVu { get; set; }
        public IEnumerable<LoaiDichVu> LoaiDichVu { get; set; }
    }
}
