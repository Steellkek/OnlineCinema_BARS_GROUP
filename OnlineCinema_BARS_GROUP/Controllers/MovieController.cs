using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        private readonly IMovie _movie;
        public  MovieController(IMovie movie)
        {
            _movie = movie;
        }
        [HttpGet]
        public  Task<ActionResult<IEnumerable<Movie>>> Index() {
            return   Task.FromResult<ActionResult<IEnumerable<Movie>>>(_movie.AllMovies.ToList());
        }
        
        [HttpGet("{id}")]
        public Task<ActionResult<Movie>> GetById(int id)
        {
            var movie = _movie.getObjectMovieById(id);
            return Task.FromResult<ActionResult<Movie>>(movie);
        }
    }
}

