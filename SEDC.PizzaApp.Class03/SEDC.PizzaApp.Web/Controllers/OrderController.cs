using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Web.Models.Domain;
using SEDC.PizzaApp.Web.Models.Enums;
using SEDC.PizzaApp.Web.Models.Mapper;
using SEDC.PizzaApp.Web.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.PizzaApp.Web.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            List<Order> orders = StaticDB.Orders;
            List<OrderDetailsViewModel> orderDetails = new List<OrderDetailsViewModel>();

            foreach (Order order in orders)
            {
                orderDetails.Add(OrderMapper.OrderToOrderDetailsViewModel(order));
            }

            return View(orderDetails);
        }
    }
}
