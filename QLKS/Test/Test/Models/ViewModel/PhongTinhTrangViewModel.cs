using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test.Models.ViewModel
{
    public class PhongTinhTrangViewModel
    {
        public List<Phong> Phongs { get; set; }
        public SelectList LoaiPhongSelectList { get; set; }
        public string LoaiPhong { get; set; }
        public string SearchString { get; set; }
        public PhieuDatPhong PhieuDatPhong { get; set; }

        public List<Phong> ListPhongDat { get; set; }

    }
}
