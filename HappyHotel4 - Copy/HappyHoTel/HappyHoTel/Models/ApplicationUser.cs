using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace HappyHoTel.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Display(Name="Username")]
        public string Name { get; set; }

        //public ICollection<PhieuDatPhong> PhieuDatPhongs { get; set; }

        [NotMapped]
        public bool IsAdmin { get; set; }

    }
}
