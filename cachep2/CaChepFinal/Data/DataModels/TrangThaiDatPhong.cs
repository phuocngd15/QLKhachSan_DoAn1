namespace CaChepFinal.Data
{
    public class TrangThaiDatPhong
    {
        public int Id { get; set; }
        public int DatPhongId { get; set; }
        public int TrangThaiId { get; set; }
       
        public virtual DatPhong GetDatPhong { get; set; }
        public virtual TrangThai GetTrangThai { get; set; }
    }
}