using HaxsenTriviaServer.Data;
using HaxsenTriviaServer.Models;
using HaxsenTriviaServer.Repositories;
using System.Linq;

namespace HaxsenTriviaServer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TriviaDbContext _context;

        public UserRepository(TriviaDbContext context)
        {
            _context = context;
        }

        public User GetUserById(int id)
        {
            return _context.Users.Find(id);
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User GetGuestUser()
        {
            return new User { IsGuest = true, Username = "Guest", Email = "guest@triviagame.com" };
        }
    }
}
