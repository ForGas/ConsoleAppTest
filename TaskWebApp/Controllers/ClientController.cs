using TaskEFConsoleApp.Data;
using TaskEFConsoleApp.Data.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWebApp.Repositories;

namespace TaskWebApp.Controllers
{
    public class ClientController : Controller
    {
        private ClientRepository _repository;
        public ClientController(ClientRepository repository)
        {
            _repository = repository;
        }

        // GET: ClientController
        [HttpGet]
        public IActionResult Index()
        {
            var clients = _repository.GetAll().ToList();

            return View(clients);
        }

        // POST: ClientController/Remove/5
        [HttpGet]
        public JsonResult Remove(long Id)
        {
            var client = _repository.Get(Id);

            if (client == null)
            {
                return Json(false);
            }
            _repository.Remove(client);

            return Json(true);
        }

        // GET: ClientController/View/5
        [HttpGet]
        public IActionResult View(long Id)
        {
            var client = _repository.Get(Id);

            return View(client);
        }

        // GET: ClientController/Edit/5
        [HttpGet]
        public IActionResult Edit(long Id)
        {
            var client = _repository.Get(Id);

            return View(client);
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        public IActionResult Edit(BankClient client)
        {
            if (client is null)
            {
                return BadRequest(client);
            }

            _repository.Save(client);

            return View(client);
        }
    }
}
