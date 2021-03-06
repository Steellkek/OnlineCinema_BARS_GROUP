using Microsoft.EntityFrameworkCore;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Data.Repository;

public class ReviewRepository:IReview
{
    private  readonly CinemaContext _context;

    public ReviewRepository(CinemaContext context)
    {
        _context = context;
    }
    public IEnumerable<Review> AllReview(int movieId)
    {
        return _context.Reviews
            .Where(u=>u.MovieId==movieId)
            .Include(u=>u.Author)
            .OrderBy(x=>x.Time)
            .Reverse()
            .ToList();
    }

    public void Post(Review review)
    {
        _context.Reviews.Add(review);
        _context.SaveChanges();
    }

    public Review Delete(Guid id)
    {
        Review review = _context.Reviews.FirstOrDefault(x => x.Id == id)!;
        _context.Reviews.Remove(review);
        _context.SaveChanges();
        return review;
    }
}