namespace CaChepFinal2.Data
{
    public class ChiTietDichVuDatPhong
    {
        public int Id { get; set; }
        public int DatPhongId { get; set; }
        public int DichVuId { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaTien { get; set; }
        public virtual DatPhong GetDatPhong { get; set; }
        public virtual DichVu GetDichVu { get; set; }
    }
}