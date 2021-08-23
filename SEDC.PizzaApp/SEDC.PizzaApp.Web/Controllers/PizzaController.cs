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
        [HttpGet]
        public IActionResult Index()
        {
            List<Pizza> pizzas = StaticDB.Pizzas;

            return View(pizzas);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Pizza pizza = StaticDB.Pizzas.FirstOrDefault(x => x.Id == id);
            if (pizza != null)
            {
                return View(pizza);
            }
            return View("ErrorPage");
        }
        [HttpPost]
        public IActionResult Edit(Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                Pizza editedPizza = StaticDB.Pizzas.FirstOrDefault(x => x.Id == pizza.Id);
                if (editedPizza != null)
                {
                    editedPizza.Id = pizza.Id;
                    editedPizza.Name = pizza.Name;
                    editedPizza.IsOnPromotion = pizza.IsOnPromotion;
                    editedPizza.Price = pizza.Price;
                }

                return RedirectToAction("Index");
            }
            return View("ErrorPage");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Pizza pizza = StaticDB.Pizzas.FirstOrDefault(x => x.Id == id);
            if (pizza != null)
            {
                return View(pizza);
            }
            return View("ErrorPage");
        }
        [HttpPost]
        public IActionResult Delete(Pizza pizza)
        {
            var findpizza = StaticDB.Orders.FirstOrDefault(x => x.Pizza.Id == pizza.Id);
            if (findpizza != null)
            {
                return RedirectToAction("ActionForbidden");
            }

            var pizzaToRemove = StaticDB.Pizzas.Single(x => x.Id == pizza.Id);
            if (pizzaToRemove != null)
            {
                StaticDB.Pizzas.Remove(pizzaToRemove);
                return RedirectToAction("Index");
            }
            return View("ErrorPage");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Pizza pizza)
        {
            int lastPizzaIndex = StaticDB.Pizzas.Count - 1;
            int newPizzaId = StaticDB.Pizzas[lastPizzaIndex].Id + 1;
            pizza.Id = newPizzaId;

            StaticDB.Pizzas.Add(pizza);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult ActionForbidden()
        {
            return View();
        }

    }
}
