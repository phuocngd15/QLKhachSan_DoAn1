using CaChepFinal.Models.DataModels;
using System.Collections.Generic;
using System.Linq;
namespace CaChepFinal.Models.IDataModels
{
    public interface IQueryBasic<T>
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void New(T LoaiDv);
        void Edit(T LoaiDv);
        void Delete(int id);
    }
}