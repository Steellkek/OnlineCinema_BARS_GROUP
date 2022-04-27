using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Data.Models;
using OnlineCinema_BARS_GROUP.Models;

namespace OnlineCinema_BARS_GROUP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly IMovie _movie;
        public  HomeController(IMovie movie)
        {
            _movie = movie;
        }
        // GET
        /*public ViewResult Index()
        {
            ViewData["Title"] = "Главная страница";
            var movies = _movie.GetAllMovies;
            return View(movies);
        }*/

        //[Route("/GetMovies")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> Index() {
            return  _movie.GetAllMovies.ToList();
        }
    }
}

