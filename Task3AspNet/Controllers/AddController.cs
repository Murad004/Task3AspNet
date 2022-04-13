using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3AspNet.Models;
using Task3AspNet.Services;

namespace Task3AspNet.Controllers
{
    public class AddController : Controller
    {
        private IRepository repository;

        public AddController(IRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            UserViewModel userViewModel = new UserViewModel()
            {
                User = new Entities.User()
            };
            return View(userViewModel);
        }

        [HttpPost]
        public IActionResult Add(UserViewModel userViewModel)
        {
            repository.Add(userViewModel.User);


            return RedirectToAction("Index", "Home");
        }
    }
}
