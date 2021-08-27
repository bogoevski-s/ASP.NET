using Microsoft.AspNetCore.Mvc;
using SEDC.E_store.Domain.Models;
using SEDC.E_store.Services.Services.Interface;
using SEDC.E_store.Web.Models;
using SEDC.E_store.Web.Models.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.E_store.Web.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Profile()
        {
            User user =  _userService.GetUser(1);
            UserProfileViewModel loggedUser = UserMapper.UserToUserProfileViewModel(user);
            return View(loggedUser);
        }
    }
}
