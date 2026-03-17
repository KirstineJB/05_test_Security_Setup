using BackendAPI.Model;

namespace BackendAPI.Data
{
    public class UserMock
    {
        public static List<User> Users => new()
        {
            new User { Id = 101, Name = "Anna Jensen", Email = "anna.jensen@example.com" },
            new User { Id = 102, Name = "Peter Hansen", Email = "peter.hansen@example.com" },
            new User { Id = 103, Name = "Maria Nielsen", Email = "maria.nielsen@example.com" },
            new User { Id = 104, Name = "Jonas Larsen", Email = "jonas.larsen@example.com" }
        };
    }
}
