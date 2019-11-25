namespace CaChepFinal.Data
{
    public class ChiTietHoaDon
    {
        public int Id { get; set; }
        public int HoaDonId { get; set; }
        public int DichVud { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaTien { get; set; }
        public virtual HoaDon GetHoaDon { get; set; }
        public virtual DichVu GetDichVu { get; set; }
    }
}