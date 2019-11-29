using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaChepFinal2.Data.DataModel
{
    public class PhongImage
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string ShortDescription { get; set; }
        public int PhongId { get; set; }
        public virtual Phong phongs { get; set; }
    }
}
