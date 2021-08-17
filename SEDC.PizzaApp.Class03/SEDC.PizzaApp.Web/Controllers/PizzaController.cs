using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Web.Models;
using SEDC.PizzaApp.Web.Models.Mapper;
using SEDC.PizzaApp.Web.Models.ViewModels;
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
            List<Pizza> Pizzas = StaticDB.Pizzas;
            List<PizzaDetailsViewModel> pizzaDetails = new List<PizzaDetailsViewModel>();
            foreach (Pizza pizza in Pizzas)
            {
                pizzaDetails.Add(PizzaMapper.PizzaToPizzaDetailsModelView(pizza));
            }
            ViewData.Add("Title", "Pizza Store");
            return View(pizzaDetails);
        }
        public IActionResult Details(int id)
        {
            var model = StaticDB.Pizzas.FirstOrDefault(x => x.Id == id);
            if(model == null)
            {
                return new EmptyResult();
            }
            if (model.HasExtras)
            {
                model.Price += 10;
            }
            ViewData.Add("Title", "Pizza Details");
            ViewBag.pizza = model;
            return View();
        }
    }
}
