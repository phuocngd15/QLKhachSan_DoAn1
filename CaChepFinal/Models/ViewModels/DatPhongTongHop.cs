using CaChepFinal.Models.DataModels;
using  System.Collections.Generic;

namespace CaChepFinal.Models.ViewModels
{
    public class DatPhongTongHop
    {
        public  List<DatPhong> datPhongs{get;set;}
        public  List<ChiTietDatPhong> chiTietDatPhongs{get;set;}
        public  DatPhong newDatPhong{get;set;}

    }
}