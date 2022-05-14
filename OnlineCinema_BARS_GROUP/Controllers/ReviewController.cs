using Microsoft.AspNetCore.Authorization;
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
    public ReviewController(IReview review, CinemaContext context)
    {
        _review = review;
    }

    
    [HttpGet("{id}")]
    public async Task<ActionResult<IEnumerable<Review>>> Get(int id)
    {
        var reviews = _review.AllReview(id).ToList();
        if (reviews!=null)
        {
            return await Task.FromResult<ActionResult<IEnumerable<Review>>>(reviews);
        }
        else
        {
            return BadRequest();
        }
        
    }
    [Authorize]
    [HttpPost]
    public Task<ActionResult<Review>> Add(Review review)
    {
        _review.Post(review);
        return Task.FromResult<ActionResult<Review>>(Ok(review));
    }
}