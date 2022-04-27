using System.Collections.Generic;
using System.Linq;
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
                        Img = "https://steamcdn-a.akamaihd.net/steamcommunity/public/images/avatars/b4/b4e271dd79e5800d7d25c6a51586478d4adf3826_full.jpg",
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