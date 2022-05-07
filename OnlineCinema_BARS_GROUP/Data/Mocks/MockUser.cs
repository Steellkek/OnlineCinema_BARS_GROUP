using System.Collections.Generic;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Data.Mocks
{
    public class MockUser : IUser
    {
        public IEnumerable<User> GetAllUsers
        {
            get
            {
                return new List<User>()
                {
                    new User()
                    {
                        UserName = "Maksim",
                    },
                    new User()
                    {
                        UserName = "Test",
                    }
                };
            }
        }
    }
}
