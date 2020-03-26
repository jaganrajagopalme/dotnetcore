using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Webappsdemo.wwwroot
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View("Hello Mvc");
        }

        public IActionResult Default()
        {
            return View("sdf");
        }
    }
}