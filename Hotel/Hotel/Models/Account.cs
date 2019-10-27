using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(20)]
        public String UserName { get; set; }

        [StringLength(20)]
        public String PassWords { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayDangKy { get; set; }
        
        // tham chieu toi user
        public int NguoiDungId { get; set; }
        public User User { get; set; }

        //mot account co nhieu phieu dat phong
        public ICollection<PhieuDatPhong> PhieuDatPhongs { get; set; }
    }
}