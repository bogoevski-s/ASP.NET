using Microsoft.AspNetCore.Mvc;
using SEDC.E_store.Domain.Enums;
using SEDC.E_store.Domain.Models;
using SEDC.E_store.Services.Services.Interface;
using SEDC.E_store.Web.Models;
using SEDC.E_store.Web.Models.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.E_store.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult ProductDetails(int id)
        {
            Product product = _productService.GetProductById(id);
            ProductDetailsViewModel productDetails = ProductMapper.ProductToProductDetailsViewModel(product);
            return View(productDetails);
        }
        public IActionResult AddNewProduct()
        {
            List<CategoryEnum> categories = Enum.GetValues(typeof(CategoryEnum)).Cast<CategoryEnum>().ToList();
            ViewBag.ViewCategories = categories;
            return View();
        }
        [HttpPost]
        public IActionResult AddNewProduct(Product product)
        {
            _productService.AddProduct(product);
            return RedirectToAction("Index","Home");
        }
        public IActionResult DeleteProduct(Product product)
        {
            Product productToDelete = _productService.GetProductById(product.Id);
            return View(productToDelete);
        }
        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult UpdateProduct(int id)
        {
            Product productToDelete = _productService.GetProductById(id);
            List<CategoryEnum> categories = Enum.GetValues(typeof(CategoryEnum)).Cast<CategoryEnum>().ToList();
            ViewBag.ViewCategories = categories;
            return View(productToDelete);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.EditProduct(product);
            return RedirectToAction("Index", "Home");
        }
    }
}
