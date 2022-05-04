namespace OnlineCinema_BARS_GROUP.Data.Models;

public class Playlist
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid AuthorId { get; set; }
    public User Author { get; set; }
    public List<Movie> Movies { get; set; } = new();
}