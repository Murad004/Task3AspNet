using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3AspNet.Entities;
using Task3AspNet.Helper;
using Task3AspNet.Services;

namespace Task3AspNet.Controllers
{
    public class UpdateController : Controller
    {
        private IRepository _repo;

        public UpdateController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }

        public IActionResult UserFind1(int id)
        {
            UserHelper.IdUpdate = id;
            return View(_repo.Get(id));
        }
        [HttpPost]
        public IActionResult UserFind(User client)
        {
            _repo.Update(UserHelper.IdUpdate, client);
            return RedirectToAction("Index", "Home");

        }
    }
}
