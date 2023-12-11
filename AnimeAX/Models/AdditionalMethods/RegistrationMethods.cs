using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AnimeAX.View.Pages
{
    partial class Registration
    {
        /// <summary>
        /// Проверка пароля на правильность
        /// </summary>
        /// <param name="password">Пароль пользователя</param>
        /// <returns>(Список невыполненных требований, флаг выполненности)</returns>
        private (List<string>, bool) ValidatePassword(string password)
        {
            List<string> mess = new List<string>();

            if (password.Length < 6)
                mess.Add("Пароль должен быть не менее 6 символов");
            if (!password.Any(c => Char.IsUpper(c)))
                mess.Add("В пароле должна быть хотя бы одна прописная буква");
            if (!Regex.IsMatch(password, @"\d"))
                mess.Add("В пароле должна быть хотя бы одна цифра");
            if (!Regex.IsMatch(password, @"[!@#$%^]"))
                mess.Add("В пароле должен быть хотя бы одний из символов ! @ # $ % ^");

            if (mess.Count >= 1)
                return (mess, false);

            return (mess, true);
        }

        /// <summary>
        /// Поиск похожего пользователя
        /// </summary>
        /// <param name="LoginBoxText">Логин пользователя</param>
        /// <param name="Nickname">Nickname пользователя</param>
        /// <returns>True/False</returns>
        private bool ValidateUser(string LoginBoxText, string Nickname) 
            => App.Db.User.Local.FirstOrDefault(x => x.Login == LoginBoxText || x.Nickname == Nickname) != null;
    }
}
