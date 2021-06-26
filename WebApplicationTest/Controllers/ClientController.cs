using ConsoleAppTest.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Repositories;

namespace WebApplicationTest.Controllers
{
    public class ClientController : Controller
    {
        private ClientRepository _repository;
        public ClientController(ClientRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var clients = _repository.GetAll().ToList();

            return View(clients);
        }
    }
}
