using TaskEFConsoleApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWebApp.Repositories;

namespace TaskWebApp.Controllers
{
    public class CityController : Controller
    {
        private CityRepository _repository;
        public CityController(CityRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var cities = _repository.GetAll().ToList();

            return View(cities);
        }
    }
}
