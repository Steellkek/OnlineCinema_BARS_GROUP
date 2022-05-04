namespace OnlineCinema_BARS_GROUP.Data.Models;

public class Room
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<User> Users { get; set; }
    public List<Genre> Genres { get; set; }
    public List<Movie> Movies { get; set; }
}