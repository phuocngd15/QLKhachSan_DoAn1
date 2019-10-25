using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Hotel.Models
{
    public class ChiTietHoaDon
    {
       
        public int IdBill { get; set; }
        public Bill Bill { get; set; }

        public string TenDichVu { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaTienDichVuDecimal { get; set; }
    }
}
