using Korzh.EasyQuery.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OnlineCinema_BARS_GROUP.Data;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Data.Models;
using OnlineCinema_BARS_GROUP.Data.Options;

namespace OnlineCinema_BARS_GROUP.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        private readonly IMovie _movie;
        private readonly ICategory _category;
        private readonly IGenre _genre;

        public MovieController(IMovie movie, ICategory category, IGenre genre)
        {
            _movie = movie;
            _category = category;
            _genre = genre;
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
        /// <param name="categoryId"></param>
        /// <returns>Отфильтрованный список фильмов</returns>
        [HttpPost("list")]
        public async Task<ActionResult<IEnumerable<Movie>>> List(MoviesOptionsDTO moviesOptionsDto)
        {
            IQueryable<Movie> movies = _movie.Movies
                .Include(x => x.Category)
                .Include(x => x.Genres);

            var filteredMovies = movies
                .FullTextSearchQuery(moviesOptionsDto.SearchText);


            if (moviesOptionsDto.CategoryId != null)
            {
                filteredMovies = filteredMovies
                    .Where(x => x.CategoryId == moviesOptionsDto.CategoryId);
            }

            if (moviesOptionsDto.GenreId != null)
            {
                filteredMovies = filteredMovies
                    .SelectMany(x => x.Genres, (x, l) => new {Movie = x, GenreId = l.Id})
                    .Where(x => x.GenreId == moviesOptionsDto.GenreId)
                    .Select(x => x.Movie);
            }
            
            return new ActionResult<IEnumerable<Movie>>(filteredMovies);
        }
        
        
        [HttpGet("allCategories")]
        public async Task<ActionResult<IEnumerable<Category>>> AllCategories() => await _category.Categories.ToListAsync();
        
        [HttpGet("allGenres")]
        public async Task<ActionResult<IEnumerable<Genre>>> AllGenres() => await _genre.AllGenres.ToListAsync();

        [HttpGet("{id}")]
        public Task<ActionResult<Movie>> GetById(int id)
        {
            var movie = _movie.getObjectMovieById(id);
            return Task.FromResult<ActionResult<Movie>>(movie);
        }
    }
}