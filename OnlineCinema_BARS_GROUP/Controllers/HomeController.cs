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
        
        [HttpGet]
        public  Task<ActionResult<IEnumerable<Movie>>> Index() {
            return   Task.FromResult<ActionResult<IEnumerable<Movie>>>(_movie.GetAllMovies.ToList());
        }
        
        [HttpGet("{id}")]
        public  Task<ActionResult<Movie>> Get(int id)
        {
            Movie movie = _movie.getObjectMovie(id);
            return Task.FromResult<ActionResult<Movie>>(movie);
        }
    }
}

