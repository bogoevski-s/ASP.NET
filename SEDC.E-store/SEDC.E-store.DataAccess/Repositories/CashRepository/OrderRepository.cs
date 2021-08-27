using SEDC.E_store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.E_store.DataAccess.Repositories.CashRepository
{
    public class OrderRepository : IRepository<Order>
    {
        public void Delete(int id)
        {
            Order order = Db.Orders.FirstOrDefault(x => x.Id == id);
            if (order != null)
            {
                Db.Orders.Remove(order);
            }
        }

        public List<Order> GetAll()
        {
            List<Order> orders = Db.Orders.ToList();
            return orders;
        }

        public Order GetById(int id)
        {
            Order order = Db.Orders.FirstOrDefault(x => x.Id == id);
            return order;
        }

        public void Insert(Order entity)
        {
            Db.OrderId++;
            entity.Id = Db.OrderId;
            Db.Orders.Add(entity);
        }

        public void Update(Order entity)
        {
            Order order = Db.Orders.FirstOrDefault(x => x.Id == entity.Id);
            if (order != null)
            {
                int index = Db.Orders.IndexOf(order);
                Db.Orders[index] = entity;
            }
        }
    }
}
