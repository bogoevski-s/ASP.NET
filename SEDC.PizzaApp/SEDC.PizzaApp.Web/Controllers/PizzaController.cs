using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Web.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            var model = StaticDB.Pizzas;
            return new JsonResult(model);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var model = StaticDB.Pizzas.FirstOrDefault(x => x.Id == id);
            if(model == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(model);
        }
    }
}
