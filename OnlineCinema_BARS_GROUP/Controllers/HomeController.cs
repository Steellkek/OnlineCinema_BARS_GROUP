using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Models;

namespace OnlineCinema_BARS_GROUP.Controllers
{
    public class HomeController : ControllerBase
    {
        private readonly IMovie _movie;
        public  HomeController(IMovie movie)
        {
            _movie = movie;
        }
        // GET
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            //ViewData["Title"] = "Главная страница";
            var movies =_movie.GetAllMovies ;
            return movies;
        }
    }
}

