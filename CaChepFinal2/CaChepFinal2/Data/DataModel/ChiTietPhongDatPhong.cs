namespace CaChepFinal2.Data
{
    public class ChiTietPhongDatPhong
    {
        public int Id { get; set; }
        public int DatPhongId { get; set; }  // get Id from phong xong add vo day
        public int PhongId { get; set; } // them phong vao gio hang
        public int TongSoNgay { get; set; } // check in check out. du kien
        public decimal GiaTienMotNgay { get; set; } // get gia tien from phong
        public virtual DatPhong DatPhong { get; set; }
        public virtual Phong Phong { get; set; }
       
    }
}