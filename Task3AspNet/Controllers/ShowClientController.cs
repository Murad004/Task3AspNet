using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task3AspNet.Controllers
{
    public class ShowClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
