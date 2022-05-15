using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Data.Intarfaces;

public interface ICategory
{
    IQueryable<Category> Categories { get; }
}