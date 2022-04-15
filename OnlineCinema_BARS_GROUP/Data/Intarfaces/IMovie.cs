using System.Collections.Generic;
using OnlineCinema_BARS_GROUP.Models;

namespace OnlineCinema_BARS_GROUP.Data.Intarfaces
{
    public interface IMovie
    {
        IEnumerable<Movie> GetAllMovies { get;  }//выдаёт все фильмы
        Movie getObjectMovie(int songId);// вернуть конкректный трек по id
    }
}