using Microsoft.AspNetCore.Mvc;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Controllers
{
    public class AuthController : Controller
    {   
        private readonly IUser _user;
        public AuthController(IUser user)
        {
            _user = user;
        }
            
        /*public ViewResult Index()
        {
            ViewData["Title"] = "Авторизация";
            return View();
        }*/
        [HttpPost]
        public IActionResult CheckUser(string userName, string password) {
            var users = _user.GetAllUsers;
            IEnumerable<User> query = users
                .Where(x => x.Name.Equals(userName));
            
            if (query.Count() != 0)
            {
                return Redirect("~/Home/Index");
            }
            
            return Redirect("~/Auth/Index");
        }
    }
}

