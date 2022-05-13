using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Data.Repository;

public class UserRepository:IUser
{
    private readonly CinemaContext _context;

    public UserRepository(CinemaContext context)
    {
        _context = context;
    }

    //public IEnumerable<User> GetAllUsers { get; }
    
    public User GetUser(string title)
    {
        return _context.Users.FirstOrDefault(x => x.UserName == title)!;
    }
}