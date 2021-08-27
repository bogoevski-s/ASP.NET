using SEDC.E_store.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.E_store.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Review> Reviews { get; set; }
        public CategoryEnum Category { get; set; }
        public string Spec { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public bool IsOnPromotion { get; set; }
    }
}
