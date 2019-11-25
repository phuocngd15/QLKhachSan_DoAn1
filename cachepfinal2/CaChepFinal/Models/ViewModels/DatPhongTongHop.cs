using  System.Collections.Generic;
using CaChepFinal.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace CaChepFinal.Models.ViewModels
{
    public class DatPhongTongHop
    {
        public  List<DatPhong> datPhongs{get;set;}
        public  List<ChiTietDatPhong> chiTietDatPhongs{get;set;}
        public  DatPhong newDatPhong{get;set;}
        public TrangThaiDatPhong trangThaiDatPhong{get;set;}
         public SelectList ListNameTrangThai {get;set;}

    }
}