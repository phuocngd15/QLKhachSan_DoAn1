using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class ChiTietHoaDon
    {
        [Key]
        public int IdBill { get; set; }
        [Display(Name = "Hóa đơn")]

        public Bill Bill { get; set; }

        [Display(Name = "Tên dịch vụ")]
        public string TenDichVu { get; set; }

        [Display(Name = "Số lượng")]
        public int SoLuong { get; set; }

        [Display(Name = "Giá tiền")]
        public decimal GiaTienDichVu { get; set; }
        [Display(Name ="Phiếu đặt phòng")]
        public int PhieuDatPhongId { get; set; }
    }
}
