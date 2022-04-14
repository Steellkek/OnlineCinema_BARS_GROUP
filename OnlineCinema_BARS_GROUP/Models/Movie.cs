using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCinema_BARS_GROUP.Models
{
    public class Movie
    {
        //id фильма в БД
        public int Id {get; set;}
        //название фильма
        public string Name { get; set; }
        //описание на главной страницу
        public string ShortDesc { get; set; }
        //описание на странице фильма
        public string LongDesc { get; set; }
        //Средняя оценка фильма
        public double FilmScore { get; set; }
        //ссылка на картинку постера фильма
        public string Img { get; set; }
        //ссылка на видеофайл фильма
        public string Film { get; set; }
        //длительность фильма в секундах
        public int Time { get; set; }
        //Жанры фильма
        public List<Category> Categories { get; set; }
        //список отзывов
        public List<Comment> Comments { get; set; }
    }
}