using FullStackDevWeek7.Models;

namespace FullStackDevWeek7.Services
{
    public class AuthService
    {

        public User? CurrentUser { get; private set; }
        public bool IsLoggedIn => CurrentUser != null;

        public void Login(User user)
        {
            CurrentUser = user;
        }

        public void Logout()
        {
            CurrentUser = null;
        }

    }
}
