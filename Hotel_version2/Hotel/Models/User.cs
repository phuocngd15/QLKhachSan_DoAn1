﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class User
    {
        //luu tai khoan khach hang, nhan vien
        [Key]
        public int NguoiDungId { get; set; }
        public string HoTenNguoiDung { get; set; }
        public string CmndNguoiDung { get; set; }
        public string SdtNguoiDung { get; set; }
        public string EmailNguoiDung { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }

    }
}
