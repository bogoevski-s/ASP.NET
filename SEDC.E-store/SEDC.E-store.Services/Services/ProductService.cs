using SEDC.E_store.DataAccess;
using SEDC.E_store.Domain.Models;
using SEDC.E_store.Services.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.E_store.Services.Services
{
    public class ProductService : IProductService
    {
        private IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetById(id);
        }

        public List<Product> GetProducts()
        {
            return _productRepository.GetAll();
        }
        public void AddProduct(Product product)
        {
            Product newProduct = product;
            _productRepository.Insert(newProduct);

        }
        public void DeleteProduct(int id)
        {
            _productRepository.Delete(id);
        }

        public void EditProduct(Product product)
        {
            //Product product = _productRepository.GetById(id);
            _productRepository.Update(product);
        }
    }
}
