using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace CaChepFinal.Models.ViewModels
{
    public class NewDichVuViewModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name of the DichVu")]
        [Display(Name = "Ten DichVu*")]
        [StringLength(20)]
        public string Name { get; set; }

        [Display(Name = "Short Description")]
        public string ShortDescription { get; set; }


        [Required(ErrorMessage = "Please enter price of the food")]
        [Range(0.1, double.MaxValue)]
        [Display(Name = "GiaTien*")]
        public decimal? GiaTien { get; set; }
        public string Hinh { get; set; }
        public int? ConHang { get; set; }

        [Required(ErrorMessage = "Please select category")]
        [Range(1, double.MaxValue)]
        public int CategoryId { get; set; }
    }
}