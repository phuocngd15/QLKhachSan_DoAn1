using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KTCT7.Models
{
    public class PhieuMuon
    {
        [Key]
        public int SoPhieu { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }
        public int MaDocGia { get; set; }
        public DocGia DocGias { get; set; }
      

    }
}
