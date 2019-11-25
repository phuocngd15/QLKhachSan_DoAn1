using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CaChepFinal2.Data
{
    public class DatPhong
    {
        public int Id { get; set; }

        public IEnumerable<ChiTietPhongDatPhong> chiTietDatPhongsLine { get; set; }
       // public IEnumerable<TrangThaiDatPhong> OrderLines { get; set; }

        public string TenNguoiDat { get; set; }
        public  HoaDon hoadon { get; set; }
        public string Address { get; set; }

        public string City { get; set; }

        public string CMND { get; set; }
        public string SDT { get; set; }

        public decimal TienDatCoc { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "ThoiGianNhan")]
        public DateTime ThoiGianNhanPhongDuKien { get; set; }

         [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
         [Display(Name = "ThoiGianTra")]
        public DateTime ThoiGianTraPhongDuKien { get; set; }

        public string UserId { get; set; } // nguoi dat phong

        public virtual TrangThai GetTrangThai { get; set; }

       // public ApplicationUser User { get; set; }
    }
}