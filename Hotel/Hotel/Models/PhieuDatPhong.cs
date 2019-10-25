using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class PhieuDatPhong
    {
        [Key]
        public int IdPhieuDatPhong { get; set; }

        // tinh trang = 0: chua nhan,,,,,, Tinh trang = 1: da nhan phong
        public bool TinhTrang { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayNhanDuTinh{ get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayTraDuTinh { get; set; }

        [DefaultValue(0)]
        public int IdUser { get; set; }
        public Account NguoiLapPhieu { get; set; }

        //Dieu kien de tim phong 
        // getRoomByRangeDate
        //select NgayNhanDuTinh - NgayHienTai < 30days

        //Tim nhung phong co ( New_NgayTraDuTinh > New_NgayNhanDuTinh  > NgayTraDuTinh cua nguoi truoc ) || 
        //-----------------------TruongHop1-----------------------------  ||  ----------------------------TruongHop2------------------------
        //=========[NewDayNhan............NewDayTra]==========[OldNhan.........OldTra]=========[NewDayNhan............NewDayTra]

        public ICollection<Phong> Phongs { get; set; }



    }
}
