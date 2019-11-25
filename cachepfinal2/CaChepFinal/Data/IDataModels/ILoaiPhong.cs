using System.Collections.Generic;
using System.Linq;
namespace CaChepFinal.Data
{
    public interface ILoaiPhong
    {
        IQueryable<LoaiPhong> GetAll();
        LoaiPhong GetOneById(int? id);
        void New(LoaiPhong LoaiPhong);
        void Edit(LoaiPhong LoaiPhong);
        void Delete(int id);
    }
}