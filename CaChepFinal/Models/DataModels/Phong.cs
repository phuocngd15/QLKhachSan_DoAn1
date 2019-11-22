namespace CaChepFinal.Models.DataModels
{
    public class Phong
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int TrangThai { get; set; }
        public int LoaiPhongId { get; set; }
        public virtual LoaiPhong GetLoaiPhong { get; set; }
    }
}
