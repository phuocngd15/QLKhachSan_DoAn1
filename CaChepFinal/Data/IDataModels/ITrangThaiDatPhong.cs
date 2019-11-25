using System.Collections.Generic;
using System.Linq;
namespace CaChepFinal.Data
{
    public interface ITrangThaiDatPhong
    {
        IQueryable<TrangThaiDatPhong> GetAll();

        // id có 2 loại, id của phiếu đặt phòng, id của trạng thái. 0: datphong, 1: trạng thái
        TrangThaiDatPhong GetOneById(int? id,int type); 
        void New(TrangThaiDatPhong a);
        void Edit(TrangThaiDatPhong a);
        void Delete(int id);
    }
}