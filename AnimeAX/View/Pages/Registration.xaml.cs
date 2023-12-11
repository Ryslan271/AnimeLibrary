using AnimeAX.Models.DataBase;
using AnimeAX.View.Windows;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Wpf.Ui.Controls;
using MessageBox = System.Windows.MessageBox;

namespace AnimeAX.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : UiPage
    {
        public Registration()
            => InitializeComponent();

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (NameBox.Text == "" || LoginBox.Text == "" || PasswordBox.Password == "" || AgeBox.Text == "")
            {
                MessageBox.Show("Поля не должны оставаться пустыми", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (ValidateUser(LoginBox.Text.Trim(), NameBox.Text.Trim()))
            {
                MessageBox.Show("Такой пользователь уже есть", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            (List<string> message, bool flag) = ValidatePassword(PasswordBox.Password.Trim());

            if (flag == false)
            {
                MessageBox.Show(string.Join("\n", message), "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            try
            {
                User userNew = new User() 
                {
                    Password = PasswordBox.Password.Trim(),
                    Nickname = NameBox.Text.Trim(),
                    Age = Convert.ToInt32(AgeBox.Text.Trim())
                };

                App.Db.User.Local.Add(userNew);

                App.CurrentUser = userNew;

                App.Db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Что то случилось, пожалуйста, проверьте введенный данные");
                return;
            }

            new MainWindow().Show();
            Entrance.Instance.Close();
        }

        private void GoToLoginPage_Click(object sender, RoutedEventArgs e) 
            => Entrance.Instance.EntranceFrame.Navigate(new Login());
    }
}
