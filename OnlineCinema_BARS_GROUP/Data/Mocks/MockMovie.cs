using System.Collections.Generic;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Models;

namespace OnlineCinema_BARS_GROUP.Data.Mocks
{
    public class MockMovie:IMovie
    {
        private readonly ICategory _category = new MockCategory();
        public IEnumerable<Movie> GetAllMovies
        {
            get
            {
                return new List<Movie>()
                {
                    new Movie()
                    {
                        Name = "Гачи",
                        ShortDesc = "Лучший фильм",
                        LongDesc = "Самый лучший фильм",
                        FilmScore = 4.5,
                        Img = "https://i.ytimg.com/vi/zg6JsU9s3XE/maxresdefault.jpg",
                        Film = "",
                        Categories = {_category.AllCategories.First(),_category.AllCategories.Last()},
                        Time = 500
                    }
                };
            }
        }
            

        public Movie getObjectMovie(int songId)
        {
            throw new System.NotImplementedException();
        }
    }
}