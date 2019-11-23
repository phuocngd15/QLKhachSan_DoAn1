using System.Collections.Generic;
using System.Linq;
namespace CaChepFinal.Data
{
    public interface ILoaiDv
    {
        IQueryable<LoaiDV> GetAll();
        LoaiDV GetById(int id);
        void New(LoaiDV LoaiDv);
        void Edit(LoaiDV LoaiDv);
        void Delete(int id);
    }
}