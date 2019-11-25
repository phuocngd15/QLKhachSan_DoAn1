using System.Collections.Generic;
using System.Linq;
namespace CaChepFinal.Data
{
    public interface IChiTietHoaDon
    {
        IQueryable<ChiTietHoaDon> GetAll();
        ChiTietHoaDon GetOneById(int? id);

      //  IQueryable<ChiTietHoaDon> GetByIDPhieuDatPhong(int? id);
        void New(ChiTietHoaDon DatPhong);
        void Edit(ChiTietHoaDon DatPhong);
        void Delete(int id);

    }
}