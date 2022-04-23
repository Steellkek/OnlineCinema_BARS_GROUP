using System.Collections.Generic;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Data.Intarfaces
{
    public interface IUser
    {
        IEnumerable<User> GetAllUsers { get; }//выдаёт все фильмы
    }
}
