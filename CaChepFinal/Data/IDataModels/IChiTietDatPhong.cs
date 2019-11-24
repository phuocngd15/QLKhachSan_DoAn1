using System.Collections.Generic;
using System.Linq;
namespace CaChepFinal.Data
{
    public interface IChiTietDatPhong
    {
        IQueryable<ChiTietDatPhong> GetAll();
        ChiTietDatPhong GetOneById(int? id);

        IQueryable<ChiTietDatPhong> GetByIDPhieuDatPhong(int? id);
        void New(ChiTietDatPhong DatPhong);
        void Edit(ChiTietDatPhong DatPhong);
        void Delete(int id);

    }
}