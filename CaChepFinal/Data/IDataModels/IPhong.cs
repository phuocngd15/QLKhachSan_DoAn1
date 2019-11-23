using System.Collections.Generic;
using System.Linq;
namespace CaChepFinal.Data
{
    public interface IPhong
    {
        IQueryable<Phong> GetAll();
        Phong GetById(int id);
        void New(Phong a);
        void Edit(Phong a);
        void Delete(int id);
    }
}