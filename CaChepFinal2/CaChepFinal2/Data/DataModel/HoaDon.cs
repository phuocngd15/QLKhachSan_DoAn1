using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CaChepFinal2.Data
{
    public class HoaDon
    {
        public int Id { get; set; }

        public IEnumerable<ChiTietHoaDon> chiTietHoaDons { get; set; }

        public string TenNguoiTao { get; set; }

        public DateTime ThoiGianTao { get; set; }
        public decimal TongTien { get; set; }

        public string UserId { get; set; } // nguoi dat phong

       // public ApplicationUser User { get; set; }
    }
}