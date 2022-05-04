namespace OnlineCinema_BARS_GROUP.Data.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Movie> Movies { get; set; } = new();
    }
}