namespace OnlineCinema_BARS_GROUP.Data.Models;

public class Movie
{
    public int Id {get; set;}
        
    public string Title { get; set; }
    
    /// <summary>
    /// Описание.
    /// </summary>
    public string? LongDescription { get; set; }

    /// <remark>
    /// прим. Фильм, сериал.
    /// </remark>
    public Category? Category { get; set; }
    public Guid? CategoryId { get; set; }

    public double Rating { get; set; }
        
    /// <summary>
    /// Cсылка на картинку постера.
    /// </summary>
    public string? ImagePath { get; set; }
        
    /// <summary>
    /// Cсылка на видеофайл.
    /// </summary>
    public string? FilmPath { get; set; }
        
    /// <summary>
    /// Длительность.
    /// </summary>
    public TimeSpan? Duration { get; set; }

    /// <summary>
    /// Количество просмотров.
    /// </summary>
    public List<Genre> Genres { get; set; } = new();
        
    /// <summary>
    /// Список отзывов
    /// </summary>
    public List<Review> Reviews = new();

    
}