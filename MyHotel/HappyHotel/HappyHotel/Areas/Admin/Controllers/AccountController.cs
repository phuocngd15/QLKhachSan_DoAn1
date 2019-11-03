using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HappyHotel.Data;
using HappyHotel.Models;
using HappyHotel.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HappyHotel.Areas.Admin.Controllers
{
    //[Authorize(Roles = RoleSD.SuperAdminEndUser)]
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]

    public class AccountController : Controller
    {
        private HappyHotelDbContext _context;

        public AccountController(HappyHotelDbContext context)
        {
            _context = context;
        }

        public IActionResult LogIn()
        {

            return View();
        }
        public IActionResult LogOut()
        {

            return PartialView("_Layout");
        }

        public ActionResult Validate(Account admin)
        {
            var _admin =
                _context.SystemAccount.Where(s => s.UserName == admin.UserName || s.EmailNguoiDung == admin.UserName);
            if (_admin.Any())
            {
                _admin = _admin.Where(s => s.PassWords == admin.PassWords);
                if (_admin.Any())
                    return Json(new {status = true, message = "Đăng nhập thành công!"});

                return Json(new {status = false, message = "Sai Password!"});
            }

            return Json(new {status = false, message = "Sai Email!"});
        }
    }
}