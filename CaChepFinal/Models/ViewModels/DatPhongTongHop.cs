using  System.Collections.Generic;
using CaChepFinal.Data;
namespace CaChepFinal.Models.ViewModels
{
    public class DatPhongTongHop
    {
        public  List<DatPhong> datPhongs{get;set;}
        public  List<ChiTietDatPhong> chiTietDatPhongs{get;set;}
        public  DatPhong newDatPhong{get;set;}

    }
}