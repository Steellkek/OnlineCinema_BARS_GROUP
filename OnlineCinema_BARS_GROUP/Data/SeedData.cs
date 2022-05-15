using Microsoft.EntityFrameworkCore;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Data;

/// <summary>
/// Создает тестовые данные.
/// </summary>
public class SeedData
{
    /// <summary>
    /// Создает БД и заполняет ее тестовыми данными.
    /// </summary>
    public void EnsurePopulated(IApplicationBuilder app)
    {
        var scopedFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
        using var scope = scopedFactory.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<CinemaContext>();
        
        context.Database.Migrate();
        
        if (context.Movies.Any())
        {
            return;
        }

        var movies = CreateMovies();

        context.AddRange(movies);

        context.SaveChanges();
    }

    private List<Genre> CreateGenres()
    {
        var genres = new List<Genre>();
        
        genres.Add(new Genre
        {
            Name = "Боевик"
        });
        
        genres.Add(new Genre
        {
            Name = "Триллер"
        });
        
        genres.Add(new Genre
        {
            Name = "Мультфильм"
        });
        
        genres.Add(new Genre
        {
            Name = "Аниме"
        });
        
        genres.Add(new Genre
        {
            Name = "Фэнтези"
        });

        genres.Add(new Genre
        {
            Name = "Комедия"
        });
        
        genres.Add(new Genre
        {
            Name = "Семейное кино"
        });
        
        genres.Add(new Genre
        {
            Name = "Драма"
        });
        
        genres.Add(new Genre
        {
            Name = "Криминал"
        });
        
        genres.Add(new Genre
        {
            Name = "Приключения"
        });
        
        return genres;
    }
    
    public List<Category> CreateCategories()
    {
        var categories = new List<Category>();
        
        categories.Add(new Category
        {
            Name = "Фильм"
        });
        
        categories.Add(new Category
        {
            Name = "Сериал"
        });

        return categories;
    }
    
