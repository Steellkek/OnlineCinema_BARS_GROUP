using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Data.Mocks
{
    public class MockGenre: IGenre
    {
        public IEnumerable<Genre> AllGenres
        {
            get
            {
                return new List<Genre>
                {
                    new Genre(){Name = "Экшн"},
                    new Genre(){Name = "Боевик"}
                };
            }
        }
    }
}

