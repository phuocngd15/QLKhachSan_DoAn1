namespace CaChepFinal2.Data
{
    public class DichVu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int InStock { get; set; }
        public int LoaiDVId { get; set; }
        public virtual LoaiDV GetLoaiDV { get; set; }
    }
}
