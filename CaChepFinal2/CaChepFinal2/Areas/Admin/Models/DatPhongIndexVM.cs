using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaChepFinal2.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CaChepFinal2.Areas.Admin.Models
{
    public class DatPhongIndexVM
    {
        public List<DatPhong> datPhongs { get; set; }
        public List<ChiTietPhongDatPhong> chiTietDatPhongs { get; set; }
        public DatPhong newDatPhong { get; set; } 
        public TrangThaiDatPhong trangThaiDatPhong { get; set; }
        public SelectList ListNameTrangThai { get; set; }
        public string TrangThai { get; set; }

        public  string CMND { get; set; }


    }
}
