using Microsoft.AspNetCore.Mvc;
using OnlineCinema_BARS_GROUP.Data;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController
{
    private readonly CinemaContext _context;

    public UserController(CinemaContext context)
    {
        _context = context;
    }

    [HttpGet("{name}")]
    public async Task<ActionResult<User>> GetUser(string name)
    {
        return await Task.FromResult<ActionResult<User>>(_context.Users.FirstOrDefault(x=>x.UserName==name)!);
    }
}