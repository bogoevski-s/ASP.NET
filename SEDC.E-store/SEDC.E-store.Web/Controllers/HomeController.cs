using Microsoft.AspNetCore.Mvc;
using SEDC.E_store.Web.Models;
using System.Collections.Generic;
using System.Diagnostics;
using SEDC.E_store.Domain.Models;
using SEDC.E_store.DataAccess;
using SEDC.E_store.Services.Services.Interface;
using SEDC.E_store.Web.Models.Mapper;
using SEDC.E_store.Domain.Enums;
using System;
using System.Linq;

namespace SEDC.E_store.Web.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        private IOrderService _orderService;
        private IUserService _userService;
        public HomeController(IProductService productService, IOrderService orderService, IUserService userService)
        {
            _productService = productService;
            _orderService = orderService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            Db.Adding();
            //List<Product> products = _productService.GetProducts();
            //Product product = _productService.GetProductById(2);
            //List<Order> orders = _orderService.GetAllOrders();
            //Order order = _orderService.GetOrderById(1);
            //User user = _userService.GetUser(2);
            //User user1 = _userService.GetUser(1);
            //User user2 = _userService.GetUser(3);

            List<Product> allProducts = _productService.GetProducts();
            List<ProductsViewModel> productsModel = new List<ProductsViewModel>();
            foreach (Product item in allProducts)
            {
                productsModel.Add(ProductMapper.ProductToProductViewModel(item));
            }
            

            return View(productsModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
