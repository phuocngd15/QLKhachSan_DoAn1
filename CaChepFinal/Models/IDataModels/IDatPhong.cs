using CaChepFinal.Models.DataModels;
using System.Collections.Generic;

namespace CaChepFinal.Models.IDataModels
{
    public interface IDatPhong
    {
        IEnumerable<DatPhong> GetAll();
        DatPhong GetById(int id);
        void NewDatPhong(DatPhong DatPhong);
        void EditDatPhong(DatPhong DatPhong);
        void DeleteDatPhong(int id);
    }
}