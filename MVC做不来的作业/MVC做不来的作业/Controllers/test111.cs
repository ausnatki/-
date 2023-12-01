using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC做不来的作业.Controllers
{
    public class test111 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Test111() 
        {
            int id = 11;
            return View();
        }
    }
}
