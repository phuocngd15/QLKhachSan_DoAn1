using System;
using System.Collections.Generic;
using System.Text;

namespace CaChepFinal2.Data
{
    public class DichVuCartItem
    {
        public int Id { get; set; }
        public DichVu DichVu { get; set; }
        public int Amount { get; set; }
        public string DichVuCartId { get; set; }
    }
}