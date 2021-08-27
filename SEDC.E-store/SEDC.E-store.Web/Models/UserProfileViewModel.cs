using SEDC.E_store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.E_store.Web.Models
{
    public class UserProfileViewModel
    {
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string ShippingAdress { get; set; }
        public string City { get; set; }
        public int CreditCardNo { get; set; }
        public List<Order> Orders { get; set; }
        public int TotalAmount { get; set; }
    }
}
