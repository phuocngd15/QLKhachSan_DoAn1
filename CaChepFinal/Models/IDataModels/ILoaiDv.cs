using CaChepFinal.Models.DataModels;
using System.Collections.Generic;

namespace CaChepFinal.Models.IDataModels
{
    public interface ILoaiDv
    {
        IEnumerable<LoaiDV> GetAll();
        LoaiDV GetById(int id);
        void NewLoaiDv(LoaiDV LoaiDv);
        void EditLoaiDv(LoaiDV LoaiDv);
        void DeleteLoaiDv(int id);
    }
}