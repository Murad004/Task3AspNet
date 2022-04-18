using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task3AspNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddClient()
        {
            return RedirectToAction("Index", "Register");
                
        }
        public IActionResult DeleteClient()
        {
            return RedirectToAction("Index", "Delete");

        }

        public IActionResult UpdateClient()
        {
            return RedirectToAction("Index", "Update");
        }

        public IActionResult ShowClients()
        {
            return RedirectToAction("Index", "ShowClients");

        }
        public IActionResult ShowClient()
        {
            return RedirectToAction("Index", "ShowClient");

        }
    }
}
