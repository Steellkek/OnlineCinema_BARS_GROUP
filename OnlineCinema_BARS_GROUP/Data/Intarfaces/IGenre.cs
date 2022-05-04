using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Data.Intarfaces
{
    public interface IGenre
    {
        IEnumerable<Genre> AllGenres { get; }
    }
}

