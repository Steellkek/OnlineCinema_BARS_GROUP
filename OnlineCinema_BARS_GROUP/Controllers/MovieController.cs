using Microsoft.AspNetCore.Mvc;
using OnlineCinema_BARS_GROUP.Data;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        private readonly CinemaContext _context;
        public  MovieController(IMovie movie, CinemaContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> Index() {
            return  await Task.FromResult<ActionResult<IEnumerable<Movie>>>(_context.Movies.ToList());
        }
        
        [HttpGet("{id}")]
        public Task<ActionResult<Movie>> GetById(int id)
        {
            return Task.FromResult<ActionResult<Movie>>(_context.Movies.FirstOrDefault(x=>x.Id==id));
        }
    }
}

