using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.E_store.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Product OrderedProduct { get; set; }
        public User User { get; set; } 
        public int OrderNumber => new Random().Next(10, 10000) + new Random().Next(10, 10000);
        public int Price => OrderedProduct.Price;
    }
}
