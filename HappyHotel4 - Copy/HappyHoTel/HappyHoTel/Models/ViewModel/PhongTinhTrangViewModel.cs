using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HappyHoTel.Models.ViewModel
{
    public class PhongTinhTrangViewModel
    {
        public List<Phong> Phongs { get; set; }
        public SelectList TinhTrangSelectList { get; set; }
        public string TinhTrang { get; set; }
        public string SearchString { get; set; }
        public PhieuDatPhong PhieuDatPhong { get; set; }


    }
}
