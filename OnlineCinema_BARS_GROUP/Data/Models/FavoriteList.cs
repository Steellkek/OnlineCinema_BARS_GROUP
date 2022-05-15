namespace OnlineCinema_BARS_GROUP.Data.Models;

public class FavoriteList
{
    public Guid Id { get; set; }
    public int AuthorId { get; set; }
    public User Author { get; set; }
    public List<Movie> Movies { get; set; } = new();
}