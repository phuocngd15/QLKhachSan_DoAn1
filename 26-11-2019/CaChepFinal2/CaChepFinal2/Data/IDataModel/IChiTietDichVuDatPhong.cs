using System.Collections.Generic;
using System.Linq;
namespace CaChepFinal2.Data
{
    public interface IChiTietDichVuDatPhong
    {
        IQueryable<ChiTietDichVuDatPhong> GetAll();
        ChiTietDichVuDatPhong GetOneById(int? id);

        IQueryable<ChiTietDichVuDatPhong> GetByIDPhieuDatPhong(int? id);
        void New(ChiTietDichVuDatPhong DatPhong);
        void Edit(ChiTietDichVuDatPhong DatPhong);
        void Delete(int id);

    }
}