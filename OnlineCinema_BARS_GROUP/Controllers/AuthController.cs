using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Data.Models;
using System.Linq;

namespace OnlineCinema_BARS_GROUP.Controllers
{
    public class AuthController : Controller
    {   
        private readonly IUser _user;
        public AuthController(IUser user)
        {
            _user = user;
        }
            
        public ViewResult Index()
        {
            ViewData["Title"] = "Авторизация";
            return View();
        }
        [HttpPost]
        public IActionResult CheckUser(string userName, string password) {
            var users = _user.GetAllUsers;
            IEnumerable<User> query = users
                .Where(x => x.UserName.Equals(userName))
                .Where(x => x.Password.Equals(password));
            if (query.Count() != 0)
            {
                return Redirect("~/Home/Index");
            }
            else
                return Redirect("~/Auth/Index");
        }
    }
}

