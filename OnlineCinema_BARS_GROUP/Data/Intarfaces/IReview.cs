using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Data.Intarfaces;

public interface IReview
{
    IEnumerable<Review> AllReview(int movieId);
    void Post(Review review);
    Review Delete(Guid id);
}