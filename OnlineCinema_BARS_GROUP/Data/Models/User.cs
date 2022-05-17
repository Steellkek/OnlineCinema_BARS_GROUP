namespace OnlineCinema_BARS_GROUP.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public List<Review> Reviews { get; set; } = new();
        public List<Movie> Movies { get; set; } = new();
    }
}
