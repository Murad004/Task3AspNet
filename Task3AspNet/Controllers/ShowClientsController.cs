using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3AspNet.Services;

namespace Task3AspNet.Controllers
{
    public class ShowClientsController : Controller
    {

        private IRepository repository;

        public ShowClientsController(IRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View(repository.GetAll());
        }


        [HttpPost]
        public IActionResult GoBack()
        {
            return RedirectToAction("Index", "Home");

        }
    }
}
