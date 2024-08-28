using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET5.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            //return Content("Demo Page");
            return View();
        }
    }
}
