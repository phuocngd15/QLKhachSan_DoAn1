using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KTCT7.Models
{
    public class DocGia
    {

        [Key]
        public int MaDocGia { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public DocGia()
        {
            PhieuMuons = new HashSet<PhieuMuon>();
        }
        public virtual ICollection<PhieuMuon> PhieuMuons { get; set; }
    }
}
