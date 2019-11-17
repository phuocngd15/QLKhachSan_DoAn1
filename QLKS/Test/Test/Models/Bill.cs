using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name ="Ngày nhận thực tế")]
        public DateTime NgayNhanThucTe { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name ="Ngày trả thực tế")]
        public DateTime NgayTraThucTe { get; set; }

        [Display(Name ="Tiền đặt cọc")]
        public decimal TienDatCoc { get; set; }

        [Display(Name ="Tổng tiền thanh toán")]
        public decimal TongTienThanhToan { get; set; }

        [Display(Name ="Phiếu đặt phòng")]
        public int PhieuDatPhongId { get; set; }
    }
}
