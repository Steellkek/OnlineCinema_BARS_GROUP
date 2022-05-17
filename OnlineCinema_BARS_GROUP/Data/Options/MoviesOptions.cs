using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Data.Options;

public class MoviesOptionsDTO
{
    public string? SearchText { get; set; } = "";
    public Guid? CategoryId { get; set; }
    public Guid? GenreId { get; set; }
}