using HaxsenTriviaServer.Models;

namespace HaxsenTriviaServer.Repositories
{
    public interface IUserRepository
    {
        User GetUserById(int id);
        void AddUser(User user);
        User GetGuestUser();
        // Additional methods as needed
    }
}
