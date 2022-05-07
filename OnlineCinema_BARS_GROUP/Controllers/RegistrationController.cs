using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineCinema_BARS_GROUP.Data;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private CinemaContext _context;
        public RegistrationController(CinemaContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<List<User>>> Registration(User user)
        {
            User userReg = checkReg(user);
            Console.WriteLine(userReg);
            if (userReg == null)
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
            }
            return Ok(await _context.Users.ToListAsync());
        }

        private User checkReg(User user)
        {
            var regUser = _context.Users.FirstOrDefault(o => o.UserName ==
                 user.UserName);
            return regUser;
        }
    }
}
