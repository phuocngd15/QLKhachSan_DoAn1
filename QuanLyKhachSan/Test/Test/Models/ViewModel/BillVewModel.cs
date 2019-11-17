using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models.ViewModel
{
    public class BillVewModel
    {
        public Bill Bill { get; set; }
        public IEnumerable<PhieuDatPhong> PhieuDatPhong { get; set; }

    }
}
