using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using broodwar3.web.Models;
using System.Threading;

namespace broodwar3.web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            broodwar3.lib.GoDoWa goDowa = new broodwar3.lib.GoDoWa();
            string strTemp = string.Empty;
            strTemp = goDowa.ReturnReturn(new string[] { "저그와 ", "테란" });
            Thread.Sleep(3000);
            ViewData["Message"] = strTemp;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
