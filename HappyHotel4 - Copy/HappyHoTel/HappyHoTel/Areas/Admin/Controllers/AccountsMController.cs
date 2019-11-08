using System.Linq;
using HappyHoTel.Data;
using HappyHoTel.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HappyHoTel.Areas.Admin.Controllers
{
    [Authorize(Roles = Role.SPAdmin)]
    [Area("Admin")]
    public class AccountsMController : Controller
    {
        private readonly ApplicationDbContext _applicationDb;

        public AccountsMController(ApplicationDbContext applicationDb)
        {
            _applicationDb = applicationDb;
        }
        public IActionResult Index()
        {
            return View(_applicationDb.ApplicationUsers.ToList());
        }

    }
}