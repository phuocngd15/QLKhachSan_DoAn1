using System.Collections.Generic;
using System.Linq;
namespace CaChepFinal2.Data
{
    public interface IPhong
    {
        IQueryable<Phong> GetAll();
        Phong GetOneById(int? id);
        void New(Phong a);
        void Edit(Phong a);
        void Delete(int id);
    }
}