namespace OnlineCinema_BARS_GROUP.Data.Models;

public class Review
{
    public Guid Id { get; set; }
    public int AuthorId { get; set; }
    public User Author { get; set; } = new User();
    public int MovieId { get; set; }
    public Movie Movie { get; set; } = new Movie();
    public string Comment { get; set; }
    //public List<Comment> Comments { get; set; } = new();
    public int Likes { get; set; }
    public int Dislikes { get; set; }
}