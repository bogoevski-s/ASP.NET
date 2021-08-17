using SEDC.PizzaApp.Web.Models.ViewModels;


namespace SEDC.PizzaApp.Web.Models.Mapper
{
    public static class PizzaMapper
    {
        public static PizzaDetailsViewModel PizzaToPizzaDetailsModelView(Pizza pizza)
        {
            if (pizza.HasExtras)
            {
                pizza.Price += 10;
            }
            return new PizzaDetailsViewModel
            {
                Name = pizza.Name,
                Price = pizza.Price,
                PizzaSize = pizza.Size
            };
        }
    }
}
