using AnimeAX.Models.DataBase;
using System;
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

        /// <summary>
        /// Поиск администратора в базе
        /// </summary>
        /// <param name="Login">Login</param>
        /// <param name="Password">Password</param>
        /// <returns>Найденный администратор</returns>
        private Administrator AdminSearch(string Login, string Password)
        {
            try
            {
                return App.Db.Administrator.Local.FirstOrDefault(x => x.Login == Convert.ToInt32(Login) && x.Password == Password);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
