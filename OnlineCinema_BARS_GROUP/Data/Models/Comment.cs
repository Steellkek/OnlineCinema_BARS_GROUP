namespace OnlineCinema_BARS_GROUP.Data.Models
{
    public class Comment
    {
        public int Id { get; set; }
        
        public string Text { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public Guid AuthorId { get; set; }
        public User Author { get; set; }
        public Guid? ParentId { get; set; }
        public Comment? Parent { get; set; }
        public Guid ReviewId { get; set; }
        public Review Review { get; set; }
        public List<Comment> Children { get; set; } = new();
    }
}