namespace OnlineCinema_BARS_GROUP.Models
{
    public class Comment
    {
        //Id отзыва
        public int Id { get; set; }
        //Текст отзыва
        public string Text { get; set; }
        //Оценка отзыва
        public byte Score { get; set; }
    }
}