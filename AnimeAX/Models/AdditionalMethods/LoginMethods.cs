using AnimeAX.Models.DataBase;
using System.Linq;

namespace AnimeAX.View.Pages
{
    partial class Login
    {
        /// <summary>
        /// Поиск пользователя в базе
        /// </summary>
        /// <param name="Login">Login</param>
        /// <param name="Password">Password</param>
        /// <returns>Найденный User</returns>
        private User UserSearch(string Login, string Password)
            => App.Db.User.Local.FirstOrDefault(x => x.Login == Login && x.Password == Password);
    }
}
