using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Data.Intarfaces
{
    public interface IMovie
    {
        IEnumerable<Movie> AllMovies { get;  }//выдаёт все фильмы
        Movie getObjectMovie(int movieId);// вернуть конкректный фильм по id
    }
}