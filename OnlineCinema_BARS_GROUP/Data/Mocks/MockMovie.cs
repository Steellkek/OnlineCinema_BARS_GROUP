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

                Movie? movie;
                for (int i = 1; i <= 10; i++)
                {
                    movie = new Movie
                    {
                        Id = i,
                        Title = "Райан Гослинг",
                        ShortDescription = "Лучший фильм",
                        LongDescription = "Великолепный водитель – при свете дня он выполняет каскадерские трюки на съёмочных площадках Голливуда, а по ночам ведет рискованную игру. Но один опасный контракт – и за его жизнь назначена награда. Теперь, чтобы остаться в живых и спасти свою очаровательную соседку, он должен делать то, что умеет лучше всего – виртуозно уходить от погони.",
                        Rating = 4.5,
                        ImagePath = "https://i02.fotocdn.net/s112/d5943550cc7427e6/public_pin_l/2528698510.jpg",
                        FilmPath = "",
                        Genres = {_genre.AllGenres.First(), _genre.AllGenres.Last()},
                        //Duration = new TimeSpan(1,48,8)
                    };
                    movies.Add(movie);
                }
                
                movie = new Movie
                {
                    Id = 11,
                    Title = "Дракула",
                    ShortDescription = "Лучший фильм",
                    LongDescription = "Великолепный водитель – при свете дня он выполняет каскадерские трюки на съёмочных площадках Голливуда, а по ночам ведет рискованную игру. Но один опасный контракт – и за его жизнь назначена награда. Теперь, чтобы остаться в живых и спасти свою очаровательную соседку, он должен делать то, что умеет лучше всего – виртуозно уходить от погони.",
                    Rating = 4.5,
                    ImagePath = "https://media.globalcitizen.org/thumbnails/ea/c1/" +
                                "eac1a9c0-85e8-4298-b24a-1788aea2eb98/" +
                                "hey-girl-those-ryan-gosling-memes-actually-do-some__1600x900_q85_crop_subsampling-2.jpg",
                    FilmPath = "",
                    Genres = {_genre.AllGenres.First(), _genre.AllGenres.Last()},
                    //Duration = new TimeSpan(1,48,8)
                };
                movies.Add(movie);
                return movies;
            }
        }

        public Movie getObjectMovieById(int movieId )
        {
            return AllMovies.FirstOrDefault(c => c.Id == movieId) ?? throw new InvalidOperationException();
        }
        
    }
}