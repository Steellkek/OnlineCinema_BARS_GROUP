namespace OnlineCinema_BARS_GROUP.Data.Models;

public class Genre
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<Movie> Movies { get; set; } = new List<Movie>();
}