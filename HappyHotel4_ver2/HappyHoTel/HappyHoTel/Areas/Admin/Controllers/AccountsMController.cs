using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyHoTel.Data;
using HappyHoTel.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Remotion.Linq.Clauses;

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