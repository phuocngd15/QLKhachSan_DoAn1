﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaChepFinal2.Data;

namespace CaChepFinal2.Areas.Admin.Models
{
    public class DatPhongCartVM
    {
        public  DatPhong newDatPhong { get; set; }
        public List<Phong> LsPhongDatPhongs { get; set; }
        public List<DichVu> LsDichVuDatPhongs { get; set; }

    }
}