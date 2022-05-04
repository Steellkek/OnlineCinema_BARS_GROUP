namespace OnlineCinema_BARS_GROUP.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Movie> Movies { get; set; } = new();
        public List<Room> Rooms { get; set; } = new();
    }
}
