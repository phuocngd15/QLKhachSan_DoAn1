using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CaChepFinal.Areas.Admin.Controllers
{
    public class DatDichVuController : Controller
    {
        // them, sua, xoa Dich vu vao bill
        public IActionResult Index()
        {
            return View();
        }
    }
}