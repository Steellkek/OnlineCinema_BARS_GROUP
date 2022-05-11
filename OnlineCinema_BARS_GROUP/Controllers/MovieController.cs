using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineCinema_BARS_GROUP.Data;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        private readonly IMovie _movie;
        public  MovieController(IMovie movie, CinemaContext context)
        {
            _movie = movie;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> Index()
        {
            return await Task.FromResult<ActionResult<IEnumerable<Movie>>>(_movie.AllMovies.ToList());
        }
        
        [HttpGet("{id}")]
        public Task<ActionResult<Movie>> GetById(int id)
        {
            return Task.FromResult<ActionResult<Movie>>(_movie.getObjectMovieById(id));
        }
    }
}

