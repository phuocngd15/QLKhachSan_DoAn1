using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class User
    {
        [Key]
        public int NguoiDungId { get; set; }

        [Display(Name ="Họ tên")]
        public string HoTenNguoiDung { get; set; }

        [Display(Name = "Chứng minh nhân dân")]
        public string CmndNguoiDung { get; set; }

        [Display(Name = "Số điện thoại")]
        public string SdtNguoiDung { get; set; }

        [Display(Name = "Email")]
        public string EmailNguoiDung { get; set; }

        [Display(Name = "Tên Account")]
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
