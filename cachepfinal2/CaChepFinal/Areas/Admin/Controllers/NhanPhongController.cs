using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CaChepFinal.Areas.Admin.Controllers
{
    public class NhanPhongController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}