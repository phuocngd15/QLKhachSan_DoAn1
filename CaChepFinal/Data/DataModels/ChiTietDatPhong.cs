namespace CaChepFinal.Data
{
    public class ChiTietDatPhong
    {
        public int Id { get; set; }
        public int DatPhongId { get; set; }
        public int PhongId { get; set; }
        public int TongSoNgay { get; set; }
        public decimal GiaTienMotNgay { get; set; }
        public virtual Phong Phong { get; set; }
        public virtual DatPhong DatPhong { get; set; }
    }
}