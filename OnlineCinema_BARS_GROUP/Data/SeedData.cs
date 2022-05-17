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
            Name = "Фантастика"
        });
        
        
        genres.Add(new Genre
        {
            Name = "Хоррор"
        });
        genres.Add(new Genre
        {
            Name = "Приключение"
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
            LongDescription = "Драйв – это слово, которым можно охарактеризовать крутую автомобильную погоню или " +
                              "динамичную перестрелку, идеально уложенную на саундтрек. А в английском языке слово " +
                              "«drive» смотрится гораздо скромнее. Самое распространённое значение – «езда на " +
                              "автомобиле». Именно от этого и необходимо отталкиваться, усаживаясь смотреть фильм.",
            Category = categories.FirstOrDefault(x => x.Name == "Фильм"),
            Rating = 7.8,
            ImagePath = "/img/1.jpg",
            FilmPath = "https://www.youtube.com/embed/SDhGly0CgvQ",
            Duration = new TimeSpan(1,40,0),
            Genres = genres.Where(x => x.Name is "Боевик" or "Триллер").ToList()
        });
        
        movies.Add(new Movie
        {
            Title = "Истребитель демонов",
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
            ImagePath = "/img/2.jpg",
            FilmPath = "https://www.youtube.com/embed/wtE-SW8YDHM",
            Duration = new TimeSpan(0,20,0),
            Genres = genres.Where(x => x.Name is "Боевик" or "Фэнтези" or "Аниме").ToList(),
        });

        movies.Add(new Movie
        {
            Title = "Клаус",
            LongDescription = "Полнометражная испано-британская анимационная лента. Молодой человек Джеспер " +
                              "оказывается сосланным своим отцом, владельцем почтовой империи, работать " +
                              "почтальоном в самое унылое место на свете – северный город Смиренсбург. Отец поставил " +
                              "своему ленивому сыну условие: пока он не отправит с острова 6000 писем, " +
                              "ему нельзя возвращаться домой.",
            Category = categories.FirstOrDefault(x => x.Name == "Фильм"),
            Rating = 8.1,
            ImagePath = "/img/3.jpg",
            FilmPath = "https://www.youtube.com/embed/6ntdmScyBDM",
            Duration = new TimeSpan(1,36,0),
            Genres = genres.Where(x => x.Name is "Мультфильм" or "Семейный" or "Комедия" or "Приключение").ToList(),
        });
        
        movies.Add(new Movie
        {
            Title = "Острые козырьки",
            LongDescription = "Британский сериал о криминальном мире Бирмингема 20-х годов прошлого века, в " +
                              "котором многолюдная семья Шелби стала одной из самых жестоких и влиятельных " +
                              "гангстерских банд послевоенного времени. Фирменным знаком группировки, промышлявшей " +
                              "грабежами и азартными играми, стали зашитые в козырьки лезвия.",
            Category = categories.FirstOrDefault(x => x.Name == "Сериал"),
            Rating = 8.4,
            ImagePath = "/img/4.jpg",
            FilmPath = "https://www.youtube.com/embed/SwQSvchPh9Y",
            Duration = new TimeSpan(1,0,0),
            Genres = genres.Where(x => x.Name is "Криминал" or "Драма").ToList(),
        });
        
        movies.Add(new Movie
        {
            Title = "ТРАХОБОЙЩИКИ - Catalina Video's Trucker Huggers",
            LongDescription = "Новое видение сериала \"Дальнобойщики\" в экранизации 2021 года. Всё сделано в" +
                              " контексте комедии и сатиры, а совпадения с реальными людьми случайны.",
            Category = categories.FirstOrDefault(x => x.Name == "Фильм"),
            Rating = 8.4,
            ImagePath = "/img/5.jpg",
            FilmPath = "https://www.youtube.com/embed/8N7mtvyYnhg",
            Duration = new TimeSpan(6,59,0),
            Genres = genres.Where(x => x.Name is "Комедия" or "Семейное кино").ToList(),
        });
        
        movies.Add(new Movie
        {
            Title = "Винницианский канибал",
            LongDescription = "Психопат похищает и убивает молодых женщин по всему Среднему Западу. ФБР," +
                              " уверенное, что все преступления совершены одним и тем же человеком, поручает " +
                              "агенту Клариссе Старлинг встретиться с заключенным-маньяком Ганнибалом Лектером, " +
                              "который мог бы помочь составить психологический портрет убийцы. " +
                              "Сам Лектер отбывает наказание за убийства и каннибализм. " +
                              "Он согласен помочь Клариссе лишь в том случае, если она попотчует его " +
                              "больное воображение подробностями своей личной жизни.",
            Category = categories.FirstOrDefault(x => x.Name == "Фильм"),
            Rating = 9.5,
            ImagePath = "/img/6.jpg",
            FilmPath = "https://www.youtube.com/embed/gMqnibDCHaQ",
            Duration = new TimeSpan(0,2,0),
            Genres = genres.Where(x => x.Name is "Боевик" or "Триллер").ToList(),
        });
        
        movies.Add(new Movie
        {
            Title = "JoJo’s Bizarre Adventure",
            LongDescription = "Англия, конец XIX века. Богатый аристократ Джордж Джостар, " +
                              "верный некогда данному слову, принимает в семью осиротевшего бедного парня " +
                              "Дио и теперь относится к нему как к сыну. " +
                              "Родной же сын Джорджа Джонатан совсем не рад новому «брату», " +
                              "ведь тот превосходит его во всём, но вскоре благородство отца обернётся для " +
                              "него настоящей трагедией. Внимание Дио привлекает Каменная маска — семейная реликвия, " +
                              "украв которую он высвобождает древние силы, способные превратить его в неуязвимого вампира. " +
                              "На протяжении многих десятилетий против зла будут сражаться представители разных " +
                              "поколений семьи Джостар: Джонатан Джостар, Джозеф Джостар, Джотаро Куджо, " +
                              "Джосукэ Хигасиката, Джорно Джованна, Джолин Куджо.",
            Category = categories.FirstOrDefault(x => x.Name == "Сериал"),
            Rating = 8.4,
            ImagePath = "/img/7.jpg",
            FilmPath = "https://www.youtube.com/embed/K7flYcLKG6Q",
            Duration = new TimeSpan(0,20,0),
            Genres = genres.Where(x => x.Name is "Боевик" or "Фэнтези" or "Аниме").ToList(),
        });

        movies.Add(new Movie
        {
            Title = "Мстители: Финал",
            LongDescription = "Оставшиеся в живых члены команды Мстителей и их союзники должны разработать новый план, " +
                              "который поможет противостоять разрушительным действиям могущественного титана Таноса. " +
                              "После наиболее масштабной и трагической битвы в истории они не могут допустить ошибку.",
            Category = categories.FirstOrDefault(x => x.Name == "Фильм"),
            Rating = 7.8,
            ImagePath = "/img/8.jpg",
            FilmPath = "https://www.youtube.com/embed/gbcVZgO4n4E",
            Duration = new TimeSpan(3,2,0),
            Genres = genres.Where(x => x.Name is "Боевик" or "Фантастика" or "Приключение").ToList(),
        });
        
        movies.Add(new Movie
        {
            Title = "Синистер ",
            LongDescription = "Автор детективов с семьёй переезжает в небольшой городок и селится в доме, где почти год " +
                              "назад развернулась леденящая душу трагедия – были убиты все жильцы. Писатель случайно " +
                              "находит видеозаписи, которые являются ключом к тайне преступления. " +
                              "Но ничто не дается даром: в доме начинают происходить жуткие вещи, и теперь под угрозой " +
                              "оказывается жизнь его близких. Они столкнулись с чем-то, от чего нет спасения.",
            Category = categories.FirstOrDefault(x => x.Name == "Фильм"),
            Rating = 6.6,
            ImagePath = "/img/9.jpg",
            FilmPath = "https://www.youtube.com/embed/UljkvGAx26s",
            Duration = new TimeSpan(1,50,0),
            Genres = genres.Where(x => x.Name is "Хоррор" or "Триллер").ToList(),
        });
        
        movies.Add(new Movie
        {
            Title = "Лука ",
            LongDescription = "Незабываемые каникулы, в которых есть место и домашней пасте, и мороженому, и бесконечным " +
                              "поездкам на мопеде, мальчик Лука проводит в красивом приморском городке на итальянской " +
                              "Ривьере. Ни одно приключение Луки не обходится без участия его нового лучшего друга, и " +
                              "беззаботность отдыха омрачает только лишь тот факт, что на самом деле в облике мальчика " +
                              "скрывается морской монстр из глубин лагуны, на берегу которой стоит городок.",
            Category = categories.FirstOrDefault(x => x.Name == "Фильм"),
            Rating = 7.8,
            ImagePath = "/img/10.jpg",
            FilmPath = "https://www.youtube.com/embed/Tn1eN62hW5s",
            Duration = new TimeSpan(1,35,0),
            Genres = genres.Where(x => x.Name is "Мультфильм" or "Семейный" or "Комедия" or "Приключение").ToList(),
        });
        return movies;
    }
}