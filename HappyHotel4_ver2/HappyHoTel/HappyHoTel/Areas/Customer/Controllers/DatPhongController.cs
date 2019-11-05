using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HappyHoTel.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class DatPhongController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}