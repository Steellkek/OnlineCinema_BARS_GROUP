using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Data.Mocks
{
    public class MockMovie : IMovie
    {
        private readonly IGenre _genre = new MockGenre();
        public IEnumerable<Movie> AllMovies
        {
            get
            {
                var movies = new List<Movie>();
                
                for (int i = 1; i <= 10; i++)
                {
                    var movie = new Movie
                    {
                        Id = i,
                        Title = "Райан Гослинг",
                        ShortDescription = "Лучший фильм",
                        LongDescription = "Самый лучший фильм",
                        Rating = 4.5,
                        ImagePath = "https://media.globalcitizen.org/thumbnails/ea/c1/" +
                                    "eac1a9c0-85e8-4298-b24a-1788aea2eb98/" +
                                    "hey-girl-those-ryan-gosling-memes-actually-do-some__1600x900_q85_crop_subsampling-2.jpg",
                        FilmPath = "",
                        Genres = {_genre.AllGenres.First(), _genre.AllGenres.Last()},
                        Duration = new TimeSpan(1,48,8)
                    };
                    movies.Add(movie);
                }

                return movies;
            }
        }

        public Movie getObjectMovie(int movieId)
        {
            return AllMovies.FirstOrDefault(c => c.Id == movieId) ?? throw new InvalidOperationException();
        }
    }
}