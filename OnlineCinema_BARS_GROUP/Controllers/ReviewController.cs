using Microsoft.AspNetCore.Mvc;
using OnlineCinema_BARS_GROUP.Data;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReviewController:Controller
{
    
    private readonly IReview _review;
    private readonly CinemaContext _context;
    public ReviewController(IReview review, CinemaContext context)
    {
        _review = review;
        _context = context;
    }

    
    [HttpGet("{id}")]
    public async Task<ActionResult<IEnumerable<Review>>> Get(int id)
    {
        /*var review = new Review()
        {
            MovieId = 1,
            AuthorId = 1,
            Comment = "cxzc",
            Id = Guid.NewGuid(),
            Likes = 0,
            Dislikes = 0
        };
        _context.Reviews.Add(review);
        await _context.SaveChangesAsync();*/
        return await Task.FromResult<ActionResult<IEnumerable<Review>>>(_review.AllReview(id).ToList());
    }

    [HttpPost]
    public async Task<ActionResult<Review>> Add(Review review)
    {
        try
        {
            Console.WriteLine(review);
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();
            return Ok(review);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}