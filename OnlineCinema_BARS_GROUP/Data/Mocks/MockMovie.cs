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
                        Name = "Райан Гослинг",
                        ShortDesc = "Лучший фильм",
                        LongDesc = "Самый лучший фильм",
                        FilmScore = 4.5,
                        Img = "https://media.globalcitizen.org/thumbnails/ea/c1/eac1a9c0-85e8-4298-b24a-1788aea2eb98/hey-girl-those-ryan-gosling-memes-actually-do-some__1600x900_q85_crop_subsampling-2.jpg",
                        Film = "",
                        Categories = {_category.AllCategories.First(),_category.AllCategories.Last()},
                        Time = 500
                    },
                    new Movie()
                    {
                        Name = "Райан Гослинг",
                        ShortDesc = "Лучший фильм",
                        LongDesc = "Самый лучший фильм",
                        FilmScore = 4.5,
                        Img = "https://media.globalcitizen.org/thumbnails/ea/c1/eac1a9c0-85e8-4298-b24a-1788aea2eb98/hey-girl-those-ryan-gosling-memes-actually-do-some__1600x900_q85_crop_subsampling-2.jpg",
                        Film = "",
                        Categories = {_category.AllCategories.First(),_category.AllCategories.Last()},
                        Time = 500
                    },
                    new Movie()
                    {
                        Name = "Райан Гослинг",
                        ShortDesc = "Лучший фильм",
                        LongDesc = "Самый лучший фильм",
                        FilmScore = 4.5,
                        Img = "https://media.globalcitizen.org/thumbnails/ea/c1/eac1a9c0-85e8-4298-b24a-1788aea2eb98/hey-girl-those-ryan-gosling-memes-actually-do-some__1600x900_q85_crop_subsampling-2.jpg",
                        Film = "",
                        Categories = {_category.AllCategories.First(),_category.AllCategories.Last()},
                        Time = 500
                    },
                    new Movie()
                    {
                        Name = "Райан Гослинг",
                        ShortDesc = "Лучший фильм",
                        LongDesc = "Самый лучший фильм",
                        FilmScore = 4.5,
                        Img = "https://media.globalcitizen.org/thumbnails/ea/c1/eac1a9c0-85e8-4298-b24a-1788aea2eb98/hey-girl-those-ryan-gosling-memes-actually-do-some__1600x900_q85_crop_subsampling-2.jpg",
                        Film = "",
                        Categories = {_category.AllCategories.First(),_category.AllCategories.Last()},
                        Time = 500
                    },
                    new Movie()
                    {
                        Name = "Райан Гослинг",
                        ShortDesc = "Лучший фильм",
                        LongDesc = "Самый лучший фильм",
                        FilmScore = 4.5,
                        Img = "https://media.globalcitizen.org/thumbnails/ea/c1/eac1a9c0-85e8-4298-b24a-1788aea2eb98/hey-girl-those-ryan-gosling-memes-actually-do-some__1600x900_q85_crop_subsampling-2.jpg",
                        Film = "",
                        Categories = {_category.AllCategories.First(),_category.AllCategories.Last()},
                        Time = 500
                    },new Movie()
                    {
                        Name = "Райан Гослинг",
                        ShortDesc = "Лучший фильм",
                        LongDesc = "Самый лучший фильм",
                        FilmScore = 4.5,
                        Img = "https://media.globalcitizen.org/thumbnails/ea/c1/eac1a9c0-85e8-4298-b24a-1788aea2eb98/hey-girl-those-ryan-gosling-memes-actually-do-some__1600x900_q85_crop_subsampling-2.jpg",
                        Film = "",
                        Categories = {_category.AllCategories.First(),_category.AllCategories.Last()},
                        Time = 500
                    },
                    new Movie()
                    {
                        Name = "Райан Гослинг",
                        ShortDesc = "Лучший фильм",
                        LongDesc = "Самый лучший фильм",
                        FilmScore = 4.5,
                        Img = "https://media.globalcitizen.org/thumbnails/ea/c1/eac1a9c0-85e8-4298-b24a-1788aea2eb98/hey-girl-those-ryan-gosling-memes-actually-do-some__1600x900_q85_crop_subsampling-2.jpg",
                        Film = "",
                        Categories = {_category.AllCategories.First(),_category.AllCategories.Last()},
                        Time = 500
                    },
                    new Movie()
                    {
                        Name = "Райан Гослинг",
                        ShortDesc = "Лучший фильм",
                        LongDesc = "Самый лучший фильм",
                        FilmScore = 4.5,
                        Img = "https://media.globalcitizen.org/thumbnails/ea/c1/eac1a9c0-85e8-4298-b24a-1788aea2eb98/hey-girl-those-ryan-gosling-memes-actually-do-some__1600x900_q85_crop_subsampling-2.jpg",
                        Film = "",
                        Categories = {_category.AllCategories.First(),_category.AllCategories.Last()},
                        Time = 500
                    },
                    new Movie()
                    {
                        Name = "Райан Гослинг",
                        ShortDesc = "Лучший фильм",
                        LongDesc = "Самый лучший фильм",
                        FilmScore = 4.5,
                        Img = "https://media.globalcitizen.org/thumbnails/ea/c1/eac1a9c0-85e8-4298-b24a-1788aea2eb98/hey-girl-those-ryan-gosling-memes-actually-do-some__1600x900_q85_crop_subsampling-2.jpg",
                        Film = "",
                        Categories = {_category.AllCategories.First(),_category.AllCategories.Last()},
                        Time = 500
                    },
                    new Movie()
                    {
                        Name = "Райан Гослинг",
                        ShortDesc = "Лучший фильм",
                        LongDesc = "Самый лучший фильм",
                        FilmScore = 4.5,
                        Img = "https://media.globalcitizen.org/thumbnails/ea/c1/eac1a9c0-85e8-4298-b24a-1788aea2eb98/hey-girl-those-ryan-gosling-memes-actually-do-some__1600x900_q85_crop_subsampling-2.jpg",
                        Film = "",
                        Categories = {_category.AllCategories.First(),_category.AllCategories.Last()},
                        Time = 500
                    },
                    new Movie()
                    {
                        Name = "Райан Гослинг",
                        ShortDesc = "Лучший фильм",
                        LongDesc = "Самый лучший фильм",
                        FilmScore = 4.5,
                        Img = "https://media.globalcitizen.org/thumbnails/ea/c1/eac1a9c0-85e8-4298-b24a-1788aea2eb98/hey-girl-those-ryan-gosling-memes-actually-do-some__1600x900_q85_crop_subsampling-2.jpg",
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