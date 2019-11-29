using System.Collections.Generic;
using System.Linq;
namespace CaChepFinal2.Data
{
    public interface ILoaiDv
    {
        IQueryable<LoaiDV> GetAll();
        LoaiDV GetOneById(int? id);
        void New(LoaiDV LoaiDv);
        void Edit(LoaiDV LoaiDv);
        void Delete(int id);
    }
}