using System.Collections.Generic;
using System.Linq;
namespace CaChepFinal.Data
{
    public interface IDichVu
    {
        IQueryable<DichVu> GetAll();
        DichVu GetById(int id);
        void New(DichVu dv);
        void Edit(DichVu dv);
        void Delete(int id);
    }
}