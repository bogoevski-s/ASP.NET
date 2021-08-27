using SEDC.E_store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.E_store.Services.Services.Interface
{
    public interface IUserService
    {
        User GetUser(int id);
    }
}