    public List<Movie> CreateMovies()
    {
        var movies = new List<Movie>();
        var categories = CreateCategories();
        var genres = CreateGenres();
        
        movies.Add(new Movie
        {
            Title = "Драйв",
            ShortDescription = "Молчаливый водитель спасает девушку от гангстеров. " +
                               "Неонуар с Райаном Гослингом и пульсирующим саундтреком",
            LongDescription = "Драйв – это слово, которым можно охарактеризовать крутую автомобильную погоню или " +
                              "динамичную перестрелку, идеально уложенную на саундтрек. А в английском языке слово " +
                              "«drive» смотрится гораздо скромнее. Самое распространённое значение – «езда на " +
                              "автомобиле». Именно от этого и необходимо отталкиваться, усаживаясь смотреть фильм.",
            Category = categories.FirstOrDefault(x => x.Name == "Фильм"),
            Rating = 7.8,
            ImagePath = "https://i02.fotocdn.net/s112/d5943550cc7427e6/public_pin_l/2528698510.jpg",
            FilmPath = "https://www.youtube.com/embed/SDhGly0CgvQ",
            Duration = new TimeSpan(1,40,0),
            Views = 121901,
            Genres = genres.Where(x => x.Name is "Боевик" or "Триллер").ToList()
        });
        
        movies.Add(new Movie
        {
            Title = "Истребитель демонов",
            ShortDescription = "Демон убивает семью Тандзиро и насылает заклятие на его сестру. Тогда Тандзиро " +
                               "отправляется в опасный путь, чтобы найти лекарство и отомстить за тех, кого он потерял.",
            LongDescription = "Эпоха Тайсё. Ещё с древних времён ходят слухи, что в лесу обитают человекоподобные " +
                              "демоны, которые питаются людьми и выискивают по ночам новых жертв. Тандзиро Камадо — " +
                              "старший сын в семье, потерявший отца и взявший на себя заботу о родных. Однажды он " +
                              "уходит в соседний город, чтобы продать древесный уголь. Вернувшись утром, парень " +
                              "обнаруживает перед собой страшную картину: вся родня зверски убита, а единственная " +
                              "выжившая — младшая сестра Нэдзуко, обращённая в демона, но пока не потерявшая " +
                              "человечность. С этого момента начинается долгое и опасное путешествие Тандзиро и " +
                              "Нэдзуко, в котором мальчик намерен разыскать убийцу и узнать способ исцеления сестры.",
            Category = categories.FirstOrDefault(x => x.Name == "Сериал"),
            Rating = 8.2,
            ImagePath = "https://pm1.narvii.com/7336/cdb54fe3ce6d33dd9b883680ef7a1b02b49b780br1-1080-1496v2_hq.jpg",
            FilmPath = "https://www.youtube.com/embed/wtE-SW8YDHM",
            Duration = new TimeSpan(0,20,0),
            Views = 41912,
            Genres = genres.Where(x => x.Name is "Боевик" or "Фэнтези" or "Аниме").ToList(),
        });

        movies.Add(new Movie
        {
            Title = "Клаус",
            ShortDescription = "Молодой паренек, сын богатого родителя, пребывает в небольшую провинцию, " +
                               "которая далеко от всяческой цивилизации. Здесь он будет пытаться быть в качестве " +
                               "почтальона. Но мало того жители ведут себя недружелюбно, так ещё и не пользуются " +
                               "подобными услугами. Случайное знакомство с создателем игрушек исправит ситуацию. ",
            LongDescription = "Полнометражная испано-британская анимационная лента. Молодой человек Джеспер " +
                              "оказывается сосланным своим отцом, владельцем почтовой империи, работать " +
                              "почтальоном в самое унылое место на свете – северный город Смиренсбург. Отец поставил " +
                              "своему ленивому сыну условие: пока он не отправит с острова 6000 писем, " +
                              "ему нельзя возвращаться домой.",
            Category = categories.FirstOrDefault(x => x.Name == "Фильм"),
            Rating = 8.1,
            ImagePath = "https://animemult.ru/uploads/posts/2020-04/1586953408_ei4gwijvaaaap7r.jpg",
            FilmPath = "https://www.youtube.com/embed/6ntdmScyBDM",
            Duration = new TimeSpan(1,36,0),
            Views = 1411412,
            Genres = genres.Where(x => x.Name is "Мультфильм" or "Семейный" or "Комедия" or "Приключение").ToList(),
        });
        
        movies.Add(new Movie
        {
            Title = "Острые козырьки",
            ShortDescription = "Бирмингем, Англия. 1919 год. Скандально известную банду возглавляет жестокий Томми " +
                               "Шелби, лидер преступного клана, который решил добиться новых высот любой ценой.",
            LongDescription = "Британский сериал о криминальном мире Бирмингема 20-х годов прошлого века, в " +
                              "котором многолюдная семья Шелби стала одной из самых жестоких и влиятельных " +
                              "гангстерских банд послевоенного времени. Фирменным знаком группировки, промышлявшей " +
                              "грабежами и азартными играми, стали зашитые в козырьки лезвия.",
            Category = categories.FirstOrDefault(x => x.Name == "Сериал"),
            Rating = 8.4,
            ImagePath = "https://img.tvdate.ru/serials/peaky-blinders/peaky-blinders-big-poster.jpg",
            FilmPath = "https://www.youtube.com/embed/SwQSvchPh9Y",
            Duration = new TimeSpan(1,0,0),
            Views = 1927312,
            Genres = genres.Where(x => x.Name is "Криминал" or "Драма").ToList(),
        });
        
        movies.Add(new Movie
        {
            Title = "ТРАХОБОЙЩИКИ - Catalina Video's Trucker Huggers",
            ShortDescription = "Они прокатят вас на своей фуре.",
            LongDescription = "Новое видение сериала \"Дальнобойщики\" в экранизации 2021 года. Всё сделано в" +
                              " контексте комедии и сатиры, а совпадения с реальными людьми случайны.",
            Category = categories.FirstOrDefault(x => x.Name == "Фильм"),
            Rating = 8.4,
            ImagePath = "https://i.ytimg.com/vi/d0LGR-HrEcY/maxresdefault.jpg",
            FilmPath = "https://www.youtube.com/embed/8N7mtvyYnhg",
            Duration = new TimeSpan(6,59,0),
            Views = 12312,
            Genres = genres.Where(x => x.Name is "Комедия" or "Семейное кино").ToList(),
        });

        return movies;
    }
}