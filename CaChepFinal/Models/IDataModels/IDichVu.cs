using CaChepFinal.Models.DataModels;
using System.Collections.Generic;

namespace CaChepFinal.Models.IDataModels
{
    public interface IDichVu
    {
        IEnumerable<DichVu> GetAll();
        DichVu GetById(int id);
        void NewDichVu(DichVu dv);
        void EditDichVu(DichVu dv);
        void DeleteDichVu(int id);
    }
}