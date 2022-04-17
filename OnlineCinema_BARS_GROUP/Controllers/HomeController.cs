using Microsoft.AspNetCore.Mvc;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;

namespace OnlineCinema_BARS_GROUP.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovie _movie;
        public  HomeController(IMovie movie)
        {
            _movie = movie;
        }
        // GET
        public ViewResult Index()
        {
            ViewData["Title"] = "Главная страница";
            var movies = _movie.GetAllMovies;
            return View(movies);
        }
    }
}

