using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataCore.Core.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace DataCore.App.Controllers
{
    public class EquipoController : Controller
    {
        IEquipoRepository Repository;

        public EquipoController(IEquipoRepository repository) {
            Repository = repository;
        }

        public IActionResult Index()
        {
            var equipos = Repository.GetList();

            

            return View();
        }
    }
}