using System;
using System.Collections.Generic;
using System.Linq;
namespace CaChepFinal2.Data
{
    public interface IDatPhong
    {
        IQueryable<DatPhong> GetAll();
        DatPhong GetOneById(int? id);
        void New(DatPhong DatPhong);
        void Edit(DatPhong DatPhong);
        void Delete(int id);

        IQueryable<DatPhong> getLDatPhongByTimeNhanDuKien(DateTime dp);
        IQueryable<DatPhong> getLDatPhongByCMND(string CMND);
        IQueryable<DatPhong> getLDatPhongBySDT(string SDT);
    }
}