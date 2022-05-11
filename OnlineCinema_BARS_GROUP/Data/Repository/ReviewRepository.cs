using Microsoft.EntityFrameworkCore;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Data.Repository;

public class ReviewRepository:IReview
{
    private readonly CinemaContext _context;

    public ReviewRepository(CinemaContext context)
    {
        _context = context;
    }
    public IEnumerable<Review> AllReview(int movieId)
    {
        return _context.Reviews.Where(u=>u.MovieId==movieId).Include(u=>u.Author).ToList();
    }
}