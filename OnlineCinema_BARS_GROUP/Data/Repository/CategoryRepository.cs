using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Data.Repository;

/// <summary>
/// Доступ к категориям из БД.
/// </summary>
public class CategoryRepository : ICategory
{
    private readonly CinemaContext _context;

    public CategoryRepository(CinemaContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Все категории.
    /// </summary>
    public IQueryable<Category> Categories => _context.Categories;
}