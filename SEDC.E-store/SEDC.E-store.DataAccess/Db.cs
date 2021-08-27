using SEDC.E_store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.E_store.DataAccess
{
    public static class Db
    {
        
        public static int ProductId = 4;
        public static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Lenovo 320",
                Description = "15.6 lap-top with full hd display",
                Reviews = new List<Review>{},
                Category = Domain.Enums.CategoryEnum.Laptops,
                Spec = "8G Ram, 15,6 inch full hd display, Intel i5 10gen, 500g SSD",
                Brand = "Lenovo",
                Price = 770,
                IsOnPromotion = true
            },
            new Product
            {
                Id = 2,
                Name = "LG 650G4K",
                Description = "4K Gaming monitor",
                Reviews = new List<Review>{},
                Category = Domain.Enums.CategoryEnum.Monitors,
                Spec = "1Ms response time, 4K resolution, Gaming monitor",
                Brand = "LG",
                Price = 130,
                IsOnPromotion = false
            },
            new Product
            {
                Id = 3,
                Name = "Samsung",
                Description = "Smart phone",
                Reviews = new List<Review>{},
                Category = Domain.Enums.CategoryEnum.Smartphones,
                Spec = "Quad-core processor, 64G memory, 6Inch display, 4k resolution",
                Brand = "Samsung",
                Price = 500,
                IsOnPromotion = false
            },
            new Product
            {
                Id = 4,
                Name = "Genesis",
                Description = "Mechnical keyboard with RGB ",
                Reviews = new List<Review>{},
                Category = Domain.Enums.CategoryEnum.KeyboardMouse,
                Spec = "Mechanical keyboard wiith RGB lighting, cherry mx switches keystrokes",
                Brand = "Genesis",
                Price = 30,
                IsOnPromotion = true
            }
        };
        public static int UserId = 3;
        public static List<User> Users = new List<User>
        {
            new User
            {
                Id = 1,
                UserName = "bob",
                Password = "bob123",
                Mail = "bob@gmail.com",
                ShippingAdress = "Leninova",
                City = "Skopje",
                CreditCardNo = 12345678,
                Orders = new List<Order>{}
            },
            new User
            {
                Id = 2,
                UserName = "Slave",
                Password = "SlaveB123",
                Mail = "Slave@gmail.com",
                ShippingAdress = "Przino",
                City = "Skopje",
                CreditCardNo = 1231231,
                Orders = new List<Order>{}
            },
             new User
            {
                Id = 3,
                UserName = "RickRoss",
                Password = "RR123",
                Mail = "RR@gmail.com",
                ShippingAdress = "Street Blv",
                City = "New York",
                CreditCardNo = 1231231,
                Orders = new List<Order>{}
            }
        };
        public static int OrderId = 3;
        public static List<Order> Orders = new List<Order>
        {
            new Order
            {
                Id = 1,
                OrderedProduct = Products[0],
                User = Users.First()
            },
            new Order
            {
                Id = 2,
                OrderedProduct = Products[1],
                User = Db.Users.FirstOrDefault(x => x.Id == 2),
            },
            new Order
            {
                Id = 3,
                OrderedProduct = Products[3],
                User = Db.Users.Last(),
            }
        };
        public static int ReviewId = 7;
        public static List<Review> Reviews = new List<Review>
        {
            new Review
            {
                Id = 1,
                ProductReview = Products[0],
                ReviewComment = "Ut ut rhoncus erat. Suspendisse potent",
                User = Users[0]
            },
            new Review
            {
                Id = 2,
                ProductReview = Products[0],
                ReviewComment = "Etiam ullamcorper vulputate pharetra",
                User = Users[1]
            },
            new Review
            {
                Id = 3,
                ProductReview = Products[0],
                ReviewComment = "Ut sed enim egestas, ultricies lectus sit amet, commodo lorem.",
                User = Users[2]
            },
            new Review
            {
                Id = 4,
                ProductReview = Products.FirstOrDefault(x => x.Id == 2),
                ReviewComment = "Vestibulum scelerisque, elit sed euismod lobortis, ",
                User = Users[2]
            },
            new Review
            {
                Id = 5,
                ProductReview = Products.FirstOrDefault(x => x.Id == 2),
                ReviewComment = "ng Lorem Ipsum is that it has a more-or-less, as oppos",
                User = Users[0]
            },
            new Review
            {
                Id = 6,
                ProductReview = Products.FirstOrDefault(x => x.Id == 3),
                ReviewComment = "Contrary to popular belief, Lorem Ipsum is not simply random text",
                User = Users[0]
            },
            new Review
            {
                Id = 7,
                ProductReview = Products.Last(),
                ReviewComment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                User = Users[1]
            }
        };
        public static void Adding()
        {
            //Adding orders to user
            Db.Users.First().Orders = new List<Order>() { Db.Orders.First(), Db.Orders.Last() };
            Db.Users[1].Orders = new List<Order>() { Db.Orders.Last() };
            Db.Users.Last().Orders = new List<Order>() { Db.Orders.FirstOrDefault(x => x.Id == 2), Db.Orders.First(), Db.Orders.Last() };

            //Adding reviews to products
            foreach (Product product in Db.Products)
            {
                if(Db.Products.Count > 0)
                {
                    product.Reviews = new List<Review> { Db.Reviews[0], Db.Reviews[1], Db.Reviews[2], Db.Reviews[3]};
                }
                
            }
        }
    }
    
}
