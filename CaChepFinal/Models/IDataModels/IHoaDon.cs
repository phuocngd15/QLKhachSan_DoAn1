using CaChepFinal.Models.DataModels;
using System.Collections.Generic;

namespace CaChepFinal.Models.IDataModels
{
    public interface IHoaDon
    {
        IEnumerable<HoaDon> GetAll();
        HoaDon GetById(int id);
        void NewHoaDon(HoaDon DatPhong);
        void EditHoaDon(HoaDon DatPhong);
        void DeleteHoaDon(int id);
    }
}