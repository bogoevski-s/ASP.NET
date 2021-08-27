using SEDC.E_store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.E_store.DataAccess.Repositories.CashRepository
{
    public class UserRepository : IRepository<User>
    {
        public void Delete(int id)
        {
            User user = Db.Users.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                Db.Users.Remove(user);
            }
        }

        public List<User> GetAll()
        {
            List<User> products = Db.Users.ToList();
            return products;
        }

        public User GetById(int id)
        {
            User user = Db.Users.FirstOrDefault(x => x.Id == id);
            return user;
        }

        public void Insert(User entity)
        {
            Db.UserId++;
            entity.Id = Db.UserId;
            Db.Users.Add(entity);
        }

        public void Update(User entity)
        {
            User user = Db.Users.FirstOrDefault(x => x.Id == entity.Id);
            if (user != null)
            {
                int index = Db.Users.IndexOf(user);
                Db.Users[index] = entity;
            }
        }
    }
}
