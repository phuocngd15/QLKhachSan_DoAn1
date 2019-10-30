using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class SystemAccount
    {
        [Key]
        public int SystemAccountId { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(20)]
        public String SystemAccountName { get; set; }

        [StringLength(20)]
        public String SystemAccountPassWords { get; set; }
    }
}
