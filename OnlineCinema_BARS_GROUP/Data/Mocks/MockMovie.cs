using System.Collections.Generic;
using System.Linq;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Models;

namespace OnlineCinema_BARS_GROUP.Data.Mocks
{
    public class MockMovie:IMovie
    {
        private readonly ICategory _category = new MockCategory();
        public IEnumerable<Movie> GetAllMovies =>
            new List<Movie>()
            {
                new Movie()
                {
                    Id = 0,
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
                    Id = 1,
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
                    Id = 2,
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
                    Id = 3,
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
                    Id = 4,
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
                    Id = 5,
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
                    Id = 6,
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
                    Id = 7,
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
                    Id = 8,
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
                    Id = 9,
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
                    Id = 10,
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


        public Movie getObjectMovie(int movieId)
        {
            return GetAllMovies.FirstOrDefault(c => c.Id == movieId) ?? throw new InvalidOperationException();
        }
    }
}