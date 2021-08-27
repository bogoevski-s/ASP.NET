using SEDC.E_store.Domain.Models;

namespace SEDC.E_store.Web.Models.Mapper
{
    public class ProductMapper
    {
        public static ProductsViewModel ProductToProductViewModel(Product product)
        {
            return new ProductsViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price
            };
        }
        public static ProductDetailsViewModel ProductToProductDetailsViewModel(Product product)
        {
            return new ProductDetailsViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Reviews = product.Reviews,
                Category = product.Category,
                Spec = product.Spec,
                Brand = product.Brand,
                Price = product.Price,
                IsOnPromo = product.IsOnPromotion
            };
        }
    }
}
