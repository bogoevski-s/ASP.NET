
using SEDC.E_store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.E_store.DataAccess.Repositories.CashRepository
{
    public class ProductRepository : IRepository<Product>
    {
        public void Delete(int id)
        {
            Product product = Db.Products.FirstOrDefault(x => x.Id == id);
            if(product != null)
            {
                Db.Products.Remove(product);
            }
        }

        public List<Product> GetAll()
        {
            List<Product> products = Db.Products.ToList();
            return products;
        }

        public Product GetById(int id)
        {
            Product product = Db.Products.FirstOrDefault(x => x.Id == id);
            return product;
        }

        public void Insert(Product entity)
        {
            Db.ProductId++;
            entity.Id = Db.ProductId;
            Db.Products.Add(entity);
        }

        public void Update(Product entity)
        {
            Product product = Db.Products.FirstOrDefault(x => x.Id == entity.Id);
            if (product != null)
            {
                int index = Db.Products.IndexOf(product);
                Db.Products[index] = entity;
            }
        }
    }
}
