using OnlineCinema_BARS_GROUP.Models;

namespace OnlineCinema_BARS_GROUP.Data.Intarfaces;

public interface ICategory
{
    IEnumerable<Category> AllCategories { get; }
}