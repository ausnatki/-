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

            string ang = "这是我分支1的修改";
            string ang2= "这是我分支2的修改";

            int id = 11;

            return View();
        }
    }
}
