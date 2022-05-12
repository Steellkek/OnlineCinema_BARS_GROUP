using Microsoft.AspNetCore.Mvc;
using OnlineCinema_BARS_GROUP.Data;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController
{

    private readonly IUser _user;

    public UserController(IUser user)
    {
        _user = user;
    }

    [HttpGet("{title}")]
    public async Task<ActionResult<User>> GetUser(string title)
    {
        return await Task.FromResult<ActionResult<User>>(_user.GetUser(title));
    }
}