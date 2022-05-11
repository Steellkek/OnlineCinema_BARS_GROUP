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
        return await Task.FromResult<ActionResult<IEnumerable<Review>>>(_review.AllReview(id).ToList());
    }
    
}