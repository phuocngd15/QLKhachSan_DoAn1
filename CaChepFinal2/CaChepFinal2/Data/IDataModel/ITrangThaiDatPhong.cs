using System.Collections.Generic;
using System.Linq;
namespace CaChepFinal2.Data
{
    public interface ITrangThaiDatPhong
    {
        IQueryable<TrangThaiDatPhong> GetAll();
        TrangThaiDatPhong GetOneById(int? id);
        void New(TrangThaiDatPhong a);
        void Edit(TrangThaiDatPhong a);
        void Delete(int id);
    }
}