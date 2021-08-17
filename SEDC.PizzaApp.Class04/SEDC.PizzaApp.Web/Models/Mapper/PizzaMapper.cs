using SEDC.PizzaApp.Web.Models.ViewModels;


namespace SEDC.PizzaApp.Web.Models.Mapper
{
    public static class PizzaMapper
    {
        public static PizzaDetailsViewModel PizzaToPizzaDetailsModelView(Pizza pizza)
        {
            return new PizzaDetailsViewModel
            {
                Name = pizza.Name,
                Price = pizza.Price,
                PizzaSize = pizza.Size,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }
    }
}
