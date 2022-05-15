using Korzh.EasyQuery.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineCinema_BARS_GROUP.Data.DTO;
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

        public MovieController(IMovie movie)
        {
            _movie = movie;
        }

        [HttpGet]
        public Task<ActionResult<IEnumerable<Movie>>> Index()
        {
            return Task.FromResult<ActionResult<IEnumerable<Movie>>>(_movie.AllMovies.ToList());
        }
        
        /// <summary>
        /// Возвращает отфильтрованный список фильмов.
        /// </summary>
        /// <param name="moviesOptionsDto">Настройки фильтрации.</param>
        /// <returns>Отфильтрованный список фильмов</returns>
        [HttpGet("list")]
        public async Task<ActionResult<IEnumerable<Movie>>> List(MoviesOptionsDTO moviesOptionsDto)
        {
            IQueryable<Movie> movies = _movie.Movies
                .Include(x => x.Category)
                .Include(x => x.Genres);

            var filteredMovies = movies
                .FullTextSearchQuery(moviesOptionsDto.SearchText);
            
            var pagedMovies = await filteredMovies
                .Skip((moviesOptionsDto.PageNumber - 1) * moviesOptionsDto.PageSize)
                .Take(moviesOptionsDto.PageSize)
                .ToListAsync();

            return pagedMovies;
        }

        [HttpGet("{id}")]
        public Task<ActionResult<Movie>> GetById(int id)
        {
            var movie = _movie.getObjectMovieById(id);
            return Task.FromResult<ActionResult<Movie>>(movie);
        }
    }
}