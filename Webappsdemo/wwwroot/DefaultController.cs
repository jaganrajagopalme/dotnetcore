using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Webappsdemo.wwwroot
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View("Default Page");
        }
    }
}