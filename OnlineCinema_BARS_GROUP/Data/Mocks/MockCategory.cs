using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Models;

namespace OnlineCinema_BARS_GROUP.Data.Mocks;

public class MockCategory: ICategory
{
    public IEnumerable<Category> AllCategories
    {
        get
        {
            return new List<Category>
            {
                new Category(){CategoryName = "Экшн"},
                new Category(){CategoryName = "Боевик"}
            };
        }
    }
}