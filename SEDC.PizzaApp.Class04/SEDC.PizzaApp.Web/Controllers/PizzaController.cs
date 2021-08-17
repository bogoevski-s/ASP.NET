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
                pizza.isPriceChanged(pizza.PriceChanged, pizza.HasExtras);

                //if (pizza.HasExtras && !pizza.PriceChanged)
                //{
                //    pizza.PriceChanged = true;
                //    pizza.Price += 10;
                //}

                pizzaDetails.Add(PizzaMapper.PizzaToPizzaDetailsModelView(pizza));
            }
            ViewData.Add("Title", "Pizza Store");
            return View(pizzaDetails);
        }
        public IActionResult Details(int id)
        {
            var model = StaticDB.Pizzas.FirstOrDefault(x => x.Id == id);
            model.isPriceChanged(model.PriceChanged, model.HasExtras);

            //if (model.HasExtras && !model.PriceChanged)
            //{
            //    model.PriceChanged = true;
            //    model.Price += 10;
            //}

            if (model == null)
            {
                return new EmptyResult();
            }
            ViewData.Add("Title", "Pizza Details");
            ViewBag.pizza = model;
            return View();
        }
    }
}
