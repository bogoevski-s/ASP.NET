using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.E_store.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string ShippingAdress { get; set; }
        public string City { get; set; }
        public int CreditCardNo { get; set; }
        public List<Order> Orders { get; set; }
        public int TotalAmount => Orders.Sum(x => x.Price);
    }
}
