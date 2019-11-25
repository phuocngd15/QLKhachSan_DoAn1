using System.Collections.Generic;
using System.Linq;
namespace CaChepFinal2.Data
{
    public interface ITrangThai
    {
        IQueryable<TrangThai> GetAll();
        TrangThai GetOneById(int? id);
        void New(TrangThai a);
        void Edit(TrangThai a);
        void Delete(int id);
    }
}