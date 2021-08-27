using SEDC.E_store.DataAccess;
using SEDC.E_store.Domain.Models;
using SEDC.E_store.Services.Services.Interface;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.E_store.Services.Services
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _orderRepository;
        public OrderService(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAll().ToList();
        }

        public Order GetOrderById(int id)
        {
            return _orderRepository.GetById(id); 
        }
    }
}
