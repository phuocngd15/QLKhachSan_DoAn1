using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace HappyHoTel.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Display(Name="Username")]
        public string Name { get; set; }

        [NotMapped]
        public bool IsAdmin { get; set; }

    }
}
