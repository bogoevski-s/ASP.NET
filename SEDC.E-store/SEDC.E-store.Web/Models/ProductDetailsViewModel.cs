using SEDC.E_store.Domain.Enums;
using SEDC.E_store.Domain.Models;
using System.Collections.Generic;

namespace SEDC.E_store.Web.Models
{
    public class ProductDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Review> Reviews { get; set; }
        public CategoryEnum Category { get; set; }
        public string Spec { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public bool IsOnPromo { get; set; }
    }
}
