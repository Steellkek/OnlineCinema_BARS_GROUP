using System.Collections.Generic;

namespace OnlineCinema_BARS_GROUP.Models
{
    public class Category
    {
        //Id жанра
        public int Id { get; set; }
        //название жанра
        public string CategoryName { get; set; }
        //список фильмов жанра
        //public List<Movie> Movies { get; set; }
    }
}