using Microsoft.EntityFrameworkCore;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Data.Repository;

public class MovieRepository : IMovie
{
    private readonly CinemaContext _context;

    public MovieRepository(CinemaContext context)
    {
        _context = context;
    }

    public IEnumerable<Movie> AllMovies
    {
        get
        {
            return _context.Movies
                .Include(u => u.Category)
                .Include(x => x.Genres)
                .ToList();
        }
    }

    /// <summary>
    /// Все фильмы.
    /// </summary>
    public IQueryable<Movie> Movies => _context.Movies;

    public Movie getObjectMovieById(int movieId)
    {
        return _context.Movies
            .Include(u => u.Category)
            .Include(x => x.Genres).FirstOrDefault(x => x.Id == movieId)!;
    }
}