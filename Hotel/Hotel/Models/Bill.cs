using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Bill
    {
        
        public int IdPhieuDatPhong { get; set; }
 
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime NgayNhanThucTe { get; set; }
 
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime NgayTraThucTe { get; set; }

        public decimal TienDatCoc { get; set; }
        public decimal TongTienThanhToan { get; set; }
    }
}
