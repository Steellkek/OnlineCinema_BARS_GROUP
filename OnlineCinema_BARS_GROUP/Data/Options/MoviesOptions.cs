using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Data.Options;

public class MoviesOptionsDTO
{
    public string? SearchText { get; set; } = "";
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 12;
    public Guid? CategoryId { get; set; }
    public IEnumerable<int>? GenreIds { get; set; }
    public SortOrder SortOrder { get; set; } = SortOrder.Ascending;
    public SortBy SortBy { get; set; } = SortBy.Views;
}