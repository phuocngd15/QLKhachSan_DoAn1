using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Demo.Controllers
{
    public class HelloWorldController : Controller
    {

        ///[Controller]/[ActionName]/[Parameters]
        // Get: /HelloWorld
        // below is the hard code
        //public string Index()
        //{
        //    return "this is my default action....";
        //}
        public IActionResult Index()
        {

            return View();
        }


       
        public IActionResult Welcome(string name, int numTimes = 1, int testNum=1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            ViewData["test"] = testNum;
            return View();
        }
    }
}