using System.Collections.Generic;
using System.Linq;
namespace CaChepFinal.Data
{
    public interface IHoaDon
    {
        IQueryable<HoaDon> GetAll();
        HoaDon GetById(int id);
        void New(HoaDon DatPhong);
        void Edit(HoaDon DatPhong);
        void Delete(int id);
    }
}