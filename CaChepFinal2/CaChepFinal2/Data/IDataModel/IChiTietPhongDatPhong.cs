using System.Collections.Generic;
using System.Linq;
namespace CaChepFinal2.Data
{
    public interface IChiTietPhongDatPhong
    {
        IQueryable<ChiTietPhongDatPhong> GetAll();
        ChiTietPhongDatPhong GetOneById(int? id);

        IQueryable<ChiTietPhongDatPhong> GetByIDPhieuDatPhong(int? id);
        void New(ChiTietPhongDatPhong DatPhong);
        void Edit(ChiTietPhongDatPhong DatPhong);
        void Delete(int id);

    }
}