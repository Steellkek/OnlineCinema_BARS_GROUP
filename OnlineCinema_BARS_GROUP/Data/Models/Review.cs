namespace OnlineCinema_BARS_GROUP.Data.Models;

public class Review
{
    public Guid Id { get; set; }
    public int AuthorId { get; set; }
    public User? Author { get; set; } 
    public int MovieId { get; set; }
    public Movie? Movie { get; set; } 
    public string Comment { get; set; }
    public int Rating { get; set; }
    public long Time { get; set; }
}