using System;

namespace CaChepFinal2.Data
{// tam thoi model nay khong sai
    public class TrangThaiDatPhong
    {
        public int Id { get; set; }
        public int DatPhongId { get; set; }
        public int TrangThaiId { get; set; }
       
        public DateTime ThoiGian{get;set;}
        public virtual DatPhong GetDatPhong { get; set; }
        public virtual TrangThai GetTrangThai { get; set; }
    }
}