using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Data.Repository;

public class GenryRepository:IGenre
{
    private readonly CinemaContext _context;

    public GenryRepository(CinemaContext context)
    {
        _context = context;
    }

    public IQueryable<Genre> AllGenres => _context.Genres;
}