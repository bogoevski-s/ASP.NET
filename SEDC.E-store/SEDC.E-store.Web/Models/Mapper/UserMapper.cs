
using SEDC.E_store.Domain.Models;

namespace SEDC.E_store.Web.Models.Mapper
{
    public class UserMapper
    {
        public static UserProfileViewModel UserToUserProfileViewModel(User user)
        {
            return new UserProfileViewModel
            {
                UserName = user.UserName,
                Mail = user.Mail,
                ShippingAdress = user.ShippingAdress,
                City = user.City,
                CreditCardNo = user.CreditCardNo,
                Orders = user.Orders,
                TotalAmount = user.TotalAmount
            };
        }
    }
}
