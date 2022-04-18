using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3AspNet.Services;

namespace Task3AspNet.Controllers
{
    public class ShowClientController : Controller
    {
        private IRepository _repo;

        public ShowClientController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }
        public IActionResult GetClient(int id)
        {
            return View(_repo.Get(id));
        }
        public IActionResult GoBack()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
