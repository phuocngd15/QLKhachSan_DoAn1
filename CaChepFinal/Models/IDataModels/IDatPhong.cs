using CaChepFinal.Models.DataModels;
using System.Collections.Generic;
using System.Linq;
namespace CaChepFinal.Models.IDataModels
{
    public interface IDatPhong
    {
        IQueryable<DatPhong> GetAll();
        DatPhong GetById(int id);
        void New(DatPhong DatPhong);
        void Edit(DatPhong DatPhong);
        void Delete(int id);

        IQueryable<DatPhong> getLDatPhongByNow();
        IQueryable<DatPhong> getLDatPhongByCMND(string CMND);
        IQueryable<DatPhong> getLDatPhongBySDT(string SDT);
    }
}