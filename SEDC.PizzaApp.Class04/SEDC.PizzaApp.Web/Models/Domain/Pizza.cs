using SEDC.PizzaApp.Web.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Web.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsOnPromotion { get; set; }
        public double Price { get; set; }
        public PizzaSize Size { get; set; }
        public bool HasExtras { get; set; }
        public bool PriceChanged = false;

        public void isPriceChanged(bool isPriceChanged, bool hasExtras)
        {
            if (isPriceChanged == false && hasExtras == true)
            {
                Price += 10;
                PriceChanged = true;
            }
        }
    }
}
