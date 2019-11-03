using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HappyHotel.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(20)]
        public string PassWords { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayDangKy { get; set; } = System.DateTime.Today;

        public string HoTenNguoiDung { get; set; }
        public string CmndNguoiDung { get; set; }
        public string SdtNguoiDung { get; set; }
        public string EmailNguoiDung { get; set; }
    }
}
